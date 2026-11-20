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
type NullRotationAnimation2 =
    inherit NullRotationAnimation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullRotationAnimation2.jclinitDone then
            NullRotationAnimation2.jclinitDone <- true
            NullRotationAnimation2.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit NullRotationAnimation(AngleInfo.getInstance(AngleFactory.getInstance().QUARTER_TOTAL_ANGLE), CircularIndexUtil.createInstance(4), (new IndexedAnimationBehavior(1, 250L))) }
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        ()


