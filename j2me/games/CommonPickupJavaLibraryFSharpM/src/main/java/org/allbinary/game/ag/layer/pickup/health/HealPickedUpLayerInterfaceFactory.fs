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
type HealPickedUpLayerInterfaceFactory =
    inherit PickedUpLayerInterfaceFactory
    [<DefaultValue(false)>] val mutable pool : HealLayerCircularStaticPool
    [<DefaultValue(false)>] static val mutable private jcell_pickedUpLayerInterfaceFactoryInterface : PickedUpLayerInterfaceFactoryInterface
    static member pickedUpLayerInterfaceFactoryInterface with get() : PickedUpLayerInterfaceFactoryInterface = (HealPickedUpLayerInterfaceFactory.jclinit(); HealPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface) and set (jvalue: PickedUpLayerInterfaceFactoryInterface) = (HealPickedUpLayerInterfaceFactory.jclinit(); HealPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HealPickedUpLayerInterfaceFactory.jclinitDone then
            HealPickedUpLayerInterfaceFactory.jclinitDone <- true
            HealPickedUpLayerInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        HealPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- CountedPickedUpLayerInterfaceFactory.NULL_COUNTED_PICKUP_LAYER_FACTORY
        ()
    member this.jfields_HealPickedUpLayerInterfaceFactory() : unit =
        this.pool <- (new HealLayerCircularStaticPool((new HealLayerFactory()), 1))
        ()
    
    static member init() : unit =
        HealPickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface <- (new HealPickedUpLayerInterfaceFactory())
    
    new () as this =
        { inherit PickedUpLayerInterfaceFactory(PickedUpLayerTypeFactory.getInstance().HEAL, IconLayerFactory.getInstance(FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(HealthResources.getInstance().RESOURCE).getInstance(0), 10, 10), FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(HealthResources.getInstance().RESOURCE).getInstance(0)) }
        then
            this.jfields_HealPickedUpLayerInterfaceFactory()
    
    abstract getTotal : unit -> int
    default this.getTotal() : int =
        1
    
    static member getInstance() : PickedUpLayerInterfaceFactoryInterface =
        HealPickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface
    
    abstract process_ : sourceLayerInterface: AllBinaryLayer -> unit
    default this.process_(sourceLayerInterface: AllBinaryLayer) : unit =
        this.pool.visit(sourceLayerInterface)
    interface PickupProcessorInterface with
        member this.process_(jp0: AllBinaryLayer) : unit = this.process_(jp0)


