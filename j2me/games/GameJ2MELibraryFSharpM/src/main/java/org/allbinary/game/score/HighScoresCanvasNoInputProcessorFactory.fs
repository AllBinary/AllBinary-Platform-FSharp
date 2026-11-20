namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type HighScoresCanvasNoInputProcessorFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoresCanvasNoInputProcessorFactory.jclinitDone then
            HighScoresCanvasNoInputProcessorFactory.jclinitDone <- true
            HighScoresCanvasNoInputProcessorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : highScoresCanvas: HighScoresCanvas -> HighScoresCanvasInputProcessor
    default this.getInstance(highScoresCanvas: HighScoresCanvas) : HighScoresCanvasInputProcessor =
        (new HighScoresCanvasInputProcessor(highScoresCanvas))
    interface HighScoresCanvasInputProcessorFactoryInterface with
        member this.getInstance(jp0: HighScoresCanvas) : HighScoresCanvasInputProcessor = this.getInstance(jp0)


