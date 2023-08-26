namespace Engine
open System.IO
open Tesseract

module Ocr =
    let score = 
        let path = __SOURCE_DIRECTORY__ + "/tessdata"
        let file = __SOURCE_DIRECTORY__ + "/img/original.jpg"
        let output = __SOURCE_DIRECTORY__ + "/output.txt"
        let engine = new TesseractEngine(path, "eng", EngineMode.Default)
        let img = Pix.LoadFromFile(file)
        let page = engine.Process(img)
        File.WriteAllText(output, page.GetText()) |> ignore

        (page.GetText(), page.GetMeanConfidence())    
