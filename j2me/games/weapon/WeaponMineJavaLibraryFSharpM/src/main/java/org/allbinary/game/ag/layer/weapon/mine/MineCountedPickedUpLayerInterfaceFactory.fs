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
type MineCountedPickedUpLayerInterfaceFactory =
    inherit CountedPickedUpLayerInterfaceFactory
    [<DefaultValue(false)>] val mutable weaponLayerCircularStaticPool : WeaponLayerCircularPool
    [<DefaultValue(false)>] val mutable weaponProperties : WeaponProperties
    [<DefaultValue(false)>] val mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory
    [<DefaultValue(false)>] static val mutable private jcell_pickedUpLayerInterfaceFactoryInterface : PickedUpLayerInterfaceFactoryInterface
    static member pickedUpLayerInterfaceFactoryInterface with get() : PickedUpLayerInterfaceFactoryInterface = (MineCountedPickedUpLayerInterfaceFactory.jclinit(); MineCountedPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface) and set (jvalue: PickedUpLayerInterfaceFactoryInterface) = (MineCountedPickedUpLayerInterfaceFactory.jclinit(); MineCountedPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MineCountedPickedUpLayerInterfaceFactory.jclinitDone then
            MineCountedPickedUpLayerInterfaceFactory.jclinitDone <- true
            MineCountedPickedUpLayerInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        MineCountedPickedUpLayerInterfaceFactory.jcell_pickedUpLayerInterfaceFactoryInterface <- CountedPickedUpLayerInterfaceFactory.NULL_COUNTED_PICKUP_LAYER_FACTORY
        ()
    member this.jfields_MineCountedPickedUpLayerInterfaceFactory() : unit =
        this.weaponLayerCircularStaticPool <- MineLayerCircularStaticPool.getInstance()
        this.weaponProperties <- (new WeaponProperties(-1L, -1L, 0L, 8000, int16 (10)))
        this.smallIntegerSingletonFactory <- SmallIntegerSingletonFactory.getInstance()
        ()
    
    static member init() : unit =
        MineCountedPickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface <- (new MineCountedPickedUpLayerInterfaceFactory())
    
    new () as this =
        { inherit CountedPickedUpLayerInterfaceFactory(PickedUpLayerTypeFactory.getInstance().MINE, IconLayerFactory.getInstance(FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(MineWeaponResources.getInstance().DROP_ICON_RESOURCE).getInstance(0), 10, 10), FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(MineWeaponResources.getInstance().DROP_RESOURCE).getInstance(0)) }
        then
            this.jfields_MineCountedPickedUpLayerInterfaceFactory()
    
    static member getInstance() : PickedUpLayerInterfaceFactoryInterface =
        MineCountedPickedUpLayerInterfaceFactory.pickedUpLayerInterfaceFactoryInterface
    
    override this.getTotal() : int =
        3
    
    override this.getNextInstance(hashtable: ABHashtable, x: int, y: int, z: int) : AllBinaryLayer =
        let mutable sourceLayerInterface : AllBinaryLayer = (box (hashtable.get((box (this.smallIntegerSingletonFactory.getAt(0))))) :?> AllBinaryLayer)
        let mutable angle : Integer = (box (hashtable.get((box (this.smallIntegerSingletonFactory.getAt(1))))) :?> Integer)
        let mutable scoreableInterface : ScoreableInterface = (box (sourceLayerInterface) :?> ScoreableInterface)
        this.weaponLayerCircularStaticPool.getInstanceWeaponLayer(sourceLayerInterface, x, y, z, angle.intValue(), 0, this.weaponProperties, scoreableInterface)


