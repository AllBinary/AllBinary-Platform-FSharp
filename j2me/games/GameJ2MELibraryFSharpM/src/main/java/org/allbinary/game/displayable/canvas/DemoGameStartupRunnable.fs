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
type DemoGameStartupRunnable =
    inherit ABRunnable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable demoCanvas : DemoCanvas
    static member TYPE : int = 4
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoGameStartupRunnable.jclinitDone then
            DemoGameStartupRunnable.jclinitDone <- true
            DemoGameStartupRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DemoGameStartupRunnable() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (demoCanvas: DemoCanvas) as this =
        { inherit ABRunnable() }
        then
            this.jfields_DemoGameStartupRunnable()
            this.jctor1(demoCanvas)
    member this.jctor1(demoCanvas: DemoCanvas) : unit =
        this.demoCanvas <- demoCanvas
        ()
    
    override this.run() : unit =
        try
            this.setRunning(true)
            this.demoCanvas.stopGameDemo()
            this.demoCanvas.create()
            this.demoCanvas.start()
            this.setRunning(false)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.setRunning(false)
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.RUN, e)
            | _ -> reraise ()
    
    override this.getType() : int =
        DemoGameStartupRunnable.TYPE


