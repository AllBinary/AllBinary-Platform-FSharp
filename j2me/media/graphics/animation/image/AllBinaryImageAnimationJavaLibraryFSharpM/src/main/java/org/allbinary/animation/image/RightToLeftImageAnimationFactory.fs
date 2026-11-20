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
type RightToLeftImageAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RightToLeftImageAnimationFactory.jclinitDone then
            RightToLeftImageAnimationFactory.jclinitDone <- true
            RightToLeftImageAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (image: Image, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) =
        { inherit BaseImageAnimationFactory(image, PrimitiveIntUtil.getArrayInstance(), image.getWidth(), image.getHeight(), dx, dy, animationBehaviorFactory) }
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        let mutable scaledImage : Image = this.animationFactoryImageScaleUtil.createImage(this.getImage(), this.animationFactoryInitializationVisitor.width, this.animationFactoryInitializationVisitor.height, this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        if (this.animationFactoryInitializationVisitor.dx <> 0) || (this.animationFactoryInitializationVisitor.dy <> 0) then
            this.animationFactoryImageScaleUtil.processAdjust(this)
            jret <- (new AdjustedRightToLeftImageAnimation(scaledImage, this.animationFactoryInitializationVisitor.dx, this.animationFactoryInitializationVisitor.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- (new RightToLeftImageAnimation(scaledImage, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        jret


