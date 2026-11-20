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
type GameNotificationEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable enabled : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameNotificationEventHandler
    static member instance with get() : GameNotificationEventHandler = (GameNotificationEventHandler.jclinit(); GameNotificationEventHandler.jcell_instance) and set (jvalue: GameNotificationEventHandler) = (GameNotificationEventHandler.jclinit(); GameNotificationEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameNotificationEventHandler.jclinitDone then
            GameNotificationEventHandler.jclinitDone <- true
            GameNotificationEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        GameNotificationEventHandler.jcell_instance <- (new GameNotificationEventHandler())
        ()
    member this.jfields_GameNotificationEventHandler() : unit =
        this.enabled <- true
        ()
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_GameNotificationEventHandler()
    
    override this.removeAllListeners() : unit =
        let mutable eventListenerInterface : EventListenerInterface = NullEventListener.NULL_EVENT_LISTENER
        let mutable list_ : BasicArrayList = this.eventListenerInterfaceList
        if list_.size() > 0 then
            eventListenerInterface <- (box (list_.objectArray.[0]) :?> EventListenerInterface)
        base.removeAllListeners()
        if not (JR.same(eventListenerInterface, NullEventListener.NULL_EVENT_LISTENER)) then
            this.addListenerInterface(eventListenerInterface)
    
    static member getInstance() : GameNotificationEventHandler =
        GameNotificationEventHandler.instance
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable jflow = 0
        if not (this.enabled) then
            jflow <- 1
        if jflow = 0 then
            let mutable gameNotificationListenerInterface : GameNotificationListenerInterface = (box (eventListenerInterface) :?> GameNotificationListenerInterface)
            gameNotificationListenerInterface.onGameNotificationEvent((box (eventObject) :?> GameNotificationEvent))


