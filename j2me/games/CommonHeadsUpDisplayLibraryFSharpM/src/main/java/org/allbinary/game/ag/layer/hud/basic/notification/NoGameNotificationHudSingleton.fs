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
type NoGameNotificationHudSingleton =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable gameNotificationHud : GameNotificationHud
    [<DefaultValue(false)>] static val mutable private jcell_instance : NoGameNotificationHudSingleton
    static member instance with get() : NoGameNotificationHudSingleton = (NoGameNotificationHudSingleton.jclinit(); NoGameNotificationHudSingleton.jcell_instance) and set (jvalue: NoGameNotificationHudSingleton) = (NoGameNotificationHudSingleton.jclinit(); NoGameNotificationHudSingleton.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoGameNotificationHudSingleton.jclinitDone then
            NoGameNotificationHudSingleton.jclinitDone <- true
            NoGameNotificationHudSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        NoGameNotificationHudSingleton.jcell_instance <- (new NoGameNotificationHudSingleton())
        ()
    member this.jfields_NoGameNotificationHudSingleton() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.gameNotificationHud <- GameNotificationHud.NULL_GAME_NOTIFICATION
        ()
    
    static member getInstance() : NoGameNotificationHudSingleton =
        NoGameNotificationHudSingleton.instance
    
    new () as this =
        {  }
        then
            this.jfields_NoGameNotificationHudSingleton()
            this.jctor1()
    member this.jctor1() : unit =
        try
            let mutable basicHudFactory : BasicHudFactory = BasicHudFactory.getInstance()
            this.gameNotificationHud <- (new NoGameGameNotificationHud())
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        ()
    
    abstract getGameNotificationHud : unit -> GameNotificationHud
    default this.getGameNotificationHud() : GameNotificationHud =
        this.gameNotificationHud


