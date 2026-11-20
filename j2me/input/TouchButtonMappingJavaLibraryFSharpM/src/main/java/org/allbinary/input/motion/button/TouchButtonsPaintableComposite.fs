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
type TouchButtonsPaintableComposite =
    inherit ProcessPaintable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable inputMappingInterface : InputMappingInterface
    [<DefaultValue(false)>] val mutable touchButtonsPaintable : TouchButtonsMappingPaintable
    [<DefaultValue(false)>] val mutable timeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable released : bool
    [<DefaultValue(false)>] val mutable METHOD_NAME : string
    [<DefaultValue(false)>] val mutable RELEASE : string
    [<DefaultValue(false)>] val mutable FAST_REPEAT : string
    [<DefaultValue(false)>] val mutable IGNORE : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonsPaintableComposite.jclinitDone then
            TouchButtonsPaintableComposite.jclinitDone <- true
            TouchButtonsPaintableComposite.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TouchButtonsPaintableComposite() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.timeHelper <- (new TimeDelayHelper(250))
        this.released <- true
        this.METHOD_NAME <- "onCompleteMotionGestureInputEvent"
        this.RELEASE <- "Ignoring: MotionGestureInput Release"
        this.FAST_REPEAT <- "Ignoring: MotionGestureInput Repeated To Quickly"
        this.IGNORE <- "Ignoring: Until Released"
        ()
    
    new (inputMappingInterface: InputMappingInterface, basicColor: BasicColor) as this =
        { inherit ProcessPaintable() }
        then
            this.jfields_TouchButtonsPaintableComposite()
            this.jctor1(inputMappingInterface, basicColor)
    member this.jctor1(inputMappingInterface: InputMappingInterface, basicColor: BasicColor) : unit =
        this.inputMappingInterface <- inputMappingInterface
        CompleteMotionGestureInputEventHandler.getInstance().addListenerInterface(this)
        this.touchButtonsPaintable <- (new TouchButtonsMappingPaintable(basicColor))
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onCompleteMotionGestureInputEvent : completeMotionGestureInputEvent: CompleteMotionGestureInputEvent -> unit
    default this.onCompleteMotionGestureInputEvent(completeMotionGestureInputEvent: CompleteMotionGestureInputEvent) : unit =
        let mutable jflow = 0
        try
            this.logUtil.putF(this.commonStrings.START, this, "onCompleteMotionGestureInputEvent")
            let mutable touchMotionGestureFactory : TouchMotionGestureFactory = TouchMotionGestureFactory.getInstance()
            let mutable gameKeyCompleteMotionGestureInputEvent : GameKeyCompleteMotionGestureInputEvent = (box (completeMotionGestureInputEvent) :?> GameKeyCompleteMotionGestureInputEvent)
            let mutable gameKey : GameKey = gameKeyCompleteMotionGestureInputEvent.getGameKey()
            let mutable motionGestureInput : MotionGestureInput = completeMotionGestureInputEvent.getMotionGestureInput()
            if (JR.same(motionGestureInput, touchMotionGestureFactory.RELEASED)) then
                this.logUtil.putF(this.RELEASE, this, this.METHOD_NAME)
                this.released <- true
                jflow <- 1
            if jflow = 0 then
                if ((JR.same(motionGestureInput, TouchMotionGestureFactory.getInstance().NO_MOTION))) && (not (this.timeHelper.isTimeTNT())) then
                    this.logUtil.putF(this.FAST_REPEAT, this, this.METHOD_NAME)
                    jflow <- 1
                if jflow = 0 then
                    if not (this.released) then
                        this.logUtil.putF(this.IGNORE, this, this.METHOD_NAME)
                        jflow <- 1
                    if jflow = 0 then
                        this.released <- false
                        this.logUtil.putF((new StringMaker()).append("GameKey: ").append(StringUtil.getInstance().toString(gameKey)).append(" MotionGestureInput: ").append(StringUtil.getInstance().toString(motionGestureInput)).ToString(), this, this.METHOD_NAME)
                        this.inputMappingInterface.processInputMapping(gameKey, motionGestureInput)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.METHOD_NAME, e)
            | _ -> reraise ()
    
    override this.process_() : unit =
        CompleteMotionGestureInputEventHandler.getInstance().removeListener(this)
    interface CompleteMotionGestureInputEventListenerInterface with
        member this.onCompleteMotionGestureInputEvent(jp0: CompleteMotionGestureInputEvent) : unit = this.onCompleteMotionGestureInputEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


