open MathExt
open System

[<EntryPoint>]
let main argv = 
    let data = [ 
      ("A", 1.0) 
      ("B", 2.1)
      ("C", 1.5)
    ]

    printfn "%M" ((decimal) (Math.Round( ( data |> List.map ( fun (_, d) -> (double)d  ) ).StandardDeviation(), 2 )))
    0
