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
type AllMotionRecognizer =
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] static val mutable private jcell_index : int
    static member index with get() : int = (AllMotionRecognizer.jclinit(); AllMotionRecognizer.jcell_index) and set (jvalue: int) = (AllMotionRecognizer.jclinit(); AllMotionRecognizer.jcell_index <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllMotionRecognizer.jclinitDone then
            AllMotionRecognizer.jclinitDone <- true
            AllMotionRecognizer.jclinitBody()
    static member private jclinitBody() : unit =
        AllMotionRecognizer.jcell_index <- 0
        ()
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        this.id <- (let jt = AllMotionRecognizer.index in AllMotionRecognizer.index <- AllMotionRecognizer.index + 1; jt)
        ()
    
    abstract processStartMotionEvent : x: int * y: int * deviceId: int * modifiers: int -> unit
    default this.processStartMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        ()
    
    abstract processEndMotionEvent : x: int * y: int * deviceId: int * modifiers: int -> unit
    default this.processEndMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        ()
    
    abstract processDraggedMotionEvent : x: int * y: int * deviceId: int * modifiers: int -> unit
    default this.processDraggedMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        ()
    
    abstract processMovedMotionEvent : x: int * y: int * deviceId: int * modifiers: int -> unit
    default this.processMovedMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        ()
    
    abstract processScrolledMotionEvent : x: int * y: int * deviceId: int * modifiers: int -> unit
    default this.processScrolledMotionEvent(x: int, y: int, deviceId: int, modifiers: int) : unit =
        ()
    
    abstract getId : unit -> int
    default this.getId() : int =
        this.id


