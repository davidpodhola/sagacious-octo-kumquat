open System

let rec fib = function
    | 0 -> 0
    | 1 -> 1
    | n -> fib (n-1) + fib (n-2)

[<EntryPoint>]
let main argv = 
    printfn "%A" (fib (Int32.Parse(argv.[0])))
    
    0 // return an integer exit code
