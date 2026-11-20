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
type LeftToRightImageAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LeftToRightImageAnimationFactory.jclinitDone then
            LeftToRightImageAnimationFactory.jclinitDone <- true
            LeftToRightImageAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (image: Image, sequenceArray: int[], dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) =
        { inherit BaseImageAnimationFactory(image, sequenceArray, image.getWidth(), image.getHeight(), dx, dy, animationBehaviorFactory) }
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        let mutable scaledImage : Image = this.animationFactoryImageScaleUtil.createImage(this.getImage(), this.animationFactoryInitializationVisitor.width, this.animationFactoryInitializationVisitor.height, this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        if (this.animationFactoryInitializationVisitor.dx <> 0) || (this.animationFactoryInitializationVisitor.dy <> 0) then
            this.animationFactoryImageScaleUtil.processAdjust(this)
            jret <- (new AdjustedLeftToRightImageAnimation(scaledImage, this.getSequenceArray(), this.animationFactoryInitializationVisitor.dx, this.animationFactoryInitializationVisitor.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- (new LeftToRightImageAnimation(scaledImage, this.getSequenceArray(), this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        jret


