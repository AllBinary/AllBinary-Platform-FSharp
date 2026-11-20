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
type NoShakeAnimationListener =
    inherit ShakeAnimationListener
    [<DefaultValue(false)>] static val mutable private jcell_NO_SHAKE_ANIMATION_LISTENER : ShakeAnimationListener
    static member NO_SHAKE_ANIMATION_LISTENER with get() : ShakeAnimationListener = (NoShakeAnimationListener.jclinit(); NoShakeAnimationListener.jcell_NO_SHAKE_ANIMATION_LISTENER) and set (jvalue: ShakeAnimationListener) = (NoShakeAnimationListener.jclinit(); NoShakeAnimationListener.jcell_NO_SHAKE_ANIMATION_LISTENER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoShakeAnimationListener.jclinitDone then
            NoShakeAnimationListener.jclinitDone <- true
            NoShakeAnimationListener.jclinitBody()
    static member private jclinitBody() : unit =
        NoShakeAnimationListener.jcell_NO_SHAKE_ANIMATION_LISTENER <- (new NoShakeAnimationListener())
        ()
    new () =
        { inherit ShakeAnimationListener() }


