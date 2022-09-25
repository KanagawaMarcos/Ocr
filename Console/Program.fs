// For more information see https://aka.ms/fsharp-console-apps
open Engine
open System

[<EntryPoint>]
let main args = 
    let (text, confidence) = Ocr.score

    printfn "Confidence: %.4f" confidence
    printfn "-----------------"
    printfn "%s" text

    0