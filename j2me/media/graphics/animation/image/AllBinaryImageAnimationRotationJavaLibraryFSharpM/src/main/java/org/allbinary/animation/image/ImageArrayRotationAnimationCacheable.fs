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
type ImageArrayRotationAnimationCacheable =
    inherit AdjustedImageArrayRotationAnimation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageArrayRotationAnimationCacheable.jclinitDone then
            ImageArrayRotationAnimationCacheable.jclinitDone <- true
            ImageArrayRotationAnimationCacheable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (anyType: obj, animationBehavior: AnimationBehavior) =
        { inherit AdjustedImageArrayRotationAnimation(((box (anyType) :?> ImageArrayRotationAnimationInfo)).getImageArray(), ((box (anyType) :?> ImageArrayRotationAnimationInfo)).getAngleInfoP(), ((box (anyType) :?> ImageArrayRotationAnimationInfo)).getTotalAngle(), ((box (anyType) :?> ImageArrayRotationAnimationInfo)).getDx(), ((box (anyType) :?> ImageArrayRotationAnimationInfo)).getDy(), animationBehavior) }
    
    abstract getKey : unit -> obj
    default this.getKey() : obj =
        NullUtil.getInstance().NULL_OBJECT
    
    override this.ToString() : string =
        StringUtil.getInstance().EMPTY_STRING
    interface CacheableInterface with
        member this.getKey() : obj = this.getKey()


