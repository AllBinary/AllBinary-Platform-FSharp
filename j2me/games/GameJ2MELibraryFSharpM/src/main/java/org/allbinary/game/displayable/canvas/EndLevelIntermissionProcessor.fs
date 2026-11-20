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
type EndLevelIntermissionProcessor =
    inherit Processor
    [<DefaultValue(false)>] val mutable gameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not EndLevelIntermissionProcessor.jclinitDone then
            EndLevelIntermissionProcessor.jclinitDone <- true
            EndLevelIntermissionProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (gameCanvas: AllBinaryGameCanvas) as this =
        { inherit Processor() }
        then
            this.jctor1(gameCanvas)
    member this.jctor1(gameCanvas: AllBinaryGameCanvas) : unit =
        this.gameCanvas <- gameCanvas
        ()
    
    override this.process_() : unit =
        this.gameCanvas.processEndLevelIntermissionGameState()


