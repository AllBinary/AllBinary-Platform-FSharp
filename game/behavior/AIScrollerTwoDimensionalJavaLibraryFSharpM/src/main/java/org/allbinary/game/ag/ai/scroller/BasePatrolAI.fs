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
type BasePatrolAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable maxDistance : Integer
    [<DefaultValue(false)>] val mutable currentDistance : int
    [<DefaultValue(false)>] val mutable xTotalDistance : int
    [<DefaultValue(false)>] val mutable lastKeyDirection : int
    [<DefaultValue(false)>] val mutable keyDirection : int
    [<DefaultValue(false)>] static val mutable private jcell_MAX_DISTANCE : Integer
    static member MAX_DISTANCE with get() : Integer = (BasePatrolAI.jclinit(); BasePatrolAI.jcell_MAX_DISTANCE) and set (jvalue: Integer) = (BasePatrolAI.jclinit(); BasePatrolAI.jcell_MAX_DISTANCE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_DIRECTION_ARRAY : Integer
    static member DIRECTION_ARRAY with get() : Integer = (BasePatrolAI.jclinit(); BasePatrolAI.jcell_DIRECTION_ARRAY) and set (jvalue: Integer) = (BasePatrolAI.jclinit(); BasePatrolAI.jcell_DIRECTION_ARRAY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_FIRING_DISTANCE : Integer
    static member FIRING_DISTANCE with get() : Integer = (BasePatrolAI.jclinit(); BasePatrolAI.jcell_FIRING_DISTANCE) and set (jvalue: Integer) = (BasePatrolAI.jclinit(); BasePatrolAI.jcell_FIRING_DISTANCE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_SPEED : Integer
    static member SPEED with get() : Integer = (BasePatrolAI.jclinit(); BasePatrolAI.jcell_SPEED) and set (jvalue: Integer) = (BasePatrolAI.jclinit(); BasePatrolAI.jcell_SPEED <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasePatrolAI.jclinitDone then
            BasePatrolAI.jclinitDone <- true
            BasePatrolAI.jclinitBody()
    static member private jclinitBody() : unit =
        BasePatrolAI.jcell_MAX_DISTANCE <- SmallIntegerSingletonFactory.getInstance().getAt(2)
        BasePatrolAI.jcell_DIRECTION_ARRAY <- SmallIntegerSingletonFactory.getInstance().getAt(3)
        BasePatrolAI.jcell_FIRING_DISTANCE <- SmallIntegerSingletonFactory.getInstance().getAt(4)
        BasePatrolAI.jcell_SPEED <- SmallIntegerSingletonFactory.getInstance().getAt(5)
        ()
    member this.jfields_BasePatrolAI() : unit =
        this.lastKeyDirection <- Canvas.RIGHT
        this.keyDirection <- Canvas.RIGHT
        ()
    
    new (hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_BasePatrolAI()
            this.jctor1(hashtable, ownerLayerInterface, gameInput)
    member this.jctor1(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.maxDistance <- (box (hashtable.get(BasePatrolAI.MAX_DISTANCE)) :?> Integer)
        this.currentDistance <- this.maxDistance.intValue()
        ()
    
    abstract update : unit -> unit
    default this.update() : unit =
        this.updateTotalDistance()
        this.changeDirectionIfReachedPacingAreaMax()
    
    member this.updateTotalDistance() : unit =
        let mutable velocityInterfaceCompositeInterface : VelocityInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> VelocityInterfaceCompositeInterface)
        let mutable velocityProperties : BasicVelocityProperties = velocityInterfaceCompositeInterface.getVelocityProperties()
        this.xTotalDistance <- this.xTotalDistance + velocityProperties.getVelocityXBasicDecimalP().getScaled()
    
    member this.changeDirectionIfReachedPacingAreaMax() : unit =
        let mutable mathUtil : MathUtil = MathUtil.getInstance()
        let mutable totalDistance : int = mathUtil.abs(this.xTotalDistance)
        if totalDistance > this.currentDistance then
            this.nextDirection()
    
    abstract nextDirection : unit -> unit
    default this.nextDirection() : unit =
        if this.lastKeyDirection = Canvas.LEFT then
            this.keyDirection <- Canvas.RIGHT
            this.lastKeyDirection <- this.keyDirection
            this.xTotalDistance <- 0
        elif this.lastKeyDirection = Canvas.RIGHT then
            this.keyDirection <- Canvas.LEFT
            this.lastKeyDirection <- this.keyDirection
            this.xTotalDistance <- 0
    
    abstract disable : unit -> unit
    default this.disable() : unit =
        ()


