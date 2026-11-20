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
type CountedPickedUpLayerInterfaceFactory =
    inherit PickedUpLayerInterfaceFactory
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] static val mutable private jcell_NULL_COUNTED_PICKUP_LAYER_FACTORY : CountedPickedUpLayerInterfaceFactory
    static member NULL_COUNTED_PICKUP_LAYER_FACTORY with get() : CountedPickedUpLayerInterfaceFactory = (CountedPickedUpLayerInterfaceFactory.jclinit(); CountedPickedUpLayerInterfaceFactory.jcell_NULL_COUNTED_PICKUP_LAYER_FACTORY) and set (jvalue: CountedPickedUpLayerInterfaceFactory) = (CountedPickedUpLayerInterfaceFactory.jclinit(); CountedPickedUpLayerInterfaceFactory.jcell_NULL_COUNTED_PICKUP_LAYER_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CountedPickedUpLayerInterfaceFactory.jclinitDone then
            CountedPickedUpLayerInterfaceFactory.jclinitDone <- true
            CountedPickedUpLayerInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CountedPickedUpLayerInterfaceFactory.jcell_NULL_COUNTED_PICKUP_LAYER_FACTORY <- (new CountedPickedUpLayerInterfaceFactory(PickedUpLayerTypeFactory.getInstance().NONE, IconLayer.NULL_ICON_LAYER, NullAnimationFactory.getFactoryInstance().getInstance(0)))
        ()
    
    new (pickeUpLayerType: PickedUpLayerType, iconLayer: IconLayer, animationInterface: Animation) as this =
        { inherit PickedUpLayerInterfaceFactory(pickeUpLayerType, iconLayer, animationInterface) }
        then
            this.jctor1(pickeUpLayerType, iconLayer, animationInterface)
    member this.jctor1(pickeUpLayerType: PickedUpLayerType, iconLayer: IconLayer, animationInterface: Animation) : unit =
        ()
        let mutable list_ : BasicArrayList = CountedPickedUpLayerInterfaceFactoryPool.getInstance().getList()
        this.id <- list_.size()
        ignore (list_.add(this))
        ()
    
    abstract getNextInstance : hashtable: ABHashtable * x: int * y: int * z: int -> AllBinaryLayer
    default this.getNextInstance(hashtable: ABHashtable, x: int, y: int, z: int) : AllBinaryLayer =
        raise ((new JException(CommonStrings.getInstance().NOT_IMPLEMENTED)))
    
    abstract getTotal : unit -> int
    default this.getTotal() : int =
        -1
    
    abstract getId : unit -> int
    default this.getId() : int =
        this.id
    interface CountedPickedUpLayerInterfaceFactoryInterface with
        member this.getId() : int = this.getId()
        member this.getTotal() : int = this.getTotal()
    interface PickedUpLayerInterfaceFactoryInterface with
        member this.getPickedUpLayerType() : PickedUpLayerType = this.getPickedUpLayerType()
        member this.getIconLayer() : AllBinaryLayer = this.getIconLayer()
        member this.getAnimationInterface() : Animation = this.getAnimationInterface()
    interface LayerInterfaceFactoryInterface with
        member this.getNextInstance(jp0: ABHashtable, jp1: int, jp2: int, jp3: int) : AllBinaryLayer = this.getNextInstance(jp0, jp1, jp2, jp3)


