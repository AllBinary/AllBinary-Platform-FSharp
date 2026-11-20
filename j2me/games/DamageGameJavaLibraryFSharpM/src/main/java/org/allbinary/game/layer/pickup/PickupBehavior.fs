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
type PickupBehavior =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable countedIndex : int
    [<DefaultValue(false)>] val mutable ownerLayerInterface : CollidableCompositeLayer
    [<DefaultValue(false)>] static val mutable private jcell_NULL_PICKUP_BEHAVIOR : obj
    static member NULL_PICKUP_BEHAVIOR with get() : obj = (PickupBehavior.jclinit(); PickupBehavior.jcell_NULL_PICKUP_BEHAVIOR) and set (jvalue: obj) = (PickupBehavior.jclinit(); PickupBehavior.jcell_NULL_PICKUP_BEHAVIOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PickupBehavior.jclinitDone then
            PickupBehavior.jclinitDone <- true
            PickupBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        PickupBehavior.jcell_NULL_PICKUP_BEHAVIOR <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_PickupBehavior() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getNullInstance() : PickupBehavior =
        if (JR.same(PickupBehavior.NULL_PICKUP_BEHAVIOR, NullUtil.getInstance().NULL_OBJECT)) then
            PickupBehavior.NULL_PICKUP_BEHAVIOR <- (new PickupBehavior(CollidableCompositeLayer.getNullInstance(), 0))
        (box (PickupBehavior.NULL_PICKUP_BEHAVIOR) :?> PickupBehavior)
    
    new (ownerLayerInterface: CollidableCompositeLayer, countedIndex: int) as this =
        {  }
        then
            this.jfields_PickupBehavior()
            this.jctor1(ownerLayerInterface, countedIndex)
    member this.jctor1(ownerLayerInterface: CollidableCompositeLayer, countedIndex: int) : unit =
        this.ownerLayerInterface <- ownerLayerInterface
        this.countedIndex <- countedIndex
        ()
    
    abstract doPickup : pickupProcessorInterface: PickupProcessorInterface -> unit
    default this.doPickup(pickupProcessorInterface: PickupProcessorInterface) : unit =
        try
            let mutable healthInterfaceCompositeInterface : HealthInterfaceCompositeInterface = (box (this.ownerLayerInterface) :?> HealthInterfaceCompositeInterface)
            if healthInterfaceCompositeInterface.getHealthInterface().isAlive() then
                pickupProcessorInterface.process_(this.ownerLayerInterface)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "doPickup", e)
            | _ -> reraise ()
    
    abstract doPickupLayer : pickupLayerInterface: PickedUpLayerInterface -> unit
    default this.doPickupLayer(pickupLayerInterface: PickedUpLayerInterface) : unit =
        try
            let mutable pickedUpLayerInterfaceFactoryInterface : PickedUpLayerInterfaceFactoryInterface = pickupLayerInterface.getPickedUpLayerInterfaceFactoryInterface()
            let mutable pickedUpLayerType : PickedUpLayerType = pickedUpLayerInterfaceFactoryInterface.getPickedUpLayerType()
            let mutable pickedUpLayerTypeFactory : PickedUpLayerTypeFactory = PickedUpLayerTypeFactory.getInstance()
            if ((((JR.same(pickedUpLayerType, pickedUpLayerTypeFactory.BEAM))) || ((JR.same(pickedUpLayerType, pickedUpLayerTypeFactory.MINE)))) || ((JR.same(pickedUpLayerType, pickedUpLayerTypeFactory.PROJECTILE)))) || ((JR.same(pickedUpLayerType, pickedUpLayerTypeFactory.ENHANCEMENT))) then
                this.add((box (pickedUpLayerInterfaceFactoryInterface) :?> CountedPickedUpLayerInterfaceFactoryInterface))
            elif (JR.same(pickedUpLayerInterfaceFactoryInterface.getPickedUpLayerType(), pickedUpLayerTypeFactory.PART)) then
                let mutable collidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer = (box (this.ownerLayerInterface) :?> CollidableDestroyableDamageableLayer)
                collidableDestroyableDamageableLayer.addPart(pickedUpLayerInterfaceFactoryInterface)
            elif (JR.same(pickedUpLayerType, pickedUpLayerTypeFactory.NONE)) then
                ()
            else
                let mutable pickupProcessorInterface : PickupProcessorInterface = (box (pickedUpLayerInterfaceFactoryInterface) :?> PickupProcessorInterface)
                this.doPickup(pickupProcessorInterface)
            pickupLayerInterface.setPickedUp()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                PreLogUtil.putOE(commonStrings.EXCEPTION, this, "doPickup", e)
            | _ -> reraise ()
    
    abstract add : countedPickedUpLayerInterfaceFactoryInterface: CountedPickedUpLayerInterfaceFactoryInterface -> unit
    default this.add(countedPickedUpLayerInterfaceFactoryInterface: CountedPickedUpLayerInterfaceFactoryInterface) : unit =
        let mutable partIndex : int = countedPickedUpLayerInterfaceFactoryInterface.getId() + this.countedIndex
        this.addAt(countedPickedUpLayerInterfaceFactoryInterface, partIndex)
    
    abstract addAt : countedPickedUpLayerInterfaceFactoryInterface: CountedPickedUpLayerInterfaceFactoryInterface * partIndex: int -> unit
    default this.addAt(countedPickedUpLayerInterfaceFactoryInterface: CountedPickedUpLayerInterfaceFactoryInterface, partIndex: int) : unit =
        let mutable collidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer = (box (this.ownerLayerInterface) :?> CollidableDestroyableDamageableLayer)
        let mutable countedLayerInterfaceFactory : CountedLayerInterfaceFactoryPart = (box (collidableDestroyableDamageableLayer.getPartInterfaceArray().[partIndex]) :?> CountedLayerInterfaceFactoryPart)
        countedLayerInterfaceFactory.setTotal((countedLayerInterfaceFactory.getTotal() + countedPickedUpLayerInterfaceFactoryInterface.getTotal()))
    
    abstract getFirstAvailableCountedLayerInterfaceFactory : pickedUpLayerTypeArray: PickedUpLayerType[] -> CountedLayerInterfaceFactoryPart
    default this.getFirstAvailableCountedLayerInterfaceFactory(pickedUpLayerTypeArray: PickedUpLayerType[]) : CountedLayerInterfaceFactoryPart =
        let mutable jflow = 0
        let mutable jret : CountedLayerInterfaceFactoryPart = Unchecked.defaultof<CountedLayerInterfaceFactoryPart>
        let mutable collidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer = (box (this.ownerLayerInterface) :?> CollidableDestroyableDamageableLayer)
        let mutable partInterfaceArray : PartInterface[] = collidableDestroyableDamageableLayer.getPartInterfaceArray()
        let mutable size : int = partInterfaceArray.Length
        let mutable nextCountedLayerInterfaceFactory : CountedLayerInterfaceFactoryPart = null
        let mutable countedPickedUpLayerInterfaceFactory : CountedPickedUpLayerInterfaceFactory = null
        let mutable index : int = this.countedIndex
        while jflow = 0 && (index < size) do
            nextCountedLayerInterfaceFactory <- (box (collidableDestroyableDamageableLayer.getPartInterfaceArray().[index]) :?> CountedLayerInterfaceFactoryPart)
            countedPickedUpLayerInterfaceFactory <- nextCountedLayerInterfaceFactory.getCountedPickedUpLayerInterfaceFactory()
            let mutable index2 : int = pickedUpLayerTypeArray.Length
            while jflow = 0 && (((index2 <- index2 - 1; index2)) >= 0) do
                if (JR.same(countedPickedUpLayerInterfaceFactory.getPickedUpLayerType(), pickedUpLayerTypeArray.[index2])) then
                    if nextCountedLayerInterfaceFactory.getTotal() > 0 then
                        jret <- nextCountedLayerInterfaceFactory
                        jflow <- 1
                if jflow = 200002 then jflow <- 0
            if jflow = 100002 then jflow <- 0
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- CountedLayerInterfaceFactoryPart.NULL_COUNTED_LAYER_INTERFACE_FACTORY
            jflow <- 1
        jret
    
    abstract getCountedLayerInterfaceFactoryForSlot : slotIndex: int -> CountedLayerInterfaceFactoryPart
    default this.getCountedLayerInterfaceFactoryForSlot(slotIndex: int) : CountedLayerInterfaceFactoryPart =
        let mutable jflow = 0
        let mutable jret : CountedLayerInterfaceFactoryPart = Unchecked.defaultof<CountedLayerInterfaceFactoryPart>
        let mutable currentSlot : int = 0
        let mutable collidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer = (box (this.ownerLayerInterface) :?> CollidableDestroyableDamageableLayer)
        let mutable partInterfaceArray : PartInterface[] = collidableDestroyableDamageableLayer.getPartInterfaceArray()
        let mutable size : int = partInterfaceArray.Length
        let mutable nextCountedLayerInterfaceFactory : CountedLayerInterfaceFactoryPart = null
        let mutable index : int = this.countedIndex
        while jflow = 0 && (index < size) do
            nextCountedLayerInterfaceFactory <- (box (collidableDestroyableDamageableLayer.getPartInterfaceArray().[index]) :?> CountedLayerInterfaceFactoryPart)
            if nextCountedLayerInterfaceFactory.getTotal() > 0 then
                if currentSlot = slotIndex then
                    jret <- nextCountedLayerInterfaceFactory
                    jflow <- 1
                else
                    currentSlot <- currentSlot + 1
            if jflow = 200003 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100003 then jflow <- 0
        if jflow = 0 then
            jret <- CountedLayerInterfaceFactoryPart.NULL_COUNTED_LAYER_INTERFACE_FACTORY
            jflow <- 1
        jret
    
    abstract getCountedIndex : unit -> int
    default this.getCountedIndex() : int =
        this.countedIndex
    interface PickupBehaviorInterface with
        member this.doPickup(jp0: PickupProcessorInterface) : unit = this.doPickup(jp0)
        member this.doPickupLayer(jp0: PickedUpLayerInterface) : unit = this.doPickupLayer(jp0)


