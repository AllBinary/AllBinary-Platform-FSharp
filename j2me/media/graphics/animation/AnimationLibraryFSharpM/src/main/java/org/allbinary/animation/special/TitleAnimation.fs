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
type TitleAnimation =
    inherit SpecialAnimation
    [<DefaultValue(false)>] val mutable systemWrapper : ABSystemWrapper
    [<DefaultValue(false)>] val mutable deltaX : float32
    [<DefaultValue(false)>] val mutable deltaY : float32
    [<DefaultValue(false)>] val mutable deltaZ : float32
    [<DefaultValue(false)>] val mutable basicColorArray : BasicColor[]
    [<DefaultValue(false)>] val mutable dxArray : int[]
    [<DefaultValue(false)>] val mutable dyArray : int[]
    [<DefaultValue(false)>] val mutable widthP : int
    [<DefaultValue(false)>] val mutable animationInterfaceArray : IndexedAnimation[]
    [<DefaultValue(false)>] val mutable sizeP : int
    [<DefaultValue(false)>] val mutable y : int
    [<DefaultValue(false)>] val mutable lastFrameStartTime : int64
    [<DefaultValue(false)>] val mutable displayInfoSingleton : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable CLEAR_COLOR : BasicColor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TitleAnimation.jclinitDone then
            TitleAnimation.jclinitDone <- true
            TitleAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TitleAnimation() : unit =
        this.systemWrapper <- ABSystemWrapper.getInstance()
        this.displayInfoSingleton <- DisplayInfoSingleton.getInstance()
        this.CLEAR_COLOR <- BasicColorFactory.getInstance().CLEAR_COLOR
        ()
    
    static member createAnimation(animationInterfaceArray: IndexedAnimation[], basicColorArray: BasicColor[], dxArray: int[], dyArray: int[], y: int, width: int) : TitleAnimation =
        (new TitleAnimation(animationInterfaceArray, basicColorArray, dxArray, dyArray, y, width, (new IndexedAnimationBehavior(1, 250L))))
    
    new (animationInterfaceArray: IndexedAnimation[], basicColorArray: BasicColor[], dxArray: int[], dyArray: int[], y: int, width: int, animationBehavior: AnimationBehavior) as this =
        { inherit SpecialAnimation(animationBehavior) }
        then
            this.jfields_TitleAnimation()
            this.jctor1(animationInterfaceArray, basicColorArray, dxArray, dyArray, y, width, animationBehavior)
    member this.jctor1(animationInterfaceArray: IndexedAnimation[], basicColorArray: BasicColor[], dxArray: int[], dyArray: int[], y: int, width: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.lastFrameStartTime <- this.systemWrapper.currentTimeMillis()
        this.animationInterfaceArray <- animationInterfaceArray
        this.sizeP <- this.animationInterfaceArray.Length
        this.basicColorArray <- basicColorArray
        this.dxArray <- dxArray
        this.dyArray <- dyArray
        this.y <- y
        this.widthP <- width
        this.reset()
        ()
    
    override this.nextFrame() : unit =
        let mutable currentTime : int64 = this.systemWrapper.currentTimeMillis()
        let mutable totalTimeElapsed : int64 = currentTime - this.lastFrameStartTime
        let mutable indexedAnimationBehavior : IndexedAnimationBehavior = (box (this.getAnimationBehavior()) :?> IndexedAnimationBehavior)
        if totalTimeElapsed > indexedAnimationBehavior.frameDelayTime then
            this.previousFrame()
            this.lastFrameStartTime <- currentTime
        if this.animationInterfaceArray.[0].getFrame() = 0 then
            indexedAnimationBehavior.loopIndex <- indexedAnimationBehavior.loopIndex + 1
    
    override this.isComplete() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable indexedAnimationBehavior : IndexedAnimationBehavior = (box (this.getAnimationBehavior()) :?> IndexedAnimationBehavior)
        if ((indexedAnimationBehavior.loopTotal = (-1)) || (indexedAnimationBehavior.loopIndex < indexedAnimationBehavior.loopTotal)) || (this.getFrame() <> 0) then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.getSize() : int =
        this.animationInterfaceArray.[0].getSize()
    
    override this.getFrame() : int =
        this.animationInterfaceArray.[0].getFrame()
    
    override this.setFrame(frame: int) : unit =
        let mutable index : int = 0
        while index < this.sizeP do
            this.animationInterfaceArray.[index].setFrame(frame)
            index <- index + 1
    
    override this.setLastFrame() : unit =
        this.setFrame((this.getSize() - 1))
    
    override this.reset() : unit =
        this.setLastFrame()
        let mutable indexedAnimationBehavior : IndexedAnimationBehavior = ((box (this.getAnimationBehavior()) :?> IndexedAnimationBehavior))
        indexedAnimationBehavior.reset()
    
    override this.previousFrame() : unit =
        let mutable index : int = 0
        while index < this.sizeP do
            this.animationInterfaceArray.[index].previousFrame()
            index <- index + 1
    
    abstract paintFrameXY : graphics: Graphics * frame: int * x: int * y: int -> unit
    default this.paintFrameXY(graphics: Graphics, frame: int, x: int, y: int) : unit =
        this.setFrame(frame)
        this.paintXY(graphics, x, y)
    
    override this.paintXY(graphics: Graphics, ax: int, ay: int) : unit =
        let mutable x : int = 0
        if this.widthP <> Integer.MIN_VALUE then
            x <- ((this.displayInfoSingleton.getLastWidth() - this.widthP) / 2)
        let mutable deltaX : int = 0
        let mutable deltaY : int = 0
        let mutable index : int = 0
        while index < this.sizeP do
            deltaX <- this.dxArray.[index] + x
            deltaY <- this.dyArray.[index] + this.y
            if not (JR.same(this.basicColorArray.[index], this.CLEAR_COLOR)) then
                this.basicSetColorUtil.setBasicColorP(graphics, this.basicColorArray.[index])
            this.animationInterfaceArray.[index].paintXY(graphics, deltaX, deltaY)
            index <- index + 1


