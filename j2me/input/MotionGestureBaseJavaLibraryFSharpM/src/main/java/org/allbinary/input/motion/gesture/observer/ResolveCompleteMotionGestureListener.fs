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
type ResolveCompleteMotionGestureListener =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ResolveCompleteMotionGestureListener.jclinitDone then
            ResolveCompleteMotionGestureListener.jclinitDone <- true
            ResolveCompleteMotionGestureListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ResolveCompleteMotionGestureListener() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_ResolveCompleteMotionGestureListener()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        this.logUtil.putF("MotionGesture to CompleteMotionGesture Reciever", this, commonStrings.CONSTRUCTOR)
        CompleteMotionGestureInputEventHandler.getInstance().addListener((new GameKeyFromMotionGestureEventListener()))
        ()
    
    abstract onMotionGestureCompleted : list_: BasicArrayList -> unit
    default this.onMotionGestureCompleted(list_: BasicArrayList) : unit =
        let mutable jflow = 0
        let mutable configuration : MotionGestureConfiguration = MotionGestureConfigurationFactory.getInstance()
        let mutable commandActionsList : BasicArrayList = configuration.getAssociateCommandActionsList()
        let mutable size : int = commandActionsList.size()
        let mutable index : int = size - 1
        while jflow = 0 && (index >= 0) do
            let mutable association : MotionGestureToMotionGestureActionAssociation = (box (commandActionsList.objectArray.[index]) :?> MotionGestureToMotionGestureActionAssociation)
            if association.isMotionGestureArrayEquals(list_) = true then
                let mutable completeMotionGestureInputEvent : GameKeyCompleteMotionGestureInputEvent = (box (association.getCommandAction()) :?> GameKeyCompleteMotionGestureInputEvent)
                CompleteMotionGestureInputEventHandler.getInstance().fireEvent(completeMotionGestureInputEvent)
                jflow <- 100001
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index - 1
        if jflow = 100001 then jflow <- 0
    interface CompleteMotionGestureListenerInterface with
        member this.onMotionGestureCompleted(jp0: BasicArrayList) : unit = this.onMotionGestureCompleted(jp0)


