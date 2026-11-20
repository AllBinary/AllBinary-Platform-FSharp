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
type BaseAnimationInterfaceFactoryInterfaceComposite =
    [<DefaultValue(false)>] val mutable basicAnimationInterfaceFactoryInterfaceArray : BasicAnimationInterfaceFactoryInterface[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseAnimationInterfaceFactoryInterfaceComposite.jclinitDone then
            BaseAnimationInterfaceFactoryInterfaceComposite.jclinitDone <- true
            BaseAnimationInterfaceFactoryInterfaceComposite.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (basicAnimationInterfaceFactoryInterfaceArray: BasicAnimationInterfaceFactoryInterface[]) as this =
        {  }
        then
            this.jctor1(basicAnimationInterfaceFactoryInterfaceArray)
    member this.jctor1(basicAnimationInterfaceFactoryInterfaceArray: BasicAnimationInterfaceFactoryInterface[]) : unit =
        this.basicAnimationInterfaceFactoryInterfaceArray <- basicAnimationInterfaceFactoryInterfaceArray
        ()
    
    abstract getInstance : instanceId: int -> Animation
    default this.getInstance(instanceId: int) : Animation =
        NullAnimationFactory.getFactoryInstance().getInstance(0)
    
    abstract getBasicAnimationInterfaceFactoryInterfaceArray : unit -> BasicAnimationInterfaceFactoryInterface[]
    default this.getBasicAnimationInterfaceFactoryInterfaceArray() : BasicAnimationInterfaceFactoryInterface[] =
        this.basicAnimationInterfaceFactoryInterfaceArray
    
    abstract setBasicAnimationInterfaceFactoryInterfaceArray : basicAnimationInterfaceFactoryInterfaceArray: BasicAnimationInterfaceFactoryInterface[] -> unit
    default this.setBasicAnimationInterfaceFactoryInterfaceArray(basicAnimationInterfaceFactoryInterfaceArray: BasicAnimationInterfaceFactoryInterface[]) : unit =
        this.basicAnimationInterfaceFactoryInterfaceArray <- basicAnimationInterfaceFactoryInterfaceArray
    
    abstract setInitialScale : scaleProperties: ScaleProperties -> unit
    default this.setInitialScale(scaleProperties: ScaleProperties) : unit =
        ()
    interface AnimationInterfaceFactoryInterface with
        member this.getInstance(jp0: int) : Animation = this.getInstance(jp0)
        member this.setInitialScale(jp0: ScaleProperties) : unit = this.setInitialScale(jp0)
    interface BasicAnimationInterfaceFactoryInterface


