module TestApp =
  open Galactus.Core
  open Galactus.Generated.Controls
  open System.Windows.Controls

  let textButton values text = button values (textBlock [|TextBlock.text text|])

  let tt = TextBox ()

  type Message =
    | TextChanged of string

  type Model = Model of string

  let update (Model _) message =
    match message with
    | TextChanged info -> Model info

  let view (Model info) =
    stackPanel
      [|StackPanel.orientation Orientation.Vertical|]
      [|
        textBlock   [|TextBlock.text "Hello"|]
        textBox     [|TextBox.text   "GG"; TextBoxBase.onTextChanged (fun tb args -> TextChanged "Testing")|]
        textBox     [|TextBox.text   "GG"|]
        textButton  [||] "Hello"
        textButton  [||] info
      |]

  let run () =
    openWindow (Model "There!") view update


open System

[<EntryPoint>]
[<STAThread>]
let main argv =
  TestApp.run ()
  0
