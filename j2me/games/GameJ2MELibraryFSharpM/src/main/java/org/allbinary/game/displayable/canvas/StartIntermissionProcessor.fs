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
type StartIntermissionProcessor =
    inherit Processor
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable gameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] val mutable WAIT : int64
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StartIntermissionProcessor.jclinitDone then
            StartIntermissionProcessor.jclinitDone <- true
            StartIntermissionProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_StartIntermissionProcessor() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.WAIT <- 5000L
        ()
    
    new (gameCanvas: AllBinaryGameCanvas) as this =
        { inherit Processor() }
        then
            this.jfields_StartIntermissionProcessor()
            this.jctor1(gameCanvas)
    member this.jctor1(gameCanvas: AllBinaryGameCanvas) : unit =
        this.gameCanvas <- gameCanvas
        ()
    
    override this.process_() : unit =
        if this.gameCanvas.getStartIntermissionInterface().getTimeDelayHelper().isElapsedTNT(this.WAIT) then
            this.logUtil.putF("Intermission End", this, this.commonStrings.PROCESS)
            this.gameCanvas.getStartIntermissionInterface().setEnabled(false)


