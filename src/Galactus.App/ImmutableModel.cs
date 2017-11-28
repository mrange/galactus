namespace Galactus.App.ImmutableModel
{
  using System.Windows.Controls;
  using System.Windows;
  using System.Windows.Media;

  using Galactus.Core;
  using Galactus.App.Model;

  using static Galactus.Standard.Controls<Message>;

  public delegate Customer Message(Customer customer);

  class Program
  {
    static IView<Message> View(Customer customer)
    {
      var margin = frameworkElement.margin(new Thickness(4));

      IView<Message> labeledGroup(string lbl, IView<Message> view)
      {
        return border.View
          ( border.borderThickness(new Thickness(2.0))
          , border.borderBrush(Brushes.LimeGreen)
          , border.padding(new Thickness(4.0))
          , margin
          )
          (view).Named(lbl);
      }

      IView<Message> labeledCheckBox(string lbl, Lens<Customer, bool> l)
      {
        return checkBox.View
          ( checkBox.isChecked(l.Get(customer))
          , checkBox.onClick((ui, args) => c => l.Set(c, ((CheckBox)ui).IsChecked ?? false))
          )
          (textBlock.View(textBlock.text(lbl)))
          ;
      }

      IView<Message> labeledTextBox(string lbl, Lens<Customer, string> l)
      {
        return stackPanel.View
          ( stackPanel.orientation(Orientation.Horizontal), margin)
          ( textBlock.View(textBlock.text(lbl), textBlock.width(80))
          , textBox.View
            ( textBox.text(l.Get(customer))
            , textBox.minWidth(80)
            , uIElement.lens(l)
            )
          )
          ;
      }

      IView<Message> address(string lbl, Lens<Customer, Address> l)
      {
        return labeledGroup(
            lbl
          , stackPanel.View
            (stackPanel.orientation(Orientation.Vertical))
            ( labeledTextBox("Carry Over" , l.To(Address.carryOver))
            , labeledTextBox("Street"     , l.To(Address.street))
            , labeledTextBox("Zip"        , l.To(Address.zip))
            , labeledTextBox("City"       , l.To(Address.city))
            , labeledTextBox("County"     , l.To(Address.county))
            , labeledTextBox("Country"    , l.To(Address.county))
            ));
      }

      var textBoxHandler = uIElement.onLostFocus((ui, args) => c =>
        {
          var ltb = args.OriginalSource as TextBox;
          var ll  = DependencyProperties.GetLens(ltb) as Lens<Customer, string>;
          return ll?.Set(c, ltb.Text) ?? c;
        });

      return stackPanel.View
        ( stackPanel.orientation(Orientation.Vertical)
        , textBoxHandler
        )
        ( labeledTextBox("First Name" , Customer.firstName  )
        , labeledTextBox("Last Name"  , Customer.lastName   )
        , labeledCheckBox("Separate Delivery Address?", Customer.separateDeliveryAddress)
        , address("Invoice Address" , Customer.invoiceAddress)
        , customer.SeparateDeliveryAddress ? address("Delivery Address", Customer.deliveryAddress) : empty.View
        , address("Invoice Address" , Customer.invoiceAddress)
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
      var newCustomer   = Lens.SetAll
        ( customer
        , Customer.firstName      .Set("Bill")
        , Customer.lastName       .Set("Gates")
        , Customer.invoiceAddress .Set(setCarryOver)
        , Customer.deliveryAddress.Set(setCarryOver)
        );
      Hosts.OpenWindow(newCustomer, View, Update);
    }
  }
}
