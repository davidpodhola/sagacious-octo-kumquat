module console

open PostSharp.Patterns.Diagnostics

[<EntryPoint>]
[<Log>]
let main argv =
    printfn "%A" argv
    0 // return an integer exit code
