namespace Galactus.Core
{
  using System;
  using System.Collections.Generic;
  using System.Windows;
  using System.Windows.Controls;
  using static NonCohesive;

  public sealed class MessageEventArgs : RoutedEventArgs
  {
    public readonly object Message;

    public MessageEventArgs(object message)
    {
      Message = message;
    }
  }

  public delegate void MessageEventHandler(object o, MessageEventArgs args);

  public static class RoutedEvents
  {
    public static readonly RoutedEvent MessageEvent = EventManager.RegisterRoutedEvent("Message", RoutingStrategy.Bubble, typeof(MessageEventHandler), typeof(RoutedEvents));
  }

  public static class DependencyProperties
  {
    public static readonly DependencyProperty DummyProperty = DependencyProperty.RegisterAttached("Dummy", typeof(object), typeof(DependencyProperties));
  }

  public interface IProperty
  {
    DependencyProperty DependencyProperty { get; }
  }

  public interface IProperty<in TUI, T> : IProperty
    where TUI : UIElement
  {
    T     Get(TUI ui);
    void  Set(TUI ui, T v);
  }

  public sealed class Property<TUI, T> : IProperty<TUI, T>
    where TUI : UIElement
  {
    readonly DependencyProperty dependencyProperty;

    public Property(DependencyProperty dp)
    {
      dependencyProperty = dp ?? DependencyProperties.DummyProperty;
    }

    public DependencyProperty DependencyProperty => dependencyProperty;

    public T Get(TUI ui)
    {
      return (T)ui.GetValue(dependencyProperty);
    }

    public void Set(TUI ui, T v)
    {
      ui.SetValue(dependencyProperty, v);
    }
  }

  public sealed class UpdateContext
  {

  }

  public enum ParentInfo
  {
    NewInstance   ,
    ReusedInstance,
  }

  public interface IValue<TMessage, in TUI>
    where TUI : UIElement
  {
    void Update(UpdateContext ctx, ParentInfo pi, UIElement ui);
  }

  public interface ISetValue<TMessage, in TUI, T> : IValue<TMessage, TUI>
    where TUI : UIElement
  {
    IProperty<TUI, T> Property { get; }
  }

  public sealed class SetValue<TMessage, TUI, T> : ISetValue<TMessage, TUI, T>
    where TUI : UIElement
  {
    readonly IProperty<TUI, T> property ;
    readonly T                 value    ;

    public SetValue(IProperty<TUI, T> p, T v)
    {
      // TODO: Handle nulls
      property = p;
    }

    public IProperty<TUI, T> Property => property;

    public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      // TODO: Cast unnecessary but doesn't cost that much compared to set in general
      property.Set ((TUI)ui, value);
    }
  }

  public interface IView<TMessage>
  {
    UIElement Update(UpdateContext ctx, ParentInfo pi, UIElement ui);
  }

  public sealed class StandardView<TMessage, TUI>
    : IView<TMessage>
    where TUI: UIElement, new()
  {
    readonly IValue<TMessage, TUI>[] values;

    public StandardView(IValue<TMessage, TUI>[] vs)
    {
      values = vs ?? new IValue<TMessage, TUI>[0];
    }

    public UIElement Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      var v = GetInstance<TUI>(ui);

      var tpi = v.ParentInfo;
      var tui = v.Instance  ;

      foreach (var value in values)
      {
        value.Update(ctx, tpi, tui);
      }

      return tui;
    }
  }

  public sealed class StandardContentView<TMessage, TUI>
    : IView<TMessage>
    where TUI: ContentControl, new()
  {
    readonly IValue<TMessage, TUI>[]  values;
    readonly IView<TMessage>          view  ;

    public StandardContentView(IValue<TMessage, TUI>[] vs, IView<TMessage> c)
    {
      // TODO: Handle nulls
      values = vs ?? new IValue<TMessage, TUI>[0];
      view   = c;
    }

    public UIElement Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      var v = GetInstance<TUI>(ui);

      var tpi = v.ParentInfo;
      var tui = v.Instance  ;

      var content = tui.Content as UIElement;
      tui.Content = view.Update(ctx, pi, content);

      foreach (var value in values)
      {
        value.Update(ctx, tpi, tui);
      }

      return tui;
    }
  }

  public sealed class StandardPanelView<TMessage, TUI>
    : IView<TMessage>
    where TUI: Panel, new()
  {
    readonly IValue<TMessage, TUI>[]  values  ;
    readonly IView<TMessage>[]        views   ;

    public StandardPanelView(IValue<TMessage, TUI>[] vs, IView<TMessage>[] cs)
    {
      values  = vs ?? new IValue<TMessage, TUI>[0] ;
      views   = cs ?? new IView<TMessage>[0]       ;
    }

    public UIElement Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      var v = GetInstance<TUI>(ui);

      var tpi = v.ParentInfo;
      var tui = v.Instance  ;

      var children  = tui.Children  ;
      var count     = children.Count;
      if (count > views.Length)
      {
        children.RemoveRange(views.Length, count - views.Length);
      }

      for (var i = 0; i < views.Length; ++i)
      {
        if (i < count)
        {
          var child   = children[i] ;
          var view    = views[i]    ;
          children[i] = view.Update(ctx, tpi, child);
        }
        else
        {
          var view    = views[i]    ;
          children[i] = view.Update(ctx, tpi, null);
        }
      }

      foreach (var value in values)
      {
        value.Update(ctx, tpi, tui);
      }

      return tui;
    }
  }

  public delegate IView<TMEssage>  View<TModel, TMEssage>   (TModel model);
  public delegate TModel           Update<TModel, TMEssage> (TModel model, TMEssage message);

  public static class Hosts
  {
    public static void OpenWindow<TModel, TMessage>(TModel model, View<TModel, TMessage> view, Update<TModel, TMessage> update)
    {
      var wnd     = new Window()            ;
      var disp    = wnd.Dispatcher          ;
      var current = model                   ;
      var queue   = new Queue<TMessage>(16) ;

      void Refresh()
      {
        var nv  = view(current)             ;
        var ctx = new UpdateContext()       ;
        var cnt = wnd.Content as UIElement  ;
        var pi  = ParentInfo.ReusedInstance ;

        wnd.Content = nv.Update(ctx, pi, cnt);
      }

      void Process()
      {
        while (queue.Count > 0)
        {
          var msg = queue.Dequeue ();
          current = update (current, msg);
        }

        Refresh();
      }
      var process = new Action(Process);

      void OnMessage (object o, MessageEventArgs args)
      {
        var msg = (TMessage)args.Message;
        queue.Enqueue(msg);
        disp.Delay(process);
      }
      var onMessage = new MessageEventHandler(OnMessage);

      Refresh ();
      wnd.AddHandler(RoutedEvents.MessageEvent, onMessage);

      wnd.ShowDialog ();
    }
  }

}
