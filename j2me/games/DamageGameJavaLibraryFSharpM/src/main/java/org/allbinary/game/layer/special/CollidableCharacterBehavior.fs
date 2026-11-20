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
type CollidableCharacterBehavior =
    inherit CollidableDestroyableDamageableBehavior
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableCharacterBehavior.jclinitDone then
            CollidableCharacterBehavior.jclinitDone <- true
            CollidableCharacterBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (collidable: bool) =
        { inherit CollidableDestroyableDamageableBehavior(collidable) }
    
    override this.collide(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableCompositeLayer) : unit =
        let mutable collisionTypeFactory : CollisionTypeFactory = CollisionTypeFactory.getInstance()
        let mutable collisionType : CollisionType = collidableInterfaceCompositeInterface.getCollidableInferface().getCollisionTypeWith(ownerLayer)
        if (JR.same(collisionType, collisionTypeFactory.PICKUP)) then
            let mutable collidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer = (box (ownerLayer) :?> CollidableDestroyableDamageableLayer)
            collidableDestroyableDamageableLayer.getPickupBehavior().doPickupLayer((box (collidableInterfaceCompositeInterface) :?> PickedUpLayerInterface))
        else
            base.collide(ownerLayer, collidableInterfaceCompositeInterface)
    
    override this.collideInterface(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface) : unit =
        ForcedLogUtil.log(this.commonStrings.NOT_IMPLEMENTED, this)


