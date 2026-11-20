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
type DemoRunnable =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable demoGameMidlet : DemoGameMidlet
    [<DefaultValue(false)>] val mutable startDemoGameMidletEvent : DemoGameMidletEvent
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoRunnable.jclinitDone then
            DemoRunnable.jclinitDone <- true
            DemoRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DemoRunnable() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (demoGameMidlet: DemoGameMidlet) as this =
        {  }
        then
            this.jfields_DemoRunnable()
            this.jctor1(demoGameMidlet)
    member this.jctor1(demoGameMidlet: DemoGameMidlet) : unit =
        this.demoGameMidlet <- demoGameMidlet
        this.startDemoGameMidletEvent <- (new DemoGameMidletEvent(this.demoGameMidlet, DemoGameMidletStateFactory.getInstance().START_DEMO))
        ()
    
    abstract run : unit -> unit
    default this.run() : unit =
        try
            this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().START_LABEL).append("GameCanvasRunnableInterface").ToString(), this, this.commonStrings.RUN)
            this.demoGameMidlet.commandAction(MyCommandsFactory.getInstance().SET_DISPLAYABLE, ProgressCanvasFactory.getInstance())
            this.demoGameMidlet.setGameCanvasRunnableInterface(this.demoGameMidlet.createDemoGameCanvasRunnableInterface())
            this.demoGameMidlet.demoSetup()
            DemoGameMidletEventHandler.getInstance().fireEvent(this.startDemoGameMidletEvent)
            this.demoGameMidlet.startGameCanvasRunnableInterface()
            this.demoGameMidlet.postDemoSetup()
            this.logUtil.putF(this.commonStrings.END_RUNNABLE, this, this.commonStrings.RUN)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.RUN, e)
            | _ -> reraise ()
    interface Runnable with
        member this.run() : unit = this.run()


