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
type AdjustedImageArrayRotationAnimation =
    inherit ImageArrayRotationAnimation
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AdjustedImageArrayRotationAnimation.jclinitDone then
            AdjustedImageArrayRotationAnimation.jclinitDone <- true
            AdjustedImageArrayRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createAdjustedImageArrayRotationAnimationInfo(anyType: obj, animationBehavior: AnimationBehavior) : AdjustedImageArrayRotationAnimation =
        let mutable imageRotationAnimationInfo : ImageArrayRotationAnimationInfo = (box (anyType) :?> ImageArrayRotationAnimationInfo)
        (new AdjustedImageArrayRotationAnimation(imageRotationAnimationInfo.getImageArray(), imageRotationAnimationInfo.getAngleInfoP(), imageRotationAnimationInfo.getTotalAngle(), imageRotationAnimationInfo.getDx(), imageRotationAnimationInfo.getDy(), animationBehavior))
    
    static member createAnimation(imageArray: Image[], angleInfo: AngleInfo, totalAngle: int, animationBehavior: AnimationBehavior) : AdjustedImageArrayRotationAnimation =
        (new AdjustedImageArrayRotationAnimation(imageArray, angleInfo, totalAngle, -((imageArray.[0].getWidth() >>> 2)), -((imageArray.[0].getHeight() >>> 2)), animationBehavior))
    
    new (imageArray: Image[], angleInfo: AngleInfo, totalAngle: int, dx: int, dy: int, animationBehavior: AnimationBehavior) as this =
        { inherit ImageArrayRotationAnimation(imageArray, angleInfo, totalAngle, animationBehavior) }
        then
            this.jctor1(imageArray, angleInfo, totalAngle, dx, dy, animationBehavior)
    member this.jctor1(imageArray: Image[], angleInfo: AngleInfo, totalAngle: int, dx: int, dy: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.init(dx, dy)
        ()
    
    abstract init : dx: int * dy: int -> unit
    default this.init(dx: int, dy: int) : unit =
        this.setDx(dx)
        this.setDy(dy)
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        base.paintXY(graphics, (x + this.dx), (y + this.dy))
    
    override this.setDx(dx: int) : unit =
        this.dx <- dx
    
    override this.getDx() : int =
        this.dx
    
    override this.setDy(dy: int) : unit =
        this.dy <- dy
    
    override this.getDy() : int =
        this.dy


