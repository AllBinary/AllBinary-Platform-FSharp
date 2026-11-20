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
type GameKeyEventHandler =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable pressGameKeyEventHandler : PressGameKeyEventHandler
    [<DefaultValue(false)>] val mutable upGameKeyEventHandler : UpGameKeyEventHandler
    [<DefaultValue(false)>] val mutable downGameKeyEventHandler : DownGameKeyEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameKeyEventHandler
    static member instance with get() : GameKeyEventHandler = (GameKeyEventHandler.jclinit(); GameKeyEventHandler.jcell_instance) and set (jvalue: GameKeyEventHandler) = (GameKeyEventHandler.jclinit(); GameKeyEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameKeyEventHandler.jclinitDone then
            GameKeyEventHandler.jclinitDone <- true
            GameKeyEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        GameKeyEventHandler.jcell_instance <- (new GameKeyEventHandler())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameKeyEventHandler()
    member this.jfields_GameKeyEventHandler() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.pressGameKeyEventHandler <- PressGameKeyEventHandler.getInstance()
        this.upGameKeyEventHandler <- UpGameKeyEventHandler.getInstance()
        this.downGameKeyEventHandler <- DownGameKeyEventHandler.getInstance()
        ()
    
    static member getInstance() : GameKeyEventHandler =
        GameKeyEventHandler.instance
    
    abstract removeAllListeners : unit -> unit
    default this.removeAllListeners() : unit =
        this.pressGameKeyEventHandler.removeAllListeners()
        this.upGameKeyEventHandler.removeAllListeners()
        this.downGameKeyEventHandler.removeAllListeners()
    
    abstract addListenerForPlayer : eventListenerInterface: EventListenerInterface * playerInputId: int -> unit
    default this.addListenerForPlayer(eventListenerInterface: EventListenerInterface, playerInputId: int) : unit =
        this.logUtil.putF(eventListenerInterface.ToString(), this, this.commonStrings.ADD_LISTENER)
        this.pressGameKeyEventHandler.addListenerSingleThreaded(eventListenerInterface)
        this.upGameKeyEventHandler.getInstanceForPlayer(playerInputId).addListenerSingleThreaded(eventListenerInterface)
        this.downGameKeyEventHandler.getInstanceForPlayer(playerInputId).addListenerSingleThreaded(eventListenerInterface)
    
    abstract addListener : eventListenerInterface: EventListenerInterface -> unit
    default this.addListener(eventListenerInterface: EventListenerInterface) : unit =
        this.logUtil.putF(eventListenerInterface.ToString(), this, this.commonStrings.ADD_LISTENER)
        this.pressGameKeyEventHandler.addListenerSingleThreaded(eventListenerInterface)
        this.upGameKeyEventHandler.addListenerSingleThreaded(eventListenerInterface)
        this.downGameKeyEventHandler.addListenerSingleThreaded(eventListenerInterface)
    
    abstract removeListener : eventListenerInterface: EventListenerInterface -> unit
    default this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        this.logUtil.putF(eventListenerInterface.ToString(), this, this.commonStrings.REMOVE_LISTENER)
        this.pressGameKeyEventHandler.removeListenerSingleThreaded(eventListenerInterface)
        this.upGameKeyEventHandler.removeListenerSingleThreaded(eventListenerInterface)
        this.downGameKeyEventHandler.removeListenerSingleThreaded(eventListenerInterface)


