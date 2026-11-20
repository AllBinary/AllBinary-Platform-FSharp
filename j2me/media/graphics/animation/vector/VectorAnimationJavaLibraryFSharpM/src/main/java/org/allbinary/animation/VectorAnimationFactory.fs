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
type VectorAnimationFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorAnimationFactory.jclinitDone then
            VectorAnimationFactory.jclinitDone <- true
            VectorAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : points: int[][][] * basicColor: BasicColor -> VectorAnimation
    default this.getInstance(points: int[][][], basicColor: BasicColor) : VectorAnimation =
        (new VectorAnimation(points, basicColor, AnimationBehavior.getInstance()))
    interface VectorAnimationFactoryInterface with
        member this.getInstance(jp0: int[][][], jp1: BasicColor) : VectorAnimation = this.getInstance(jp0, jp1)


