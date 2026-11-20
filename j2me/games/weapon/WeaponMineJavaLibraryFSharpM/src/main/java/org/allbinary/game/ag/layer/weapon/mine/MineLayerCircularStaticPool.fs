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
type MineLayerCircularStaticPool =
    [<DefaultValue(false)>] static val mutable private jcell_WEAPON_LAYER_CIRCULAR_STATIC_POOL : WeaponLayerCircularPool
    static member WEAPON_LAYER_CIRCULAR_STATIC_POOL with get() : WeaponLayerCircularPool = (MineLayerCircularStaticPool.jclinit(); MineLayerCircularStaticPool.jcell_WEAPON_LAYER_CIRCULAR_STATIC_POOL) and set (jvalue: WeaponLayerCircularPool) = (MineLayerCircularStaticPool.jclinit(); MineLayerCircularStaticPool.jcell_WEAPON_LAYER_CIRCULAR_STATIC_POOL <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MineLayerCircularStaticPool.jclinitDone then
            MineLayerCircularStaticPool.jclinitDone <- true
            MineLayerCircularStaticPool.jclinitBody()
    static member private jclinitBody() : unit =
        MineLayerCircularStaticPool.jcell_WEAPON_LAYER_CIRCULAR_STATIC_POOL <- (new WeaponLayerCircularPool())
        ()
    new () =
        {  }
    
    static member init(viewPositionFactoryInterface: ViewPositionFactoryInterface) : unit =
        MineCountedPickedUpLayerInterfaceFactory.init()
        MineLayerCircularStaticPool.WEAPON_LAYER_CIRCULAR_STATIC_POOL.initAllBinaryLayerCircularPool((new MineLayerFactory(viewPositionFactoryInterface)), 20)
    
    static member getInstance() : WeaponLayerCircularPool =
        MineLayerCircularStaticPool.WEAPON_LAYER_CIRCULAR_STATIC_POOL


