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
type CollidableDamageWeaponBehavior =
    inherit CollidableDestroyableDamageableBehavior
    [<DefaultValue(false)>] val mutable collided : bool
    [<DefaultValue(false)>] val mutable collisionHelper : CollisionHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableDamageWeaponBehavior.jclinitDone then
            CollidableDamageWeaponBehavior.jclinitDone <- true
            CollidableDamageWeaponBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
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
        this.damageUtil.process_((box (ownerLayer) :?> DamageableInterface), (box (collidableInterfaceCompositeInterface) :?> DamageableInterface))
        this.collided <- true
    
    override this.getCollisionTypeWith(layerInterface: AllBinaryLayer) : CollisionType =
        CollisionTypeFactory.getInstance().COLLISION
    
    abstract isCollided : unit -> bool
    default this.isCollided() : bool =
        this.collided
    
    member this.setCollided(collided: bool) : unit =
        this.collided <- collided


