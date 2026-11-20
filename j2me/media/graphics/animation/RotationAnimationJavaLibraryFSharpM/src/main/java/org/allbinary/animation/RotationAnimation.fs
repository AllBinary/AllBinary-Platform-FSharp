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
type RotationAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable frameUtil : FrameUtil
    [<DefaultValue(false)>] val mutable directionUtil : DirectionUtil
    [<DefaultValue(false)>] val mutable angleInfo : AngleInfo
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RotationAnimation.jclinitDone then
            RotationAnimation.jclinitDone <- true
            RotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_RotationAnimation() : unit =
        this.frameUtil <- FrameUtil.getInstance()
        this.directionUtil <- DirectionUtil.getInstance()
        ()
    
    new (angleInfo: AngleInfo, circularIndexUtil: CircularIndexUtil, animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jfields_RotationAnimation()
            this.jctor1(angleInfo, circularIndexUtil, animationBehavior)
    member this.jctor1(angleInfo: AngleInfo, circularIndexUtil: CircularIndexUtil, animationBehavior: AnimationBehavior) : unit =
        ()
        this.angleInfo <- angleInfo
        this.circularIndexUtil <- circularIndexUtil
        ()
    
    abstract nextRotationX : unit -> unit
    default this.nextRotationX() : unit =
        ()
    
    abstract previousRotationX : unit -> unit
    default this.previousRotationX() : unit =
        ()
    
    abstract nextRotation : unit -> unit
    default this.nextRotation() : unit =
        this.angleInfo.adjustAngle(this.circularIndexUtil.next())
    
    abstract previousRotation : unit -> unit
    default this.previousRotation() : unit =
        this.angleInfo.adjustAngle(this.circularIndexUtil.previous())
    
    abstract nextRotationZ : unit -> unit
    default this.nextRotationZ() : unit =
        ()
    
    abstract previousRotationZ : unit -> unit
    default this.previousRotationZ() : unit =
        ()
    
    override this.setFrame(index: int) : unit =
        this.circularIndexUtil.setIndex(index)
        let mutable newFrame : int = this.circularIndexUtil.getIndex()
        this.angleInfo.adjustAngle(newFrame)
    
    abstract setFrameByDirection : direction: Direction -> unit
    default this.setFrameByDirection(direction: Direction) : unit =
        let mutable angle : Angle = this.directionUtil.getFrameAngle(direction)
        this.adjustFrameToAngle(angle)
    
    abstract setFrameToAngle : angle: Angle -> unit
    default this.setFrameToAngle(angle: Angle) : unit =
        this.adjustFrameToAngle(angle)
    
    abstract adjustFrameToAngle : angle: Angle -> unit
    default this.adjustFrameToAngle(angle: Angle) : unit =
        this.adjustFrame(angle.getValue())
    
    abstract adjustFrame : angle: int16 -> unit
    default this.adjustFrame(angle: int16) : unit =
        this.setFrame(this.frameUtil.getFrameForAngle(angle, int (this.angleInfo.getAngleIncrementInfo().getAngleIncrement())))
    
    override this.getFrame() : int =
        this.circularIndexUtil.getIndex()
    
    override this.getSize() : int =
        this.circularIndexUtil.getSize()
    
    abstract getAngleInfoP : unit -> AngleInfo
    default this.getAngleInfoP() : AngleInfo =
        this.angleInfo
    
    override this.ToString() : string =
        (new StringMaker()).append(base.ToString()).append("circularIndexUtil: ").append(this.circularIndexUtil.ToString()).append("angleInfo: ").append(this.angleInfo.ToString()).ToString()
    interface RotationAnimationInterface with
        member this.getAngleInfoP() : AngleInfo = this.getAngleInfoP()
        member this.nextRotation() : unit = this.nextRotation()
        member this.previousRotation() : unit = this.previousRotation()
    interface IndexedAnimationInterface with
        member this.reset() : unit = this.reset()
        member this.setFrame(jp0: int) : unit = this.setFrame(jp0)
        member this.getFrame() : int = this.getFrame()
    interface DirectionalInterface with
        member this.setFrameByDirection(jp0: Direction) : unit = this.setFrameByDirection(jp0)
        member this.setFrameToAngle(jp0: Angle) : unit = this.setFrameToAngle(jp0)
        member this.adjustFrameToAngle(jp0: Angle) : unit = this.adjustFrameToAngle(jp0)
        member this.adjustFrame(jp0: int16) : unit = this.adjustFrame(jp0)
    interface SequentialAnimationInterface with
        member this.getSize() : int = this.getSize()
        member this.previousFrame() : unit = this.previousFrame()
    interface AnimationInterface with
        member this.nextFrame() : unit = this.nextFrame()
        member this.paintThreedXYZ(jp0: Graphics, jp1: int, jp2: int, jp3: int) : unit = this.paintThreedXYZ(jp0, jp1, jp2, jp3)
    interface SequenceInterface with
        member this.setSequence(jp0: int[]) : unit = this.setSequence(jp0)
        member this.getSequence() : int[] = this.getSequence()
    interface LocationPaintableInterface with
        member this.paintXY(jp0: Graphics, jp1: int, jp2: int) : unit = this.paintXY(jp0, jp1, jp2)


