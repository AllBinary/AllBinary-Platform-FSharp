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
type AnimationFactoryImageScaleUtil =
    [<DefaultValue(false)>] val mutable imageScaleUtil : ImageJ2MEScaleUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : AnimationFactoryImageScaleUtil
    static member instance with get() : AnimationFactoryImageScaleUtil = (AnimationFactoryImageScaleUtil.jclinit(); AnimationFactoryImageScaleUtil.jcell_instance) and set (jvalue: AnimationFactoryImageScaleUtil) = (AnimationFactoryImageScaleUtil.jclinit(); AnimationFactoryImageScaleUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnimationFactoryImageScaleUtil.jclinitDone then
            AnimationFactoryImageScaleUtil.jclinitDone <- true
            AnimationFactoryImageScaleUtil.jclinitBody()
    static member private jclinitBody() : unit =
        AnimationFactoryImageScaleUtil.jcell_instance <- (new AnimationFactoryImageScaleUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_AnimationFactoryImageScaleUtil()
    member this.jfields_AnimationFactoryImageScaleUtil() : unit =
        this.imageScaleUtil <- ImageJ2MEScaleUtil.getInstance()
        ()
    
    static member getInstance() : AnimationFactoryImageScaleUtil =
        AnimationFactoryImageScaleUtil.instance
    
    abstract createImage : image: Image * width: int * height: int * scaleWidth: int * scaleHeight: int -> Image
    default this.createImage(image: Image, width: int, height: int, scaleWidth: int, scaleHeight: int) : Image =
        let mutable scaledImage : Image = null
        if (scaleWidth <> 0) && (scaleHeight <> 0) then
            let mutable scaleX : float32 = (float32 (scaleWidth)) / (float32 (width))
            let mutable scaleY : float32 = (float32 (scaleHeight)) / (float32 (height))
            if ((scaleX = 1.0f) && (scaleY = 1.0f)) || ((scaleX = 0.0f) || (scaleY = 0.0f)) then
                scaledImage <- image
            else
                let mutable scaledWidth : int = JR.d2i(float ((scaleX * float32 (width))))
                let mutable scaledHeight : int = JR.d2i(float ((scaleY * float32 (height))))
                scaledImage <- this.imageScaleUtil.scale(image, scaledWidth, scaledHeight)
        else
            scaledImage <- image
        scaledImage
    
    abstract processAdjust : baseImageAnimationFactory: BaseImageAnimationFactory -> unit
    default this.processAdjust(baseImageAnimationFactory: BaseImageAnimationFactory) : unit =
        let mutable scaleProperties : ScaleProperties = baseImageAnimationFactory.getScalePropertiesP()
        if (scaleProperties.scaleWidth <> 0) && (scaleProperties.scaleHeight <> 0) then
            let mutable animationFactoryInitializationVisitor : AnimationFactoryInitializationVisitor = baseImageAnimationFactory.getAnimationFactoryInitializationVisitorP()
            let mutable scaleX : float32 = (float32 (scaleProperties.scaleWidth)) / (float32 (animationFactoryInitializationVisitor.width))
            let mutable scaleY : float32 = (float32 (scaleProperties.scaleHeight)) / (float32 (animationFactoryInitializationVisitor.height))
            if ((scaleX = 1.0f) && (scaleY = 1.0f)) || ((scaleX = 0.0f) || (scaleY = 0.0f)) then
                ()
            else
                animationFactoryInitializationVisitor.dx <- JR.d2i(float ((float32 (animationFactoryInitializationVisitor.originalDx) * scaleX)))
                animationFactoryInitializationVisitor.dy <- JR.d2i(float ((float32 (animationFactoryInitializationVisitor.originalDy) * scaleY)))
        else
            ()


