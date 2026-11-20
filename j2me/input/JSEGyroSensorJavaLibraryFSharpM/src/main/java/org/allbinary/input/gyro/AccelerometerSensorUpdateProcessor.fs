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
type AccelerometerSensorUpdateProcessor =
    inherit Processor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AccelerometerSensorUpdateProcessor.jclinitDone then
            AccelerometerSensorUpdateProcessor.jclinitDone <- true
            AccelerometerSensorUpdateProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        { inherit Processor() }
    
    override this.process_() : unit =
        let mutable sensorFeatureFactory : SensorFeatureFactory = SensorFeatureFactory.getInstance()
        if Features.getInstance().isFeature(sensorFeatureFactory.ORIENTATION_SENSORS) then
            AccelerometerSensorFactory.getInstance().setCompleteMotionGestureInputEventListener((new SingleKeyPressGameKeyFromMotionGestureEventListener()))
        elif Features.getInstance().isFeature(sensorFeatureFactory.SIMULATED_ORIENTATION_SENSORS) then
            AccelerometerSensorFactory.getInstance().setCompleteMotionGestureInputEventListener((new SingleKeyPressGameKeyFromMotionGestureEventListener()))
        elif Features.getInstance().isFeature(sensorFeatureFactory.NO_ORIENTATION) then
            AccelerometerSensorFactory.getInstance().setCompleteMotionGestureInputEventListener(NoCompleteMotionGestureInputEventListener.getInstance())
        else
            raise ((new JException("Sensor Feature Not Set")))


