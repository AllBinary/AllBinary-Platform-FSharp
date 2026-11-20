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
type AutoCompoundRotationAnimation =
    inherit RotationAnimation
    [<DefaultValue(false)>] val mutable animationInterfaceArray : RotationAnimation[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AutoCompoundRotationAnimation.jclinitDone then
            AutoCompoundRotationAnimation.jclinitDone <- true
            AutoCompoundRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (animationInterfaceArray: RotationAnimation[], animationBehavior: AnimationBehavior) as this =
        { inherit RotationAnimation(AngleInfo.getInstance(AngleFactory.getInstance().QUARTER_TOTAL_ANGLE), CircularIndexUtil.createInstance(4), animationBehavior) }
        then
            this.jctor1(animationInterfaceArray, animationBehavior)
    member this.jctor1(animationInterfaceArray: RotationAnimation[], animationBehavior: AnimationBehavior) : unit =
        ()
        this.animationInterfaceArray <- animationInterfaceArray
        this.circularIndexUtil <- CircularIndexUtil.createInstance(this.animationInterfaceArray.Length)
        ()
    
    override this.setFrame(index: int) : unit =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].setFrame(index)
    
    override this.getFrame() : int =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].getFrame()
    
    override this.getAnimationSize() : int =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].getAnimationSize()
    
    override this.getSize() : int =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].getSize()
    
    override this.previousFrame() : unit =
        ignore (this.circularIndexUtil.previous())
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].previousFrame()
    
    override this.nextFrame() : unit =
        ignore (this.circularIndexUtil.next())
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].nextFrame()
    
    override this.previousRotation() : unit =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].previousRotation()
    
    override this.nextRotation() : unit =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].nextRotation()
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].paintXY(graphics, x, y)
    
    override this.paintThreedXYZ(graphics: Graphics, x: int, y: int, z: int) : unit =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].paintThreedXYZ(graphics, x, y, z)
    
    abstract getCurrentAnimation : unit -> IndexedAnimation
    default this.getCurrentAnimation() : IndexedAnimation =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()]
    
    abstract nextAnimation : unit -> unit
    default this.nextAnimation() : unit =
        let mutable frame : int = this.getFrame()
        ignore (this.circularIndexUtil.next())
        this.setFrame(frame)
    
    abstract previousAnimation : unit -> unit
    default this.previousAnimation() : unit =
        let mutable frame : int = this.getFrame()
        ignore (this.circularIndexUtil.previous())
        this.setFrame(frame)
    
    abstract setAnimation : index: int -> unit
    default this.setAnimation(index: int) : unit =
        let mutable frame : int = this.getFrame()
        this.circularIndexUtil.setIndex(index)
        this.setFrame(frame)
    
    override this.setFrameByDirection(direction: Direction) : unit =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].setFrameByDirection(direction)
    
    override this.setFrameToAngle(angle: Angle) : unit =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].setFrameToAngle(angle)
    
    override this.adjustFrameToAngle(newAngle: Angle) : unit =
        this.adjustFrame(newAngle.getValue())
    
    override this.adjustFrame(angle: int16) : unit =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].adjustFrame(angle)
    
    override this.getAngleInfoP() : AngleInfo =
        this.animationInterfaceArray.[this.circularIndexUtil.getIndex()].getAngleInfoP()
    
    abstract getAnimationInterfaceArray : unit -> RotationAnimation[]
    default this.getAnimationInterfaceArray() : RotationAnimation[] =
        this.animationInterfaceArray
    
    abstract setAnimationInterfaceArray : animationInterfaceArray: RotationAnimation[] -> unit
    default this.setAnimationInterfaceArray(animationInterfaceArray: RotationAnimation[]) : unit =
        this.animationInterfaceArray <- animationInterfaceArray
    
    override this.set(gl: GL) : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].set(gl)
    interface CompoundAnimationInterface with
        member this.nextAnimation() : unit = this.nextAnimation()
        member this.previousAnimation() : unit = this.previousAnimation()
        member this.setAnimation(jp0: int) : unit = this.setAnimation(jp0)
        member this.getCurrentAnimation() : IndexedAnimation = this.getCurrentAnimation()
    interface AnimationInterface with
        member this.nextFrame() : unit = this.nextFrame()
        member this.paintThreedXYZ(jp0: Graphics, jp1: int, jp2: int, jp3: int) : unit = this.paintThreedXYZ(jp0, jp1, jp2, jp3)
    interface LocationPaintableInterface with
        member this.paintXY(jp0: Graphics, jp1: int, jp2: int) : unit = this.paintXY(jp0, jp1, jp2)


