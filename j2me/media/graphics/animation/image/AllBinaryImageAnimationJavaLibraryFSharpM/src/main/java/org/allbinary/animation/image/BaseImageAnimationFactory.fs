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
type BaseImageAnimationFactory =
    [<DefaultValue(false)>] val mutable animationFactoryImageScaleUtil : AnimationFactoryImageScaleUtil
    [<DefaultValue(false)>] val mutable image : Image
    [<DefaultValue(false)>] val mutable animationBehaviorFactory : AnimationBehaviorFactory
    [<DefaultValue(false)>] val mutable sequenceArray : int[]
    [<DefaultValue(false)>] val mutable animationFactoryInitializationVisitor : AnimationFactoryInitializationVisitor
    [<DefaultValue(false)>] val mutable scaleProperties : ScaleProperties
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseImageAnimationFactory.jclinitDone then
            BaseImageAnimationFactory.jclinitDone <- true
            BaseImageAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BaseImageAnimationFactory() : unit =
        this.animationFactoryImageScaleUtil <- AnimationFactoryImageScaleUtil.getInstance()
        this.scaleProperties <- ScaleProperties.instance
        ()
    
    static member createFactoryBase(image: Image, sequenceArray: int[], width: int, height: int, animationBehaviorFactory: AnimationBehaviorFactory) : BaseImageAnimationFactory =
        (new BaseImageAnimationFactory(image, sequenceArray, width, height, 0, 0, animationBehaviorFactory))
    
    new (image: Image, sequenceArray: int[], width: int, height: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        {  }
        then
            this.jfields_BaseImageAnimationFactory()
            this.jctor1(image, sequenceArray, width, height, dx, dy, animationBehaviorFactory)
    member this.jctor1(image: Image, sequenceArray: int[], width: int, height: int, dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        this.animationFactoryInitializationVisitor <- (new AnimationFactoryInitializationVisitor())
        this.image <- image
        this.animationFactoryInitializationVisitor.width <- width
        this.animationFactoryInitializationVisitor.height <- height
        this.animationBehaviorFactory <- animationBehaviorFactory
        this.sequenceArray <- sequenceArray
        this.animationFactoryInitializationVisitor.dx <- dx
        this.animationFactoryInitializationVisitor.dy <- dy
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        NullAnimationFactory.getFactoryInstance().getInstance(instanceId)
    
    abstract getImage : unit -> Image
    default this.getImage() : Image =
        this.image
    
    abstract getSequenceArray : unit -> int[]
    default this.getSequenceArray() : int[] =
        this.sequenceArray
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        this.scaleProperties <- scaleProperties
        if this.scaleProperties.shouldScale then
            this.scaleProperties.scaleWidth <- JR.d2i(float ((float32 (this.animationFactoryInitializationVisitor.width) * this.scaleProperties.scaleX)))
            this.scaleProperties.scaleHeight <- JR.d2i(float ((float32 (this.animationFactoryInitializationVisitor.height) * this.scaleProperties.scaleY)))
        else
            ()
    
    abstract getAnimationFactoryInitializationVisitorP : unit -> AnimationFactoryInitializationVisitor
    default this.getAnimationFactoryInitializationVisitorP() : AnimationFactoryInitializationVisitor =
        this.animationFactoryInitializationVisitor
    
    abstract getScalePropertiesP : unit -> ScaleProperties
    default this.getScalePropertiesP() : ScaleProperties =
        this.scaleProperties
    
    override this.ToString() : string =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable commonLabels : CommonLabels = CommonLabels.getInstance()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(JR.objectToString(this)))
        ignore (stringBuffer.append(commonLabels.HEIGHT_LABEL))
        ignore (stringBuffer.appendint(this.image.getHeight()))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(this.animationFactoryInitializationVisitor.ToString()))
        stringBuffer.ToString()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


