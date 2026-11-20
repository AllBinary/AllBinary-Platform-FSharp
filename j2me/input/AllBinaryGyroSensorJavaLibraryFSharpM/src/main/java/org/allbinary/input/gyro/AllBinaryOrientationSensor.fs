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
type AllBinaryOrientationSensor =
    inherit AllBinarySensor
    [<DefaultValue(false)>] val mutable sensorDataFloatArray : float32[]
    [<DefaultValue(false)>] val mutable listener : CompleteMotionGestureInputEventListenerInterface
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ALLBINARY_ORIENTATION_SENSOR : AllBinaryOrientationSensor
    static member NULL_ALLBINARY_ORIENTATION_SENSOR with get() : AllBinaryOrientationSensor = (AllBinaryOrientationSensor.jclinit(); AllBinaryOrientationSensor.jcell_NULL_ALLBINARY_ORIENTATION_SENSOR) and set (jvalue: AllBinaryOrientationSensor) = (AllBinaryOrientationSensor.jclinit(); AllBinaryOrientationSensor.jcell_NULL_ALLBINARY_ORIENTATION_SENSOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryOrientationSensor.jclinitDone then
            AllBinaryOrientationSensor.jclinitDone <- true
            AllBinaryOrientationSensor.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryOrientationSensor.jcell_NULL_ALLBINARY_ORIENTATION_SENSOR <- (new AllBinaryOrientationSensor())
        ()
    member this.jfields_AllBinaryOrientationSensor() : unit =
        this.sensorDataFloatArray <- PrimitiveFloatUtil.getArrayInstance()
        this.listener <- NoCompleteMotionGestureInputEventListener.getInstance()
        ()
    
    abstract setCompleteMotionGestureInputEventListener : completeMotionGestureInputEventListenerInterface: CompleteMotionGestureInputEventListenerInterface -> unit
    default this.setCompleteMotionGestureInputEventListener(completeMotionGestureInputEventListenerInterface: CompleteMotionGestureInputEventListenerInterface) : unit =
        this.listener <- completeMotionGestureInputEventListenerInterface
    
    new () as this =
        { inherit AllBinarySensor() }
        then
            this.jfields_AllBinaryOrientationSensor()
    
    abstract getOrientation : unit -> Orientation
    default this.getOrientation() : Orientation =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))


