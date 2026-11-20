namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ARectangleFilledAnimation =
    inherit RectangleFilledAnimation
    [<DefaultValue(false)>] val mutable x : int
    [<DefaultValue(false)>] val mutable y : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ARectangleFilledAnimation.jclinitDone then
            ARectangleFilledAnimation.jclinitDone <- true
            ARectangleFilledAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit RectangleFilledAnimation(0, 0, BasicColorFactory.getInstance().BLACK) }
    
    override this.nextFrame() : unit =
        ()
    
    override this.paintXY(graphics: Graphics, unusedX: int, unusedY: int) : unit =
        base.paintXY(graphics, this.x, this.y)


