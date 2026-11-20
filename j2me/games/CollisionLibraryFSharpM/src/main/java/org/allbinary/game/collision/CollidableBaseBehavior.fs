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
type CollidableBaseBehavior =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable layerCollisionUtil : LayerCollisionUtil
    [<DefaultValue(false)>] val mutable collidable : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableBaseBehavior.jclinitDone then
            CollidableBaseBehavior.jclinitDone <- true
            CollidableBaseBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CollidableBaseBehavior() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.layerCollisionUtil <- LayerCollisionUtil.getInstance()
        this.collidable <- true
        ()
    
    new (collidable: bool) as this =
        {  }
        then
            this.jfields_CollidableBaseBehavior()
            this.jctor1(collidable)
    member this.jctor1(collidable: bool) : unit =
        this.collidable <- collidable
        ()
    
    abstract update : unit -> unit
    default this.update() : unit =
        ()
    
    abstract getName : unit -> string
    default this.getName() : string =
        JR.getClass(this)
    
    abstract setCollidable : collidable: bool -> unit
    default this.setCollidable(collidable: bool) : unit =
        this.collidable <- collidable
    
    abstract isCollidable : ownerLayer: CollidableCompositeLayer -> bool
    default this.isCollidable(ownerLayer: CollidableCompositeLayer) : bool =
        this.collidable
    
    abstract collide : ownerLayer: CollidableCompositeLayer * allbinaryCollidableLayer: CollidableCompositeLayer -> unit
    default this.collide(ownerLayer: CollidableCompositeLayer, allbinaryCollidableLayer: CollidableCompositeLayer) : unit =
        raise ((new JException((new StringMaker()).append(this.commonStrings.NOT_IMPLEMENTED).append(CommonLabels.getInstance().COLON_SEP).append(JR.getClass(this)).ToString())))
    
    abstract isCollision : ownerLayer: CollidableCompositeLayer * collisionLayer: CollidableCompositeLayer -> bool
    default this.isCollision(ownerLayer: CollidableCompositeLayer, collisionLayer: CollidableCompositeLayer) : bool =
        this.layerCollisionUtil.isCollision(ownerLayer, collisionLayer)
    
    abstract isCollisionInterface : ownerLayer: CollidableCompositeLayer * collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface -> bool
    default this.isCollisionInterface(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface) : bool =
        this.layerCollisionUtil.isCollision(ownerLayer, (box (collidableInterfaceCompositeInterface) :?> AllBinaryLayer))
    
    abstract collideInterface : ownerLayer: CollidableCompositeLayer * collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface -> unit
    default this.collideInterface(ownerLayer: CollidableCompositeLayer, collidableInterfaceCompositeInterface: CollidableInterfaceCompositeInterface) : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract paint : ownerLayer: CollidableCompositeLayer * graphics: Graphics -> unit
    default this.paint(ownerLayer: CollidableCompositeLayer, graphics: Graphics) : unit =
        ()
    
    abstract getCollisionTypeWith : layerInterface: AllBinaryLayer -> CollisionType
    default this.getCollisionTypeWith(layerInterface: AllBinaryLayer) : CollisionType =
        CollisionTypeFactory.getInstance().NONE
    interface CollidableInterface with
        member this.isCollidable(jp0: CollidableCompositeLayer) : bool = this.isCollidable(jp0)
        member this.isCollision(jp0: CollidableCompositeLayer, jp1: CollidableCompositeLayer) : bool = this.isCollision(jp0, jp1)
        member this.collide(jp0: CollidableCompositeLayer, jp1: CollidableCompositeLayer) : unit = this.collide(jp0, jp1)
        member this.getCollisionTypeWith(jp0: AllBinaryLayer) : CollisionType = this.getCollisionTypeWith(jp0)
    interface NamedInterface with
        member this.getName() : string = this.getName()


