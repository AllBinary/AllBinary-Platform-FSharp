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
type BasicWeaponPartCircularPool =
    [<DefaultValue(false)>] val mutable basicWeaponPart : BasicWeaponPart
    [<DefaultValue(false)>] static val mutable private jcell_NULL_BASIC_WEAPON_PART_CIRCULAR_POOL : BasicWeaponPartCircularPool
    static member NULL_BASIC_WEAPON_PART_CIRCULAR_POOL with get() : BasicWeaponPartCircularPool = (BasicWeaponPartCircularPool.jclinit(); BasicWeaponPartCircularPool.jcell_NULL_BASIC_WEAPON_PART_CIRCULAR_POOL) and set (jvalue: BasicWeaponPartCircularPool) = (BasicWeaponPartCircularPool.jclinit(); BasicWeaponPartCircularPool.jcell_NULL_BASIC_WEAPON_PART_CIRCULAR_POOL <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicWeaponPartCircularPool.jclinitDone then
            BasicWeaponPartCircularPool.jclinitDone <- true
            BasicWeaponPartCircularPool.jclinitBody()
    static member private jclinitBody() : unit =
        BasicWeaponPartCircularPool.jcell_NULL_BASIC_WEAPON_PART_CIRCULAR_POOL <- (new BasicWeaponPartCircularPool())
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicWeaponPartCircularPool()
    member this.jfields_BasicWeaponPartCircularPool() : unit =
        this.basicWeaponPart <- BasicWeaponPart.NULL_BASIC_WEAPON_PART
        ()
    
    abstract init : basicWeaponPartFactoryInterface: BasicWeaponPartFactoryInterface -> unit
    default this.init(basicWeaponPartFactoryInterface: BasicWeaponPartFactoryInterface) : unit =
        this.basicWeaponPart <- basicWeaponPartFactoryInterface.getInstance()
    
    abstract getInstance : sourceLayerInterface: AllBinaryLayer * weaponProperties: WeaponProperties * scoreableInterface: ScoreableInterface * relativeRelationship: RelativeRelationship -> BasicWeaponPart
    default this.getInstance(sourceLayerInterface: AllBinaryLayer, weaponProperties: WeaponProperties, scoreableInterface: ScoreableInterface, relativeRelationship: RelativeRelationship) : BasicWeaponPart =
        this.basicWeaponPart.init(sourceLayerInterface, weaponProperties, scoreableInterface, relativeRelationship)
        this.basicWeaponPart


