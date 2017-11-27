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

      IView<Message> addressInfo(string lbl, Lens<Customer, AddressInfo> l)
      {
        return labeledGroup(
            lbl
          , stackPanel.View
            (stackPanel.orientation(Orientation.Vertical))
            ( labeledTextBox("First Name" , l.To(AddressInfo.firstName))
            , labeledTextBox("Last Name"  , l.To(AddressInfo.lastName))
            , labeledTextBox("Carry Over" , l.To(AddressInfo.carryOver))
            , labeledTextBox("Street"     , l.To(AddressInfo.street))
            , labeledTextBox("Zip"        , l.To(AddressInfo.zip))
            , labeledTextBox("City"       , l.To(AddressInfo.city))
            , labeledTextBox("County"     , l.To(AddressInfo.county))
            , labeledTextBox("Country"    , l.To(AddressInfo.county))
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
        ( labeledCheckBox("Separate Delivery Address?", Customer.separateDeliveryAddress)
        , addressInfo("Invoice Address" , Customer.invoiceAddress)
        , customer.SeparateDeliveryAddress ? addressInfo("Delivery Address", Customer.deliveryAddress) : empty.View
        , addressInfo("Invoice Address" , Customer.invoiceAddress)
        )
        ;
    }

    static Customer Update(Customer customer, Message message)
    {
      return message(customer);
    }

    public static void Run()
    {
      Hosts.OpenWindow(new Customer(), View, Update);
    }
  }
}
