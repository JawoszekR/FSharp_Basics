// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "%s" (BasicLib.BasicLibModule.convertToJson "Hello World from F#!")
    0 // return an integer exit code
