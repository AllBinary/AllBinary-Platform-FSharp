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
type CollidableDestroyableDamageableLayer =
    inherit CollidableCompositeLayer
    [<DefaultValue(false)>] val mutable groupInterface : Group[]
    [<DefaultValue(false)>] val mutable readyForExplosion : bool
    [<DefaultValue(false)>] val mutable initWidth : int
    [<DefaultValue(false)>] val mutable initHeight : int
    [<DefaultValue(false)>] val mutable initX : int
    [<DefaultValue(false)>] val mutable initY : int
    [<DefaultValue(false)>] val mutable initZ : int
    [<DefaultValue(false)>] val mutable partInterfaceArrayP : PartInterface[]
    [<DefaultValue(false)>] val mutable pickupBehavior : PickupBehavior
    [<DefaultValue(false)>] val mutable allBinaryGameLayerManagerP : AllBinaryGameLayerManager
    [<DefaultValue(false)>] val mutable isDraggable : bool
    [<DefaultValue(false)>] val mutable isDragged : bool
    [<DefaultValue(false)>] val mutable isDropped : bool
    [<DefaultValue(false)>] static val mutable private jcell_NULL_COLLIDABLE_DESTROYABLE_DAMAGE_LAYER : obj
    static member NULL_COLLIDABLE_DESTROYABLE_DAMAGE_LAYER with get() : obj = (CollidableDestroyableDamageableLayer.jclinit(); CollidableDestroyableDamageableLayer.jcell_NULL_COLLIDABLE_DESTROYABLE_DAMAGE_LAYER) and set (jvalue: obj) = (CollidableDestroyableDamageableLayer.jclinit(); CollidableDestroyableDamageableLayer.jcell_NULL_COLLIDABLE_DESTROYABLE_DAMAGE_LAYER <- jvalue)
    static member READYFOREXPLOSION : string = "ReadyForExplosion: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableDestroyableDamageableLayer.jclinitDone then
            CollidableDestroyableDamageableLayer.jclinitDone <- true
            CollidableDestroyableDamageableLayer.jclinitBody()
    static member private jclinitBody() : unit =
        CollidableDestroyableDamageableLayer.jcell_NULL_COLLIDABLE_DESTROYABLE_DAMAGE_LAYER <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_CollidableDestroyableDamageableLayer() : unit =
        this.partInterfaceArrayP <- PartInterfaceUtil.getZeroArray()
        this.allBinaryGameLayerManagerP <- AllBinaryGameLayerManager.getNullInstance()
        this.isDraggable <- false
        this.isDragged <- false
        this.isDropped <- false
        ()
    
    static member getNullInstance() : CollidableDestroyableDamageableLayer =
        if (JR.same(CollidableDestroyableDamageableLayer.NULL_COLLIDABLE_DESTROYABLE_DAMAGE_LAYER, NullUtil.getInstance().NULL_OBJECT)) then
            CollidableDestroyableDamageableLayer.NULL_COLLIDABLE_DESTROYABLE_DAMAGE_LAYER <- (new CollidableDestroyableDamageableLayer(BasicGroupFactory.getInstance().NONE_ARRAY, StringUtil.getInstance().EMPTY_STRING, RectangleFactory.SINGLETON, ViewPositionBase.NULL_VIEW_POSITION))
        (box (CollidableDestroyableDamageableLayer.NULL_COLLIDABLE_DESTROYABLE_DAMAGE_LAYER) :?> CollidableDestroyableDamageableLayer)
    
    new (groupInterface: Group[], name: string, layerInfo: Rectangle, viewPosition: ViewPositionBase) as this =
        { inherit CollidableCompositeLayer(name, layerInfo, viewPosition, CollidableNeverCollideBehaviorFactory.getInstance()) }
        then
            this.jfields_CollidableDestroyableDamageableLayer()
            this.jctor1(groupInterface, name, layerInfo, viewPosition)
    member this.jctor1(groupInterface: Group[], name: string, layerInfo: Rectangle, viewPosition: ViewPositionBase) : unit =
        ()
        this.initWidth <- layerInfo.getWidth()
        this.initHeight <- layerInfo.getHeight()
        this.groupInterface <- groupInterface
        this.pickupBehavior <- PickupBehavior.getNullInstance()
        ()
    
    abstract initPosition : unit -> unit
    default this.initPosition() : unit =
        this.setPosition(this.initX, this.initY, this.initZ)
    
    abstract initPositionXYZ : x: int * y: int * z: int -> unit
    default this.initPositionXYZ(x: int, y: int, z: int) : unit =
        this.initX <- x
        this.initY <- y
        this.initZ <- z
    
    override this.paint(graphics: Graphics) : unit =
        base.paint(graphics)
    
    abstract damage : damage: int * damageType: int -> unit
    default this.damage(damage: int, damageType: int) : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract getDamage : damageType: int -> int
    default this.getDamage(damageType: int) : int =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract isDestroyed : unit -> bool
    default this.isDestroyed() : bool =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    override this.getGroupInterface() : Group[] =
        this.groupInterface
    
    abstract setGroupInterface : teamInterface: Group[] -> unit
    default this.setGroupInterface(teamInterface: Group[]) : unit =
        this.groupInterface <- teamInterface
    
    abstract setAllBinaryGameLayerManager : allBinaryGameLayerManager: AllBinaryGameLayerManager -> unit
    default this.setAllBinaryGameLayerManager(allBinaryGameLayerManager: AllBinaryGameLayerManager) : unit =
        this.allBinaryGameLayerManagerP <- allBinaryGameLayerManager
        if (JR.same(this.allBinaryGameLayerManagerP, null)) then
            raise ((new JRuntimeException()))
    
    member this.isReadyForExplosion() : bool =
        this.readyForExplosion
    
    member this.setReadyForExplosion(isReadyForExplosion: bool) : unit =
        this.readyForExplosion <- isReadyForExplosion
    
    abstract getInitWidth : unit -> int
    default this.getInitWidth() : int =
        this.initWidth
    
    abstract getInitHeight : unit -> int
    default this.getInitHeight() : int =
        this.initHeight
    
    abstract getInitX : unit -> int
    default this.getInitX() : int =
        this.initX
    
    abstract getInitY : unit -> int
    default this.getInitY() : int =
        this.initY
    
    abstract up : unit -> unit
    default this.up() : unit =
        ()
    
    abstract down : unit -> unit
    default this.down() : unit =
        ()
    
    abstract right : unit -> unit
    default this.right() : unit =
        ()
    
    abstract left : unit -> unit
    default this.left() : unit =
        ()
    
    abstract strafeLeft : unit -> unit
    default this.strafeLeft() : unit =
        ()
    
    abstract strafeRight : unit -> unit
    default this.strafeRight() : unit =
        ()
    
    abstract fire : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.fire(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special1 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special1(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special2 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special2(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special3 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special3(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special4 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special4(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special5 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special5(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract upAnalog : yAnalogValue: int -> unit
    default this.upAnalog(yAnalogValue: int) : unit =
        ()
    
    abstract downAnalog : yAnalogValue: int -> unit
    default this.downAnalog(yAnalogValue: int) : unit =
        ()
    
    abstract rightAnalog : xAnalogValue: int -> unit
    default this.rightAnalog(xAnalogValue: int) : unit =
        ()
    
    abstract leftAnalog : xAnalogValue: int -> unit
    default this.leftAnalog(xAnalogValue: int) : unit =
        ()
    
    abstract rightTrigger : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent * xAnalogValue: int -> unit
    default this.rightTrigger(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent, xAnalogValue: int) : unit =
        ()
    
    abstract leftTrigger : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent * xAnalogValue: int -> unit
    default this.leftTrigger(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent, xAnalogValue: int) : unit =
        ()
    
    abstract onDestroyed : destroyedEvent: DestroyedEvent -> unit
    default this.onDestroyed(destroyedEvent: DestroyedEvent) : unit =
        ()
    
    abstract getPickupBehavior : unit -> PickupBehavior
    default this.getPickupBehavior() : PickupBehavior =
        this.pickupBehavior
    
    abstract setPickupBehavior : pickupBehavior: PickupBehavior -> unit
    default this.setPickupBehavior(pickupBehavior: PickupBehavior) : unit =
        this.pickupBehavior <- pickupBehavior
    
    abstract addPart : pickedUpLayerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface -> unit
    default this.addPart(pickedUpLayerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface) : unit =
        ()
    
    abstract setPartInterfaceArray : partInterfaceArray: PartInterface[] -> unit
    default this.setPartInterfaceArray(partInterfaceArray: PartInterface[]) : unit =
        this.partInterfaceArrayP <- partInterfaceArray
    
    abstract getPartInterfaceArray : unit -> PartInterface[]
    default this.getPartInterfaceArray() : PartInterface[] =
        this.partInterfaceArrayP
    
    override this.toStringAppend(stringBuffer: StringMaker) : unit =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        let mutable positionStrings : PositionStrings = PositionStrings.getInstance()
        base.toStringAppend(stringBuffer)
        ignore (stringBuffer.append(commonSeps.NEW_LINE))
        let mutable groupInterfaceArray : Group[] = this.getGroupInterface()
        let mutable size : int = groupInterfaceArray.Length
        let mutable index : int = 0
        while index < size do
            ignore (stringBuffer.append(groupInterfaceArray.[index].ToString()))
            ignore (stringBuffer.append(commonSeps.COMMA))
            index <- index + 1
        let mutable pickupBehavior : PickupBehavior = this.getPickupBehavior()
        if not (JR.same(pickupBehavior, null)) then
            ignore (stringBuffer.append(commonSeps.NEW_LINE))
            ignore (stringBuffer.append(pickupBehavior.ToString()))
        ignore (stringBuffer.append(commonSeps.NEW_LINE))
        ignore (stringBuffer.append(CollidableDestroyableDamageableLayer.READYFOREXPLOSION))
        ignore (stringBuffer.appendboolean(this.readyForExplosion))
        ignore (stringBuffer.append(commonSeps.NEW_LINE))
        ignore (stringBuffer.append(this.commonStrings.INIT))
        ignore (stringBuffer.append(commonSeps.SPACE))
        ignore (stringBuffer.append(positionStrings.X_LABEL))
        ignore (stringBuffer.appendint(this.initX))
        ignore (stringBuffer.append(positionStrings.Y_LABEL))
        ignore (stringBuffer.appendint(this.initX))
        ignore (stringBuffer.append(positionStrings.Z_LABEL))
        ignore (stringBuffer.appendint(this.initZ))
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        this.toStringAppend(stringBuffer)
        stringBuffer.ToString()
    interface DestroyableInterface with
        member this.isDestroyed() : bool = this.isDestroyed()
    interface DamageableInterface with
        member this.damage(jp0: int, jp1: int) : unit = this.damage(jp0, jp1)
        member this.getDamage(jp0: int) : int = this.getDamage(jp0)
    interface PickupCompositeInterface with
        member this.getPickupBehavior() : PickupBehavior = this.getPickupBehavior()
        member this.setPickupBehavior(jp0: PickupBehavior) : unit = this.setPickupBehavior(jp0)
    interface SpecialGameInputInterface with
        member this.up() : unit = this.up()
        member this.down() : unit = this.down()
        member this.right() : unit = this.right()
        member this.left() : unit = this.left()
        member this.strafeLeft() : unit = this.strafeLeft()
        member this.strafeRight() : unit = this.strafeRight()
        member this.fire(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.fire(jp0, jp1)
        member this.special1(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special1(jp0, jp1)
        member this.special2(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special2(jp0, jp1)
        member this.special3(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special3(jp0, jp1)
        member this.special4(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special4(jp0, jp1)
        member this.special5(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special5(jp0, jp1)
    interface NamedInterface with
        member this.getName() : string = this.getName()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)


