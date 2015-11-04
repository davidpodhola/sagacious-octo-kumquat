open FSharp.Data
open System.IO

module Async =
    let AwaitTaskVoid : (System.Threading.Tasks.Task -> Async<unit>) =
        Async.AwaitIAsyncResult >> Async.Ignore

[<EntryPoint>]
let main argv = 
    let logoUrl = "http://infinite-download.ma.ttias.be/download.php"
    let fileName = Path.GetTempPath() + "infinitefile.bin"
    async {
        let! request = Http.AsyncRequestStream(logoUrl)
        use outputFile = new System.IO.FileStream(fileName,System.IO.FileMode.Create)
        do! request.ResponseStream.CopyToAsync( outputFile ) |> Async.AwaitTaskVoid 
    } |> Async.RunSynchronously
    0
