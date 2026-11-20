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
type LayerBounds =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable rectangle : Rectangle
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerBounds.jclinitDone then
            LayerBounds.jclinitDone <- true
            LayerBounds.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LayerBounds() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (rectangle: Rectangle) as this =
        {  }
        then
            this.jfields_LayerBounds()
            this.jctor1(rectangle)
    member this.jctor1(rectangle: Rectangle) : unit =
        this.rectangle <- rectangle
        ()
    
    abstract getRectangleP : unit -> Rectangle
    default this.getRectangleP() : Rectangle =
        this.rectangle
    
    abstract visit : boundsVisitorInterface: BoundsVisitorInterface -> unit
    default this.visit(boundsVisitorInterface: BoundsVisitorInterface) : unit =
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onBoundsChangeEvent : boundsChangeEvent: BoundsChangeEvent -> unit
    default this.onBoundsChangeEvent(boundsChangeEvent: BoundsChangeEvent) : unit =
        this.rectangle <- boundsChangeEvent.getRectangle()
    interface BoundsChangeEventListener with
        member this.onBoundsChangeEvent(jp0: BoundsChangeEvent) : unit = this.onBoundsChangeEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


