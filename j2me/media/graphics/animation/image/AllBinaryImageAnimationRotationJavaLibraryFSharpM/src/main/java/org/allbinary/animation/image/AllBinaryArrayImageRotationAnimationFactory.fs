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
type AllBinaryArrayImageRotationAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] val mutable imageArray : Image[]
    [<DefaultValue(false)>] val mutable angleIncrement : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryArrayImageRotationAnimationFactory.jclinitDone then
            AllBinaryArrayImageRotationAnimationFactory.jclinitDone <- true
            AllBinaryArrayImageRotationAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AllBinaryArrayImageRotationAnimationFactory() : unit =
        this.imageArray <- NullImage.NULL_IMAGE_ARRAY
        ()
    
    static member createFactory(image: Image, dx: int, dy: int) : AllBinaryArrayImageRotationAnimationFactory =
        let mutable arrayImageRotationAnimationFactory : AllBinaryArrayImageRotationAnimationFactory = (new AllBinaryArrayImageRotationAnimationFactory(image, image.getWidth(), image.getHeight(), (int (int (AngleFactory.getInstance().TOTAL_ANGLE)) / GameConfigurationCentral.getInstance().getGameControlFidelity()), AnimationBehaviorFactory.getInstance()))
        arrayImageRotationAnimationFactory.initDXY(dx, dy)
        arrayImageRotationAnimationFactory
    
    static member createFactoryA(image: Image, dx: int, dy: int, angleIncrement: int) : AllBinaryArrayImageRotationAnimationFactory =
        let mutable arrayImageRotationAnimationFactory : AllBinaryArrayImageRotationAnimationFactory = (new AllBinaryArrayImageRotationAnimationFactory(image, image.getWidth(), image.getHeight(), angleIncrement, AnimationBehaviorFactory.getInstance()))
        arrayImageRotationAnimationFactory.initDXY(dx, dy)
        arrayImageRotationAnimationFactory
    
    new (image: Image, width: int, height: int, angleIncrement: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        { inherit BaseImageAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), width, height, 0, 0, animationBehaviorFactory) }
        then
            this.jfields_AllBinaryArrayImageRotationAnimationFactory()
            this.jctor1(image, width, height, angleIncrement, animationBehaviorFactory)
    member this.jctor1(image: Image, width: int, height: int, angleIncrement: int, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        ()
        this.angleIncrement <- angleIncrement
        this.init()
        ()
    
    member this.init() : unit =
        this.setImageArray(ImageToRotationImageArrayUtil.getInstance().generate(this.getImage(), this.getAngleIncrement(), int (AngleFactory.getInstance().TOTAL_ANGLE)))
    
    member this.initDXY(dx: int, dy: int) : unit =
        this.animationFactoryInitializationVisitor.dx <- dx
        this.animationFactoryInitializationVisitor.dy <- dy
        this.animationFactoryInitializationVisitor.originalDx <- dx
        this.animationFactoryInitializationVisitor.originalDy <- dy
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        let mutable scaledImageArray : Image[] = (Array.zeroCreate<Image> (this.imageArray.Length))
        let mutable size : int = scaledImageArray.Length
        let mutable image : Image = this.getImage()
        let mutable index : int = 0
        while index < size do
            scaledImageArray.[index] <- this.animationFactoryImageScaleUtil.createImage(image, image.getWidth(), image.getHeight(), this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
            index <- index + 1
        if (this.animationFactoryInitializationVisitor.dx <> 0) || (this.animationFactoryInitializationVisitor.dy <> 0) then
            this.animationFactoryImageScaleUtil.processAdjust(this)
            jret <- (new AdjustedImageArrayRotationAnimation(scaledImageArray, AngleInfo.getInstance(int16 (this.getAngleIncrement())), int (AngleFactory.getInstance().TOTAL_ANGLE), this.animationFactoryInitializationVisitor.dx, this.animationFactoryInitializationVisitor.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- (new ImageArrayRotationAnimation(scaledImageArray, AngleInfo.getInstance(int16 (this.getAngleIncrement())), int (AngleFactory.getInstance().TOTAL_ANGLE), this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        jret
    
    abstract setImageArray : imageArray: Image[] -> unit
    default this.setImageArray(imageArray: Image[]) : unit =
        this.imageArray <- imageArray
    
    abstract getAngleIncrement : unit -> int
    default this.getAngleIncrement() : int =
        this.angleIncrement


