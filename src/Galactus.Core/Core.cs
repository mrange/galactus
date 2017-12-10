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
    public static readonly RoutedEvent DummyEvent   = EventManager.RegisterRoutedEvent("Dummy"  , RoutingStrategy.Direct, typeof(MessageEventHandler), typeof(RoutedEvents));

    public static readonly RoutedEvent MessageEvent = EventManager.RegisterRoutedEvent("Message", RoutingStrategy.Bubble, typeof(MessageEventHandler), typeof(RoutedEvents));
  }

  public static class DependencyProperties
  {
    public static readonly DependencyProperty DummyProperty = DependencyProperty.RegisterAttached ("Dummy" , typeof(object), typeof(DependencyProperties));

    public static readonly DependencyProperty NameProperty  = DependencyProperty.RegisterAttached ("Name"  , typeof(string), typeof(DependencyProperties));

    public static readonly DependencyProperty PrismProperty  = DependencyProperty.RegisterAttached("Prism"  , typeof(IPrism) , typeof(DependencyProperties));

    public static IPrism GetPrism(DependencyObject dobj)
    {
      return (IPrism)dobj?.GetValue(PrismProperty);
    }

    public static void SetPrism(DependencyObject dobj, IPrism l)
    {
      dobj?.SetValue(PrismProperty, l);
    }
  }
  
  public struct ValidationError
  {
    public readonly IImmutableList<string>  Path    ;
    public readonly string                  Message ;

    public ValidationError(IImmutableList<string> path, string message)
    {
      Path    = path    ?? ImmutableList.Empty<string>();
      Message = message ?? ""                           ;
    }
  }

  public delegate void Teardown();

  public sealed class UpdateContext
  {
    readonly List<Teardown>         tearDowns         = new List<Teardown>(16);
    readonly List<ValidationError>  validationErrors  = new List<ValidationError>(16);
    
    IImmutableList<string> path = ImmutableList.Empty<string>();

    public void AddValidationError(string name, string message)
    {
      validationErrors.Add(new ValidationError(path.Cons(name ?? ""), message));
    }

    public ValidationError[] ValidationErrors => validationErrors.ToArray();

    public void PushValidationContext(string name)
    {
      path = path.Cons(name ?? "");
    }

    public void PopValidationContext()
    {
      var m = path.Decons();
      if (m.HasValue)
      {
        path = m.Value.tail;
      }
    }

    public void OnTearDown(Teardown action)
    {
      if (action != null)
      {
        tearDowns.Add(action);
      }
    }

    public void TearDown()
    {
      for (var iter = tearDowns.Count - 1; iter >= 0; --iter)
      {
        var a = tearDowns[iter];
        a();
      }

      tearDowns.Clear();
      validationErrors.Clear();
      path = ImmutableList.Empty<string>();
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
    T    Get  (TUI ui);
    void Set  (TUI ui, T v);
    void Clear(TUI ui);
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
      var lv    = ui.ReadLocalValue(dependencyProperty);
      object nv = v;
      if (ReferenceEquals(lv, nv) || lv != null && nv != null && lv.Equals(nv))
      {
        // Do nothing
      }
      else
      {
        ui.SetValue(dependencyProperty, v);
      }
    }

    public void Clear(TUI ui)
    {
      ui.ClearValue(dependencyProperty);
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
    IProperty<TUI, T> Property  { get; }
    T                 Value     { get; }
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

    public IProperty<TUI, T> Property   => property ;
    public T                  Value     => value    ;

    public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      // TODO: Cast unnecessary but doesn't cost that much compared to set in general
      property.Set((TUI)ui, value);
    }
  }

  public interface IViewValue<TMessage, in TUI> : IValue<TMessage, TUI>
    where TUI : UIElement
  {
    IView<TMessage> View { get; }
  }

  public interface IViewsValue<TMessage, in TUI> : IValue<TMessage, TUI>
    where TUI : UIElement
  {
    IView<TMessage>[] Views { get; }
  }

  public delegate void Invoker(UpdateContext ctx, ParentInfo pi, UIElement ui);

  public interface IInvokedValue<TMessage, in TUI> : IValue<TMessage, TUI>
    where TUI : UIElement
  {
    Invoker Invoker { get; }
  }

  public sealed class InvokedValue<TMessage, TUI> : IInvokedValue<TMessage, TUI>
    where TUI : UIElement
  {
    readonly Invoker invoker;

    public Invoker Invoker => invoker;

    public InvokedValue(Invoker i)
    {
      // TODO: Handle nulls
      invoker = i;
    }

    public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      invoker(ctx, pi, ui);
    }
  }

  public interface IOnChangedValue<TMessage, in TUI, TEventHandler, TEventArgs> : IValue<TMessage, TUI>
    where TUI : UIElement
  {
  }

  public delegate Delegate EventHandlerMapper<TEventArgs>(EventHandler<TEventArgs> handler)
    where TEventArgs : RoutedEventArgs
    ;

  public delegate TMessage OnChange<TMessage, in TUI, in TEventArgs>(TUI uiElement, TEventArgs args)
    where TUI : UIElement
    ;

  public sealed class OnChangedValue<TMessage, TUI, TEventHandler, TEventArgs> : IOnChangedValue<TMessage, TUI, TEventHandler, TEventArgs>
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
      // TODO: How to handle events more efficiently?

      // TODO: Whether to handle events that already been handled should be configurable
      ui.AddHandler(event_.RoutedEvent, onChangeHandler, false);
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

  public sealed class ValidateValue<TMessage, TUI, T> : ISetValue<TMessage, TUI, T>
    where TUI : UIElement
  {
    readonly ISetValue<TMessage, TUI, T> setValue ;
    readonly string                      name     ;
    readonly Func<T, string[]>           validator;

    public ValidateValue(ISetValue<TMessage, TUI, T> v, string n, Func<T, string[]> vr)
    {
      // TODO: Handle nulls
      setValue  = v       ;
      name      = n ?? "" ;
      validator = vr      ;
    }

    public IProperty<TUI, T> Property   => setValue.Property ;
    public T                  Value     => setValue.Value    ;

    public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      setValue.Update(ctx, pi, ui);

      var v     = Value;
      var msgs  = validator(v);
      if (msgs != null)
      {
        foreach (var msg in msgs)
        {
          ctx.AddValidationError(name, msg);
        }
      }

    }
  }

  public static class ValueExtensions
  {
    public static IValue<TMessage, TUI> InitOnly<TMessage, TUI>(this IValue<TMessage, TUI> value)
      where TUI : UIElement
    {
      return new InitOnlyValue<TMessage, TUI>(value);
    }

    public static ISetValue<TMessage, TUI, T> Validate<TMessage, TUI, T>(this ISetValue<TMessage, TUI, T> value, string name, Func<T, string[]> validator)
      where TUI : UIElement
    {
      return new ValidateValue<TMessage, TUI, T>(value, name, validator);
    }

    public static ISetValue<TMessage, TUI, T> Validate<TMessage, TUI, T>(this ISetValue<TMessage, TUI, T> value, string name, Func<T, string> validator)
      where TUI : UIElement
    {
      string[] Validator(T v)
      {
        var msg = validator(v);
        if (msg != null)
        {
          return new [] {msg};
        }
        else
        {
          return null;
        }
      }

      return new ValidateValue<TMessage, TUI, T>(value, name, Validator);
    }

  }

  // Views

  public interface IView
  {
    UIElement Update(UpdateContext ctx, ParentInfo pi, UIElement ui);
  }

  public interface IView<TMessage> : IView
  {
  }

  public sealed class Empty : UIElement
  {
    public Empty ()
    {
      Visibility = Visibility.Collapsed;
    }
  }

  public sealed class EmptyView<TMessage>
    : IView<TMessage>
  {
    public UIElement Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
    {
      var v = GetInstance<Empty>(ui);
      var tpi = v.ParentInfo;
      var tui = v.Instance  ;

      return tui;
    }
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

      ctx.PushValidationContext(name);
      var nnui = view.Update(ctx, pi, nui);
      nnui?.SetValue(DependencyProperties.NameProperty, name);
      ctx.PopValidationContext();

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

  public delegate void HostCleanup();

  public static class Hosts
  {
    public static void OpenNewWindow<TModel, TMessage>(TModel model, View<TModel, TMessage> view, Update<TModel, TMessage> update)
    {
      var wnd     = new Window();
      var cleanup = ExistingContentControl(wnd, model, view, update);

      wnd.ShowDialog();
      cleanup();
    }

    public static (ContentControl contentControl, HostCleanup cleanup) NewContentControl<TModel, TMessage>(TModel model, View<TModel, TMessage> view, Update<TModel, TMessage> update)
    {
      var cc      = new ContentControl();
      var cleanup = ExistingContentControl(cc, model, view, update);
      return (cc, cleanup);
    }

    public static HostCleanup ExistingContentControl<TModel, TMessage>(ContentControl cc, TModel model, View<TModel, TMessage> view, Update<TModel, TMessage> update)
    {
      var ctx     = new UpdateContext()     ;
      var disp    = cc.Dispatcher           ;
      var current = model                   ;
      var queue   = new Queue<TMessage>(16) ;

      void Refresh()
      {
        ctx.TearDown ();
        var nv      = view(current)             ;
        var cnt     = cc.Content as UIElement   ;
        var pi      = ParentInfo.ReusedInstance ;

        cc.Content  = nv.Update(ctx, pi, cnt)   ;
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
        // TODO: Avoiding invoking Delay if already a queue?
        disp.Delay(process);
      }
      var onMessage = new MessageEventHandler(OnMessage);

      Refresh();
      cc.AddHandler(RoutedEvents.MessageEvent, onMessage, false);

      return () => 
      { 
        cc.RemoveHandler(RoutedEvents.MessageEvent, onMessage);
        queue.Clear();
        ctx.TearDown();
      };
    }
  }
}
