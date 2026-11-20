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
type CompleteMotionGestureInputEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable motionGestureInput : MotionGestureInput
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CompleteMotionGestureInputEvent.jclinitDone then
            CompleteMotionGestureInputEvent.jclinitDone <- true
            CompleteMotionGestureInputEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CompleteMotionGestureInputEvent() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.name <- StringUtil.getInstance().EMPTY_STRING
        this.motionGestureInput <- TouchMotionGestureFactory.getInstance().NO_MOTION
        ()
    
    new (name: string, motionGestureInput: MotionGestureInput) as this =
        { inherit AllBinaryEventObject(motionGestureInput) }
        then
            this.jfields_CompleteMotionGestureInputEvent()
            this.jctor1(name, motionGestureInput)
    member this.jctor1(name: string, motionGestureInput: MotionGestureInput) : unit =
        ()
        this.setName(name)
        try
            this.setMotionGestureInput(motionGestureInput)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "InputToGameKeyEventAction", e)
            | _ -> reraise ()
        ()
    
    abstract setName : name: string -> unit
    default this.setName(name: string) : unit =
        this.name <- name
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract setMotionGestureInput : motionGestureInput: MotionGestureInput -> unit
    default this.setMotionGestureInput(motionGestureInput: MotionGestureInput) : unit =
        this.motionGestureInput <- motionGestureInput
    
    abstract getMotionGestureInput : unit -> MotionGestureInput
    default this.getMotionGestureInput() : MotionGestureInput =
        this.motionGestureInput
    interface CompleteMotionGestureInputInterface
    interface NamedInterface with
        member this.getName() : string = this.getName()


