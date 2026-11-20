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
type CollidableDestroyableDamageableBehavior =
    inherit CollidableBaseBehavior
    [<DefaultValue(false)>] val mutable damageUtil : DamageUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableDestroyableDamageableBehavior.jclinitDone then
            CollidableDestroyableDamageableBehavior.jclinitDone <- true
            CollidableDestroyableDamageableBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CollidableDestroyableDamageableBehavior() : unit =
        this.damageUtil <- DamageUtil.getInstance()
        ()
    
    new (collidable: bool) as this =
        { inherit CollidableBaseBehavior(collidable) }
        then
            this.jfields_CollidableDestroyableDamageableBehavior()
    
    override this.isCollision(ownerLayer: CollidableCompositeLayer, collisionLayer: CollidableCompositeLayer) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if ownerLayer.getGroupInterface().[0] <> collisionLayer.getGroupInterface().[0] then
            jret <- base.isCollision(ownerLayer, collisionLayer)
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    override this.collide(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableCompositeLayer) : unit =
        let mutable ownerCollidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer = (box (ownerLayer) :?> CollidableDestroyableDamageableLayer)
        let mutable collidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer = (box (collidableInterfaceCompositeInterface) :?> CollidableDestroyableDamageableLayer)
        ownerCollidableDestroyableDamageableLayer.damage(collidableDestroyableDamageableLayer.getDamage(0), 0)
    
    override this.isCollisionInterface(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface) : bool =
        ForcedLogUtil.log("No Longer Used", this)
        false
    
    override this.collideInterface(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface) : unit =
        ForcedLogUtil.log("No Longer Used", this)


