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
type GameFrameRunnable =
    inherit GameRunnable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable gameTickDisplayInfoSingleton : GameTickDisplayInfoSingleton
    [<DefaultValue(false)>] val mutable allBinaryGameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameFrameRunnable.jclinitDone then
            GameFrameRunnable.jclinitDone <- true
            GameFrameRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameFrameRunnable() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.gameTickDisplayInfoSingleton <- GameTickDisplayInfoSingleton.getInstance()
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        ()
    
    new (allBinaryGameCanvas: AllBinaryGameCanvas) as this =
        { inherit GameRunnable() }
        then
            this.jfields_GameFrameRunnable()
            this.jctor1(allBinaryGameCanvas)
    member this.jctor1(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        this.allBinaryGameCanvas <- allBinaryGameCanvas
        ()
    
    override this.run() : unit =
        try
            let mutable allBinaryGameCanvas : AllBinaryGameCanvas = this.allBinaryGameCanvas
            allBinaryGameCanvas.getLoopTimeHelperP().setStartTime(this.gameTickTimeDelayHelper.setStartTime())
            this.gameTickDisplayInfoSingleton.update()
            allBinaryGameCanvas.processGame()
            if (not (allBinaryGameCanvas.isRunning())) || allBinaryGameCanvas.isPaused() then
                allBinaryGameCanvas.notifyDonePainting()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.RUN, e)
            | _ -> reraise ()


