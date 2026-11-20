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
type MirrorMotionGestureEventUtil =
    [<DefaultValue(false)>] val mutable motionEventCircularPool : MotionEventCircularPool
    [<DefaultValue(false)>] static val mutable private jcell_instance : MirrorMotionGestureEventUtil
    static member instance with get() : MirrorMotionGestureEventUtil = (MirrorMotionGestureEventUtil.jclinit(); MirrorMotionGestureEventUtil.jcell_instance) and set (jvalue: MirrorMotionGestureEventUtil) = (MirrorMotionGestureEventUtil.jclinit(); MirrorMotionGestureEventUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MirrorMotionGestureEventUtil.jclinitDone then
            MirrorMotionGestureEventUtil.jclinitDone <- true
            MirrorMotionGestureEventUtil.jclinitBody()
    static member private jclinitBody() : unit =
        MirrorMotionGestureEventUtil.jcell_instance <- (new MirrorMotionGestureEventUtil())
        ()
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        this.motionEventCircularPool <- MotionEventCircularPool.createPool(Integer.MAX_VALUE)
        ()
    
    abstract mirrorVerticle : motionGestureEvent: MotionGestureEvent * halfWidth: int -> MotionGestureEvent
    default this.mirrorVerticle(motionGestureEvent: MotionGestureEvent, halfWidth: int) : MotionGestureEvent =
        let mutable event_ : MotionGestureEvent = this.motionEventCircularPool.getInstance(motionGestureEvent.getMotionGesture())
        let mutable previousNewX : int = this.getNewX(motionGestureEvent.getPreviousPoint().getX(), halfWidth)
        let mutable currentNewX : int = this.getNewX(motionGestureEvent.getCurrentPoint().getX(), halfWidth)
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable mirroredPreviousPoint : GPoint = pointFactory.createXY(previousNewX, motionGestureEvent.getPreviousPoint().getY())
        let mutable mirroredCurrentPoint : GPoint = pointFactory.createXY(currentNewX, motionGestureEvent.getCurrentPoint().getY())
        event_.setPreviousPoint(mirroredPreviousPoint)
        event_.setCurrentPoint(mirroredCurrentPoint)
        event_
    
    abstract getNewX : x: int * halfWidth: int -> int
    default this.getNewX(x: int, halfWidth: int) : int =
        let mutable newX : int = 0
        if x > halfWidth then
            newX <- halfWidth - (x - halfWidth)
        else
            newX <- halfWidth + (halfWidth - x)
        newX
    
    static member getInstance() : MirrorMotionGestureEventUtil =
        MirrorMotionGestureEventUtil.instance


