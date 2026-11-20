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
type GameNotification =
    [<DefaultValue(false)>] val mutable stringList : BasicArrayList
    [<DefaultValue(false)>] val mutable timeList : BasicArrayList
    [<DefaultValue(false)>] val mutable colorList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_NULL_GAME_NOTIFICATION_EVENT : GameNotificationEvent
    static member NULL_GAME_NOTIFICATION_EVENT with get() : GameNotificationEvent = (GameNotification.jclinit(); GameNotification.jcell_NULL_GAME_NOTIFICATION_EVENT) and set (jvalue: GameNotificationEvent) = (GameNotification.jclinit(); GameNotification.jcell_NULL_GAME_NOTIFICATION_EVENT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameNotification.jclinitDone then
            GameNotification.jclinitDone <- true
            GameNotification.jclinitBody()
    static member private jclinitBody() : unit =
        GameNotification.jcell_NULL_GAME_NOTIFICATION_EVENT <- (new GameNotificationEvent(NullUtil.getInstance().NULL_OBJECT, StringUtil.getInstance().EMPTY_STRING, (new Integer(0)), BasicColorFactory.getInstance().RED, BooleanFactory.getInstance().FALSE))
        ()
    new () as this =
        {  }
        then
            this.jfields_GameNotification()
    member this.jfields_GameNotification() : unit =
        this.stringList <- (new BasicArrayListD())
        this.timeList <- (new BasicArrayListD())
        this.colorList <- (new BasicArrayListD())
        ()
    
    abstract add : string_: string * seconds: Integer * basicColor: BasicColor -> unit
    default this.add(string_: string, seconds: Integer, basicColor: BasicColor) : unit =
        if not (this.stringList.contains(string_)) then
            ignore (this.stringList.add(string_))
            ignore (this.timeList.add(seconds))
            ignore (this.colorList.add(basicColor))
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.stringList.clear()
        this.timeList.clear()
        this.colorList.clear()
    
    abstract getSize : unit -> int
    default this.getSize() : int =
        this.stringList.size()


