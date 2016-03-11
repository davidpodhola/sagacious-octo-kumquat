module Eto.Forms.Test

open System
open Eto
open Eto.Forms
open Eto.Drawing

[<EntryPoint>]
let main argv =
    let app = new Application()
    let f = new Form(Topmost=true, ClientSize = new Size(600, 480))
    let p = new Panel()
    let b = new Button()
    b.Text <- "Click me!"
    b.Click.Add( fun t -> app.Quit() )
    p.Content <- b
    f.Content <- p
    app.Run(f)
    0 


