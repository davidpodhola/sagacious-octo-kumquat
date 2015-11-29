﻿// Run as console app or fsx
open Suave.Http
open Suave.Types
open Suave.Http.Successful
open Suave.Http.Writers
open Suave.Http.Applicatives
open Suave.Web

let setCORSHeaders = 
    setHeader  "Access-Control-Allow-Origin" "*" 
    >>= setHeader "Access-Control-Allow-Headers" "content-type"

let allow_cors : WebPart =
    choose [
        OPTIONS >>= 
            fun context -> 
                context |> (
                    setCORSHeaders
                    >>= OK "CORS approved" )
    ]

let webSite =
    choose [
        allow_cors
        GET >>= OK "URLs are for wimps. GETting something? This is what you get."
    ]

startWebServer defaultConfig webSite

(*
=== A fiddler scratchpad to test

OPTIONS http://localhost:8083/ HTTP/1.1
User-Agent: Fiddler
Origin: http://www.example-social-network.com
Host: localhost:8083
*)
// See the 'F# Tutorial' project for more help.
