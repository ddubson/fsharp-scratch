open System
open HelloWorldLibrary

[<EntryPoint>]
let main argv =
    printfn "%s" (convertToJson "Hello")
    0 // return an integer exit code
