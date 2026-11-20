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
type RunAtEndAnimationListener =
    [<DefaultValue(false)>] val mutable runnable : Runnable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RunAtEndAnimationListener.jclinitDone then
            RunAtEndAnimationListener.jclinitDone <- true
            RunAtEndAnimationListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (runnable: Runnable) as this =
        {  }
        then
            this.jctor1(runnable)
    member this.jctor1(runnable: Runnable) : unit =
        this.runnable <- runnable
        ()
    
    abstract onPlatformAnimationStart : unit -> unit
    default this.onPlatformAnimationStart() : unit =
        ()
    
    abstract onPlatformAnimationEnd : unit -> unit
    default this.onPlatformAnimationEnd() : unit =
        ()
    
    abstract onPlatformAnimationRepeat : unit -> unit
    default this.onPlatformAnimationRepeat() : unit =
        ()
    interface AnimationListenerInterface with
        member this.onPlatformAnimationStart() : unit = this.onPlatformAnimationStart()
        member this.onPlatformAnimationEnd() : unit = this.onPlatformAnimationEnd()
        member this.onPlatformAnimationRepeat() : unit = this.onPlatformAnimationRepeat()


