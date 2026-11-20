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
type AllMotionRecognizer =
    inherit MotionRecognizer
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable motionGestureRecognizer : MotionGestureRecognizer
    [<DefaultValue(false)>] val mutable touchButtonProcessing : bool
    [<DefaultValue(false)>] val mutable touchButtonRecognizer : TouchButtonRecognizer
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] val mutable lastX : int
    [<DefaultValue(false)>] val mutable lastY : int
    [<DefaultValue(false)>] static val mutable private jcell_index : int
    static member index with get() : int = (AllMotionRecognizer.jclinit(); AllMotionRecognizer.jcell_index) and set (jvalue: int) = (AllMotionRecognizer.jclinit(); AllMotionRecognizer.jcell_index <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_pointCircularPool : GPointCircularPool
    static member pointCircularPool with get() : GPointCircularPool = (AllMotionRecognizer.jclinit(); AllMotionRecognizer.jcell_pointCircularPool) and set (jvalue: GPointCircularPool) = (AllMotionRecognizer.jclinit(); AllMotionRecognizer.jcell_pointCircularPool <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllMotionRecognizer.jclinitDone then
            AllMotionRecognizer.jclinitDone <- true
            AllMotionRecognizer.jclinitBody()
    static member private jclinitBody() : unit =
        AllMotionRecognizer.jcell_index <- 0
        AllMotionRecognizer.jcell_pointCircularPool <- (new GPointCircularPool(40))
        ()
    member this.jfields_AllMotionRecognizer() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.touchButtonProcessing <- false
        ()
    
    new () as this =
        { inherit MotionRecognizer() }
        then
            this.jfields_AllMotionRecognizer()
            this.jctor1()
    member this.jctor1() : unit =
        this.id <- (let jt = AllMotionRecognizer.index in AllMotionRecognizer.index <- AllMotionRecognizer.index + 1; jt)
        this.motionGestureRecognizer <- (new MotionGestureRecognizer(this.id))
        this.touchButtonRecognizer <- (new TouchButtonRecognizer())
        ()
    
    override this.processStartMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        if this.touchButtonRecognizer.pressTouchButtonInput(x, y, deviceId) then
            this.touchButtonProcessing <- true
        if not (this.touchButtonProcessing) then
            let mutable point : CustomGPoint = (box (AllMotionRecognizer.pointCircularPool.getNextInstance()) :?> CustomGPoint)
            point.setX(x)
            point.setY(y)
            ignore (this.motionGestureRecognizer.processPressedMotionEvent(point, deviceId, modifiers))
    
    override this.processEndMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        if this.touchButtonRecognizer.releaseTouchButtonInput(x, y, deviceId) then
            ()
        if not (this.touchButtonProcessing) then
            let mutable point : CustomGPoint = (box (AllMotionRecognizer.pointCircularPool.getNextInstance()) :?> CustomGPoint)
            point.setX(x)
            point.setY(y)
            ignore (this.motionGestureRecognizer.processReleasedMotionEvent(point, deviceId, modifiers))
        if this.touchButtonProcessing then
            this.touchButtonProcessing <- false
    
    override this.processDraggedMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        if this.touchButtonProcessing then
            ignore (this.touchButtonRecognizer.pressTouchButtonInput(x, y, deviceId))
        if not (this.touchButtonProcessing) then
            let mutable point : CustomGPoint = (box (AllMotionRecognizer.pointCircularPool.getNextInstance()) :?> CustomGPoint)
            point.setX(x)
            point.setY(y)
            this.motionGestureRecognizer.processDraggedMotionEvent(point, deviceId, modifiers)
    
    abstract processMovedMotionEvent : x: int * y: int * deviceId: int * modifiers: int -> unit
    default this.processMovedMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        if (x <> this.lastX) || (y <> this.lastY) then
            this.lastX <- x
            this.lastY <- y
            let mutable point : CustomGPoint = (box (AllMotionRecognizer.pointCircularPool.getNextInstance()) :?> CustomGPoint)
            point.setX(x)
            point.setY(y)
            ignore (this.motionGestureRecognizer.processMovedMotionEvent(point, deviceId, modifiers))
    
    abstract processScrolledMotionEvent : x: int * y: int * deviceId: int * modifiers: int -> unit
    default this.processScrolledMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        let mutable point : CustomGPoint = (box (AllMotionRecognizer.pointCircularPool.getNextInstance()) :?> CustomGPoint)
        point.setX(x)
        point.setY(y)
        ignore (this.motionGestureRecognizer.processScrolledMotionEvent(point, deviceId, modifiers))
    
    member this.getMotionGestureRecognizer() : MotionGestureRecognizer =
        this.motionGestureRecognizer


