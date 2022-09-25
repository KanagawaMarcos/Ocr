namespace Engine

open Tesseract

module Ocr =
    let score = 
        let path = __SOURCE_DIRECTORY__ + "/tessdata"
        let file = __SOURCE_DIRECTORY__ + "/img/original2.jpg"
        let engine = new TesseractEngine(path, "eng", EngineMode.Default)
        let img = Pix.LoadFromFile(file)
        let page = engine.Process(img)
        (page.GetText(), page.GetMeanConfidence())    
