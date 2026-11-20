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
type ImageArrayRotationAnimation =
    inherit ImageArrayBaseRotationAnimation
    [<DefaultValue(false)>] val mutable expectedTotalFrames : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageArrayRotationAnimation.jclinitDone then
            ImageArrayRotationAnimation.jclinitDone <- true
            ImageArrayRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createAnimation(anyType: obj, animationBehavior: AnimationBehavior) : ImageArrayRotationAnimation =
        let mutable imageRotationAnimationInfo : ImageArrayRotationAnimationInfo = (box (anyType) :?> ImageArrayRotationAnimationInfo)
        (new ImageArrayRotationAnimation(imageRotationAnimationInfo.getImageArray(), imageRotationAnimationInfo.getAngleInfoP(), imageRotationAnimationInfo.getTotalAngle(), animationBehavior))
    
    new (imageArray: Image[], angleInfo: AngleInfo, totalAngle: int, animationBehavior: AnimationBehavior) as this =
        { inherit ImageArrayBaseRotationAnimation(imageArray, angleInfo, animationBehavior) }
        then
            this.jctor1(imageArray, angleInfo, totalAngle, animationBehavior)
    member this.jctor1(imageArray: Image[], angleInfo: AngleInfo, totalAngle: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.initImageArray(imageArray, angleInfo, totalAngle)
        ()
    
    member this.initImageArray(imageArray: Image[], angleInfo: AngleInfo, totalAngle: int) : unit =
        this.expectedTotalFrames <- totalAngle / int (int (this.angleInfo.getAngleIncrementInfo().getAngleIncrement()))
        this.angleInfo.adjustAngle(0)
        if this.expectedTotalFrames <> this.getSize() then
            raise ((new JException("Wrong Number of Frames")))
    
    override this.setImageArray(imageArray: Image[]) : unit =
        base.setImageArray(imageArray)
        this.angleInfo.adjustAngle(0)


