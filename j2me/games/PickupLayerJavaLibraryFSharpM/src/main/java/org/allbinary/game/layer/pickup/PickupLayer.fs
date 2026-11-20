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
type PickupLayer =
    inherit MultiPlayerGameLayer
    [<DefaultValue(false)>] val mutable pickedUpLayerInterfaceFactoryInterface : PickedUpLayerInterfaceFactoryInterface
    [<DefaultValue(false)>] val mutable destroyed : bool
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PickupLayer.jclinitDone then
            PickupLayer.jclinitDone <- true
            PickupLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PickupLayer() : unit =
        this.pickedUpLayerInterfaceFactoryInterface <- CountedPickedUpLayerInterfaceFactory.NULL_COUNTED_PICKUP_LAYER_FACTORY
        this.animationInterface <- NullAnimationFactory.getFactoryInstance().getInstance(0)
        ()
    
    new (name: string, remoteInfo: RemoteInfo, total: int, pickedUpLayerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface, animationInterface: Animation, rectangle: Rectangle, viewPosition: ViewPositionBase) as this =
        { inherit MultiPlayerGameLayer(remoteInfo, BasicGroupFactory.getInstance().NONE_ARRAY, name, rectangle, viewPosition) }
        then
            this.jfields_PickupLayer()
            this.jctor1(name, remoteInfo, total, pickedUpLayerInterfaceFactoryInterface, animationInterface, rectangle, viewPosition)
    member this.jctor1(name: string, remoteInfo: RemoteInfo, total: int, pickedUpLayerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface, animationInterface: Animation, rectangle: Rectangle, viewPosition: ViewPositionBase) : unit =
        ()
        this.setCollidableInferface(CollidableAlwaysPickupNeverCollideBehaviorFactory.getInstance().createBehavior())
        this.setLayerWidth(10)
        this.setLayerHeight(10)
        this.init(pickedUpLayerInterfaceFactoryInterface, animationInterface)
        ()
    
    abstract init : pickedUpLayerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface * animationInterface: Animation -> unit
    default this.init(pickedUpLayerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface, animationInterface: Animation) : unit =
        this.pickedUpLayerInterfaceFactoryInterface <- pickedUpLayerInterfaceFactoryInterface
        this.animationInterface <- animationInterface
        this.setDestroyed(false)
    
    abstract initXYZ : x: int * y: int * z: int -> unit
    default this.initXYZ(x: int, y: int, z: int) : unit =
        this.setPosition(x, y, z)
    
    override this.paint(graphics: Graphics) : unit =
        let mutable viewPosition : ViewPositionBase = this.getViewPosition()
        let mutable viewX : int = viewPosition.getX()
        let mutable viewY : int = viewPosition.getY()
        this.animationInterface.paintXY(graphics, viewX, viewY)
    
    override this.paintThreed(graphics: Graphics) : unit =
        let mutable viewPosition : ViewPositionBase = this.getViewPosition()
        let mutable viewX : int = viewPosition.getX()
        let mutable viewY : int = viewPosition.getY()
        this.animationInterface.paintThreedXYZ(graphics, viewX, viewY, 3)
    
    abstract getPickedUpLayerInterfaceFactoryInterface : unit -> PickedUpLayerInterfaceFactoryInterface
    default this.getPickedUpLayerInterfaceFactoryInterface() : PickedUpLayerInterfaceFactoryInterface =
        this.pickedUpLayerInterfaceFactoryInterface
    
    abstract setPickedUp : unit -> unit
    default this.setPickedUp() : unit =
        this.setDestroyed(true)
    
    override this.isDestroyed() : bool =
        this.destroyed
    
    abstract setDestroyed : destroyed: bool -> unit
    default this.setDestroyed(destroyed: bool) : unit =
        this.destroyed <- destroyed
        if this.isDestroyed() then
            ignore (DestroyedLayerProcessor.getInstance().add(this))
    
    override this.damage(damage: int, damageType: int) : unit =
        ()
    
    override this.getDamage(damageType: int) : int =
        0
    
    override this.set(gl: GL) : unit =
        let mutable openGLSurfaceChangedInterface : OpenGLSurfaceChangedInterface = (box (this.animationInterface) :?> OpenGLSurfaceChangedInterface)
        openGLSurfaceChangedInterface.set(gl)
    interface PickedUpLayerInterface with
        member this.getPickedUpLayerInterfaceFactoryInterface() : PickedUpLayerInterfaceFactoryInterface = this.getPickedUpLayerInterfaceFactoryInterface()
        member this.setPickedUp() : unit = this.setPickedUp()
    interface PickupableInterface
    interface LayerInterface with
        member this.getHeight() : int = this.getHeight()
        member this.getWidth() : int = this.getWidth()
        member this.getHalfHeight() : int = this.getHalfHeight()
        member this.getHalfWidth() : int = this.getHalfWidth()
        member this.getXP() : int = this.getXP()
        member this.getYP() : int = this.getYP()
        member this.getZP() : int = this.getZP()
        member this.getX2() : int = this.getX2()
        member this.getY2() : int = this.getY2()
        member this.getZ2() : int = this.getZ2()
        member this.isVisible() : bool = this.isVisible()
        member this.moveDXYZ(jp0: int, jp1: int, jp2: int) : unit = this.moveDXYZ(jp0, jp1, jp2)
        member this.setVisible(jp0: bool) : unit = this.setVisible(jp0)
        member this.implmentsTickableInterface() : bool = this.implmentsTickableInterface()
        member this.implmentsCollidableInterface() : bool = this.implmentsCollidableInterface()
        member this.implmentsGameInputInterface() : bool = this.implmentsGameInputInterface()
        member this.implmentsArtificialIntelligenceCompositeInterface() : bool = this.implmentsArtificialIntelligenceCompositeInterface()
        member this.getType() : int = this.getType()
    interface NamedInterface with
        member this.getName() : string = this.getName()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)
    interface GroupInterfaceCompositeInterface with
        member this.getGroupInterface() : Group[] = this.getGroupInterface()
    interface PositionInterface with
        member this.setPosition(jp0: int, jp1: int, jp2: int) : unit = this.setPosition(jp0, jp1, jp2)


