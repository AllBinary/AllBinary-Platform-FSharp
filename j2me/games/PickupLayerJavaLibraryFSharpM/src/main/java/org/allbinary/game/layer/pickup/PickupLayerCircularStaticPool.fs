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
type PickupLayerCircularStaticPool =
    inherit AllBinaryLayerCircularPool
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : PickupLayerCircularStaticPool
    static member SINGLETON with get() : PickupLayerCircularStaticPool = (PickupLayerCircularStaticPool.jclinit(); PickupLayerCircularStaticPool.jcell_SINGLETON) and set (jvalue: PickupLayerCircularStaticPool) = (PickupLayerCircularStaticPool.jclinit(); PickupLayerCircularStaticPool.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PickupLayerCircularStaticPool.jclinitDone then
            PickupLayerCircularStaticPool.jclinitDone <- true
            PickupLayerCircularStaticPool.jclinitBody()
    static member private jclinitBody() : unit =
        PickupLayerCircularStaticPool.jcell_SINGLETON <- (new PickupLayerCircularStaticPool())
        ()
    
    new () =
        { inherit AllBinaryLayerCircularPool() }
    
    static member getInstance() : PickupLayerCircularStaticPool =
        PickupLayerCircularStaticPool.SINGLETON
    
    abstract getInstanceXYZ : pickedUpLayerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface * x: int * y: int * z: int -> PickedUpLayerInterface
    default this.getInstanceXYZ(pickedUpLayerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface, x: int, y: int, z: int) : PickedUpLayerInterface =
        let mutable pickupLayer : PickupLayer = (box (this.getNextInstance()) :?> PickupLayer)
        pickupLayer.initXYZ(x, y, z)
        pickupLayer.init(pickedUpLayerInterfaceFactoryInterface, pickedUpLayerInterfaceFactoryInterface.getAnimationInterface())
        pickupLayer


