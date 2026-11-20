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
type MotionEventCircularPool =
    [<DefaultValue(false)>] val mutable MIN : int
    [<DefaultValue(false)>] val mutable eventPool : AllBinaryEventCircularPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionEventCircularPool.jclinitDone then
            MotionEventCircularPool.jclinitDone <- true
            MotionEventCircularPool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_MotionEventCircularPool() : unit =
        this.MIN <- TouchMotionGestureFactory.getInstance().LAST_MOTION.getId()
        this.eventPool <- (new AllBinaryEventCircularPool(((InputFactory.getInstance().MAX - 1) - this.MIN)))
        ()
    
    static member createPool(id_: int) : MotionEventCircularPool =
        (new MotionEventCircularPool(id_))
    
    new (id_: int) as this =
        {  }
        then
            this.jfields_MotionEventCircularPool()
            this.jctor1(id_)
    member this.jctor1(id_: int) : unit =
        this.eventPool.initAllBinaryEventCircularPool((new MotionEventFactory(this.eventPool, id_)))
        ()
    
    abstract getInstance : motionGestureInput: MotionGestureInput -> MotionGestureEvent
    default this.getInstance(motionGestureInput: MotionGestureInput) : MotionGestureEvent =
        (box (this.eventPool.getInstance((motionGestureInput.getId() - this.MIN))) :?> MotionGestureEvent)


