open FSharp.Data

type Simple = JsonProvider<".\sample.json">

let simple = Simple.Parse(".\sample.json")

[<EntryPoint>]
let main argv = 
    printfn "%A" simple.
    0 // return an integer exit code
