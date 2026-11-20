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
type MotionGestureRecognizer =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable j2seMath : J2SEMath
    [<DefaultValue(false)>] val mutable origin : GPoint
    [<DefaultValue(false)>] val mutable previous : GPoint
    [<DefaultValue(false)>] val mutable intermediate : GPoint
    [<DefaultValue(false)>] val mutable line : Line
    [<DefaultValue(false)>] val mutable motionGesturesHandler : BasicMotionGesturesHandler
    [<DefaultValue(false)>] val mutable movedMotionGesturesHandler : BasicEventHandler
    [<DefaultValue(false)>] val mutable scrolledMotionGesturesHandler : BasicEventHandler
    [<DefaultValue(false)>] val mutable motionEventCircularPool : MotionEventCircularPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionGestureRecognizer.jclinitDone then
            MotionGestureRecognizer.jclinitDone <- true
            MotionGestureRecognizer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_MotionGestureRecognizer() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.j2seMath <- J2SEMath.getInstance()
        this.origin <- PointFactory.getInstance().ZERO_ZERO
        this.previous <- this.origin
        this.intermediate <- this.origin
        this.line <- (new Line(this.origin, this.origin))
        ()
    
    new (id_: int) as this =
        {  }
        then
            this.jfields_MotionGestureRecognizer()
            this.jctor1(id_)
    member this.jctor1(id_: int) : unit =
        this.motionEventCircularPool <- MotionEventCircularPool.createPool(id_)
        let mutable motionGesturesHandler : BasicEventHandler = (new BasicEventHandler())
        let mutable movedMotionGesturesHandler : BasicEventHandler = motionGesturesHandler
        let mutable scrolledMotionGesturesHandler : BasicEventHandler = motionGesturesHandler
        try
            motionGesturesHandler <- BasicMotionGesturesHandler.getInstance()
            movedMotionGesturesHandler <- MovedMotionGesturesHandler.getInstance()
            scrolledMotionGesturesHandler <- ScrolledMotionGesturesHandler.getInstance()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        this.motionGesturesHandler <- (box (motionGesturesHandler) :?> BasicMotionGesturesHandler)
        this.movedMotionGesturesHandler <- movedMotionGesturesHandler
        this.scrolledMotionGesturesHandler <- scrolledMotionGesturesHandler
        ()
    
    abstract processPressedMotionEvent : current: GPoint * deviceId: int * button: int -> bool
    default this.processPressedMotionEvent(current: GPoint, deviceId: int, button: int) : bool =
        this.intermediate <- this.origin
        this.previous <- this.origin
        let mutable event_ : MotionGestureEvent = this.motionEventCircularPool.getInstance(TouchMotionGestureFactory.getInstance().PRESSED)
        event_.setPreviousPoint(this.previous)
        event_.setCurrentPoint(current)
        this.motionGesturesHandler.fireEvent(event_)
        true
    
    abstract processReleasedMotionEvent : current: GPoint * deviceId: int * button: int -> bool
    default this.processReleasedMotionEvent(current: GPoint, deviceId: int, button: int) : bool =
        let mutable event_ : MotionGestureEvent = this.motionEventCircularPool.getInstance(TouchMotionGestureFactory.getInstance().RELEASED)
        event_.setPreviousPoint(this.previous)
        event_.setCurrentPoint(current)
        this.motionGesturesHandler.fireEvent(event_)
        true
    
    abstract processDraggedMotionEvent : current: GPoint * deviceId: int * buttonMask: int -> unit
    default this.processDraggedMotionEvent(current: GPoint, deviceId: int, buttonMask: int) : unit =
        let mutable jflow = 0
        if ((JR.same(this.previous, this.origin))) || ((JR.same(this.intermediate, this.origin))) then
            this.previous <- current
            this.intermediate <- current
            jflow <- 1
        if jflow = 0 then
            this.line.setP1(this.previous)
            this.line.setP2(current)
            let mutable minimumMotionGesture : int = MotionGestureConfigurationFactory.getInstance().getMinimumMotionGesture()
            if (this.j2seMath.abs(float32 (this.line.getDeltaX())) < float32 (minimumMotionGesture)) && (this.j2seMath.abs(float32 (this.line.getDeltaY())) < float32 (minimumMotionGesture)) then
                this.intermediate <- current
                jflow <- 1
            if jflow = 0 then
                let mutable gradient : float = this.line.getGradient()
                let mutable absGradient : float = float (this.j2seMath.abs(float32 (gradient)))
                let mutable conf : MotionGestureConfiguration = MotionGestureConfigurationFactory.getInstance()
                let mutable touchMotionGestureFactory : TouchMotionGestureFactory = TouchMotionGestureFactory.getInstance()
                let mutable newMotionGesture : MotionGestureInput = touchMotionGestureFactory.NO_MOTION
                let mutable diagonalToleranceHigher : float = 12.0
                let mutable diagonalToleranceLower : float = 12.0
                if conf.isDiagonalMotionGestureAllowed() then
                    diagonalToleranceHigher <- float ((90 - conf.getDiagonalTolerance()))
                    diagonalToleranceLower <- float (conf.getDiagonalTolerance())
                if absGradient > JMath.tan(JMath.toRadians(diagonalToleranceHigher)) then
                    if this.line.getDeltaY() > 0.0 then
                        newMotionGesture <- touchMotionGestureFactory.UP
                    else
                        newMotionGesture <- touchMotionGestureFactory.DOWN
                else
                    if absGradient < JMath.tan(JMath.toRadians(diagonalToleranceLower)) then
                        if this.line.getDeltaX() > 0.0 then
                            newMotionGesture <- touchMotionGestureFactory.LEFT
                        else
                            newMotionGesture <- touchMotionGestureFactory.RIGHT
                    else
                        if gradient > 0.0 then
                            if this.line.getDeltaX() > 0.0 then
                                newMotionGesture <- touchMotionGestureFactory.DIAGONAL_UP_LEFT
                            else
                                newMotionGesture <- touchMotionGestureFactory.DIAGONAL_DOWN_RIGHT
                        else
                            if this.line.getDeltaX() > 0.0 then
                                newMotionGesture <- touchMotionGestureFactory.DIAGONAL_DOWN_LEFT
                            else
                                newMotionGesture <- touchMotionGestureFactory.DIAGONAL_UP_RIGHT
                this.previous <- current
                this.intermediate <- current
                let mutable event_ : MotionGestureEvent = this.motionEventCircularPool.getInstance(newMotionGesture)
                event_.setPreviousPoint(this.previous)
                event_.setCurrentPoint(current)
                this.motionGesturesHandler.fireEvent(event_)
                jflow <- 1
    
    abstract processMovedMotionEvent : current: GPoint * deviceId: int * button: int -> bool
    default this.processMovedMotionEvent(current: GPoint, deviceId: int, button: int) : bool =
        let mutable event_ : MotionGestureEvent = this.motionEventCircularPool.getInstance(TouchMotionGestureFactory.getInstance().NO_MOTION)
        event_.setPreviousPoint(this.previous)
        event_.setCurrentPoint(current)
        this.movedMotionGesturesHandler.fireEvent(event_)
        true
    
    abstract processScrolledMotionEvent : current: GPoint * deviceId: int * button: int -> bool
    default this.processScrolledMotionEvent(current: GPoint, deviceId: int, button: int) : bool =
        let mutable touchMotionGestureFactory : TouchMotionGestureFactory = TouchMotionGestureFactory.getInstance()
        let mutable newMotionGesture : MotionGestureInput = touchMotionGestureFactory.NO_MOTION
        if button > 0 then
            newMotionGesture <- touchMotionGestureFactory.SCROLL_UP
        elif button < 0 then
            newMotionGesture <- touchMotionGestureFactory.SCROLL_DOWN
        let mutable event_ : MotionGestureEvent = this.motionEventCircularPool.getInstance(newMotionGesture)
        event_.setPreviousPoint(this.previous)
        event_.setCurrentPoint(current)
        this.scrolledMotionGesturesHandler.fireEvent(event_)
        true
    
    abstract getMotionGesturesHandler : unit -> BasicMotionGesturesHandler
    default this.getMotionGesturesHandler() : BasicMotionGesturesHandler =
        this.motionGesturesHandler


