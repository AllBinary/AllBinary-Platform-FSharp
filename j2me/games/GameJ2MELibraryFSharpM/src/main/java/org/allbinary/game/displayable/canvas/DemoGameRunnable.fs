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
type DemoGameRunnable =
    inherit GameRunnable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable demoCanvas : DemoCanvas
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoGameRunnable.jclinitDone then
            DemoGameRunnable.jclinitDone <- true
            DemoGameRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DemoGameRunnable() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        ()
    
    new (demoCanvas: DemoCanvas) as this =
        { inherit GameRunnable() }
        then
            this.jfields_DemoGameRunnable()
            this.jctor1(demoCanvas)
    member this.jctor1(demoCanvas: DemoCanvas) : unit =
        this.demoCanvas <- demoCanvas
        ()
    
    override this.run() : unit =
        try
            this.demoCanvas.getLoopTimeHelperP().setStartTime(this.gameTickTimeDelayHelper.setStartTime())
            this.demoCanvas.processGame()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.RUN, e)
            | _ -> reraise ()
    
    override this.processLoopSleep() : unit =
        this.demoCanvas.processLoopSleep()


