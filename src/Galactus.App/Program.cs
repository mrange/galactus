namespace Galactus.App
{
  using Galactus.Core;
  using System;
  using System.Windows.Controls;
  using static Galactus.Standard.Controls<MyMessage>;
  using System.Windows;

  public class MyMessage
  {
    public readonly string Text;

    public MyMessage (string text)
    {
      Text = text ?? "";
    }
  }

  public class MyModel
  {
    public readonly string Text;

    public MyModel (string text)
    {
      Text = text ?? "";
    }
  }

  class Program
  {
    static IView<MyMessage> View(MyModel model)
    {
      var padding = textBlock.padding(new Thickness(0, 0, 4, 0));

      IView<MyMessage> textButton(string s, params IValue<MyMessage, Button>[] vs) =>
        button.View(vs)(textBlock.View(textBlock.text(s)));

      return stackPanel.View
        (stackPanel.orientation(Orientation.Vertical))
        ( textButton("Hello", button.onClick((o, args) => new MyMessage("Yello")))
        , textButton("There")
        , stackPanel.View
          (stackPanel.orientation(Orientation.Horizontal))
          ( textBlock.View(padding, textBlock.text("Some text"))
          , textBlock.View(padding, textBlock.text("Model text follows"))
          , textBlock.View(padding, textBlock.text(model.Text))
          )
        )
        ;
    }

    static MyModel Update(MyModel model, MyMessage message)
    {
      return new MyModel(message.Text);
    }

    [STAThread]
    static void Main(string[] args)
    {
      Hosts.OpenWindow(new MyModel("GG"), View, Update);
    }
  }
}
