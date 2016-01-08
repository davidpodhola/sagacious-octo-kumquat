open PostSharp.Patterns.Diagnostics
open PostSharp.Extensibility
open System

module Main =
    let log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


    [<Log>]
    let doTheWork argv =
        printfn "%A, press ENTER to continue" argv
        Console.ReadLine() |> ignore

    [<EntryPoint>]
    let main argv = 
        log4net.Config.BasicConfigurator.Configure() |> ignore
        doTheWork argv
        Console.ReadLine() |> ignore
        0 // return an integer exit code
