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
type CreateGameRunnable =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable demoGameMidlet : DemoGameMidlet
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] val mutable startGameMidletEvent : DemoGameMidletEvent
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CreateGameRunnable.jclinitDone then
            CreateGameRunnable.jclinitDone <- true
            CreateGameRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CreateGameRunnable() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (demoGameMidlet: DemoGameMidlet, hashtable: ABHashtable) as this =
        {  }
        then
            this.jfields_CreateGameRunnable()
            this.jctor1(demoGameMidlet, hashtable)
    member this.jctor1(demoGameMidlet: DemoGameMidlet, hashtable: ABHashtable) : unit =
        this.demoGameMidlet <- demoGameMidlet
        this.hashtable <- hashtable
        this.startGameMidletEvent <- (new DemoGameMidletEvent(this, DemoGameMidletStateFactory.getInstance().START_GAME))
        ()
    
    abstract run : unit -> unit
    default this.run() : unit =
        try
            this.logUtil.putF(this.commonStrings.START_RUNNABLE, this, this.commonStrings.RUN)
            let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
            this.demoGameMidlet.commandAction(MyCommandsFactory.getInstance().SET_DISPLAYABLE, progressCanvas)
            this.demoGameMidlet.stopGameCanvasRunnableInterface()
            this.demoGameMidlet.setGameCanvasRunnableInterface(this.demoGameMidlet.createGameCanvasRunnableInterface())
            this.demoGameMidlet.getGameCanvasRunnableInterface().setLoadStateHashtable(this.hashtable)
            this.demoGameMidlet.startGameCanvasRunnableInterface()
            DemoGameMidletEventHandler.getInstance().fireEvent(this.startGameMidletEvent)
            this.logUtil.putF(this.commonStrings.END_RUNNABLE, this, this.commonStrings.RUN)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.RUN, e)
            | _ -> reraise ()
    interface Runnable with
        member this.run() : unit = this.run()


