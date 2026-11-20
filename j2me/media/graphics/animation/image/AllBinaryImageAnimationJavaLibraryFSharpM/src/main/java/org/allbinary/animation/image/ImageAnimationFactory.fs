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
type ImageAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageAnimationFactory.jclinitDone then
            ImageAnimationFactory.jclinitDone <- true
            ImageAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createFactory(image: Image) : ImageAnimationFactory =
        (new ImageAnimationFactory(image, image.getWidth(), image.getHeight(), 0, 0, AnimationBehaviorFactory.getInstance()))
    
    new (image: Image, width: int, height: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) =
        { inherit BaseImageAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), width, height, dx, dy, animationBehaviorFactory) }
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        let mutable scaledImage : Image = this.animationFactoryImageScaleUtil.createImage(this.getImage(), this.animationFactoryInitializationVisitor.width, this.animationFactoryInitializationVisitor.height, this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        let mutable openGLUtil : OpenGLUtil = OpenGLUtil.getInstance()
        scaledImage <- openGLUtil.addImage(scaledImage)
        if (this.animationFactoryInitializationVisitor.dx <> 0) || (this.animationFactoryInitializationVisitor.dy <> 0) then
            this.animationFactoryImageScaleUtil.processAdjust(this)
            jret <- (new AdjustedImageAnimation(scaledImage, this.animationFactoryInitializationVisitor.dx, this.animationFactoryInitializationVisitor.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- (new ImageAnimation(scaledImage, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        jret


