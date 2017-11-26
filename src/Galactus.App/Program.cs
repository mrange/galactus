namespace Galactus.App
{
  using Galactus.Core;
  using System;
  using System.Windows.Controls;
  using static Galactus.Standard.Controls<IMessage>;
  using System.Windows;
  using System.Windows.Media;

  public class Address
  {
    public string FirstName ;
    public string LastName  ;
    public string CarryOver ;
    public string Street    ;
    public string Zip       ;
    public string City      ;
    public string County    ;
    public string Country   ;
  }

  public interface IMessage
  {
    MyModel Apply(MyModel model);
  }

  public sealed class ActionMessage : IMessage
  {
    readonly Action action;

    public ActionMessage(Action a)
    {
      action = a;
    }

    public MyModel Apply(MyModel model)
    {
      action();
      return model;
    }
  }

  public class MyModel
  {
    public bool    SeparateDeliveryAddress  = false         ;
    public Address InvoiceAddress           = new Address ();
    public Address DeliveryAddress          = new Address ();
  }

  class Program
  {
    static IView<IMessage> View(MyModel model)
    {
      var margin = frameworkElement.margin(new Thickness(4));

      IView<IMessage> LabeledCheckBox(string lbl, bool init, Action<bool?> onChanged)
      {
        return checkBox.View
          ( checkBox.isChecked(init).Init()
          , checkBox.onClick((ui, args) => new ActionMessage(() => onChanged(((CheckBox)ui).IsChecked)))
          )
          (textBlock.View(textBlock.text(lbl)))
          ;
      }

      IView<IMessage> LabeledText(string lbl, string init, Action<string> onChanged)
      {
        return stackPanel.View
          (stackPanel.orientation(Orientation.Horizontal), margin)
          ( textBlock.View(textBlock.text(lbl), textBlock.width(80))
          , textBox.View
            ( textBox.text(init).Init()
            , textBox.minWidth(80)
            , textBox.onTextChanged((ui, args) => new ActionMessage(() => onChanged(((TextBox)ui).Text)))
            )
          )
          ;
      }

      IView<IMessage> LabeledGroup(string lbl, IView<IMessage> view)
      {
        return border.View
          ( border.borderThickness(new Thickness(2.0))
          , border.borderBrush(Brushes.LimeGreen)
          , border.padding(new Thickness(4.0))
          , margin
          )
          (view).Named(lbl);
      }

      IView<IMessage> AddressView(string lbl, Address a)
      {
        return LabeledGroup(
            lbl
          , stackPanel.View
            (stackPanel.orientation(Orientation.Vertical))
            ( LabeledText("FirstName" , a.FirstName, v => a.FirstName = v)
            , LabeledText("LastName"  , a.LastName , v => a.LastName  = v)
            , LabeledText("CarryOver" , a.CarryOver, v => a.CarryOver = v)
            , LabeledText("Street"    , a.Street   , v => a.Street    = v)
            , LabeledText("Zip"       , a.Zip      , v => a.Zip       = v)
            , LabeledText("City"      , a.City     , v => a.City      = v)
            , LabeledText("County"    , a.County   , v => a.County    = v)
            , LabeledText("Country"   , a.Country  , v => a.Country   = v)
            ));
      }

      return stackPanel.View
        (stackPanel.orientation(Orientation.Vertical))
        ( LabeledCheckBox("Separate Delivery Address?", model.SeparateDeliveryAddress, v => model.SeparateDeliveryAddress = v ?? false)
        , AddressView("Invoice Address" , model.InvoiceAddress)
        , model.SeparateDeliveryAddress ? AddressView("Delivery Address", model.DeliveryAddress) : empty.View
        )
        ;
    }

    static MyModel Update(MyModel model, IMessage message)
    {
      return message.Apply(model);
    }

    [STAThread]
    static void Main(string[] args)
    {
      Hosts.OpenWindow(new MyModel(), View, Update);
    }
  }
}
