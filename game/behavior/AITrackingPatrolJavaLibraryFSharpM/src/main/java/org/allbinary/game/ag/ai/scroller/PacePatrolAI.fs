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
type PacePatrolAI =
    inherit BasePatrolAI
    [<DefaultValue(false)>] val mutable trackingList : BasicArrayList
    [<DefaultValue(false)>] val mutable firingDistance : int
    [<DefaultValue(false)>] val mutable isFollowLimitedByTerrain : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PacePatrolAI.jclinitDone then
            PacePatrolAI.jclinitDone <- true
            PacePatrolAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PacePatrolAI() : unit =
        this.isFollowLimitedByTerrain <- false
        ()
    
    new (hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasePatrolAI(hashtable, ownerLayerInterface, gameInput) }
        then
            this.jfields_PacePatrolAI()
            this.jctor1(hashtable, ownerLayerInterface, gameInput)
    member this.jctor1(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        TrackingEventHandler.getInstance().addListenerInterface(this)
        this.trackingList <- (new BasicArrayListD())
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        this.update()
        let mutable direction : Direction = this.setFiringDirectionForTargetIfInRange()
        let mutable directionFactory : DirectionFactory = DirectionFactory.getInstance()
        if (JR.same(direction, directionFactory.LEFT)) then
            if (this.lastKeyDirection <> this.keyDirection) || (not (this.isFollowLimitedByTerrain)) then
                base.processKeyAI(Canvas.LEFT)
            this.keyDirection <- Canvas.LEFT
            this.lastKeyDirection <- this.keyDirection
            this.xTotalDistance <- 0
            base.processKeyAI(Canvas.KEY_NUM1)
        elif (JR.same(direction, directionFactory.RIGHT)) then
            if (this.lastKeyDirection <> this.keyDirection) || (not (this.isFollowLimitedByTerrain)) then
                base.processKeyAI(Canvas.RIGHT)
            this.keyDirection <- Canvas.RIGHT
            this.lastKeyDirection <- this.keyDirection
            this.xTotalDistance <- 0
            base.processKeyAI(Canvas.KEY_NUM1)
        else
            base.processKeyAI(this.keyDirection)
    
    member this.setFiringDirectionForTargetIfInRange() : Direction =
        let mutable directionFactory : DirectionFactory = DirectionFactory.getInstance()
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable direction : Direction = directionFactory.NOT_BORDERED_WITH
        let mutable lastTrackingEvent : TrackingEvent = null
        let mutable lastTrackingLayerInterface : LayerInterface = null
        let mutable directionCompositeInterface : DirectionCompositeInterface = null
        let mutable size : int = this.trackingList.size()
        let mutable index : int = 0
        while index < size do
            lastTrackingEvent <- (box (this.trackingList.get(0)) :?> TrackingEvent)
            lastTrackingLayerInterface <- lastTrackingEvent.getLayerInterface()
            let mutable x : int = lastTrackingLayerInterface.getXP()
            let mutable y : int = lastTrackingLayerInterface.getYP()
            let mutable yDistance : int = (ownerLayerInterface.getYP() - y) - ownerLayerInterface.getHeight()
            let mutable xDistance : int = (ownerLayerInterface.getXP() - x) - ownerLayerInterface.getWidth()
            let mutable absXDistance : int = JMath.abs(xDistance)
            let mutable absYDistance : int = JMath.abs(yDistance)
            if absYDistance <= 100 then
                if absXDistance < (this.getFiringDistance() / 2) then
                    directionCompositeInterface <- (box (this.getOwnerLayerInterface()) :?> DirectionCompositeInterface)
                    if (xDistance < 0) && ((JR.same(directionCompositeInterface.getDirection(), directionFactory.RIGHT))) then
                        direction <- directionFactory.RIGHT
                    elif (xDistance > 0) && ((JR.same(directionCompositeInterface.getDirection(), directionFactory.LEFT))) then
                        direction <- directionFactory.LEFT
            index <- index + 1
        direction
    
    override this.disable() : unit =
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onMovement : trackingEvent: TrackingEvent -> unit
    default this.onMovement(trackingEvent: TrackingEvent) : unit =
        this.trackingList.clear()
        ignore (this.trackingList.add(trackingEvent))
    
    abstract getFiringDistance : unit -> int
    default this.getFiringDistance() : int =
        this.firingDistance
    
    abstract setFiringDistance : firingDistance: int -> unit
    default this.setFiringDistance(firingDistance: int) : unit =
        this.firingDistance <- firingDistance
    interface TrackingEventListenerInterface with
        member this.onMovement(jp0: TrackingEvent) : unit = this.onMovement(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


