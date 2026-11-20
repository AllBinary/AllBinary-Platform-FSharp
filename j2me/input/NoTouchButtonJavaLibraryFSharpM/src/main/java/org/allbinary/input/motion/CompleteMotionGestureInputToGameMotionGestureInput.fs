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
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
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
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    static member getInstance() : CompleteMotionGestureInputToGameMotionGestureInput =
        CompleteMotionGestureInputToGameMotionGestureInput.instance
    
    abstract init : unit -> unit
    default this.init() : unit =
        PreLogUtil.put("No Touch Button = No Compound Motion Gestures", this, this.commonStrings.INIT)


