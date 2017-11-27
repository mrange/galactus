namespace Galactus.App.Demo
{
  using Galactus.Core;
  using System;
  using System.Windows;
  using System.Windows.Controls;
  using System.Windows.Media;
  using static Galactus.Standard.Controls<System.Action>;

  class Program
  {
    class Customer
    {
      public string FirstName ;
      public string LastName  ;
      public bool   IsFemale  ;
    }

    static IView<Action> View(Customer model)
    {
      var margin = frameworkElement.margin(new Thickness(4));

      IView<Action> labeledText(string label, string value) =>
        stackPanel.View
          ( stackPanel.orientation(Orientation.Horizontal)
          , margin
          )
          ( textBlock.View(textBlock.text(label), textBlock.width(80))
          , textBox.View(textBox.text(value), textBox.minWidth(120))
          )
          ;

      IView<Action> labeledCheckBox(string label, bool value) =>
        checkBox.View
          ( checkBox.isChecked(value)
          , margin
          )
          ( textBlock.View(textBlock.text(label))
          )
          ;

      return stackPanel.View
        ( stackPanel.orientation(Orientation.Vertical))
        ( labeledText     ("First name" , model.FirstName)
        , labeledText     ("Last name"  , model.LastName)
        , labeledCheckBox ("Is female?" , model.IsFemale)
        )
        ;
    }

    static Customer Update(Customer model, Action message)
    {
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
      Hosts.OpenWindow(model, View, Update);
    }
  }
}
