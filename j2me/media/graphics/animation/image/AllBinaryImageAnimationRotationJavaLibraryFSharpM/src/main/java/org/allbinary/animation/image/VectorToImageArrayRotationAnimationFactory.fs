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
type VectorToImageArrayRotationAnimationFactory =
    inherit BaseImageAnimationFactory
    [<DefaultValue(false)>] val mutable imageArray : Image[]
    [<DefaultValue(false)>] val mutable angleIncrement : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorToImageArrayRotationAnimationFactory.jclinitDone then
            VectorToImageArrayRotationAnimationFactory.jclinitDone <- true
            VectorToImageArrayRotationAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_VectorToImageArrayRotationAnimationFactory() : unit =
        this.imageArray <- NullImage.NULL_IMAGE_ARRAY
        ()
    
    new (vectorInfo: VectorInfo, basicColor: BasicColor, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        { inherit BaseImageAnimationFactory(AnimationFrameToImageUtil.getInstance().getInstanceTranslate(vectorInfo.getWidth(), vectorInfo.getHeight(), VectorAnimation.createVectorAnimation(vectorInfo.getPoints(), basicColor, animationBehaviorFactory.getOrCreateInstance())), PrimitiveIntUtil.getArrayInstance(), 0, 0, 0, 0, animationBehaviorFactory) }
        then
            this.jfields_VectorToImageArrayRotationAnimationFactory()
            this.jctor1(vectorInfo, basicColor, animationBehaviorFactory)
    member this.jctor1(vectorInfo: VectorInfo, basicColor: BasicColor, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        ()
        this.init()
        ()
    
    abstract init : unit -> unit
    default this.init() : unit =
        let mutable angleFactory : AngleFactory = AngleFactory.getInstance()
        this.angleIncrement <- int (int (angleFactory.TOTAL_ANGLE)) / GameConfigurationCentral.getInstance().getGameControlFidelity()
        this.imageArray <- ImageToRotationImageArrayUtil.getInstance().generate(this.getImage(), this.getAngleIncrement(), int (angleFactory.TOTAL_ANGLE))
    
    override this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        if (this.animationFactoryInitializationVisitor.dx <> 0) || (this.animationFactoryInitializationVisitor.dy <> 0) then
            jret <- (new AdjustedImageArrayRotationAnimation(this.imageArray, AngleInfo.getInstance(int16 (this.getAngleIncrement())), int (AngleFactory.getInstance().TOTAL_ANGLE), this.animationFactoryInitializationVisitor.dx, this.animationFactoryInitializationVisitor.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- AdjustedImageArrayRotationAnimation.createAnimation(this.imageArray, AngleInfo.getInstance(int16 (this.angleIncrement)), int (AngleFactory.getInstance().TOTAL_ANGLE), this.animationBehaviorFactory.getOrCreateInstance())
            jflow <- 1
        jret
    
    abstract getAngleIncrement : unit -> int
    default this.getAngleIncrement() : int =
        this.angleIncrement
    
    override this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()


