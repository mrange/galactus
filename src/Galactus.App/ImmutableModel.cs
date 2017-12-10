namespace Galactus.App.ImmutableModel
{
  using System.Windows.Controls;
  using System.Windows;
  using System.Windows.Media;

  using Galactus.Core;
  using Galactus.App.Model;

  using static Galactus.Standard.Controls<Message>;
  using static System.Windows.GridUnitType;

  delegate Customer Message(Customer customer);

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
          ).Named(lbl);
      }

      IView<Message> labeledCheckBox(string lbl, Prism<Customer, bool> l)
      {
        return checkBox.View
          ( checkBox.isChecked(l.Get(customer).ValueOr(false))
          , uIElement.prism(l)
          , margin
          , checkBox.contentView(textBlock.View(textBlock.text(lbl)))
          )
          ;
      }
      var labeledCheckBoxHandler = checkBox.onClick((ui, args) => c => 
        {
          var cb  = args.OriginalSource as CheckBox;
          var ll  = DependencyProperties.GetPrism(cb) as Prism<Customer, bool>;
          return ll?.Set(c, cb.IsChecked ?? false) ?? c;
        });

      IView<Message> labeledTextBox(string lbl, Prism<Customer, string> l)
      {
        return stackPanel.View
          ( stackPanel.orientation(Orientation.Horizontal)
          , margin
          , stackPanel.childViews
            ( textBlock.View(textBlock.text(lbl), textBlock.width(labelWidth))
            , textBox.View
              ( textBox.text(l.Get(customer).ValueOr(""))
              , textBox.minWidth(80)
              , uIElement.prism(l)
              )
            )
          )
          ;
      }
      var labeledTextBoxHandler = uIElement.onLostFocus((ui, args) => c =>
        {
          var ltb = args.OriginalSource as TextBox;
          var ll  = DependencyProperties.GetPrism(ltb) as Prism<Customer, string>;
          return ll?.Set(c, ltb.Text) ?? c;
        });

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

      return scrollViewer.View
        ( frameworkElement.layoutTransform(new ScaleTransform(2, 2))
        , labeledTextBoxHandler
        , labeledCheckBoxHandler
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

    static Customer Update(Customer customer, Message message)
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
