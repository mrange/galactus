namespace Galactus.App.Demo
{
  using Galactus.Core;
  using System;
  using System.Windows;
  using System.Windows.Controls;
  using System.Windows.Media;
  using static Galactus.Standard.Controls<Message>;

  class Customer
  {
    public string FirstName ;
    public string LastName  ;
    public bool?  IsFemale  ;
  }

  delegate void Message(Customer customer);

  class Program
  {
    static IView<Message> View(Customer model)
    {
      var margin = frameworkElement.margin(new Thickness(4));

      IView<Message> labeledText(string label, string value, Action<Customer, string> action) =>
        stackPanel.View
          ( stackPanel.orientation(Orientation.Horizontal)
          , margin
          )
          ( textBlock.View(textBlock.text(label), textBlock.width(80))
          , textBox.View(textBox.text(value), textBox.minWidth(120)
          , textBox.onLostFocus((ui, args) => c => action(c, ((TextBox)ui).Text)))
          )
          ;

      IView<Message> labeledCheckBox(string label, bool? value, Action<Customer, bool?> action) =>
        checkBox.View
          ( checkBox.isChecked(value)
          , checkBox.onClick((ui, args) => c => action(c, ((CheckBox)ui).IsChecked))
          , margin
          )
          ( textBlock.View(textBlock.text(label))
          )
          ;

      return stackPanel.View
        ( stackPanel.orientation(Orientation.Vertical))
        ( labeledText     ("First name" , model.FirstName , (c, v) => c.FirstName = v)
        , labeledText     ("Last name"  , model.LastName  , (c, v) => c.LastName  = v)
        , labeledCheckBox ("Is female?" , model.IsFemale  , (c, v) => c.IsFemale  = v)
        )
        ;
    }

    static Customer Update(Customer model, Message message)
    {
      message(model);
      return model;
    }

    public static void Run()
    {
      var model = new Customer
      {
        FirstName = "Melinda" ,
        LastName  = "Gates"   ,
        IsFemale  = true      ,
      };
      Hosts.OpenNewWindow(model, View, Update);
    }
  }
}
