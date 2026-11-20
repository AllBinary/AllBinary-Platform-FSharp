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
type BasicMenuInputProcessor =
    inherit PlayerGameInput
    [<DefaultValue(false)>] val mutable motionGestureEventList : BasicArrayList
    [<DefaultValue(false)>] val mutable canvas : Canvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicMenuInputProcessor.jclinitDone then
            BasicMenuInputProcessor.jclinitDone <- true
            BasicMenuInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicMenuInputProcessor() : unit =
        this.motionGestureEventList <- (new BasicArrayListD())
        this.canvas <- NullCanvas.NULL_CANVAS
        ()
    
    new (gameKeyEventList: BasicArrayList, playerInputId: int, gameCanvas: Canvas) as this =
        { inherit PlayerGameInput(gameKeyEventList, (new BasicArrayListD()), playerInputId) }
        then
            this.jfields_BasicMenuInputProcessor()
            this.jctor1(gameKeyEventList, playerInputId, gameCanvas)
    member this.jctor1(gameKeyEventList: BasicArrayList, playerInputId: int, gameCanvas: Canvas) : unit =
        ()
        this.canvas <- gameCanvas
        ()
    
    abstract onMotionGestureEvent : motionGestureEvent: MotionGestureEvent -> unit
    default this.onMotionGestureEvent(motionGestureEvent: MotionGestureEvent) : unit =
        ignore (this.motionGestureEventList.add(motionGestureEvent))
    
    abstract onScrolledMotionGestureEvent : motionGestureEvent: MotionGestureEvent -> unit
    default this.onScrolledMotionGestureEvent(motionGestureEvent: MotionGestureEvent) : unit =
        ()
    
    member this.setCanvas(canvas: MyCanvas) : unit =
        this.canvas <- canvas
    
    abstract getCanvas : unit -> MyCanvas
    default this.getCanvas() : MyCanvas =
        (box (this.canvas) :?> MyCanvas)
    
    abstract processInputList : unit -> int
    default this.processInputList() : int =
        -1
    interface BaseMotionGestureEventListener with
        member this.onMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onMotionGestureEvent(jp0)
        member this.onScrolledMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onScrolledMotionGestureEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


