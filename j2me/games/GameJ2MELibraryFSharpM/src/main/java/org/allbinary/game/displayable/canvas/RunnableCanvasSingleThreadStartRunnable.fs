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
type RunnableCanvasSingleThreadStartRunnable =
    inherit GameRunnable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable runnableCanvas : RunnableCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RunnableCanvasSingleThreadStartRunnable.jclinitDone then
            RunnableCanvasSingleThreadStartRunnable.jclinitDone <- true
            RunnableCanvasSingleThreadStartRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_RunnableCanvasSingleThreadStartRunnable() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (demoCanvas: RunnableCanvas) as this =
        { inherit GameRunnable() }
        then
            this.jfields_RunnableCanvasSingleThreadStartRunnable()
            this.jctor1(demoCanvas)
    member this.jctor1(demoCanvas: RunnableCanvas) : unit =
        this.runnableCanvas <- demoCanvas
        ()
    
    override this.run() : unit =
        try
            this.runnableCanvas.run()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.RUN, e)
            | _ -> reraise ()
    
    override this.processLoopSleep() : unit =
        this.runnableCanvas.processLoopSleep()


