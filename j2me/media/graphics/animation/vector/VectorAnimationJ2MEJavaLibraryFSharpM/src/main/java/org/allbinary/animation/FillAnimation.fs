namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type FillAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable pixelBuffer : int[]
    [<DefaultValue(false)>] val mutable width : int
    [<DefaultValue(false)>] val mutable height : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FillAnimation.jclinitDone then
            FillAnimation.jclinitDone <- true
            FillAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (pixelBuffer: int[], width: int, height: int, animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jctor1(pixelBuffer, width, height, animationBehavior)
    member this.jctor1(pixelBuffer: int[], width: int, height: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.width <- 100
        this.height <- 100
        this.pixelBuffer <- pixelBuffer
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
    
    abstract paint : g: Graphics -> unit
    default this.paint(g: Graphics) : unit =
        g.drawRGB(this.pixelBuffer, 0, this.width, 0, 0, this.width, this.height, true)


