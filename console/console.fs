module console

open PostSharp.Patterns.Diagnostics

[<EntryPoint>]
[<Log>]
let main argv =
    printfn "%s" (argv.Length.ToString())
    0 // return an integer exit code
