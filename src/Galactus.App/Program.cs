namespace Galactus.App
{
  using Galactus.Core;
  using System;
  using System.Windows.Controls;
  using static Galactus.Standard.Controls<MyMessage>;

  public class MyMessage
  {

  }

  public class MyModel
  {

  }

  class Program
  {
    static IView<MyMessage> View(MyModel model)
    {
      IView<MyMessage> textButton(string s, params IValue<MyMessage, Button>[] vs) =>
        button.View(vs)(textBlock.View(textBlock.text(s)));

      return stackPanel.View
        (stackPanel.orientation(Orientation.Horizontal))
        (
            textButton("Hello")
          , textButton("There")
        )
        ;
    }

    static MyModel Update(MyModel model, MyMessage message)
    {
      return model;
    }

    [STAThread]
    static void Main(string[] args)
    {
      Hosts.OpenWindow(new MyModel(), View, Update);
    }
  }
}
