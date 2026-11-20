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
type MotionGestureEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable motionGesture : MotionGestureInput
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] val mutable previousPoint : GPoint
    [<DefaultValue(false)>] val mutable currentPoint : GPoint
    [<DefaultValue(false)>] val mutable commonLabels : CommonLabels
    static member PREVIOUS : string = " Previous: "
    static member HASHCODE : string = " hashcode: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionGestureEvent.jclinitDone then
            MotionGestureEvent.jclinitDone <- true
            MotionGestureEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_MotionGestureEvent() : unit =
        this.motionGesture <- TouchMotionGestureFactory.getInstance().NO_MOTION
        this.previousPoint <- PointFactory.getInstance().ZERO_ZERO
        this.currentPoint <- PointFactory.getInstance().ZERO_ZERO
        this.commonLabels <- CommonLabels.getInstance()
        ()
    
    new (source: obj, id_: int, motionGesture: MotionGestureInput) as this =
        { inherit AllBinaryEventObject(source) }
        then
            this.jfields_MotionGestureEvent()
            this.jctor1(source, id_, motionGesture)
    member this.jctor1(source: obj, id_: int, motionGesture: MotionGestureInput) : unit =
        ()
        this.id <- id_
        this.setMotionGesture(motionGesture)
        ()
    
    abstract getMotionGesture : unit -> MotionGestureInput
    default this.getMotionGesture() : MotionGestureInput =
        this.motionGesture
    
    abstract setMotionGesture : motionGesture: MotionGestureInput -> unit
    default this.setMotionGesture(motionGesture: MotionGestureInput) : unit =
        this.motionGesture <- motionGesture
    
    abstract getPreviousPoint : unit -> GPoint
    default this.getPreviousPoint() : GPoint =
        this.previousPoint
    
    abstract setPreviousPoint : previousPoint: GPoint -> unit
    default this.setPreviousPoint(previousPoint: GPoint) : unit =
        this.previousPoint <- previousPoint
    
    abstract getCurrentPoint : unit -> GPoint
    default this.getCurrentPoint() : GPoint =
        this.currentPoint
    
    abstract setCurrentPoint : currentPoint: GPoint -> unit
    default this.setCurrentPoint(currentPoint: GPoint) : unit =
        this.currentPoint <- currentPoint
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable stringUtil : StringUtil = StringUtil.getInstance()
        ignore (stringBuffer.append(stringUtil.toString(this.motionGesture)))
        ignore (stringBuffer.append(this.commonLabels.CURRENT))
        ignore (stringBuffer.append(stringUtil.toString(this.currentPoint)))
        ignore (stringBuffer.append(MotionGestureEvent.PREVIOUS))
        ignore (stringBuffer.append(stringUtil.toString(this.previousPoint)))
        ignore (stringBuffer.append(MotionGestureEvent.HASHCODE))
        ignore (stringBuffer.appendint(TsUtil.getInstance().hashCode(this)))
        stringBuffer.ToString()
    
    abstract getId : unit -> int
    default this.getId() : int =
        this.id


