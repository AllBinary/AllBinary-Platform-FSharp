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
type CompleteMotionGestureInputToGameMotionGestureInput =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : CompleteMotionGestureInputToGameMotionGestureInput
    static member instance with get() : CompleteMotionGestureInputToGameMotionGestureInput = (CompleteMotionGestureInputToGameMotionGestureInput.jclinit(); CompleteMotionGestureInputToGameMotionGestureInput.jcell_instance) and set (jvalue: CompleteMotionGestureInputToGameMotionGestureInput) = (CompleteMotionGestureInputToGameMotionGestureInput.jclinit(); CompleteMotionGestureInputToGameMotionGestureInput.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CompleteMotionGestureInputToGameMotionGestureInput.jclinitDone then
            CompleteMotionGestureInputToGameMotionGestureInput.jclinitDone <- true
            CompleteMotionGestureInputToGameMotionGestureInput.jclinitBody()
    static member private jclinitBody() : unit =
        CompleteMotionGestureInputToGameMotionGestureInput.jcell_instance <- (new CompleteMotionGestureInputToGameMotionGestureInput())
        ()
    new () as this =
        {  }
        then
            this.jfields_CompleteMotionGestureInputToGameMotionGestureInput()
    member this.jfields_CompleteMotionGestureInputToGameMotionGestureInput() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : CompleteMotionGestureInputToGameMotionGestureInput =
        CompleteMotionGestureInputToGameMotionGestureInput.instance
    
    abstract init : unit -> unit
    default this.init() : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        try
            PreLogUtil.put("Compound Motion Gestures", this, commonStrings.INIT)
            let mutable motionGestureConfiguration : MotionGestureConfiguration = MotionGestureConfigurationFactory.getInstance()
            let mutable touchMotionGestureFactory : TouchMotionGestureFactory = TouchMotionGestureFactory.getInstance()
            let mutable list_ : BasicArrayList = (new BasicArrayListD())
            ignore (list_.add(touchMotionGestureFactory.DIAGONAL_DOWN_LEFT))
            motionGestureConfiguration.addMotionGestureAction(list_, DiagonalDownLeftTouchInputToGameKeyEventAction.getInstance())
            list_ <- (new BasicArrayListD())
            ignore (list_.add(touchMotionGestureFactory.DIAGONAL_DOWN_RIGHT))
            motionGestureConfiguration.addMotionGestureAction(list_, DiagonalDownRightTouchInputToGameKeyEventAction.getInstance())
            list_ <- (new BasicArrayListD())
            ignore (list_.add(touchMotionGestureFactory.DIAGONAL_UP_LEFT))
            motionGestureConfiguration.addMotionGestureAction(list_, DiagonalUpLeftTouchInputToGameKeyEventAction.getInstance())
            list_ <- (new BasicArrayListD())
            ignore (list_.add(touchMotionGestureFactory.DIAGONAL_UP_RIGHT))
            motionGestureConfiguration.addMotionGestureAction(list_, DiagonalUpRightTouchInputToGameKeyEventAction.getInstance())
            list_ <- (new BasicArrayListD())
            ignore (list_.add(touchMotionGestureFactory.LEFT))
            motionGestureConfiguration.addMotionGestureAction(list_, LeftTouchInputToGameKeyEventAction.getInstance())
            list_ <- (new BasicArrayListD())
            ignore (list_.add(touchMotionGestureFactory.RIGHT))
            motionGestureConfiguration.addMotionGestureAction(list_, RightTouchInputToGameKeyEventAction.getInstance())
            list_ <- (new BasicArrayListD())
            ignore (list_.add(touchMotionGestureFactory.DOWN))
            motionGestureConfiguration.addMotionGestureAction(list_, DownTouchInputToGameKeyEventAction.getInstance())
            list_ <- (new BasicArrayListD())
            ignore (list_.add(touchMotionGestureFactory.UP))
            motionGestureConfiguration.addMotionGestureAction(list_, UpTouchInputToGameKeyEventAction.getInstance())
            list_ <- (new BasicArrayListD())
            ignore (list_.add(touchMotionGestureFactory.RELEASED))
            motionGestureConfiguration.addMotionGestureAction(list_, ReleaseTouchInputToGameKeyEventAction.getInstance())
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.INIT, e)
            | _ -> reraise ()


