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
          (stackPanel.orientation(Orientation.Horizontal), margin)
          ( textBlock.View(textBlock.text(lbl), textBlock.width(80))
          , textBox.View
            ( textBox.text(l.Get(customer))
            , textBox.minWidth(80)
            , textBox.onLostFocus((ui, args) => c => l.Set(c, ((TextBox)ui).Text))
            )
          )
          ;
      }

      IView<Message> addressInfo(string lbl, Lens<Customer, AddressInfo> a)
      {
        return labeledGroup(
            lbl
          , stackPanel.View
            (stackPanel.orientation(Orientation.Vertical))
            ( labeledTextBox("First Name" , a.To(AddressInfo.firstName))
            , labeledTextBox("Last Name"  , a.To(AddressInfo.lastName))
            , labeledTextBox("Carry Over" , a.To(AddressInfo.carryOver))
            , labeledTextBox("Street"     , a.To(AddressInfo.street))
            , labeledTextBox("Zip"        , a.To(AddressInfo.zip))
            , labeledTextBox("City"       , a.To(AddressInfo.city))
            , labeledTextBox("County"     , a.To(AddressInfo.county))
            , labeledTextBox("Country"    , a.To(AddressInfo.county))
            ));
      }

      return stackPanel.View
        (stackPanel.orientation(Orientation.Vertical))
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
      var vs = new string[0];
      Hosts.OpenWindow(new Customer(), View, Update);
    }
  }
}
