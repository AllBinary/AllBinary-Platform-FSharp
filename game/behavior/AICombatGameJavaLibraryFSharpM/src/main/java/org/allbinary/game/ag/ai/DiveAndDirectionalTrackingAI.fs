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
type DiveAndDirectionalTrackingAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable mathUtil : MathUtil
    [<DefaultValue(false)>] val mutable directionFactory : DirectionFactory
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable directionalInterface : DirectionalInterface
    [<DefaultValue(false)>] val mutable velocityInterface : BasicVelocityProperties
    [<DefaultValue(false)>] val mutable directionToKeyMap : int[]
    [<DefaultValue(false)>] val mutable initialDropped : bool
    [<DefaultValue(false)>] val mutable diveP : bool
    [<DefaultValue(false)>] val mutable directionOfTarget : Direction
    [<DefaultValue(false)>] val mutable MIN_DISTANCE : int
    [<DefaultValue(false)>] val mutable lastTrackingLayerInterface : AllBinaryLayer
    [<DefaultValue(false)>] val mutable artificialIntelligenceInterface : ArtificialIntelligenceInterface
    [<DefaultValue(false)>] val mutable aiVistor : Visitor
    [<DefaultValue(false)>] val mutable lastDirection : Direction
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DiveAndDirectionalTrackingAI.jclinitDone then
            DiveAndDirectionalTrackingAI.jclinitDone <- true
            DiveAndDirectionalTrackingAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DiveAndDirectionalTrackingAI() : unit =
        this.mathUtil <- MathUtil.getInstance()
        this.directionFactory <- DirectionFactory.getInstance()
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        this.timeDelayHelper <- (new TimeDelayHelper(500))
        this.list <- (new BasicArrayListD())
        this.directionToKeyMap <- ([| Canvas.LEFT; Canvas.DOWN; Canvas.UP; Canvas.RIGHT |] : int[])
        this.directionOfTarget <- Direction.getInstance(0)
        this.MIN_DISTANCE <- 40
        this.lastTrackingLayerInterface <- AllBinaryLayer.NULL_ALLBINARY_LAYER
        this.lastDirection <- DirectionFactory.getInstance().NO_DIRECTION
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, artificialIntelligenceInterface: ArtificialIntelligenceInterface, gameInput: GameInput, visitor: Visitor) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_DiveAndDirectionalTrackingAI()
            this.jctor1(ownerLayerInterface, artificialIntelligenceInterface, gameInput, visitor)
    member this.jctor1(ownerLayerInterface: AllBinaryLayer, artificialIntelligenceInterface: ArtificialIntelligenceInterface, gameInput: GameInput, visitor: Visitor) : unit =
        ()
        this.aiVistor <- visitor
        this.artificialIntelligenceInterface <- artificialIntelligenceInterface
        let mutable directionalCompositeInterface : DirectionalCompositeInterface = (box (this.getOwnerLayerInterface()) :?> DirectionalCompositeInterface)
        this.directionalInterface <- directionalCompositeInterface.getDirectionalInterface()
        let mutable velocityInterfaceCompositeInterface : VelocityInterfaceCompositeInterface = (box (this.getOwnerLayerInterface()) :?> VelocityInterfaceCompositeInterface)
        this.velocityInterface <- velocityInterfaceCompositeInterface.getVelocityProperties()
        DestroyedEventHandler.getInstance().addListenerInterface(this)
        this.init()
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        if this.isBeyondTarget() then
            this.init()
            this.velocityInterface.zero()
        if not (this.diveP) then
            this.target(allBinaryLayerManager)
        else
            this.dive()
            this.attack()
        this.list.clear()
    
    member this.init() : unit =
        this.diveP <- false
        this.directionOfTarget <- DirectionFactory.getInstance().NOT_BORDERED_WITH
        TrackingEventHandler.getInstance().addListenerInterface(this)
    
    member this.target(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable jflow = 0
        if this.list.size() = 0 then
            jflow <- 1
        if jflow = 0 then
            let mutable lastTrackingEvent : TrackingEvent = (box (this.list.removeAt(0)) :?> TrackingEvent)
            this.lastTrackingLayerInterface <- lastTrackingEvent.getLayerInterface()
            let mutable layerInterface : AllBinaryLayer = this.lastTrackingLayerInterface
            let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
            let mutable groupArray : Group[] = layerInterface.getGroupInterface()
            let mutable ownerGroupArray : Group[] = ownerLayerInterface.getGroupInterface()
            if (JR.same(groupArray, ownerGroupArray)) then
                jflow <- 1
            if jflow = 0 then
                let mutable x : int = this.lastTrackingLayerInterface.getXP()
                let mutable y : int = this.lastTrackingLayerInterface.getYP()
                let mutable yDistance : int = (ownerLayerInterface.getYP() - y) - ownerLayerInterface.getHeight()
                let mutable xDistance : int = (ownerLayerInterface.getXP() - x) - ownerLayerInterface.getWidth()
                let mutable directionFactory : DirectionFactory = DirectionFactory.getInstance()
                if this.mathUtil.abs(yDistance) > this.mathUtil.abs(xDistance) then
                    if yDistance > this.MIN_DISTANCE then
                        this.directionOfTarget <- directionFactory.UP
                    elif yDistance < (-(this.MIN_DISTANCE)) then
                        this.directionOfTarget <- directionFactory.DOWN
                else
                    if xDistance > this.MIN_DISTANCE then
                        this.directionOfTarget <- directionFactory.LEFT
                    elif xDistance < (-(this.MIN_DISTANCE)) then
                        this.directionOfTarget <- directionFactory.RIGHT
                if (not (this.initialDropped)) && (not (JR.same(this.directionOfTarget, directionFactory.NOT_BORDERED_WITH))) then
                    this.drop()
                if this.initialDropped then
                    if ((JR.same(this.directionOfTarget, directionFactory.UP))) || ((JR.same(this.directionOfTarget, directionFactory.DOWN))) then
                        this.verticalTargeting(x)
                    elif ((JR.same(this.directionOfTarget, directionFactory.LEFT))) || ((JR.same(this.directionOfTarget, directionFactory.RIGHT))) then
                        this.horizontalTargeting(y)
                    else
                        this.artificialIntelligenceInterface.processAI(allBinaryLayerManager)
    
    member this.verticalTargeting(x: int) : unit =
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        if ownerLayerInterface.getXP() < x then
            this.moveRight()
        if ownerLayerInterface.getXP() > x then
            this.moveLeft()
        if (ownerLayerInterface.getXP() > (x - 3)) && (ownerLayerInterface.getXP() < (x + 3)) then
            this.setDive()
    
    member this.horizontalTargeting(y: int) : unit =
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        if ownerLayerInterface.getYP() < y then
            this.moveDown()
        if ownerLayerInterface.getYP() > y then
            this.moveUp()
        if (ownerLayerInterface.getYP() > (y - 3)) && (ownerLayerInterface.getYP() < (y + 3)) then
            this.setDive()
    
    member this.setDive() : unit =
        this.diveP <- true
        this.velocityInterface.zero()
        TrackingEventHandler.getInstance().removeListener(this)
    
    member this.moveRight() : unit =
        this.setLastDirection(this.directionFactory.RIGHT)
        this.directionalInterface.setFrameByDirection(this.lastDirection)
        ignore (this.aiVistor.visit(this))
    
    member this.moveLeft() : unit =
        this.setLastDirection(this.directionFactory.LEFT)
        this.directionalInterface.setFrameByDirection(this.lastDirection)
        ignore (this.aiVistor.visit(this))
    
    member this.moveDown() : unit =
        this.setLastDirection(this.directionFactory.DOWN)
        this.directionalInterface.setFrameByDirection(this.lastDirection)
        ignore (this.aiVistor.visit(this))
    
    member this.moveUp() : unit =
        this.setLastDirection(this.directionFactory.UP)
        this.directionalInterface.setFrameByDirection(this.lastDirection)
        ignore (this.aiVistor.visit(this))
    
    member this.dive() : unit =
        this.directionalInterface.setFrameByDirection(this.directionOfTarget)
        ignore (this.aiVistor.visit(this))
    
    member this.attack() : unit =
        base.processKeyAI(Canvas.KEY_NUM1)
    
    member this.drop() : unit =
        if this.timeDelayHelper.isTime(this.gameTickTimeDelayHelper.startTime) then
            this.initialDropped <- true
            ignore (this.aiVistor.visit(this))
    
    member this.isBeyondTarget() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(this.directionOfTarget, this.directionFactory.DOWN)) then
            if this.getOwnerLayerInterface().getYP() > (this.lastTrackingLayerInterface.getYP() + this.MIN_DISTANCE) then
                jret <- true
                jflow <- 1
            else
                jret <- false
                jflow <- 1
        elif (JR.same(this.directionOfTarget, this.directionFactory.UP)) then
            if this.getOwnerLayerInterface().getYP() < (this.lastTrackingLayerInterface.getYP() + this.MIN_DISTANCE) then
                jret <- true
                jflow <- 1
            else
                jret <- false
                jflow <- 1
        elif (JR.same(this.directionOfTarget, this.directionFactory.RIGHT)) then
            if this.getOwnerLayerInterface().getXP() > (this.lastTrackingLayerInterface.getXP() + this.MIN_DISTANCE) then
                jret <- true
                jflow <- 1
            else
                jret <- false
                jflow <- 1
        elif (JR.same(this.directionOfTarget, this.directionFactory.LEFT)) then
            if this.getOwnerLayerInterface().getXP() < (this.lastTrackingLayerInterface.getXP() + this.MIN_DISTANCE) then
                jret <- true
                jflow <- 1
            else
                jret <- false
                jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onMovement : trackingEvent: TrackingEvent -> unit
    default this.onMovement(trackingEvent: TrackingEvent) : unit =
        ignore (this.list.add(trackingEvent))
    
    abstract onDestroyed : destroyedEvent: DestroyedEvent -> unit
    default this.onDestroyed(destroyedEvent: DestroyedEvent) : unit =
        if (JR.same(this.getOwnerLayerInterface(), destroyedEvent.getLayerInterface())) then
            TrackingEventHandler.getInstance().removeListener(this)
            DestroyedEventHandler.getInstance().removeListener(this)
    
    abstract setLastDirection : lastDirection: Direction -> unit
    default this.setLastDirection(lastDirection: Direction) : unit =
        this.lastDirection <- lastDirection
        let mutable value : int = this.getLastDirection().getValue()
        if value < 4 then
            base.setLastKey(this.directionToKeyMap.[value])
    
    override this.setLastKey(lastKey: int) : unit =
        base.setLastKey(lastKey)
        if this.getLastKey() = Canvas.LEFT then
            this.lastDirection <- DirectionFactory.getInstance().LEFT
        elif this.getLastKey() = Canvas.DOWN then
            this.lastDirection <- DirectionFactory.getInstance().DOWN
        elif this.getLastKey() = Canvas.UP then
            this.lastDirection <- DirectionFactory.getInstance().UP
        elif this.getLastKey() = Canvas.RIGHT then
            this.lastDirection <- DirectionFactory.getInstance().RIGHT
    
    abstract getLastDirection : unit -> Direction
    default this.getLastDirection() : Direction =
        this.lastDirection
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(base.ToString()))
        ignore (stringBuffer.append(" LastDirection: "))
        ignore (stringBuffer.append(StringUtil.getInstance().toString(this.getLastDirection())))
        stringBuffer.ToString()
    interface TrackingEventListenerInterface with
        member this.onMovement(jp0: TrackingEvent) : unit = this.onMovement(jp0)
    interface DestroyedEventListenerInterface with
        member this.onDestroyed(jp0: DestroyedEvent) : unit = this.onDestroyed(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


