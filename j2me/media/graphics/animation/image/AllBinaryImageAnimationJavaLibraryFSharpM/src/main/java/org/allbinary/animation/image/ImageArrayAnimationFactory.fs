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
type ImageArrayAnimationFactory =
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] val mutable imageArray : Image[]
    [<DefaultValue(false)>] val mutable animationBehaviorFactory : AnimationBehaviorFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageArrayAnimationFactory.jclinitDone then
            ImageArrayAnimationFactory.jclinitDone <- true
            ImageArrayAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImageArrayAnimationFactory() : unit =
        this.dx <- 0
        this.dy <- 0
        ()
    
    new (imageArray: Image[], dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) as this =
        {  }
        then
            this.jfields_ImageArrayAnimationFactory()
            this.jctor1(imageArray, dx, dy, animationBehaviorFactory)
    member this.jctor1(imageArray: Image[], dx: int, dy: int, animationBehaviorFactory: AnimationBehaviorFactory) : unit =
        this.imageArray <- imageArray
        this.animationBehaviorFactory <- animationBehaviorFactory
        this.dx <- dx
        this.dy <- dy
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        let mutable jflow = 0
        let mutable jret : Animation = Unchecked.defaultof<Animation>
        if (this.dx <> 0) || (this.dy <> 0) then
            jret <- (new AdjustedImageArrayAnimation(this.imageArray, this.dx, this.dy, this.animationBehaviorFactory.getOrCreateInstance()))
            jflow <- 1
        else
            jret <- (new ImageArrayAnimation(this.imageArray, AnimationBehavior.getInstance()))
            jflow <- 1
        jret
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


