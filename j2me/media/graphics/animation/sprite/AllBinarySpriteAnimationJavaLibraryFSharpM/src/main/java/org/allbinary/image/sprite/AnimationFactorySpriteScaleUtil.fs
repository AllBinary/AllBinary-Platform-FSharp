namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type AnimationFactorySpriteScaleUtil =
    [<DefaultValue(false)>] val mutable imageCache : ImageCache
    [<DefaultValue(false)>] val mutable imageScaleUtil : ImageScaleUtil
    [<DefaultValue(false)>] val mutable openGLUtil : OpenGLUtil
    [<DefaultValue(false)>] val mutable j2seMath : J2SEMath
    [<DefaultValue(false)>] val mutable openGLESImageExclusionUtil : OpenGLESImageExclusionUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : AnimationFactorySpriteScaleUtil
    static member instance with get() : AnimationFactorySpriteScaleUtil = (AnimationFactorySpriteScaleUtil.jclinit(); AnimationFactorySpriteScaleUtil.jcell_instance) and set (jvalue: AnimationFactorySpriteScaleUtil) = (AnimationFactorySpriteScaleUtil.jclinit(); AnimationFactorySpriteScaleUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnimationFactorySpriteScaleUtil.jclinitDone then
            AnimationFactorySpriteScaleUtil.jclinitDone <- true
            AnimationFactorySpriteScaleUtil.jclinitBody()
    static member private jclinitBody() : unit =
        AnimationFactorySpriteScaleUtil.jcell_instance <- (new AnimationFactorySpriteScaleUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_AnimationFactorySpriteScaleUtil()
    member this.jfields_AnimationFactorySpriteScaleUtil() : unit =
        this.imageCache <- ImageCacheFactory.getInstance()
        this.imageScaleUtil <- ImageScaleUtil.getInstance()
        this.openGLUtil <- OpenGLUtil.getInstance()
        this.j2seMath <- J2SEMath.getInstance()
        this.openGLESImageExclusionUtil <- OpenGLESImageExclusionUtil.getInstance()
        ()
    
    static member getInstance() : AnimationFactorySpriteScaleUtil =
        AnimationFactorySpriteScaleUtil.instance
    
    abstract createImage : image: Image * width: int * height: int * scaleWidth: int * scaleHeight: int -> Sprite
    default this.createImage(image: Image, width: int, height: int, scaleWidth: int, scaleHeight: int) : Sprite =
        let mutable spriteFactory : SpriteFactory = SpriteFactory.getInstance()
        let mutable sprite : Sprite = null
        let mutable scaledImage : Image = null
        if (scaleWidth <> 0) && (scaleHeight <> 0) then
            let mutable scaleX : float32 = (float32 (scaleWidth)) / (float32 (width))
            let mutable scaleY : float32 = (float32 (scaleHeight)) / (float32 (height))
            if ((scaleX = 1.0f) && (scaleY = 1.0f)) || ((scaleX = 0.0f) || (scaleY = 0.0f)) then
                scaledImage <- this.openGLUtil.addImage(image)
                sprite <- spriteFactory.createSprite(scaledImage, width, height)
            else
                if this.openGLESImageExclusionUtil.isCustomScaling(image) then
                    let mutable width2 : int = this.j2seMath.round((float32 ((scaleWidth)) - 0.5f))
                    let mutable height2 : int = this.j2seMath.round((float32 ((scaleHeight)) - 0.5f))
                    let mutable multiplesOf16Width : int = width2 / 16
                    let mutable by16Width : int = multiplesOf16Width * 16
                    scaleX <- (float32 (by16Width)) / float32 (width)
                    let mutable multiplesOf16Height : int = height2 / 16
                    let mutable by16Height : int = multiplesOf16Height * 16
                    scaleY <- (float32 (by16Height)) / float32 (height)
                    if scaleWidth < width then
                        scaleX <- scaleX * 2.35f
                    if scaleHeight < height then
                        scaleY <- scaleY * 2.35f
                scaledImage <- this.imageScaleUtil.createImage2(this.imageCache, image, scaleX, 1.0f, scaleY, 1.0f, true)
                sprite <- spriteFactory.createSprite(scaledImage, JR.d2i(float ((float32 (width) * scaleX))), JR.d2i(float ((float32 (height) * scaleY))))
        else
            scaledImage <- this.openGLUtil.addImage(image)
            sprite <- spriteFactory.createSprite(scaledImage, width, height)
        sprite


