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
type MotionGestureToMotionGestureActionAssociation =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable motionGestureAction : CompleteMotionGestureInputEvent
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionGestureToMotionGestureActionAssociation.jclinitDone then
            MotionGestureToMotionGestureActionAssociation.jclinitDone <- true
            MotionGestureToMotionGestureActionAssociation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (list_: BasicArrayList, commandAction: CompleteMotionGestureInputEvent) as this =
        {  }
        then
            this.jctor1(list_, commandAction)
    member this.jctor1(list_: BasicArrayList, commandAction: CompleteMotionGestureInputEvent) : unit =
        this.list <- list_
        this.motionGestureAction <- commandAction
        ()
    
    abstract getMotionGesture : unit -> BasicArrayList
    default this.getMotionGesture() : BasicArrayList =
        this.list
    
    abstract setMotionGestures : list_: BasicArrayList -> unit
    default this.setMotionGestures(list_: BasicArrayList) : unit =
        this.list <- list_
    
    abstract getCommandAction : unit -> CompleteMotionGestureInputEvent
    default this.getCommandAction() : CompleteMotionGestureInputEvent =
        this.motionGestureAction
    
    abstract setMotionGestureAction : commandAction: CompleteMotionGestureInputEvent -> unit
    default this.setMotionGestureAction(commandAction: CompleteMotionGestureInputEvent) : unit =
        this.motionGestureAction <- commandAction
    
    abstract isMotionGestureArrayEquals : aList: BasicArrayList -> bool
    default this.isMotionGestureArrayEquals(aList: BasicArrayList) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable size : int = aList.size()
        if this.list.size() <> size then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            let mutable i : int = size - 1
            while jflow = 0 && (i >= 0) do
                if aList.objectArray.[i] <> this.list.objectArray.[i] then
                    jret <- false
                    jflow <- 1
                if jflow = 200001 then jflow <- 0
                if jflow = 0 then i <- i - 1
            if jflow = 100001 then jflow <- 0
            if jflow = 0 then
                jret <- true
                jflow <- 1
        jret


