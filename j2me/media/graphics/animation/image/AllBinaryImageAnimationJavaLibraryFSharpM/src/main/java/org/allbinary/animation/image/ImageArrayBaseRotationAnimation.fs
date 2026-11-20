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
type ImageArrayBaseRotationAnimation =
    inherit RotationAnimation
    [<DefaultValue(false)>] val mutable imageModifierUtil : ImageModifierUtil
    [<DefaultValue(false)>] val mutable originalImageArray : Image[]
    [<DefaultValue(false)>] val mutable imageArray : Image[]
    [<DefaultValue(false)>] val mutable currentImage : Image
    [<DefaultValue(false)>] val mutable totalFrames : int
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageArrayBaseRotationAnimation.jclinitDone then
            ImageArrayBaseRotationAnimation.jclinitDone <- true
            ImageArrayBaseRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImageArrayBaseRotationAnimation() : unit =
        this.imageModifierUtil <- ImageModifierUtil.getInstanceOrCreate()
        this.imageArray <- NullImage.NULL_IMAGE_ARRAY
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (originalImageArray: Image[], angleInfo: AngleInfo, animationBehavior: AnimationBehavior) as this =
        { inherit RotationAnimation(angleInfo, CircularIndexUtil.createInstance((360 / int (int (angleInfo.getAngleIncrementInfo().getAngleIncrement())))), animationBehavior) }
        then
            this.jfields_ImageArrayBaseRotationAnimation()
            this.jctor1(originalImageArray, angleInfo, animationBehavior)
    member this.jctor1(originalImageArray: Image[], angleInfo: AngleInfo, animationBehavior: AnimationBehavior) : unit =
        ()
        this.originalImageArray <- originalImageArray
        this.setImageArray(this.imageModifierUtil.getImageArray(originalImageArray))
        this.currentImage <- this.imageArray.[this.circularIndexUtil.getIndex()]
        ()
    
    override this.getAnimationSize() : int =
        this.getSize()
    
    override this.setAlpha(alpha: int) : unit =
        if this.alphaP <> alpha then
            base.setAlpha(alpha)
            this.imageModifierUtil.reset()
            let mutable index : int = this.circularIndexUtil.getIndex()
            this.imageModifierUtil.setAlpha(this.originalImageArray.[index], this.imageArray.[index], index, this.alphaP)
    
    override this.nextRotation() : unit =
        base.nextRotation()
        let mutable index : int = this.circularIndexUtil.getIndex()
        this.imageModifierUtil.setAlpha(this.originalImageArray.[index], this.imageArray.[index], index, this.alphaP)
        this.currentImage <- this.imageArray.[index]
    
    override this.previousRotation() : unit =
        base.previousRotation()
        let mutable index : int = this.circularIndexUtil.getIndex()
        this.imageModifierUtil.setAlpha(this.originalImageArray.[index], this.imageArray.[index], index, this.alphaP)
        this.currentImage <- this.imageArray.[index]
    
    override this.setFrame(index2: int) : unit =
        base.setFrame(index2)
        let mutable index : int = this.circularIndexUtil.getIndex()
        this.imageModifierUtil.setAlpha(this.originalImageArray.[index], this.imageArray.[index], index, this.alphaP)
        this.currentImage <- this.imageArray.[index]
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    abstract setImageArray : imageArray: Image[] -> unit
    default this.setImageArray(imageArray: Image[]) : unit =
        this.imageArray <- imageArray
        this.totalFrames <- imageArray.Length
        this.circularIndexUtil <- CircularIndexUtil.createInstance(this.totalFrames)
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        graphics.drawImage(this.currentImage, x, y, this.anchor)
    
    abstract close : unit -> unit
    default this.close() : unit =
        let mutable disposalUtil : DisposalUtil = DisposalUtil.getInstance()
        let mutable size2 : int = this.imageArray.Length
        let mutable index : int = 0
        while index < size2 do
            disposalUtil.disposeImage(this.imageArray.[index])
            index <- index + 1
        let mutable size : int = this.originalImageArray.Length
        let mutable index : int = 0
        while index < size do
            disposalUtil.disposeImage(this.originalImageArray.[index])
            index <- index + 1
        disposalUtil.disposeImage(this.currentImage)
    
    abstract finalize : unit -> unit
    default this.finalize() : unit =
        let mutable disposalUtil : DisposalUtil = DisposalUtil.getInstance()
        let mutable size2 : int = this.imageArray.Length
        let mutable index : int = 0
        while index < size2 do
            disposalUtil.disposeImage(this.imageArray.[index])
            index <- index + 1
        let mutable size : int = this.originalImageArray.Length
        let mutable index : int = 0
        while index < size do
            disposalUtil.disposeImage(this.originalImageArray.[index])
            index <- index + 1
        disposalUtil.disposeImage(this.currentImage)


