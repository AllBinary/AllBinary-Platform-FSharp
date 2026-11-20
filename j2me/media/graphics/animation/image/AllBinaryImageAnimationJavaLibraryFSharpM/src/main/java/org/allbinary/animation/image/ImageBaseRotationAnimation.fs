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
type ImageBaseRotationAnimation =
    inherit RotationAnimation
    [<DefaultValue(false)>] val mutable image : Image
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageBaseRotationAnimation.jclinitDone then
            ImageBaseRotationAnimation.jclinitDone <- true
            ImageBaseRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImageBaseRotationAnimation() : unit =
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (image: Image, angleInfo: AngleInfo, totalAngle: int16, animationBehavior: AnimationBehavior) as this =
        { inherit RotationAnimation(angleInfo, CircularIndexUtil.createInstance((int (totalAngle) / int (angleInfo.getAngleIncrementInfo().getAngleIncrement()))), animationBehavior) }
        then
            this.jfields_ImageBaseRotationAnimation()
            this.jctor1(image, angleInfo, totalAngle, animationBehavior)
    member this.jctor1(image: Image, angleInfo: AngleInfo, totalAngle: int16, animationBehavior: AnimationBehavior) : unit =
        ()
        this.image <- image
        ()
    
    override this.getAnimationSize() : int =
        this.getSize()
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        graphics.drawImage(this.image, x, y, this.anchor)
    
    abstract getImage : unit -> Image
    default this.getImage() : Image =
        this.image
    
    override this.getWidth() : int =
        this.image.getWidth()
    
    override this.getHeight() : int =
        this.image.getHeight()
    
    abstract close : unit -> unit
    default this.close() : unit =
        DisposalUtil.getInstance().disposeImage(this.image)
    
    abstract finalize : unit -> unit
    default this.finalize() : unit =
        DisposalUtil.getInstance().disposeImage(this.image)


