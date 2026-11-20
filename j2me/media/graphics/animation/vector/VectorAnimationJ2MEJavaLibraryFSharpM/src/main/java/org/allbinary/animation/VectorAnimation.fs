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
type VectorAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable currentPoints : int[][][]
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorAnimation.jclinitDone then
            VectorAnimation.jclinitDone <- true
            VectorAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_VectorAnimation() : unit =
        this.currentPoints <- NullUtil.getInstance().NULL_INT_ARRAY_ARRAY_ARRAY
        this.circularIndexUtil <- CircularIndexUtil.createInstance(0)
        ()
    
    static member createVectorAnimation(currentPoints2: int[][], basicColor: BasicColor, animationBehavior: AnimationBehavior) : VectorAnimation =
        let mutable currentPoints : int[][][] = (JR.newArray3<int>(1, currentPoints2.Length, 2))
        let mutable size : int = currentPoints2.Length
        let mutable index : int = 0
        while index < size do
            currentPoints.[0].[index].[0] <- currentPoints2.[index].[0]
            currentPoints.[0].[index].[1] <- currentPoints2.[index].[1]
            index <- index + 1
        (new VectorAnimation(currentPoints, basicColor, animationBehavior))
    
    new (currentPoints: int[][][], basicColor: BasicColor, animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jfields_VectorAnimation()
            this.jctor1(currentPoints, basicColor, animationBehavior)
    member this.jctor1(currentPoints: int[][][], basicColor: BasicColor, animationBehavior: AnimationBehavior) : unit =
        ()
        this.setPoints(currentPoints)
        this.setBasicColorP(basicColor)
        ()
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        let mutable changed : bool = false
        if ((JR.same(this.getBasicColorP(), null))) || (this.getBasicColorP().intValue() <> basicColor.intValue()) then
            changed <- true
        base.setBasicColorP(basicColor)
        if changed then
            this.updateModifiers()
    
    override this.changeBasicColor(basicColor: BasicColor) : unit =
        let mutable changed : bool = false
        if ((JR.same(this.getChangeBasicColor(), null))) || (this.getChangeBasicColor().intValue() <> basicColor.intValue()) then
            changed <- true
        base.changeBasicColor(basicColor)
        if changed then
            this.updateModifiers()
    
    override this.setAlpha(alpha: int) : unit =
        let mutable changed : bool = false
        if this.alphaP <> alpha then
            changed <- true
        base.setAlpha(alpha)
        if changed then
            this.updateModifiers()
    
    override this.setScale(scaleX: float32, scaleY: float32) : unit =
        ()
    
    override this.setMaxScale(maxScaleX: float32, maxScaleY: float32) : unit =
        ()
    
    member this.updateModifiers() : unit =
        ()
    
    override this.getAnimationSize() : int =
        this.getSize()
    
    override this.getSize() : int =
        this.currentPoints.Length
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.nextFrame() : unit =
        ignore (this.circularIndexUtil.next())
    
    override this.previousFrame() : unit =
        ignore (this.circularIndexUtil.previous())
    
    abstract paintVectors : graphics: Graphics * x: int * y: int -> unit
    default this.paintVectors(graphics: Graphics, x: int, y: int) : unit =
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
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.basicSetColorUtil.setBasicColorP(graphics, this.basicColor)
        this.paintVectors(graphics, x, y)
    
    override this.getFrame() : int =
        this.circularIndexUtil.getIndex()
    
    override this.setFrame(index: int) : unit =
        this.circularIndexUtil.setIndex(index)
    
    abstract getPoints : frame: int -> int[][]
    default this.getPoints(frame: int) : int[][] =
        this.currentPoints.[frame]
    
    abstract setPoints : currentPoints: int[][][] -> unit
    default this.setPoints(currentPoints: int[][][]) : unit =
        this.currentPoints <- currentPoints
        this.circularIndexUtil <- CircularIndexUtil.createInstance(currentPoints.Length)
    
    override this.getBasicColorP() : BasicColor =
        base.getBasicColorP()
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


