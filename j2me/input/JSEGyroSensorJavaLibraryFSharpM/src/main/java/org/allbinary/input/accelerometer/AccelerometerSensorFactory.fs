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
type AccelerometerSensorFactory =
    [<DefaultValue(false)>] static val mutable private jcell_allBinaryAccelerometerSensor : AllBinaryOrientationSensor
    static member allBinaryAccelerometerSensor with get() : AllBinaryOrientationSensor = (AccelerometerSensorFactory.jclinit(); AccelerometerSensorFactory.jcell_allBinaryAccelerometerSensor) and set (jvalue: AllBinaryOrientationSensor) = (AccelerometerSensorFactory.jclinit(); AccelerometerSensorFactory.jcell_allBinaryAccelerometerSensor <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AccelerometerSensorFactory.jclinitDone then
            AccelerometerSensorFactory.jclinitDone <- true
            AccelerometerSensorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member init() : unit =
        let mutable features : Features = Features.getInstance()
        let mutable sensorFeatureFactory : SensorFeatureFactory = SensorFeatureFactory.getInstance()
        if features.isFeature(sensorFeatureFactory.ORIENTATION_SENSORS) then
            raise ((new JException("No Orientation Sensors")))
        elif features.isFeature(sensorFeatureFactory.SIMULATED_ORIENTATION_SENSORS) then
            raise ((new JException("No Simulation Sensors")))
        elif features.isFeature(sensorFeatureFactory.NO_ORIENTATION) then
            AccelerometerSensorFactory.allBinaryAccelerometerSensor <- (new NoAccelerometerSensor())
        else
            raise ((new JException("Not Such SensorFeature")))
    
    static member getInstance() : AllBinaryOrientationSensor =
        AccelerometerSensorFactory.allBinaryAccelerometerSensor


