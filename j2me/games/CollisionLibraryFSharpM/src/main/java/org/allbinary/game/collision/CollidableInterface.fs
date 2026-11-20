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
type CollidableInterface =
    inherit NamedInterface
    abstract isCollidable : ownerLayer: CollidableCompositeLayer -> bool
    abstract isCollision : ownerLayer: CollidableCompositeLayer * collidableInterfaceCompositeInterface: CollidableCompositeLayer -> bool
    abstract collide : ownerLayer: CollidableCompositeLayer * collidableInterfaceCompositeInterface: CollidableCompositeLayer -> unit
    abstract getCollisionTypeWith : layerInterface: AllBinaryLayer -> CollisionType


