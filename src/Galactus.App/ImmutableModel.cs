namespace Galactus.App.ImmutableModel
{
  using System.Windows.Controls;
  using System.Windows;
  using System.Windows.Media;

  using Galactus.Core;
  using Galactus.App.Model;

  using static Galactus.Standard.Controls<Galactus.Core.Handlers.PrismMessage<Galactus.App.Model.Customer>>;
  using static System.Windows.GridUnitType;

  using Message = Galactus.Core.Handlers.PrismMessage<Galactus.App.Model.Customer>;
  
  class Program
  {
    static IView<Message> View(Customer customer)
    {
      var margin      = frameworkElement.margin(new Thickness(4));
      var labelWidth  = 120;

      IView<Message> labeledGroup(string lbl, IView<Message> view)
      {
        return groupBox.View
          ( groupBox.headerView(textBlock.View(textBlock.text(lbl)))
          , groupBox.contentView(view)
          ).WithName(lbl);
      }

      IView<Message> labeledCheckBox(string lbl, Prism<Customer, bool> l)
      {
        var state = l.Get(customer).ValueOr(false);
        return checkBox.View
          ( checkBox.isChecked(state)
          , uIElement.prism(l)
          , uIElement.state(state)
          , margin
          , checkBox.contentView(textBlock.View(textBlock.text(lbl)))
          )
          ;
      }

      IView<Message> labeledTextBox(string lbl, Prism<Customer, string> l)
      {
        var state = l.Get(customer).ValueOr("");
        return stackPanel.View
          ( stackPanel.orientation(Orientation.Horizontal)
          , margin
          , stackPanel.childViews
            ( textBlock.View(textBlock.text(lbl), textBlock.width(labelWidth))
            , textBox.View
              ( textBox.text(state).Validate(lbl, v => v.IsNullOrEmpty() ? "Missing input" : null)
              , textBox.minWidth(80)
              , uIElement.prism(l)
              , uIElement.state(state)
              ).WithErrorAdorner()
            )
          ).WithToolTip(lbl)
          ;
      }

      IView<Message> address(string lbl, Prism<Customer, Address> l)
      {
        return labeledGroup
          ( lbl
          , stackPanel.View
              ( stackPanel.orientation(Orientation.Vertical)
              , stackPanel.childViews
                ( labeledTextBox("Carry Over" , l.To(Address.carryOver))
                , labeledTextBox("Street"     , l.To(Address.street))
                , labeledTextBox("Zip"        , l.To(Address.zip))
                , labeledTextBox("City"       , l.To(Address.city))
                , labeledTextBox("County"     , l.To(Address.county))
                , labeledTextBox("Country"    , l.To(Address.county))
                )
              )
          );
      }

      IView<Message> company(Prism<Customer, Company> l)
      {
        return labeledGroup
          ( "Company"
          , stackPanel.View
              ( stackPanel.orientation(Orientation.Vertical)
              , stackPanel.childViews
                ( labeledTextBox("Name"               , l.To(Company.companyName))
                , labeledTextBox("Org No"             , l.To(Company.companyId))
                , labeledTextBox("VAT No"             , l.To(Company.vatNo))
                , labeledTextBox("Contact first name" , Customer.firstName)
                , labeledTextBox("Contact last name"  , Customer.lastName)
                , labeledTextBox("Contact email"      , Customer.email)
                )
              )
          );
      }

      IView<Message> individual(Prism<Customer, Individual> l)
      {
        return labeledGroup
          ( "Individual"
          , stackPanel.View
              ( stackPanel.orientation(Orientation.Vertical)
              , stackPanel.childViews
                ( labeledTextBox("First name" , Customer.firstName)
                , labeledTextBox("Last name"  , Customer.lastName)
                , labeledTextBox("Email"      , Customer.email)
                , labeledTextBox("Social No"  , l.To(Individual.socialId))
                )
              )
          );
      }

      IView<Message> customerKind(Prism<Customer, CustomerKind> l)
      {
        var c = l.To(CustomerKind.company);
        var i = l.To(CustomerKind.individual);
        if (c.Get(customer).HasValue())
        {
          return company(c);
        }
        else if (i.Get(customer).HasValue())
        {
          return individual(i);
        }
        else
        {
          return empty.View;
        }
      }

      var checkBoxHandler = Handlers.CreatePrismCheckBoxHandler<Customer>();
      var textBoxHandler  = Handlers.CreatePrismTextBoxHandler<Customer>();

      return scrollViewer.View
        ( frameworkElement.layoutTransform(new ScaleTransform(2, 2))
        , textBoxHandler
        , checkBoxHandler
        , scrollViewer.contentView
          ( stackPanel.View
              ( stackPanel.orientation(Orientation.Vertical)
              , stackPanel.childViews
                ( comboBox.View
                  ( comboBox.itemSourceViews
                      ( textBlock.View(textBlock.text("Hello"))
                      , textBlock.View(textBlock.text("There"))
                      ).InitOnly()
                  , comboBox.selectedIndex(1).InitOnly()
                  )
                , labeledCheckBox("Is company?", Customer.kind.Map(k => (k as Company) != null, b => b ? (CustomerKind)Company.Zero : (CustomerKind)Individual.Zero))
                , customerKind(Customer.kind)
                , labeledCheckBox("Separate Delivery Address?", Customer.separateDeliveryAddress)
                , address("Invoice Address" , Customer.invoiceAddress)
                , customer.SeparateDeliveryAddress ? address("Delivery Address", Customer.deliveryAddress) : empty.View
                , address("Invoice Address" , Customer.invoiceAddress)
                )
              )
          )
        )
        ;
    }

    static Maybe<Customer> Update(Customer customer, Message message)
    {
      return message(customer);
    }

    public static void Run()
    {
      var addressInfo   = new Address();
      var customer      = new Customer();

      var setCarryOver  = Address.carryOver.Set("Melinda Gates");
      var newCustomer   = Prism.SetAll
        ( customer
        , Customer.firstName      .Set("Bill")
        , Customer.lastName       .Set("Gates")
        , Customer.invoiceAddress .Set(setCarryOver)
        , Customer.deliveryAddress.Set(setCarryOver)
        );
      Hosts.OpenNewWindow(newCustomer, View, Update);
    }
  }
}
