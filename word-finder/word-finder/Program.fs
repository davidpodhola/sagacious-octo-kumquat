[<ReflectedDefinition>]
module Program

open System.IO
open FunScript
open FunScript.TypeScript
open FunScript.Compiler

[<ReflectedDefinition>]
module Program =
    open FunScript.TypeScript

    // The TypeScript definition define the module methods as static, which create conflicts
    // with the require statement. To solve this, we create an extension for each requirement.
    type Node with
        [<FunScript.JSEmitInline("var http = require('http')")>]
        static member require_http(): unit = failwith "never"
        [<FunScript.JSEmitInline("var express = require('express')")>]
        static member require_express(): unit = failwith "never"

    let main() =
        Node.require_http()
        Node.require_express()
        let port = 8124

        let app = express.Globals.express()
        app.set("view engine", "mustache") |> ignore

        // Then, to use the module methods we need to open <module>.Globals
        http.Globals
            .createServer(System.Func<_,_,_>(fun req res ->
                res.writeHead 200.
                res._end "Hello World!"
            )).listen(port)

// Compile the program and copy the JS code to the parent directory
open System.IO
let dir = __SOURCE_DIRECTORY__
let code = FunScript.Compiler.compileWithoutReturn <@ Program.main() @>
File.WriteAllText(Path.Combine(dir, "../deploy/simplehttpserver.js"), code)
