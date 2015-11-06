open System.IO
open PortableLibrary1
open System.Runtime.Serialization.Formatters.Binary

let serializeBinary<'a> (x :'a) =
    let binFormatter = new BinaryFormatter()

    use stream = new MemoryStream()
    binFormatter.Serialize(stream, x)
    stream.ToArray()

let deserializeBinary<'a> (arr : byte[]) =
    let binFormatter = new BinaryFormatter()

    use stream = new MemoryStream(arr)
    binFormatter.Deserialize(stream) :?> 'a

[<EntryPoint>]
let main argv = 
    printfn "%A" ( deserializeBinary<Person>( serializeBinary({FirstName="John";LastName="Rambo"}) ) )
    0 // return an integer exit code
