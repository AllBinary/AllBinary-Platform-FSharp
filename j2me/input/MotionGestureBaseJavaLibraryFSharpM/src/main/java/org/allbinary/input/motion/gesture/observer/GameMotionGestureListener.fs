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
type GameMotionGestureListener =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable motionGestureCollection : BasicArrayList
    [<DefaultValue(false)>] val mutable touchGestureCollection : BasicArrayList
    [<DefaultValue(false)>] val mutable signed : CompleteMotionGestureListenerInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameMotionGestureListener.jclinitDone then
            GameMotionGestureListener.jclinitDone <- true
            GameMotionGestureListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameMotionGestureListener() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.motionGestureCollection <- (new BasicArrayListD())
        this.touchGestureCollection <- (new BasicArrayListD())
        ()
    
    new (signed: CompleteMotionGestureListenerInterface) as this =
        {  }
        then
            this.jfields_GameMotionGestureListener()
            this.jctor1(signed)
    member this.jctor1(signed: CompleteMotionGestureListenerInterface) : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        this.signed <- signed
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(this.commonStrings.NOT_IMPLEMENTED, this)
    
    abstract onUpMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onUpMotionGestureEvent(ev: MotionGestureEvent) : unit =
        this.onMotionGestureEvent(ev)
    
    abstract onDownMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onDownMotionGestureEvent(ev: MotionGestureEvent) : unit =
        this.onMotionGestureEvent(ev)
    
    abstract onLeftMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onLeftMotionGestureEvent(ev: MotionGestureEvent) : unit =
        this.onMotionGestureEvent(ev)
    
    abstract onRightMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onRightMotionGestureEvent(ev: MotionGestureEvent) : unit =
        this.onMotionGestureEvent(ev)
    
    abstract onDiagonalDownRightMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onDiagonalDownRightMotionGestureEvent(ev: MotionGestureEvent) : unit =
        this.onMotionGestureEvent(ev)
    
    abstract onDiagonalDownLeftMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onDiagonalDownLeftMotionGestureEvent(ev: MotionGestureEvent) : unit =
        this.onMotionGestureEvent(ev)
    
    abstract onDiagonalUpRightMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onDiagonalUpRightMotionGestureEvent(ev: MotionGestureEvent) : unit =
        this.onMotionGestureEvent(ev)
    
    abstract onDiagonalUpLeftMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onDiagonalUpLeftMotionGestureEvent(ev: MotionGestureEvent) : unit =
        this.onMotionGestureEvent(ev)
    
    abstract onPressedMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onPressedMotionGestureEvent(ev: MotionGestureEvent) : unit =
        ignore (this.touchGestureCollection.add(ev.getMotionGesture()))
    
    abstract released : ev: MotionGestureEvent -> unit
    default this.released(ev: MotionGestureEvent) : unit =
        try
            ignore (this.touchGestureCollection.add(ev.getMotionGesture()))
            this.signed.onMotionGestureCompleted(this.touchGestureCollection)
            this.touchGestureCollection.clear()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable stringBuffer : StringMaker = (new StringMaker())
                ignore (stringBuffer.append(this.commonStrings.EXCEPTION_LABEL))
                ignore (stringBuffer.append(StringUtil.getInstance().toString(ev.getMotionGesture())))
                this.logUtil.put(stringBuffer.ToString(), this, "release", e)
            | _ -> reraise ()
    
    abstract onScrolledMotionGestureEvent : motionGestureEvent: MotionGestureEvent -> unit
    default this.onScrolledMotionGestureEvent(motionGestureEvent: MotionGestureEvent) : unit =
        ()
    
    abstract onMotionGestureEvent : ev: MotionGestureEvent -> unit
    default this.onMotionGestureEvent(ev: MotionGestureEvent) : unit =
        try
            let mutable motionGestureInput : MotionGestureInput = ev.getMotionGesture()
            if (JR.same(motionGestureInput, TouchMotionGestureFactory.getInstance().PRESSED)) then
                this.onPressedMotionGestureEvent(ev)
            elif (JR.same(motionGestureInput, TouchMotionGestureFactory.getInstance().RELEASED)) then
                this.released(ev)
            else
                ignore (this.motionGestureCollection.add(motionGestureInput))
                this.signed.onMotionGestureCompleted(this.motionGestureCollection)
                this.motionGestureCollection.clear()
                this.touchGestureCollection.clear()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable stringBuffer : StringMaker = (new StringMaker())
                ignore (stringBuffer.append(this.commonStrings.EXCEPTION_LABEL))
                ignore (stringBuffer.append(StringUtil.getInstance().toString(ev.getMotionGesture())))
                this.logUtil.put(stringBuffer.ToString(), this, "onMotionGestureEvent", e)
            | _ -> reraise ()
    interface MotionGestureEventListener with
        member this.onPressedMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onPressedMotionGestureEvent(jp0)
        member this.onUpMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onUpMotionGestureEvent(jp0)
        member this.onDownMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onDownMotionGestureEvent(jp0)
        member this.onLeftMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onLeftMotionGestureEvent(jp0)
        member this.onRightMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onRightMotionGestureEvent(jp0)
        member this.onDiagonalDownRightMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onDiagonalDownRightMotionGestureEvent(jp0)
        member this.onDiagonalDownLeftMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onDiagonalDownLeftMotionGestureEvent(jp0)
        member this.onDiagonalUpRightMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onDiagonalUpRightMotionGestureEvent(jp0)
        member this.onDiagonalUpLeftMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onDiagonalUpLeftMotionGestureEvent(jp0)
        member this.released(jp0: MotionGestureEvent) : unit = this.released(jp0)
    interface BaseMotionGestureEventListener with
        member this.onMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onMotionGestureEvent(jp0)
        member this.onScrolledMotionGestureEvent(jp0: MotionGestureEvent) : unit = this.onScrolledMotionGestureEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


