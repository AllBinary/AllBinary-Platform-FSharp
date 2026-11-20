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
type Points30kPickedUpLayerInterfaceFactory =
    inherit PickedUpLayerInterfaceFactory
    [<DefaultValue(false)>] val mutable pool : PointsLayerCircularStaticPool
    [<DefaultValue(false)>] static val mutable private jcell_pickedUpLayerInterfaceFactoryInterface : PickedUpLayerInterfaceFactoryInterface
    static member pickedUpLayerInterfaceFactoryInterface with get() : PickedUpLayerInterfaceFactoryInterface = (Points30kPickedUpLayerInterfaceFactory.jclinit(); Points30kPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface) and set (jvalue: PickedUpLayerInterfaceFactoryInterface) = (Points30kPickedUpLayerInterfaceFactory.jclinit(); Points30kPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Points30kPickedUpLayerInterfaceFactory.jclinitDone then
            Points30kPickedUpLayerInterfaceFactory.jclinitDone <- true
            Points30kPickedUpLayerInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        Points30kPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- CountedPickedUpLayerInterfaceFactory.NULL_COUNTED_PICKUP_LAYER_FACTORY
        ()
    member this.jfields_Points30kPickedUpLayerInterfaceFactory() : unit =
        this.pool <- (new PointsLayerCircularStaticPool((new PointsLayerFactory((GameConfigurationUtil.getInstance().getCompetitionValue() * 30000))), 1))
        ()
    
    static member init() : unit =
        Points30kPickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface <- (new Points30kPickedUpLayerInterfaceFactory())
    
    new () as this =
        { inherit PickedUpLayerInterfaceFactory(PickedUpLayerTypeFactory.getInstance().POINTS, IconLayerFactory.getInstance(FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(PointsResources.getInstance().RESOURCE_3).getInstance(0), 10, 10), FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(PointsResources.getInstance().RESOURCE_3).getInstance(0)) }
        then
            this.jfields_Points30kPickedUpLayerInterfaceFactory()
    
    abstract getTotal : unit -> int
    default this.getTotal() : int =
        1
    
    static member getInstance() : PickedUpLayerInterfaceFactoryInterface =
        Points30kPickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface
    
    abstract process_ : sourceLayerInterface: AllBinaryLayer -> unit
    default this.process_(sourceLayerInterface: AllBinaryLayer) : unit =
        this.pool.visit(sourceLayerInterface)
    interface PickupProcessorInterface with
        member this.process_(jp0: AllBinaryLayer) : unit = this.process_(jp0)


