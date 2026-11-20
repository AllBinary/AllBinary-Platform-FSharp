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
type VectorBaseRotationAnimation =
    inherit RotationAnimation
    [<DefaultValue(false)>] val mutable currentPoints : int[][][]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorBaseRotationAnimation.jclinitDone then
            VectorBaseRotationAnimation.jclinitDone <- true
            VectorBaseRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_VectorBaseRotationAnimation() : unit =
        this.currentPoints <- NullUtil.getInstance().NULL_INT_ARRAY_ARRAY_ARRAY
        ()
    
    new (angleInfo: AngleInfo, currentPoints: int[][][], basicColor: BasicColor, animationBehavior: AnimationBehavior) as this =
        { inherit RotationAnimation(angleInfo, CircularIndexUtil.createInstance((360 / int (int (angleInfo.getAngleIncrementInfo().getAngleIncrement())))), animationBehavior) }
        then
            this.jfields_VectorBaseRotationAnimation()
            this.jctor1(angleInfo, currentPoints, basicColor, animationBehavior)
    member this.jctor1(angleInfo: AngleInfo, currentPoints: int[][][], basicColor: BasicColor, animationBehavior: AnimationBehavior) : unit =
        ()
        this.setPoints(currentPoints)
        this.setBasicColorP(basicColor)
        ()
    
    override this.getAnimationSize() : int =
        this.getSize()
    
    override this.getFrame() : int =
        this.circularIndexUtil.getIndex()
    
    override this.setFrame(index: int) : unit =
        this.circularIndexUtil.setIndex(index)
    
    override this.nextFrame() : unit =
        ignore (this.circularIndexUtil.next())
    
    override this.previousFrame() : unit =
        ignore (this.circularIndexUtil.previous())
    
    override this.getSize() : int =
        this.currentPoints.Length
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.basicSetColorUtil.setBasicColorP(graphics, this.basicColor)
        try
            let mutable nextPointX : int = 0
            let mutable nextPointY : int = 0
            let mutable nextPoint : int[] = null
            let mutable point : int[] = null
            let mutable currentPointsFrame : int[][] = this.currentPoints.[this.circularIndexUtil.getIndex()]
            let mutable size : int = currentPointsFrame.Length
            let mutable index : int = size - 2
            while ((index <- index - 1; index)) >= 0 do
                nextPoint <- currentPointsFrame.[index]
                point <- currentPointsFrame.[index + 1]
                nextPointX <- nextPoint.[0]
                nextPointY <- nextPoint.[1]
                if nextPointX <> 1000 then
                    graphics.drawLine((point.[0] + x), (point.[1] + y), (nextPointX + x), (nextPointY + y))
                else
                    index <- index - 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "paintVectors", e)
            | _ -> reraise ()
    
    abstract getPoints : frame: int -> int[][]
    default this.getPoints(frame: int) : int[][] =
        this.currentPoints.[frame]
    
    abstract setPoints : currentPoints: int[][][] -> unit
    default this.setPoints(currentPoints: int[][][]) : unit =
        this.currentPoints <- currentPoints
        this.circularIndexUtil <- CircularIndexUtil.createInstance(this.currentPoints.Length)
    
    override this.getBasicColorP() : BasicColor =
        base.getBasicColorP()
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        base.setBasicColorP(basicColor)
    interface VectorAnimationInterface with
        member this.getPoints(jp0: int) : int[][] = this.getPoints(jp0)
    interface IndexedAnimationInterface with
        member this.reset() : unit = this.reset()
        member this.setFrame(jp0: int) : unit = this.setFrame(jp0)
        member this.getFrame() : int = this.getFrame()
    interface ColorCompositeInterface with
        member this.getBasicColorP() : BasicColor = this.getBasicColorP()
    interface SequentialAnimationInterface with
        member this.getSize() : int = this.getSize()
        member this.previousFrame() : unit = this.previousFrame()
    interface BasicColorCompositeSetterInterface with
        member this.setBasicColorP(jp0: BasicColor) : unit = this.setBasicColorP(jp0)
    interface AnimationInterface with
        member this.nextFrame() : unit = this.nextFrame()
        member this.paintThreedXYZ(jp0: Graphics, jp1: int, jp2: int, jp3: int) : unit = this.paintThreedXYZ(jp0, jp1, jp2, jp3)
    interface SequenceInterface with
        member this.setSequence(jp0: int[]) : unit = this.setSequence(jp0)
        member this.getSequence() : int[] = this.getSequence()
    interface LocationPaintableInterface with
        member this.paintXY(jp0: Graphics, jp1: int, jp2: int) : unit = this.paintXY(jp0, jp1, jp2)


