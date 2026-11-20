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
type ShakeAnimationListener =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ShakeAnimationListener.jclinitDone then
            ShakeAnimationListener.jclinitDone <- true
            ShakeAnimationListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract onSmallShakeEvent : unit -> unit
    default this.onSmallShakeEvent() : unit =
        ()
    
    abstract onMediumShakeEvent : unit -> unit
    default this.onMediumShakeEvent() : unit =
        ()
    
    abstract onLargeShakeEvent : unit -> unit
    default this.onLargeShakeEvent() : unit =
        ()
    
    abstract onShakeEvent : shakeEvent: ShakeEvent -> unit
    default this.onShakeEvent(shakeEvent: ShakeEvent) : unit =
        ()
    
    abstract getType : unit -> int
    default this.getType() : int =
        0


