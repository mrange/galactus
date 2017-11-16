namespace Galactus

open System
open System.Reflection
open System.Windows
open System.Windows.Controls

module Core =

  module Details =
    let inline adapt2 f = OptimizedClosures.FSharpFunc<_, _, _>.Adapt f
  open Details

  type MessageEventArgs (message : obj) =
    class
      inherit RoutedEventArgs ()
    end
 
  type EventHandler<'T when 'T :> EventArgs>  = delegate of (obj*'T) -> unit
  type MessageEventHandler                    = EventHandler<MessageEventArgs>

  module RoutedEvents =
    let ownerType () = (MethodInfo.GetCurrentMethod()).DeclaringType
    let MessageEvent = EventManager.RegisterRoutedEvent ("Message", RoutingStrategy.Bubble, typeof<MessageEventHandler>, ownerType ())

  type [<AbstractClass>] Property (dp : DependencyProperty) =
    class
      member x.DependencyProperty = dp
    end

  type [<Sealed>] Property<'T> (dp : DependencyProperty) =
    class
      inherit Property (dp)

      member x.Get (dobj : UIElement) : 'T =
        dobj.GetValue dp :?> 'T

      member x.Set (dobj : UIElement, v : 'T) : unit =
        dobj.SetValue (dp, box v)
    end

  type [<AbstractClass>] Event (re : RoutedEvent) =
    class
      member x.RoutedEvent = re
    end

  type [<Sealed>] Event<'TEventHandler, 
                        'TEventArgs   when  'TEventHandler  :> Delegate
//                                      and   'TEventHandler  : delegate<obj*'TEventArgs, unit>
                                      and   'TEventArgs     :> RoutedEventArgs
                        > (re : RoutedEvent) =
    class
      inherit Event (re)

      member x.Register (dobj : UIElement, hnd : 'TEventHandler) : unit =
        dobj.AddHandler (re, hnd)

      member x.Register (dobj : UIElement, hnd : EventHandler<'TEventArgs>) : unit =
        dobj.AddHandler (re, box hnd :?> 'TEventHandler)

      member x.Raise (dobj : UIElement, args : 'TEventArgs) : unit =
        args.RoutedEvent <- re
        dobj.RaiseEvent args

    end

  type [<AbstractClass>] Value () =
    class
      abstract Update: UIElement -> unit
    end

  type [<AbstractClass>] SetValue (p : Property) =
    class
      inherit Value ()
    end

  type [<AbstractClass>] SetValue<'T> (p : Property<'T>) =
    class
      inherit SetValue (p)

      member x.Property = p
    end

  type [<Sealed>] SetConstantValue<'T> (p : Property<'T>, v : 'T) =
    class
      inherit SetValue<'T> (p)

      override x.Update (dobj : UIElement) : unit =
        p.Set (dobj, v)
    end

  type [<AbstractClass>] OnChangedValue (e : Event) =
    class
      inherit Value ()
    end

  type [<Sealed>] OnChangedValue< 'TMessage     ,
                                  'T            ,
                                  'TEventHandler, 
                                  'TEventArgs   when  'T              :> UIElement
                                                and   'TEventHandler  :> Delegate 
//                                                and   'TEventHandler  : delegate<obj*'TEventArgs, unit>
                                                and   'TEventArgs     :> RoutedEventArgs
                                  > (e : Event<'TEventHandler, 'TEventArgs>, f : 'T -> 'TEventArgs -> 'TMessage) =
    class
      inherit OnChangedValue (e)

      let f = adapt2 f

      member x.Event = e

      member x.Raised (o : obj, args : 'TEventArgs) : unit =
        let v     = o :?> 'T
        let msg   = f.Invoke (v, args)
        let args  = MessageEventArgs (box msg)
        args.RoutedEvent <- RoutedEvents.MessageEvent
        v.RaiseEvent args

      override x.Update (dobj : UIElement) : unit =
        e.Register (dobj, x.Raised)
    end

  type [<AbstractClass>] View () =
    class
      abstract BuildUp: UIElement -> UIElement
    end

  type [<Sealed>] StandardView<'T when 'T :> UIElement and 'T : (new : unit -> 'T)> (values : Value []) =
    class
      inherit View ()
      override x.BuildUp dobj =
        let v =
          match dobj with
          | :? 'T as tv -> tv
          | _           -> new 'T ()

        for value in values do
          value.Update v

        upcast v
    end

  type [<Sealed>] StandardPanelView<'T when 'T :> Panel and 'T : (new : unit -> 'T)> (values : Value [], views : View []) =
    class
      inherit View ()
      override x.BuildUp dobj =
        let v =
          match dobj with
          | :? 'T as tv -> tv
          | _           -> new 'T ()

        let children = v.Children
        let count    = children.Count
        if count > values.Length then
          children.RemoveRange (values.Length, count - values.Length)

        for i = 0 to (views.Length - 1) do
          if i < children.Count then
            let child = children.[i]
            let view  = views.[i]
            children.[i] <- view.BuildUp child
          else
            let view  = views.[i]
            children.Add (view.BuildUp null) |> ignore

        for value in values do
          value.Update v

        upcast v
    end

  type [<Sealed>] StandardContentView<'T when 'T :> ContentControl and 'T : (new : unit -> 'T)> (values : Value [], view : View) =
    class
      inherit View ()
      override x.BuildUp dobj =
        let v =
          match dobj with
          | :? 'T as tv -> tv
          | _           -> new 'T ()

        let child = v.Content :?> UIElement
        v.Content <- view.BuildUp child

        for value in values do
          value.Update v

        upcast v
    end

  let openWindow (model : 'TModel) (view : 'TModel -> View) (update : 'TModel -> 'TMessage -> 'TModel) =
    let wnd = Window ()
    let iv  = view model
    wnd.Content <- iv.BuildUp (wnd.Content :?> UIElement)
    let messageEventHandler (o : obj, args : MessageEventArgs) =
      printfn "MessageEvent received: %A - %A" o args
    wnd.AddHandler (RoutedEvents.MessageEvent, MessageEventHandler messageEventHandler)
    wnd.ShowDialog () |> ignore
