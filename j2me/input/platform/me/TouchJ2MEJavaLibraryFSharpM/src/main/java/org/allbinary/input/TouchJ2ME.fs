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
type TouchJ2ME =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable DEVICE_ID : int
    [<DefaultValue(false)>] val mutable motionRecognizer : AllMotionRecognizer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchJ2ME.jclinitDone then
            TouchJ2ME.jclinitDone <- true
            TouchJ2ME.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TouchJ2ME() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.DEVICE_ID <- 0
        this.motionRecognizer <- (new AllMotionRecognizer())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_TouchJ2ME()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable motionGesturesHandler : BasicMotionGesturesHandler = this.motionRecognizer.getMotionGestureRecognizer().getMotionGesturesHandler()
        motionGesturesHandler.addListenerInterface((new GameMotionGestureListener(MotionGestureReceiveInterfaceFactory.getInstance())))
        ()
    
    abstract pointerDragged : x: int * y: int -> unit
    default this.pointerDragged(x: int, y: int) : unit =
        try
            this.motionRecognizer.processDraggedMotionEvent(x, y, this.DEVICE_ID, 0)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "pointerDragged", e)
            | _ -> reraise ()
    
    abstract pointerPressed : x: int * y: int -> unit
    default this.pointerPressed(x: int, y: int) : unit =
        try
            this.motionRecognizer.processStartMotionEvent(x, y, this.DEVICE_ID, 0)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "pointerPressed", e)
            | _ -> reraise ()
    
    abstract pointerReleased : x: int * y: int -> unit
    default this.pointerReleased(x: int, y: int) : unit =
        try
            this.motionRecognizer.processEndMotionEvent(x, y, this.DEVICE_ID, 0)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "pointerReleased", e)
            | _ -> reraise ()


