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
type TextNotificationUtil =
    [<DefaultValue(false)>] val mutable TWO : Integer
    [<DefaultValue(false)>] val mutable FALSE : Boolean
    [<DefaultValue(false)>] val mutable gameNotificationEventHandler : GameNotificationEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_instance : TextNotificationUtil
    static member instance with get() : TextNotificationUtil = (TextNotificationUtil.jclinit(); TextNotificationUtil.jcell_instance) and set (jvalue: TextNotificationUtil) = (TextNotificationUtil.jclinit(); TextNotificationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TextNotificationUtil.jclinitDone then
            TextNotificationUtil.jclinitDone <- true
            TextNotificationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        TextNotificationUtil.jcell_instance <- (new TextNotificationUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_TextNotificationUtil()
    member this.jfields_TextNotificationUtil() : unit =
        this.TWO <- SmallIntegerSingletonFactory.getInstance().getAt(2)
        this.FALSE <- BooleanFactory.getInstance().FALSE
        this.gameNotificationEventHandler <- GameNotificationEventHandler.getInstance()
        ()
    
    static member getInstance() : TextNotificationUtil =
        TextNotificationUtil.instance
    
    abstract fireError : message: string -> unit
    default this.fireError(message: string) : unit =
        ignore (PrimaryPlayerQueueFactory.getInstance().add(ErrorSound.getInstance()))
        this.fire(message)
    
    abstract fireNew : message: string -> unit
    default this.fireNew(message: string) : unit =
        ignore (PrimaryPlayerQueueFactory.getInstance().add(SelectSound.getInstance()))
        this.fire(message)
    
    abstract fireSuccess : message: string -> unit
    default this.fireSuccess(message: string) : unit =
        ignore (PrimaryPlayerQueueFactory.getInstance().add(SelectSound.getInstance()))
        this.fire(message)
    
    abstract fire : message: string -> unit
    default this.fire(message: string) : unit =
        let mutable gameNotificationEvent : GameNotificationEvent = (new GameNotificationEvent(this, message, this.TWO, BasicColorFactory.getInstance().RED, this.FALSE))
        this.gameNotificationEventHandler.fireEvent(gameNotificationEvent)


