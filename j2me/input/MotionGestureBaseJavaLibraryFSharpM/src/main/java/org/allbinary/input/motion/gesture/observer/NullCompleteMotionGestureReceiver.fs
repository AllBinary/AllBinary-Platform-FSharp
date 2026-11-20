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
type NullCompleteMotionGestureReceiver =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullCompleteMotionGestureReceiver.jclinitDone then
            NullCompleteMotionGestureReceiver.jclinitDone <- true
            NullCompleteMotionGestureReceiver.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_NullCompleteMotionGestureReceiver() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_NullCompleteMotionGestureReceiver()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        this.logUtil.putF("Null Gesture Reciever", this, commonStrings.CONSTRUCTOR)
        ()
    
    abstract onMotionGestureCompleted : list_: BasicArrayList -> unit
    default this.onMotionGestureCompleted(list_: BasicArrayList) : unit =
        ()
    interface CompleteMotionGestureListenerInterface with
        member this.onMotionGestureCompleted(jp0: BasicArrayList) : unit = this.onMotionGestureCompleted(jp0)


