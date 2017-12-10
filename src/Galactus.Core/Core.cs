namespace Galactus.Core
{
  using System;
  using System.Collections.Generic;
  using System.Runtime.CompilerServices;
  using System.Text;
  using System.Windows;
  using System.Windows.Controls;
  using System.Windows.Documents;
  using System.Windows.Media;
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
    public static readonly DependencyProperty DummyProperty         = DependencyProperty.RegisterAttached ("Dummy"        , typeof(object)        , typeof(DependencyProperties));

    public static readonly DependencyProperty NameProperty          = DependencyProperty.RegisterAttached ("Name"         , typeof(string)        , typeof(DependencyProperties));

    public static readonly DependencyProperty PrismProperty         = DependencyProperty.RegisterAttached("Prism"         , typeof(IPrism)        , typeof(DependencyProperties));

    public static readonly DependencyProperty ErrorAdornerProperty  = DependencyProperty.RegisterAttached("ErrorAdorner"  , typeof(ErrorAdorner)  , typeof(DependencyProperties));

    public static readonly DependencyProperty ErrorTreeProperty     = DependencyProperty.RegisterAttached("ErrorTree"     , typeof(ErrorTree)     , typeof(DependencyProperties));

    public static readonly DependencyProperty StateProperty         = DependencyProperty.RegisterAttached("State"         , typeof(object)        , typeof(DependencyProperties));

    public static IPrism GetPrism(DependencyObject dobj)
    {
      return (IPrism)dobj?.GetValue(PrismProperty);
    }

    public static void SetPrism(DependencyObject dobj, IPrism l)
    {
      dobj?.SetValue(PrismProperty, l);
    }

    public static ErrorAdorner GetErrorAdorner(DependencyObject dobj)
    {
      return (ErrorAdorner)dobj?.GetValue(ErrorAdornerProperty);
    }

    public static void SetErrorAdorner(DependencyObject dobj, ErrorAdorner l)
    {
      dobj?.SetValue(ErrorAdornerProperty, l);
    }

    public static ErrorTree GetErrorTree(DependencyObject dobj)
    {
      return (ErrorTree)dobj?.GetValue(ErrorTreeProperty);
    }

    public static void SetErrorTree(DependencyObject dobj, ErrorTree l)
    {
      dobj?.SetValue(ErrorTreeProperty, l);
    }

    public static object GetState(DependencyObject dobj)
    {
      return dobj?.GetValue(StateProperty);
    }

    public static void SetState(DependencyObject dobj, object l)
    {
      dobj?.SetValue(StateProperty, l);
    }

  }
  
  public abstract class TearDownTree
  {
    public readonly bool IsEmpty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected TearDownTree(bool isEmpty)
    {
      IsEmpty = isEmpty;
    }

    // For efficiency reasons this is set to null
    public readonly static TearDownTree Zero = null;

    public abstract void TearDown();
  }

  public sealed class EmptyTearDownTree : TearDownTree
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal EmptyTearDownTree() 
      : base(true)
    {
    }

    public override void TearDown()
    {
    }
  }

  public sealed class ForkedTearDownTree : TearDownTree
  {
    public readonly TearDownTree Left    ;
    public readonly TearDownTree Right   ;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    ForkedTearDownTree(TearDownTree left, TearDownTree right)
      : base(false)
    {
      Left  = left  ;
      Right = right ;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TearDownTree Create(TearDownTree left, TearDownTree right)
    {
      if (left == null || left.IsEmpty)
      {
        return right;
      }
      else if (right == null || right.IsEmpty)
      {
        return left;
      }

      return new ForkedTearDownTree(left, right);
    }

    public override void TearDown()
    {
      Right.TearDown();
      Left.TearDown();
    }
  }

  public abstract class ErrorTree
  {
    public readonly bool IsEmpty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected ErrorTree(bool isEmpty)
    {
      IsEmpty = isEmpty;
    }

    public abstract void OnCollapse(StringBuilder pathBuilder, Action<string, string> receiver);

    public void Collapse(Action<string, string> receiver)
    {
      var sb = new StringBuilder ();
      OnCollapse(sb, receiver);
    }                 

    public (string path, string message)[] ToArray()
    {
      var errors  = new List<(string, string)>(16);
      Collapse((p, m) => errors.Add((p, m)));
      return errors.ToArray();
    }                 

    // For efficiency reasons this is set to null
    public readonly static ErrorTree Zero = null;
  }

  public sealed class EmptyErrorTree : ErrorTree
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal EmptyErrorTree() 
      : base(true)
    {
    }

    public override void OnCollapse(StringBuilder pathBuilder, Action<string, string> receiver)
    {
    }
  }

  public sealed class ForkedErrorTree : ErrorTree
  {
    public readonly ErrorTree Left    ;
    public readonly ErrorTree Right   ;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    ForkedErrorTree(ErrorTree left, ErrorTree right)
      : base(false)
    {
      Left  = left  ;
      Right = right ;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ErrorTree Create(ErrorTree left, ErrorTree right)
    {
      if (left == null || left.IsEmpty)
      {
        return right;
      }
      else if (right == null || right.IsEmpty)
      {
        return left;
      }

      return new ForkedErrorTree(left, right);
    }

    public override void OnCollapse(StringBuilder pathBuilder, Action<string, string> receiver)
    {
      Left.OnCollapse(pathBuilder, receiver);
      Right.OnCollapse(pathBuilder, receiver);
    }
  }

  public sealed class ValidationErrorTree : ErrorTree
  {
    public readonly IImmutableList<string>  Path    ;
    public readonly string                  Message ;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    ValidationErrorTree(IImmutableList<string> path, string message)
      : base(false)
    {
      Path    = path    ;
      Message = message ;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ErrorTree Create(IImmutableList<string> path, string message)
    {
      return new ValidationErrorTree(path ?? ImmutableList.Empty<string>(), message ?? "");
    }

    static void BuildPath(StringBuilder pathBuilder, IImmutableList<string> path)
    {
      var decons = path.Decons();
      if (decons.HasValue)
      {
        BuildPath(pathBuilder, decons.Value.tail);
        pathBuilder.Append("/").Append(decons.Value.head);
      }
    }

    public override void OnCollapse(StringBuilder pathBuilder, Action<string, string> receiver)
    {
      pathBuilder.Clear();
      BuildPath(pathBuilder, Path);
      receiver(pathBuilder.ToString(), Message);
    }
  }

  public sealed class GroupErrorTree : ErrorTree
  {
    public readonly ErrorTree[]             Errors  ;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    GroupErrorTree(ErrorTree[] errors)
      : base(false)
    {
      Errors = errors;
    }

    public static ErrorTree Create(ErrorTree[] errors)
    {
      if (errors == null || errors.Length == 0)
      {
        return ErrorTree.Zero;
      }
      else if (errors.Length == 1)
      {
        return errors[0];
      }
      else
      { 
        return new GroupErrorTree(errors);
      }
    }

    public override void OnCollapse(StringBuilder pathBuilder, Action<string, string> receiver)
    {
      foreach (var e in Errors)
      {
        e.OnCollapse(pathBuilder, receiver);
      }
    }
  }

  public static class TreeExtensions
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TearDownTree JoinWith(this TearDownTree this_, TearDownTree that)
    {
      return ForkedTearDownTree.Create(this_, that);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ErrorTree JoinWith(this ErrorTree this_, ErrorTree that)
    {
      return ForkedErrorTree.Create(this_, that);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEmpty(this ErrorTree this_)
    {
      return this_ == null || this_.IsEmpty;
    }
  }


  public sealed class BuildUpContext
  {
    public readonly int                    PathLength ;
    public readonly IImmutableList<string> Path       ;
    
    public BuildUpContext(int pathLength, IImmutableList<string> path)
    {
      PathLength  = pathLength                            ;
      Path        = path ?? ImmutableList.Empty<string>() ;
    }

    public BuildUpContext()
      : this(0, null)
    {
    }

    public BuildUpContext AppendToPath(string name)
    {
      return new BuildUpContext(PathLength + 1, Path.Cons(name ?? ""));
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

  public struct UpdateResult
  {
    public readonly TearDownTree  TearDownTree  ;
    public readonly ErrorTree     ErrorTree     ;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UpdateResult(TearDownTree tearDownTree, ErrorTree errorTree)
    {
      TearDownTree  = tearDownTree;
      ErrorTree     = errorTree   ;
    }

    public static readonly UpdateResult Zero = new UpdateResult(null, null);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public BuildUpResult ToBuildUpResult(UIElement ui)
    {
      return new BuildUpResult(ui, TearDownTree, ErrorTree);
    }
  }

  public interface IValue<TMessage, in TUI>
    where TUI : UIElement
  {
    UpdateResult Update(BuildUpContext ctx, ParentInfo pi, UIElement ui);
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

    public UpdateResult Update(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      // TODO: Cast unnecessary but doesn't cost that much compared to set in general
      property.Set((TUI)ui, value);

      return UpdateResult.Zero;
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

  public delegate void Invoker(BuildUpContext ctx, ParentInfo pi, UIElement ui);

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

    public UpdateResult Update(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      invoker(ctx, pi, ui);

      return UpdateResult.Zero;
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

    sealed class RemoveHandlerTearDownTree : TearDownTree
    {
      readonly UIElement    uIElement       ;
      readonly RoutedEvent  routedEvent     ;
      readonly Delegate     onChangeHandler ;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public RemoveHandlerTearDownTree (UIElement u, RoutedEvent re, Delegate h)
        : base(false)
      {
        uIElement       = u ;
        routedEvent     = re;
        onChangeHandler = h ;
      }

      public override void TearDown()
      {
        uIElement.RemoveHandler(routedEvent, onChangeHandler);
      }
    }

    public UpdateResult Update(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      // TODO: Handle nulls
      // TODO: How to handle events more efficiently?

      // TODO: Whether to handle events that already been handled should be configurable
      ui.AddHandler(event_.RoutedEvent, onChangeHandler, false);
      return new UpdateResult(new RemoveHandlerTearDownTree(ui, event_.RoutedEvent, onChangeHandler), null);
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

    public UpdateResult Update(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      switch (pi)
      {
      case ParentInfo.NewInstance:
        value.Update(ctx, pi, ui);
        break;
      case ParentInfo.ReusedInstance:
        break;
      }

      return UpdateResult.Zero;
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

    public IProperty<TUI, T>  Property  => setValue.Property ;
    public T                  Value     => setValue.Value    ;

    public UpdateResult Update(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      setValue.Update(ctx, pi, ui);

      var v     = Value;
      var msgs  = validator(v);
      if (msgs != null && msgs.Length > 0)
      {
        var path = ctx.Path.Cons(name);
        if (msgs.Length == 1)
        {
          return new UpdateResult(null, ValidationErrorTree.Create(path, msgs[0]));
        }
        else
        {
          var es =  new ErrorTree[msgs.Length];

          for (var i = 0; i < msgs.Length; ++i)
          {
            es[i] = ValidationErrorTree.Create(path, msgs[i]);
          }

          return new UpdateResult(null, GroupErrorTree.Create(es));
        }
      }
      else
      {
        return UpdateResult.Zero;
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

  public struct BuildUpResult
  {
    public readonly UIElement     UIElement   ;
    public readonly TearDownTree  TearDownTree;
    public readonly ErrorTree     ErrorTree   ;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public BuildUpResult(UIElement uiElement, TearDownTree tearDownTree, ErrorTree errorTree)
    {
      UIElement     = uiElement     ;
      TearDownTree  = tearDownTree  ;
      ErrorTree     = errorTree     ;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UpdateResult ToUpdateResult()
    {
      return new UpdateResult(TearDownTree, ErrorTree);
    }

  }

  public interface IView
  {
    BuildUpResult BuildUp(BuildUpContext ctx, ParentInfo pi, UIElement ui);
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
    public BuildUpResult BuildUp(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      var v = GetInstance<Empty>(ui);
      var tpi = v.ParentInfo;
      var tui = v.Instance  ;

      return new BuildUpResult(tui, null, null);
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

    public BuildUpResult BuildUp(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      var v = GetInstance<TUI>(ui);

      var tpi = v.ParentInfo;
      var tui = v.Instance  ;

      var tearDownTree  = TearDownTree.Zero ;
      var errorTree     = ErrorTree.Zero    ;

      foreach (var value in values)
      {
        var ur        = value.Update(ctx, tpi, tui);
        tearDownTree  = tearDownTree.JoinWith(ur.TearDownTree);
        errorTree     = errorTree.JoinWith(ur.ErrorTree);
      }

      return new BuildUpResult(tui, tearDownTree, errorTree);
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

    public BuildUpResult BuildUp(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      var nui =
        ui != null && (string)ui.GetValue(DependencyProperties.NameProperty) == name
        ? ui
        : null
        ;

      var nctx  = ctx.AppendToPath(name);
      var br    = view.BuildUp(nctx, pi, nui);
      br.UIElement?.SetValue(DependencyProperties.NameProperty, name);

      return br;
    }
  }

  public sealed class ErrorAdorner : Adorner
  {
    static readonly Pen red = new Pen(Brushes.Red, 1.0);

    public ErrorAdorner(UIElement adornedElement)
      : base(adornedElement)
    {
    }

    protected override void OnRender(DrawingContext drawingContext)
    {
      base.OnRender(drawingContext);

      drawingContext.DrawRectangle(null, red, new Rect(0, 0, ActualWidth, ActualHeight));
    }
  }

  public sealed class ErrorAdornerView<TMessage> : IView<TMessage>
  {
    readonly IView<TMessage> view;

    public ErrorAdornerView(IView<TMessage> v)
    {
      // TODO: Handle nulls
      view = v      ;
    }

    sealed class OnLayoutUpdated
    {
      readonly UIElement    ui;
      readonly EventHandler eh;

      public OnLayoutUpdated(UIElement u)
      {
        ui = u;
        eh = UIElement_LayoutUpdated;

        ui.LayoutUpdated += eh;
      }

      void UIElement_LayoutUpdated(object sender, EventArgs e)
      {
        ui.LayoutUpdated  -=UIElement_LayoutUpdated;
        var errorAdorner  = DependencyProperties.GetErrorAdorner(ui);
        var adornerLayer  = AdornerLayer.GetAdornerLayer(ui);
        adornerLayer?.Add(errorAdorner);
      }
    }

    public BuildUpResult BuildUp(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      var br = view.BuildUp(ctx, pi, ui);

      if (br.UIElement != null)
      {
        var errorAdorner = DependencyProperties.GetErrorAdorner(ui);

        if (errorAdorner == null)
        {
          errorAdorner = new ErrorAdorner(br.UIElement);
          DependencyProperties.SetErrorAdorner(br.UIElement, errorAdorner);
          // This class registers an event in the ctor
          new OnLayoutUpdated(br.UIElement);
        }

        var hasErrors = !br.ErrorTree.IsEmpty();
        errorAdorner.Visibility = hasErrors ? Visibility.Visible : Visibility.Collapsed;
      }

      return br;
    }
  }

  public sealed class ToolTipView<TMessage> : IView<TMessage>
  {
    readonly IView<TMessage>  view    ;
    readonly string           toolTip ;

    public ToolTipView(IView<TMessage> v, string tt)
    {
      // TODO: Handle nulls
      view    = v         ;
      toolTip = tt ?? ""  ;
    }

    public BuildUpResult BuildUp(BuildUpContext ctx, ParentInfo pi, UIElement ui)
    {
      var br = view.BuildUp(ctx, pi, ui);

      if (br.UIElement != null)
      {
        ToolTipService.SetShowOnDisabled(br.UIElement, true);
        if (br.ErrorTree.IsEmpty())
        {
          ToolTipService.SetToolTip(br.UIElement, toolTip);
        }
        else
        {
          var sb = new StringBuilder(toolTip);
          br.ErrorTree.Collapse((p, m) => sb.AppendFormat("\n {0} - {1}", p, m));
          ToolTipService.SetToolTip(br.UIElement, sb.ToString());
        }
      }

      return br;
    }
  }

  public static class ViewExtensions
  {
    public static IView<TMessage> WithErrorAdorner<TMessage>(this IView<TMessage> view)
    {
      return new ErrorAdornerView<TMessage>(view);
    }

    public static IView<TMessage> WithName<TMessage>(this IView<TMessage> view, string name)
    {
      return new NamedView<TMessage>(view, name);
    }

    public static IView<TMessage> WithToolTip<TMessage>(this IView<TMessage> view, string toolTip)
    {
      return new ToolTipView<TMessage>(view, toolTip);
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
      var tearDownTree  = TearDownTree.Zero       ;
      var disp          = cc.Dispatcher           ;
      var current       = model                   ;
      var queue         = new Queue<TMessage>(16) ;

      void Refresh()
      {
        Console.WriteLine("Refresh");

        tearDownTree?.TearDown();

        tearDownTree  = TearDownTree.Zero                     ;
        var nv        = view(current)                         ;
        var cnt       = cc.Content as UIElement               ;
        var pi        = ParentInfo.ReusedInstance             ;

        var ctx       = new BuildUpContext()                  ;
        var br        = nv.BuildUp(ctx, pi, cnt)              ;
        cc.Content    = br.UIElement                          ;
        tearDownTree  = br.TearDownTree ?? TearDownTree.Zero  ;
        if(!br.ErrorTree.IsEmpty())
        {
          // TODO: Handle Error Tree?
          Console.WriteLine("Errors");
          var errors = br.ErrorTree.ToArray();
          foreach (var e in errors)
          {
            Console.WriteLine("  {0} - {1}", e.path, e.message);
          }
        }
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
      };
    }
  }
}
