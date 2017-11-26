namespace Galactus.Core
{
  using System;
  using System.Collections.Generic;
  using System.Windows;
  using System.Windows.Controls;
  using static NonCohesive;

  // Common

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
    public static readonly RoutedEvent DummyEvent   = EventManager.RegisterRoutedEvent("Dummy"  , RoutingStrategy.Bubble, typeof(MessageEventHandler), typeof(RoutedEvents));

    public static readonly RoutedEvent MessageEvent = EventManager.RegisterRoutedEvent("Message", RoutingStrategy.Bubble, typeof(MessageEventHandler), typeof(RoutedEvents));
  }

  public static class DependencyProperties
  {
    public static readonly DependencyProperty DummyProperty = DependencyProperty.RegisterAttached("Dummy" , typeof(object), typeof(DependencyProperties));

    public static readonly DependencyProperty NameProperty  = DependencyProperty.RegisterAttached("Name"  , typeof(string), typeof(DependencyProperties));
  }

  public sealed class UpdateContext
  {
    readonly List<Action> tearDowns = new List<Action>(16);

    public void OnTearDown(Action action)
    {
      // TODO: Handle nulls
      tearDowns.Add(action);
    }

    public void TearDown()
    {
      for (var iter = tearDowns.Count - 1; iter >= 0; --iter)
      {
        var a = tearDowns[iter];
        a();
      }

      tearDowns.Clear();
    }

  }

  // Properties

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

  // Events

  public interface IEvent
  {
    RoutedEvent RoutedEvent { get; }
  }

  public interface IEvent<in TUI, in TEventHandler, in TEventArgs> : IEvent
    where TUI         : UIElement
    where TEventArgs  : RoutedEventArgs
  {
  }

  public sealed class Event<TUI, TEventHandler, TEventArgs> : IEvent<TUI, TEventHandler, TEventArgs>
    where TUI         : UIElement
    where TEventArgs  : RoutedEventArgs
  {
    readonly RoutedEvent routedEvent;

    public Event(RoutedEvent re)
    {
      routedEvent = re ?? RoutedEvents.DummyEvent;
    }

    public RoutedEvent RoutedEvent => routedEvent;
  }

  // Values

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
      value    = v;
    }

    public IProperty<TUI, T> Property => property;

    public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      // TODO: Cast unnecessary but doesn't cost that much compared to set in general
      property.Set((TUI)ui, value);
    }
  }

  public interface IOnChangedValue<TMessage, in TUI> : IValue<TMessage, TUI>
    where TUI : UIElement
  {
  }

  public delegate Delegate EventHandlerMapper<TEventArgs>(EventHandler<TEventArgs> handler)
    where TEventArgs : RoutedEventArgs
    ;

  public delegate TMessage OnChange<TMessage, in TUI, in TEventArgs>(TUI uiElement, TEventArgs args)
    where TUI : UIElement
    ;

  public sealed class OnChangedValue<TMessage, TUI, TEventHandler, TEventArgs> : IOnChangedValue<TMessage, TUI>
    where TUI         : UIElement
    where TEventArgs  : RoutedEventArgs
  {
    readonly IEvent<TUI, TEventHandler, TEventArgs>   event_          ;
    readonly OnChange<TMessage, TUI, TEventArgs>      onChange        ;
    readonly Delegate                                 onChangeHandler ;

    public OnChangedValue(IEvent<TUI, TEventHandler, TEventArgs> e, EventHandlerMapper<TEventArgs> m, OnChange<TMessage, TUI, TEventArgs> oc)
    {
      // TODO: Handle NULLs
      event_          = e           ;
      onChange        = oc          ;
      onChangeHandler = m(OnChange) ;
    }

    void OnChange(object o, TEventArgs args)
    {
      var ui    = (TUI)o;
      var msg   = onChange(ui, args);
      var margs = new MessageEventArgs(msg)
      {
        RoutedEvent = RoutedEvents.MessageEvent
      };
      ui.RaiseEvent(margs);
    }

    public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      // TODO: Handle nulls
      ui.AddHandler(event_.RoutedEvent, onChangeHandler);
      ctx.OnTearDown(() => ui.RemoveHandler(event_.RoutedEvent, onChangeHandler));
    }
  }

  public sealed class InitOnlyValue<TMessage, TUI> : IValue<TMessage, TUI>
    where TUI : UIElement
  {
    readonly IValue<TMessage, TUI> value;

    public InitOnlyValue(IValue<TMessage, TUI> v)
    {
      // TODO: Handle nulls
      value = v;
    }

    public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      switch (pi)
      {
      case ParentInfo.NewInstance:
        value.Update(ctx, pi, ui);
        break;
      case ParentInfo.ReusedInstance:
        break;
      }
    }
  }

  public static class ValueExtensions
  {
    public static IValue<TMessage, TUI> Init<TMessage, TUI>(this IValue<TMessage, TUI> v)
      where TUI : UIElement
    {
      return new InitOnlyValue<TMessage, TUI>(v);
    }
  }

  // Views

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

  public delegate IView<TMessage> DelayedContentView<TMessage> (IView<TMessage> c);

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
      if (children.Count > views.Length)
      {
        children.RemoveRange(views.Length, children.Count - views.Length);
      }

      for (var i = 0; i < views.Length; ++i)
      {
        if (i < children.Count)
        {
          var child   = children[i] ;
          var view    = views[i]    ;
          children[i] = view.Update(ctx, tpi, child);
        }
        else
        {
          var view    = views[i]    ;
          children.Add(view.Update(ctx, tpi, null));
        }
      }

      foreach (var value in values)
      {
        value.Update(ctx, tpi, tui);
      }

      return tui;
    }
  }

  public delegate IView<TMessage> DelayedPanelView<TMessage> (params IView<TMessage>[] cs);

  public delegate IView<TMessage> View<in TModel, TMessage>   (TModel model);
  public delegate TModel          Update<TModel, in TMessage> (TModel model, TMessage message);

  public sealed class NamedView<TMessage> : IView<TMessage>
  {
    readonly IView<TMessage> view;
    readonly string          name;

    public NamedView(IView<TMessage> v, string n)
    {
      // TODO: Handle nulls
      view = v      ;
      name = n ?? "";
    }

    public UIElement Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      var nui = 
        ui != null && (string)ui.GetValue(DependencyProperties.NameProperty) == name
        ? ui
        : null
        ;

      var nnui = view.Update(ctx, pi, nui);
      if (nnui != null)
      {
        nnui.SetValue(DependencyProperties.NameProperty, name);
      }

      return nnui;
    }
  }

  public static class ViewExtensions
  {
    public static IView<TMessage> Named<TMessage>(this IView<TMessage> v, string n)
    {
      return new NamedView<TMessage>(v, n);
    }
  }

  // Hosts

  public static class Hosts
  {
    public static void OpenWindow<TModel, TMessage>(TModel model, View<TModel, TMessage> view, Update<TModel, TMessage> update)
    {
      var wnd     = new Window()            ;
      var ctx     = new UpdateContext()     ;
      var disp    = wnd.Dispatcher          ;
      var current = model                   ;
      var queue   = new Queue<TMessage>(16) ;

      void Refresh()
      {
        ctx.TearDown ();
        var nv  = view(current)             ;
        var cnt = wnd.Content as UIElement  ;
        var pi  = ParentInfo.ReusedInstance ;

        wnd.Content = nv.Update(ctx, pi, cnt);
      }

      void Process()
      {
        while (queue.Count > 0)
        {
          var msg = queue.Dequeue ();
          current = update(current, msg);
        }

        Refresh();
      }
      var process = new Action(Process);

      void OnMessage(object o, MessageEventArgs args)
      {
        var msg = (TMessage)args.Message;
        queue.Enqueue(msg);
        disp.Delay(process);
      }
      var onMessage = new MessageEventHandler(OnMessage);

      Refresh();
      wnd.AddHandler(RoutedEvents.MessageEvent, onMessage);

      wnd.ShowDialog();
      queue.Clear();
      ctx.TearDown();
    }
  }
}
