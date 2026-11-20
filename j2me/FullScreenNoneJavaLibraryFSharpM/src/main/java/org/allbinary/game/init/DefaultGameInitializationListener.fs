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
type DefaultGameInitializationListener =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable swtJOGLProcessor : SWTJOGLProcessor
    [<DefaultValue(false)>] val mutable firstTime : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DefaultGameInitializationListener.jclinitDone then
            DefaultGameInitializationListener.jclinitDone <- true
            DefaultGameInitializationListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DefaultGameInitializationListener() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.swtJOGLProcessor <- SWTJOGLProcessor.getInstance()
        this.firstTime <- true
        ()
    
    new () as this =
        {  }
        then
            this.jfields_DefaultGameInitializationListener()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable gameInitializedEventHandler : GameInitializedEventHandler = GameInitializedEventHandler.getInstance()
        gameInitializedEventHandler.removeAllListeners()
        gameInitializedEventHandler.addListenerInterface((box (this) :?> GameInitializedListenerInterface))
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onGameInitialized : gameInitializedEvent: GameInitializedEvent -> unit
    default this.onGameInitialized(gameInitializedEvent: GameInitializedEvent) : unit =
        let mutable ON_GAME_INITIALIZED : string = "onGameInitialized"
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        try
            this.logUtil.putF(commonStrings.START, this, ON_GAME_INITIALIZED)
            while not (this.swtJOGLProcessor.isHolderCreated()) do
                this.logUtil.putF(commonStrings.UPDATE, this, ON_GAME_INITIALIZED)
                ignore (Thread.sleep(20))
            FeatureResourceInitializationUtil.getInstance().init(gameInitializedEvent.getLevel())
            if this.firstTime then
                this.firstTime <- false
            else
                this.swtJOGLProcessor.onSurfaceChanged()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(commonStrings.EXCEPTION, this, ON_GAME_INITIALIZED, e)
            | _ -> reraise ()
    interface GameInitializedListenerInterface with
        member this.onGameInitialized(jp0: GameInitializedEvent) : unit = this.onGameInitialized(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


