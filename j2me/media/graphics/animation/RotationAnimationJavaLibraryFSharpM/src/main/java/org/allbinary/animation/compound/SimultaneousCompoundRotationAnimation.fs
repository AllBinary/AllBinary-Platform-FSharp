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
type SimultaneousCompoundRotationAnimation =
    inherit RotationAnimation
    [<DefaultValue(false)>] val mutable animationInterfaceArray : RotationAnimation[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimultaneousCompoundRotationAnimation.jclinitDone then
            SimultaneousCompoundRotationAnimation.jclinitDone <- true
            SimultaneousCompoundRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (animationInterfaceArray: RotationAnimation[], animationBehavior: AnimationBehavior) as this =
        { inherit RotationAnimation(AngleInfo.getInstance(AngleFactory.getInstance().QUARTER_TOTAL_ANGLE), CircularIndexUtil.createInstance(4), animationBehavior) }
        then
            this.jctor1(animationInterfaceArray, animationBehavior)
    member this.jctor1(animationInterfaceArray: RotationAnimation[], animationBehavior: AnimationBehavior) : unit =
        ()
        this.animationInterfaceArray <- animationInterfaceArray
        ()
    
    override this.setFrame(frameIndex: int) : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].setFrame(frameIndex)
    
    override this.getFrame() : int =
        this.animationInterfaceArray.[0].getFrame()
    
    override this.getAnimationSize() : int =
        this.animationInterfaceArray.[0].getAnimationSize()
    
    override this.getSize() : int =
        this.animationInterfaceArray.[0].getSize()
    
    override this.previousFrame() : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].previousFrame()
    
    override this.nextFrame() : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].nextFrame()
    
    override this.previousRotation() : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].previousRotation()
    
    override this.nextRotation() : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].nextRotation()
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].paintXY(graphics, x, y)
    
    override this.paintThreedXYZ(graphics: Graphics, x: int, y: int, z: int) : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].paintThreedXYZ(graphics, x, y, z)
    
    override this.setFrameByDirection(direction: Direction) : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].setFrameByDirection(direction)
    
    override this.setFrameToAngle(angle: Angle) : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].setFrameToAngle(angle)
    
    override this.adjustFrameToAngle(newAngle: Angle) : unit =
        this.adjustFrame(newAngle.getValue())
    
    override this.adjustFrame(angle: int16) : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].adjustFrame(angle)
    
    override this.getAngleInfoP() : AngleInfo =
        this.animationInterfaceArray.[0].getAngleInfoP()
    
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


