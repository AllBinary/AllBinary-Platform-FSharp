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
type ImageAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable image : Image
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageAnimation.jclinitDone then
            ImageAnimation.jclinitDone <- true
            ImageAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImageAnimation() : unit =
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (image: Image, animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jfields_ImageAnimation()
            this.jctor1(image, animationBehavior)
    member this.jctor1(image: Image, animationBehavior: AnimationBehavior) : unit =
        ()
        this.image <- image
        ()
    
    override this.getAnimationSize() : int =
        this.getSize()
    
    override this.nextFrame() : unit =
        ()
    
    override this.previousFrame() : unit =
        ()
    
    override this.setFrame(index: int) : unit =
        ()
    
    override this.getFrame() : int =
        0
    
    override this.getSize() : int =
        1
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        graphics.drawImage(this.image, x, y, this.anchor)
    
    abstract getImage : unit -> Image
    default this.getImage() : Image =
        this.image
    
    abstract close : unit -> unit
    default this.close() : unit =
        DisposalUtil.getInstance().disposeImage(this.image)
    
    abstract finalize : unit -> unit
    default this.finalize() : unit =
        DisposalUtil.getInstance().disposeImage(this.image)


