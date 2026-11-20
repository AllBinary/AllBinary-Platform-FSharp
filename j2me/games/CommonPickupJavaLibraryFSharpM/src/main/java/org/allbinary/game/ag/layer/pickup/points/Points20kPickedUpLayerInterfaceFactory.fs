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
type Points20kPickedUpLayerInterfaceFactory =
    inherit PickedUpLayerInterfaceFactory
    [<DefaultValue(false)>] val mutable pool : PointsLayerCircularStaticPool
    [<DefaultValue(false)>] static val mutable private jcell_pickedUpLayerInterfaceFactoryInterface : PickedUpLayerInterfaceFactoryInterface
    static member pickedUpLayerInterfaceFactoryInterface with get() : PickedUpLayerInterfaceFactoryInterface = (Points20kPickedUpLayerInterfaceFactory.jclinit(); Points20kPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface) and set (jvalue: PickedUpLayerInterfaceFactoryInterface) = (Points20kPickedUpLayerInterfaceFactory.jclinit(); Points20kPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Points20kPickedUpLayerInterfaceFactory.jclinitDone then
            Points20kPickedUpLayerInterfaceFactory.jclinitDone <- true
            Points20kPickedUpLayerInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        Points20kPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- CountedPickedUpLayerInterfaceFactory.NULL_COUNTED_PICKUP_LAYER_FACTORY
        ()
    member this.jfields_Points20kPickedUpLayerInterfaceFactory() : unit =
        this.pool <- (new PointsLayerCircularStaticPool((new PointsLayerFactory((GameConfigurationUtil.getInstance().getCompetitionValue() * 20000))), 1))
        ()
    
    static member init() : unit =
        Points20kPickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface <- (new Points20kPickedUpLayerInterfaceFactory())
    
    new () as this =
        { inherit PickedUpLayerInterfaceFactory(PickedUpLayerTypeFactory.getInstance().POINTS, IconLayerFactory.getInstance(FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(PointsResources.getInstance().RESOURCE_2).getInstance(0), 10, 10), FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(PointsResources.getInstance().RESOURCE_2).getInstance(0)) }
        then
            this.jfields_Points20kPickedUpLayerInterfaceFactory()
    
    abstract getTotal : unit -> int
    default this.getTotal() : int =
        1
    
    static member getInstance() : PickedUpLayerInterfaceFactoryInterface =
        Points20kPickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface
    
    abstract process_ : sourceLayerInterface: AllBinaryLayer -> unit
    default this.process_(sourceLayerInterface: AllBinaryLayer) : unit =
        this.pool.visit(sourceLayerInterface)
    interface PickupProcessorInterface with
        member this.process_(jp0: AllBinaryLayer) : unit = this.process_(jp0)


