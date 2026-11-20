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
type GestureOnlyMotionRecognizer =
    inherit MotionRecognizer
    [<DefaultValue(false)>] val mutable motionGestureRecognizer : MotionGestureRecognizer
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] static val mutable private jcell_index : int
    static member index with get() : int = (GestureOnlyMotionRecognizer.jclinit(); GestureOnlyMotionRecognizer.jcell_index) and set (jvalue: int) = (GestureOnlyMotionRecognizer.jclinit(); GestureOnlyMotionRecognizer.jcell_index <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_pointCircularPool : GPointCircularPool
    static member pointCircularPool with get() : GPointCircularPool = (GestureOnlyMotionRecognizer.jclinit(); GestureOnlyMotionRecognizer.jcell_pointCircularPool) and set (jvalue: GPointCircularPool) = (GestureOnlyMotionRecognizer.jclinit(); GestureOnlyMotionRecognizer.jcell_pointCircularPool <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GestureOnlyMotionRecognizer.jclinitDone then
            GestureOnlyMotionRecognizer.jclinitDone <- true
            GestureOnlyMotionRecognizer.jclinitBody()
    static member private jclinitBody() : unit =
        GestureOnlyMotionRecognizer.jcell_index <- 0
        GestureOnlyMotionRecognizer.jcell_pointCircularPool <- (new GPointCircularPool(40))
        ()
    
    new () as this =
        { inherit MotionRecognizer() }
        then
            this.jctor1()
    member this.jctor1() : unit =
        this.id <- (let jt = GestureOnlyMotionRecognizer.index in GestureOnlyMotionRecognizer.index <- GestureOnlyMotionRecognizer.index + 1; jt)
        this.motionGestureRecognizer <- (new MotionGestureRecognizer(this.id))
        ()
    
    override this.processStartMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        let mutable point : CustomGPoint = (box (GestureOnlyMotionRecognizer.pointCircularPool.getNextInstance()) :?> CustomGPoint)
        point.setX(x)
        point.setY(y)
        ignore (this.motionGestureRecognizer.processPressedMotionEvent(point, deviceId, modifiers))
    
    override this.processEndMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        let mutable point : CustomGPoint = (box (GestureOnlyMotionRecognizer.pointCircularPool.getNextInstance()) :?> CustomGPoint)
        point.setX(x)
        point.setY(y)
        ignore (this.motionGestureRecognizer.processReleasedMotionEvent(point, deviceId, modifiers))
    
    override this.processDraggedMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        let mutable point : CustomGPoint = (box (GestureOnlyMotionRecognizer.pointCircularPool.getNextInstance()) :?> CustomGPoint)
        point.setX(x)
        point.setY(y)
        this.motionGestureRecognizer.processDraggedMotionEvent(point, deviceId, modifiers)


