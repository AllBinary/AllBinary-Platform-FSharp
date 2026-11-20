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
type CollidableNeverCollideBehavior =
    inherit CollidableBaseBehavior
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableNeverCollideBehavior.jclinitDone then
            CollidableNeverCollideBehavior.jclinitDone <- true
            CollidableNeverCollideBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (isCollidable: bool) =
        { inherit CollidableBaseBehavior(isCollidable) }
    
    override this.isCollision(ownerLayer: CollidableCompositeLayer, allbinaryCollidableLayer: CollidableCompositeLayer) : bool =
        false
    
    override this.collide(ownerLayer: CollidableCompositeLayer, allbinaryCollidableLayer: CollidableCompositeLayer) : unit =
        ()
    
    override this.collideInterface(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface) : unit =
        ()
    
    override this.isCollisionInterface(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface) : bool =
        false


