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
type ImageCaptionIndexedAnimationFactory =
    [<DefaultValue(false)>] val mutable animationFactoryImageScaleUtil : AnimationFactoryImageScaleUtil
    [<DefaultValue(false)>] val mutable animationFactorySpriteScaleUtil : AnimationFactorySpriteScaleUtil
    [<DefaultValue(false)>] val mutable captionImage : Image
    [<DefaultValue(false)>] val mutable spriteMovieImage : Image
    [<DefaultValue(false)>] val mutable frameWidth : int
    [<DefaultValue(false)>] val mutable frameHeight : int
    [<DefaultValue(false)>] val mutable captionDx : int
    [<DefaultValue(false)>] val mutable captionDy : int
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] val mutable time : int
    [<DefaultValue(false)>] val mutable soundInterface : Sound
    [<DefaultValue(false)>] val mutable scaleProperties : ScaleProperties
    [<DefaultValue(false)>] val mutable animationBehaviorFactory : AnimationBehaviorFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageCaptionIndexedAnimationFactory.jclinitDone then
            ImageCaptionIndexedAnimationFactory.jclinitDone <- true
            ImageCaptionIndexedAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImageCaptionIndexedAnimationFactory() : unit =
        this.animationFactoryImageScaleUtil <- AnimationFactoryImageScaleUtil.getInstance()
        this.animationFactorySpriteScaleUtil <- AnimationFactorySpriteScaleUtil.getInstance()
        this.scaleProperties <- ScaleProperties.instance
        ()
    
    new (captionImage: Image, spriteMovieImage: Image, soundInterface: Sound, frameWidth: int, frameHeight: int, captionDx: int, captionDy: int, dx: int, dy: int, time: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        {  }
        then
            this.jfields_ImageCaptionIndexedAnimationFactory()
            this.jctor1(captionImage, spriteMovieImage, soundInterface, frameWidth, frameHeight, captionDx, captionDy, dx, dy, time, animationBehaviorFactory)
    member this.jctor1(captionImage: Image, spriteMovieImage: Image, soundInterface: Sound, frameWidth: int, frameHeight: int, captionDx: int, captionDy: int, dx: int, dy: int, time: int, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        if (JR.same(animationBehaviorFactory, AnimationBehaviorFactory.getInstance())) then
            ForcedLogUtil.log("Using default AnimationBehaviorFactory with IndexedAnimationFactory", this)
        this.captionImage <- captionImage
        this.spriteMovieImage <- spriteMovieImage
        this.frameWidth <- frameWidth
        this.frameHeight <- frameHeight
        this.captionDx <- captionDx
        this.captionDy <- captionDy
        this.dx <- dx
        this.dy <- dy
        this.time <- time
        this.soundInterface <- soundInterface
        this.animationBehaviorFactory <- animationBehaviorFactory
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        let mutable scaledImage : Image = this.animationFactoryImageScaleUtil.createImage(this.captionImage, this.captionImage.getWidth(), this.captionImage.getHeight(), this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        let mutable animationInterface : Animation = (new ImageAnimation(scaledImage, this.animationBehaviorFactory.getOrCreateInstance()))
        let mutable sprite : Sprite = this.animationFactorySpriteScaleUtil.createImage(this.spriteMovieImage, this.frameWidth, this.frameHeight, this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        let mutable movieIndexedAnimationInterface : IndexedAnimation = (new SpriteIndexedAnimation(sprite, this.spriteMovieImage, BasicColorUtil.getInstance().ZERO_ARRAY, this.animationBehaviorFactory.getOrCreateInstance()))
        let mutable player : Player = this.soundInterface.getPlayerP()
        if (JR.same(player, null)) then
            raise ((new JException("Sound Was not Initialized")))
        (new CaptionIndexedAnimation(animationInterface, movieIndexedAnimationInterface, player, this.captionDx, this.captionDy, this.dx, this.dy, this.time, this.animationBehaviorFactory.getOrCreateInstance()))
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        this.scaleProperties <- scaleProperties
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


