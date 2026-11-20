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
type GameNotificationHud =
    inherit BasicHud
    [<DefaultValue(false)>] val mutable METHOD_NAME : string
    [<DefaultValue(false)>] val mutable lastGameNotificationEvent : GameNotificationEvent
    [<DefaultValue(false)>] static val mutable private jcell_NULL_GAME_NOTIFICATION : GameNotificationHud
    static member NULL_GAME_NOTIFICATION with get() : GameNotificationHud = (GameNotificationHud.jclinit(); GameNotificationHud.jcell_NULL_GAME_NOTIFICATION) and set (jvalue: GameNotificationHud) = (GameNotificationHud.jclinit(); GameNotificationHud.jcell_NULL_GAME_NOTIFICATION <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameNotificationHud.jclinitDone then
            GameNotificationHud.jclinitDone <- true
            GameNotificationHud.jclinitBody()
    static member private jclinitBody() : unit =
        GameNotificationHud.jcell_NULL_GAME_NOTIFICATION <- (new GameNotificationHud(BasicHudFactory.getInstance().TOPCENTER, BasicHudFactory.getInstance().HORIZONTAL, 0, BasicColorFactory.getInstance().RED))
        ()
    member this.jfields_GameNotificationHud() : unit =
        this.METHOD_NAME <- "onGameNotificationEvent"
        this.lastGameNotificationEvent <- GameNotification.NULL_GAME_NOTIFICATION_EVENT
        ()
    
    new (location: int, direction: int, bufferZone: int, basicColor: BasicColor) as this =
        { inherit BasicHud(location, direction, bufferZone, basicColor) }
        then
            this.jfields_GameNotificationHud()
    
    override this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onGameNotificationEvent : gameNotificationEvent: GameNotificationEvent -> unit
    default this.onGameNotificationEvent(gameNotificationEvent: GameNotificationEvent) : unit =
        if not (JR.same(this.lastGameNotificationEvent, gameNotificationEvent)) then
            this.lastGameNotificationEvent <- gameNotificationEvent
            this.logUtil.putF(gameNotificationEvent.getString(), this, this.METHOD_NAME)
        this.add(gameNotificationEvent.getString(), gameNotificationEvent.getSeconds(), gameNotificationEvent.getBasicColorP(), gameNotificationEvent.getPermanent())
    
    abstract add : string_: string * seconds: Integer * basicColor: BasicColor * permanent: Boolean -> unit
    default this.add(string_: string, seconds: Integer, basicColor: BasicColor, permanent: Boolean) : unit =
        ()
    
    abstract processTick : unit -> unit
    default this.processTick() : unit =
        ()
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        ()
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        ()
    interface GameNotificationListenerInterface with
        member this.onGameNotificationEvent(jp0: GameNotificationEvent) : unit = this.onGameNotificationEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


