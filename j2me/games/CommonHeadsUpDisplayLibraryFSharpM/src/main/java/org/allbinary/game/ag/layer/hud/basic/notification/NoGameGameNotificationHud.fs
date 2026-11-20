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
type NoGameGameNotificationHud =
    inherit GameNotificationHud
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoGameGameNotificationHud.jclinitDone then
            NoGameGameNotificationHud.jclinitDone <- true
            NoGameGameNotificationHud.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () as this =
        { inherit GameNotificationHud(BasicHudFactory.getInstance().TOPCENTER, BasicHudFactory.getInstance().HORIZONTAL, 2, BasicColorFactory.getInstance().RED) }
        then
            this.jctor1()
    member this.jctor1() : unit =
        ()
        this.updateMaxWidth <- 40
        this.updateMaxHeight <- 14
        ()


