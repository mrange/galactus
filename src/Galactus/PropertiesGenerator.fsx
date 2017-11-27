#r "WindowsBase"
#r "PresentationCore"
#r "PresentationFramework"

open System.Reflection
open System.Windows
open System.Windows.Controls
open System
open System.Text
open System.IO

open FSharp.Core.Printf
open System.Windows
open System.Windows.Interop

let content             = typeof<ContentControl>
let dependencyProperty  = typeof<DependencyProperty>
let routedEvent         = typeof<RoutedEvent>
let panel               = typeof<Panel>
let uiElement           = typeof<UIElement>
let assemblies          =
  [|
    uiElement.Assembly
    typeof<Panel>.Assembly
  |]

let blackList =
  [|
    typeof<HwndHost>
  |]

let generate () =
  let fixName (s : string) =
    if s.Length > 0 then
      let c = s.[0]
      if Char.IsLower c then
        s
      else
        (Char.ToLowerInvariant c).ToString () + s.Substring 1
    else
      s


  let removeTrailing (t : string) (s : string) =
    let i = s.LastIndexOf t
    if i > 0 then
      s.Substring (0, i)
    else
      s

  let toString tp =
    let sb = StringBuilder 16
    let str s = sb.Append (s : string) |> ignore

    let rec loop (tp : Type) =
      if tp.IsGenericType then
        let itps = tp.GetGenericArguments ()
        let gtp = tp.GetGenericTypeDefinition ()
        str (removeTrailing (sprintf "`%d" itps.Length) gtp.FullName)
        str "<"
        for i = 0 to (itps.Length - 1) do
          if i > 0 then str ", "
          let itp = itps.[i]
          loop itp
        str ">"
      else
        str tp.FullName

    loop tp

    sb.ToString ()

  let types =
    assemblies
    |> Array.collect (fun assembly -> assembly.ExportedTypes |> Seq.toArray)
    |> Array.filter  (fun tp       ->
                        let c0 = tp = uiElement || tp.IsSubclassOf uiElement
                        let c1 = not tp.IsGenericType
                        let c2 = blackList |> Array.contains tp |> not
                        c0 && c1 && c2
                      )
    |> Array.sortBy  (fun tp       -> tp.Name)

  use generatedFile = File.CreateText (@"C:\temp\GitHub\galactus\src\Galactus\Generated.fs")
  generatedFile.NewLine   <- "\n"

  let writeline s   = generatedFile.WriteLine (s : string)
  let writelinef f  = kprintf writeline f

  writeline """namespace Galactus

open System.Windows
open System.Windows.Controls
open System.Windows.Controls.Primitives
open System.Windows.Documents
open System.Windows.Navigation
open System.Windows.Shapes

open Galactus.Core

module Generated =
  module Dummy =
    open System
"""

  let generate name all tfn pfn efn =
    writelinef """  module %s =""" name

    for tp in types do
      tfn tp

      let bfs =
        if all then BindingFlags.FlattenHierarchy else BindingFlags.DeclaredOnly
        ||| BindingFlags.Public

      let dps =
        tp.GetFields (BindingFlags.Static ||| bfs)
        |> Array.filter (fun f -> f.Name.EndsWith "Property" && f.FieldType = dependencyProperty)

      let es =
        tp.GetEvents (BindingFlags.Instance ||| bfs)

      // TODO: Handle namespaces
      writelinef """    module %s = """ tp.Name
      writeline  """      open Dummy"""

      for f in dps do
        let dp    = f.GetValue null :?> DependencyProperty
        let name  = f.Name |> removeTrailing "Property" |> fixName
        pfn tp f dp name

      for e in es do
        let name  = e.Name
        let eh    = e.EventHandlerType
        let mi    = eh.GetMethod "Invoke"
        let ps    = mi.GetParameters ()
        let p     = ps.[1]
        efn tp e eh p.ParameterType name

      writeline ""

  let noType     _         = ()
  let noProperty _ _ _ _   = ()
  let noEvent    _ _ _ _ _ = ()

  do
    let pfn (tp : Type) (f : FieldInfo) (dp : DependencyProperty) name =
      writelinef
        """      let %-40s = Property<%s> %s.%s"""
        name
        (toString dp.PropertyType)
        (toString tp)
        f.Name

    generate "Properties" false noType pfn noEvent

  do
    let tfn (tp : Type) =
      if not tp.IsAbstract && (tp.GetConstructor [||] |> isNull |> not) then
        let name = tp.Name |> fixName
        if tp.IsSubclassOf content then
          writelinef """    let %-40s values child =
      StandardContentView<_, %s> (values, child) :> View<_>"""
            name
            tp.Name
        elif tp.IsSubclassOf panel then
          writelinef """    let %-40s values children =
      StandardPanelView<_, %s> (values, children) :> View<_>"""
            name
            tp.Name
        else
          writelinef """    let %-40s values =
      StandardView<_, %s> (values) :> View<_>"""
            name
            tp.Name

    let pfn (tp : Type) (f : FieldInfo) (dp : DependencyProperty) name =
      writelinef
        """      let %-40s v = SetConstantValue<_, _> (Properties.%s.%s, v)"""
        name
        f.DeclaringType.Name
        name

    let efn (tp : Type) (e : EventInfo) handler args name =
      let ename = "on" + name
      writelinef """
      let private %s_r (o : %s) (h : obj -> %s -> unit) = o.%s.AddHandler    (%s h)
      let private %s_u (o : %s) (h : obj -> %s -> unit) = o.%s.RemoveHandler (%s h)
      let private %s_rf = %s_r
      let private %s_uf = %s_u
      let %-40s (f : %s -> %s-> 'TMessage) =
        OnChangedValue<'TMessage, %s, %s, %s> (%s_rf, %s_uf, f)"""
        ename
        (toString tp)
        (toString args)
        name
        (toString handler)
        ename
        (toString tp)
        (toString args)
        name
        (toString handler)
        ename
        ename
        ename
        ename
        ename
        (toString tp)
        (toString args)
        (toString tp)
        (toString handler)
        (toString args)
        ename
        ename

//"""      """
    generate "Controls" false tfn pfn efn

generate ()
