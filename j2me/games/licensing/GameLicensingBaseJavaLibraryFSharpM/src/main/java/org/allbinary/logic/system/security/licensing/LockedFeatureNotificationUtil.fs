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
type LockedFeatureNotificationUtil =
    [<DefaultValue(false)>] val mutable gameNotificationEvent : GameNotificationEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : LockedFeatureNotificationUtil
    static member instance with get() : LockedFeatureNotificationUtil = (LockedFeatureNotificationUtil.jclinit(); LockedFeatureNotificationUtil.jcell_instance) and set (jvalue: LockedFeatureNotificationUtil) = (LockedFeatureNotificationUtil.jclinit(); LockedFeatureNotificationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LockedFeatureNotificationUtil.jclinitDone then
            LockedFeatureNotificationUtil.jclinitDone <- true
            LockedFeatureNotificationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        LockedFeatureNotificationUtil.jcell_instance <- (new LockedFeatureNotificationUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_LockedFeatureNotificationUtil()
    member this.jfields_LockedFeatureNotificationUtil() : unit =
        this.gameNotificationEvent <- (new GameNotificationEvent(this, LicenseStrings.getInstance().LOCKED, SmallIntegerSingletonFactory.getInstance().getAt(3), BasicColorFactory.getInstance().RED, BooleanFactory.getInstance().FALSE))
        ()
    
    static member getInstance() : LockedFeatureNotificationUtil =
        LockedFeatureNotificationUtil.instance
    
    abstract fire : unit -> unit
    default this.fire() : unit =
        ignore (PrimaryPlayerQueueFactory.getInstance().add(ErrorSound.getInstance()))
        GameNotificationEventHandler.getInstance().fireEvent(this.gameNotificationEvent)
    
    abstract fireWithColor : basicColor: BasicColor -> unit
    default this.fireWithColor(basicColor: BasicColor) : unit =
        ignore (PrimaryPlayerQueueFactory.getInstance().add(ErrorSound.getInstance()))
        this.gameNotificationEvent.setBasicColorP(basicColor)
        GameNotificationEventHandler.getInstance().fireEvent(this.gameNotificationEvent)


