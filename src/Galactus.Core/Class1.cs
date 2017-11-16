using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Galactus.Core
{
  delegate void EventHandler<T>(object obj, T args);

  public class OnChangedValue<TMessage, T, TEventHandler, TEventArgs>
    where T             : UIElement
    where TEventHandler : class
    where TEventArgs    : RoutedEventArgs
  {
    public readonly RoutedEvent Event;

    public OnChangedValue (RoutedEvent e)
    {
      Event = e;
    }

    public void Trigger (object obj, TextChangedEventArgs args)
    {
      Console.WriteLine ("Hello");
    }

    public void Register (UIElement ui)
    {
      ui.AddHandler(Event, new TextChangedEventHandler (new EventHandler<TextChangedEventArgs>(Trigger)));
    }
  }
}
