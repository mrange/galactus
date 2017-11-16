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
    |> Array.filter  (fun tp       -> tp = uiElement || tp.IsSubclassOf uiElement)
    |> Array.filter  (fun tp       -> not tp.IsGenericType)
    |> Array.sortBy  (fun tp       -> tp.Name)

  use generatedFile = File.CreateText (@"C:\temp\Galactus\Galactus\Generated.fs")
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
"""

  let generate name all tfn pfn efn =
    writelinef """  module %s =""" name

    for tp in types do
      tfn tp

      let bfs =
        BindingFlags.Static
        ||| if all then BindingFlags.FlattenHierarchy else BindingFlags.DeclaredOnly
        ||| BindingFlags.Public
        ||| BindingFlags.GetField

      let dps =
        tp.GetFields (bfs)
        |> Array.filter (fun dp -> dp.Name.EndsWith "Property" && dp.FieldType = dependencyProperty)

      let es =
        tp.GetFields (bfs)
        |> Array.filter (fun dp -> dp.Name.EndsWith "Event" && dp.FieldType = routedEvent)

      // TODO: Handle namespaces
      writelinef """    module %s = """ tp.Name
      writeline  """      let dummy = ()"""

      for f in dps do
        let dp    = f.GetValue null :?> DependencyProperty
        let name  = f.Name |> removeTrailing "Property" |> fixName
        pfn tp f dp name

      for f in es do
        let re    = f.GetValue null :?> RoutedEvent
        let name  = f.Name |> removeTrailing "Event" |> fixName
        let mi    = re.HandlerType.GetMethod "Invoke"
        let ps    = mi.GetParameters ()
        let p     = ps.[1]
        efn tp f re p.ParameterType name

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
    let efn (tp : Type) (f : FieldInfo) (re : RoutedEvent) args name =
      writelinef
        """      let %-40s = Event<%s, %s> %s.%s"""
        name
        (toString re.HandlerType)
        (toString args)
        (toString tp)
        f.Name

    generate "Events" false noType noProperty efn

  do
    let tfn (tp : Type) =
      if not tp.IsAbstract && (tp.GetConstructor [||] |> isNull |> not) then
        let name = tp.Name |> fixName
        if tp.IsSubclassOf content then
          writelinef """
    let %-40s values child =
      StandardContentView<%s> (values, child) :> View
"""         name 
            tp.Name
        elif tp.IsSubclassOf panel then
          writelinef """
    let %-40s values children =
      StandardPanelView<%s> (values, children) :> View
"""         name
            tp.Name
        else
          writelinef """
    let %-40s values =
      StandardView<%s> (values) :> View
"""         name 
            tp.Name

    let pfn (tp : Type) (f : FieldInfo) (dp : DependencyProperty) name =
      writelinef
        """      let %-40s v = SetConstantValue<_> (Properties.%s.%s, v)"""
        name
        f.DeclaringType.Name
        name

    let efn (tp : Type) (f : FieldInfo) (re : RoutedEvent) args name =
      writelinef
        """      let %-40s (f : %s -> %s-> 'TMessage) = OnChangedValue<'TMessage, %s, %s, %s> (Events.%s.%s, f)"""
        name
        (toString tp)
        (toString args)
        (toString tp)
        (toString re.HandlerType)
        (toString args)
        f.DeclaringType.Name
        name

//"""      """
    generate "Controls" false tfn pfn efn

generate ()
