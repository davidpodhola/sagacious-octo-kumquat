module gtksharpsample

open Gtk

[<EntryPoint>]
let main argv =
    Application.Init()

    //Create the Window
    let myWin = new Window("My first GTK# Application! ")
    myWin.Resize(200,200)

    //Create a label and put some text in it.
    let myLabel = new Label()
    myLabel.Text = "Hello World!!!!"

    //Add the label to the form
    myWin.Add(myLabel)

    //Show Everything
    myWin.ShowAll()

    Application.Run()

    0 // return an integer exit code
