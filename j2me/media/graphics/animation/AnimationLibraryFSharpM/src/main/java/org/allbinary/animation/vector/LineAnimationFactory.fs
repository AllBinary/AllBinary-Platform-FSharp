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
type LineAnimationFactory =
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LineAnimationFactory.jclinitDone then
            LineAnimationFactory.jclinitDone <- true
            LineAnimationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (basicColor: BasicColor) as this =
        {  }
        then
            this.jctor1(basicColor)
    member this.jctor1(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        (new LineAnimation(this.basicColor))
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


