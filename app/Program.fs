﻿open System
open HelloWorldLibrary

// "let" is a keyword for declaring an immutable value
let x: int = 5
let y = 10

// Explicit list of items
let items = [2;3;4;5]

// Push an item to the front of list
let allItems = 1 :: items

// Explicit type on the input parameter and return type
let squareExplicit (x: int): int = x * x

// Implicit type inference on input and output types
let squareImplicit x = x * x

[<EntryPoint>]
let main argv =
    printfn "%s" <| convertToJson "Hello"
    printfn "Square of %d is %d" <| x <| squareImplicit x
    0 // return an integer exit code