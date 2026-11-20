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
type LifePickedUpLayerInterfaceFactory =
    inherit PickedUpLayerInterfaceFactory
    [<DefaultValue(false)>] val mutable pool : LifeLayerCircularStaticPool
    [<DefaultValue(false)>] static val mutable private jcell_pickedUpLayerInterfaceFactoryInterface : PickedUpLayerInterfaceFactoryInterface
    static member pickedUpLayerInterfaceFactoryInterface with get() : PickedUpLayerInterfaceFactoryInterface = (LifePickedUpLayerInterfaceFactory.jclinit(); LifePickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface) and set (jvalue: PickedUpLayerInterfaceFactoryInterface) = (LifePickedUpLayerInterfaceFactory.jclinit(); LifePickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LifePickedUpLayerInterfaceFactory.jclinitDone then
            LifePickedUpLayerInterfaceFactory.jclinitDone <- true
            LifePickedUpLayerInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LifePickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- CountedPickedUpLayerInterfaceFactory.NULL_COUNTED_PICKUP_LAYER_FACTORY
        ()
    member this.jfields_LifePickedUpLayerInterfaceFactory() : unit =
        this.pool <- (new LifeLayerCircularStaticPool((new LifeLayerFactory()), 1))
        ()
    
    static member init() : unit =
        LifePickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface <- (new LifePickedUpLayerInterfaceFactory())
    
    new () as this =
        { inherit PickedUpLayerInterfaceFactory(PickedUpLayerTypeFactory.getInstance().LIFE, IconLayerFactory.getInstance(FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(LifeResources.getInstance().RESOURCE).getInstance(0), 10, 10), FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(LifeResources.getInstance().RESOURCE).getInstance(0)) }
        then
            this.jfields_LifePickedUpLayerInterfaceFactory()
    
    abstract getTotal : unit -> int
    default this.getTotal() : int =
        1
    
    static member getInstance() : PickedUpLayerInterfaceFactoryInterface =
        LifePickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface
    
    abstract process_ : sourceLayerInterface: AllBinaryLayer -> unit
    default this.process_(sourceLayerInterface: AllBinaryLayer) : unit =
        this.pool.visit(sourceLayerInterface)
    interface PickupProcessorInterface with
        member this.process_(jp0: AllBinaryLayer) : unit = this.process_(jp0)


