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
type TopToBottomImageAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TopToBottomImageAnimationFactory.jclinitDone then
            TopToBottomImageAnimationFactory.jclinitDone <- true
            TopToBottomImageAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (image: Image, sequenceArray: int[], animationBehaviorFactory: AnimationBehaviorFactory) =
        { inherit BaseImageAnimationFactory(image, sequenceArray, image.getWidth(), image.getHeight(), 0, 0, animationBehaviorFactory) }
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable scaledImage : Image = this.animationFactoryImageScaleUtil.createImage(this.getImage(), this.animationFactoryInitializationVisitor.width, this.animationFactoryInitializationVisitor.height, this.scaleProperties.scaleWidth, this.scaleProperties.scaleHeight)
        (new TopToBottomImageAnimation(scaledImage, this.getSequenceArray(), this.animationBehaviorFactory.getOrCreateInstance()))


