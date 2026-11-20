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
type TweenedImageAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable image : Image
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] val mutable totalFrames : int
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TweenedImageAnimation.jclinitDone then
            TweenedImageAnimation.jclinitDone <- true
            TweenedImageAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TweenedImageAnimation() : unit =
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (image: Image, dx: int, dy: int, totalFrames: int, animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jfields_TweenedImageAnimation()
            this.jctor1(image, dx, dy, totalFrames, animationBehavior)
    member this.jctor1(image: Image, dx: int, dy: int, totalFrames: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.image <- image
        this.dx <- dx
        this.dy <- dy
        this.totalFrames <- totalFrames
        this.circularIndexUtil <- CircularIndexUtil.createInstance(this.totalFrames)
        ()
    
    override this.getAnimationSize() : int =
        this.getSize()
    
    override this.nextFrame() : unit =
        ignore (this.circularIndexUtil.next())
    
    override this.previousFrame() : unit =
        ignore (this.circularIndexUtil.previous())
    
    override this.setFrame(index: int) : unit =
        this.circularIndexUtil.setIndex(index)
    
    override this.getFrame() : int =
        this.circularIndexUtil.getIndex()
    
    override this.getSize() : int =
        this.totalFrames
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        let mutable frame : int = this.getFrame()
        let mutable currentX : int = this.dx * frame
        let mutable currentY : int = this.dy * frame
        graphics.drawImage(this.image, (x + currentX), (y + currentY), this.anchor)
    
    abstract close : unit -> unit
    default this.close() : unit =
        DisposalUtil.getInstance().disposeImage(this.image)
    
    abstract finalize : unit -> unit
    default this.finalize() : unit =
        DisposalUtil.getInstance().disposeImage(this.image)


