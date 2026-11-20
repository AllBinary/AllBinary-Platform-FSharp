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
type VectorRotationAnimation =
    inherit VectorBaseRotationAnimation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorRotationAnimation.jclinitDone then
            VectorRotationAnimation.jclinitDone <- true
            VectorRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (currentPoints: int[][][], basicColor: BasicColor, animationBehavior: AnimationBehavior) as this =
        { inherit VectorBaseRotationAnimation(AngleInfo.getInstance(int16 ((int (int (AngleFactory.getInstance().TOTAL_ANGLE)) / currentPoints.Length))), currentPoints, basicColor, animationBehavior) }
        then
            this.jctor1(currentPoints, basicColor, animationBehavior)
    member this.jctor1(currentPoints: int[][][], basicColor: BasicColor, animationBehavior: AnimationBehavior) : unit =
        ()
        this.angleInfo.adjustAngle(this.getFrame())
        ()
    
    override this.setFrameByDirection(direction: Direction) : unit =
        let mutable angle : Angle = this.directionUtil.getFrameAngle(direction)
        this.adjustFrameToAngle(angle)
    
    override this.setFrameToAngle(angle: Angle) : unit =
        this.adjustFrameToAngle(angle)
    
    override this.setFrame(index: int) : unit =
        base.setFrame(index)
        this.angleInfo.adjustAngle(this.getFrame())
    
    override this.adjustFrame(newAngle: int16) : unit =
        this.setFrame(this.frameUtil.getFrameForAngle(newAngle, int (this.angleInfo.getAngleIncrementInfo().getAngleIncrement())))
    
    override this.adjustFrameToAngle(newAngle: Angle) : unit =
        this.adjustFrame(newAngle.getValue())


