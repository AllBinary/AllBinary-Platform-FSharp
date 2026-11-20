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
type SingleSensorGameUpdateProcessor =
    inherit SensorGameUpdateProcessor
    [<DefaultValue(false)>] val mutable accelerometerSensorUpdateProcessor : Processor
    [<DefaultValue(false)>] val mutable gyroSensorUpdateProcessor : Processor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SingleSensorGameUpdateProcessor.jclinitDone then
            SingleSensorGameUpdateProcessor.jclinitDone <- true
            SingleSensorGameUpdateProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit SensorGameUpdateProcessor() }
        then
            this.jfields_SingleSensorGameUpdateProcessor()
    member this.jfields_SingleSensorGameUpdateProcessor() : unit =
        this.accelerometerSensorUpdateProcessor <- (new AccelerometerSensorUpdateProcessor())
        this.gyroSensorUpdateProcessor <- (new GyroSensorUpdateProcessor())
        ()
    
    override this.process_(anyType: obj) : unit =
        this.setNoSensors()
    
    override this.sendNotifications(anyType: obj) : unit =
        ()


