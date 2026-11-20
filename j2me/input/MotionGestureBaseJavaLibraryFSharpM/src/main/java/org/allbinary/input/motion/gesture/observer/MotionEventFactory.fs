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
type MotionEventFactory =
    [<DefaultValue(false)>] val mutable source : obj
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] static val mutable private jcell_index : int
    static member index with get() : int = (MotionEventFactory.jclinit(); MotionEventFactory.jcell_index) and set (jvalue: int) = (MotionEventFactory.jclinit(); MotionEventFactory.jcell_index <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionEventFactory.jclinitDone then
            MotionEventFactory.jclinitDone <- true
            MotionEventFactory.jclinitBody()
    static member private jclinitBody() : unit =
        MotionEventFactory.jcell_index <- 0
        ()
    
    new (source: obj, id_: int) as this =
        {  }
        then
            this.jctor1(source, id_)
    member this.jctor1(source: obj, id_: int) : unit =
        this.source <- source
        this.id <- id_
        MotionEventFactory.index <- TouchMotionGestureFactory.getInstance().LAST_MOTION.getId()
        ()
    
    abstract getInstance : unit -> AllBinaryEventObject
    default this.getInstance() : AllBinaryEventObject =
        let mutable jflow = 0
        let mutable jret : AllBinaryEventObject = Unchecked.defaultof<AllBinaryEventObject>
        let mutable inputFactory : InputFactory = InputFactory.getInstance()
        let mutable input : Input = inputFactory.getInstanceById((let jt = MotionEventFactory.index in MotionEventFactory.index <- MotionEventFactory.index + 1; jt))
        if (JR.same(input, inputFactory.NO_INPUT)) then
            jret <- (new MotionGestureEvent(this.source, this.id, (box (TouchMotionGestureFactory.getInstance().NO_MOTION) :?> MotionGestureInput)))
            jflow <- 1
        else
            jret <- (new MotionGestureEvent(this.source, this.id, (box (input) :?> MotionGestureInput)))
            jflow <- 1
        jret
    interface AllBinaryEventObjectFactoryInterface with
        member this.getInstance() : AllBinaryEventObject = this.getInstance()


