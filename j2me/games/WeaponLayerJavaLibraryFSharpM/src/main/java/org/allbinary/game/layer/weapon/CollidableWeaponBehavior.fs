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
type CollidableWeaponBehavior =
    inherit CollidableDestroyableDamageableBehavior
    [<DefaultValue(false)>] val mutable collided : bool
    [<DefaultValue(false)>] val mutable collisionHelper : CollisionHelper
    [<DefaultValue(false)>] static val mutable private jcell_NULL_COLLIDABLE_WEAPON_BEHAVIOR : obj
    static member NULL_COLLIDABLE_WEAPON_BEHAVIOR with get() : obj = (CollidableWeaponBehavior.jclinit(); CollidableWeaponBehavior.jcell_NULL_COLLIDABLE_WEAPON_BEHAVIOR) and set (jvalue: obj) = (CollidableWeaponBehavior.jclinit(); CollidableWeaponBehavior.jcell_NULL_COLLIDABLE_WEAPON_BEHAVIOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableWeaponBehavior.jclinitDone then
            CollidableWeaponBehavior.jclinitDone <- true
            CollidableWeaponBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        CollidableWeaponBehavior.jcell_NULL_COLLIDABLE_WEAPON_BEHAVIOR <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getNullInstance() : CollidableWeaponBehavior =
        if (JR.same(CollidableWeaponBehavior.NULL_COLLIDABLE_WEAPON_BEHAVIOR, NullUtil.getInstance().NULL_OBJECT)) then
            CollidableWeaponBehavior.NULL_COLLIDABLE_WEAPON_BEHAVIOR <- (new CollidableWeaponBehavior(false))
        (box (CollidableWeaponBehavior.NULL_COLLIDABLE_WEAPON_BEHAVIOR) :?> CollidableWeaponBehavior)
    
    new (collidable: bool) as this =
        { inherit CollidableDestroyableDamageableBehavior(collidable) }
        then
            this.jctor1(collidable)
    member this.jctor1(collidable: bool) : unit =
        ()
        this.setCollided(false)
        this.setCollidable(true)
        this.collisionHelper <- CollidableHelperFactory.getInstance()
        ()
    
    abstract init : sourceLayerInterface: AllBinaryLayer -> unit
    default this.init(sourceLayerInterface: AllBinaryLayer) : unit =
        this.setCollided(false)
        this.collisionHelper.setOwnerLayerInterface(sourceLayerInterface)
    
    override this.isCollision(ownerLayer: CollidableCompositeLayer, collisionLayer: CollidableCompositeLayer) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.collisionHelper.isCollidable(collisionLayer) then
            if ownerLayer.getGroupInterface().[0] <> collisionLayer.getGroupInterface().[0] then
                jret <- base.isCollision(ownerLayer, collisionLayer)
                jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    override this.collide(ownerLayer: CollidableCompositeLayer, collisionLayer: CollidableCompositeLayer) : unit =
        base.collide(ownerLayer, collisionLayer)
        this.collided <- true
    
    override this.isCollisionInterface(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.collisionHelper.isCollidable((box (collidableInterfaceCompositeInterface) :?> CollidableCompositeLayer)) then
            let mutable layerInterface : AllBinaryLayer = (box (collidableInterfaceCompositeInterface) :?> AllBinaryLayer)
            if ownerLayer.getGroupInterface().[0] <> layerInterface.getGroupInterface().[0] then
                if this.layerCollisionUtil.isCollision(ownerLayer, layerInterface) then
                    jret <- true
                    jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    override this.collideInterface(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface) : unit =
        let mutable ownerDamageableInterface : DamageableInterface = (box (ownerLayer) :?> DamageableInterface)
        let mutable damageableInterface : DamageableInterface = (box (collidableInterfaceCompositeInterface) :?> DamageableInterface)
        this.damageUtil.process_(ownerDamageableInterface, damageableInterface)
        this.collided <- true
    
    override this.getCollisionTypeWith(layerInterface: AllBinaryLayer) : CollisionType =
        CollisionTypeFactory.getInstance().COLLISION
    
    abstract isCollided : unit -> bool
    default this.isCollided() : bool =
        this.collided
    
    member this.setCollided(collided: bool) : unit =
        this.collided <- collided


