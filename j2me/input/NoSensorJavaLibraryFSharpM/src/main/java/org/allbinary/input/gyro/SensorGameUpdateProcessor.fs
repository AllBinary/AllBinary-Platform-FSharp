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
type SensorGameUpdateProcessor =
    [<DefaultValue(false)>] val mutable inputSensor : AllBinarySensor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SensorGameUpdateProcessor.jclinitDone then
            SensorGameUpdateProcessor.jclinitDone <- true
            SensorGameUpdateProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_SensorGameUpdateProcessor()
    member this.jfields_SensorGameUpdateProcessor() : unit =
        this.inputSensor <- NoAllBinarySensor.getInstance()
        ()
    
    abstract setInputSensor : inputSensor: AllBinarySensor -> unit
    default this.setInputSensor(inputSensor: AllBinarySensor) : unit =
        this.inputSensor <- inputSensor
    
    abstract getInputSensor : unit -> AllBinarySensor
    default this.getInputSensor() : AllBinarySensor =
        this.inputSensor
    
    abstract process_ : anyType: obj -> unit
    default this.process_(anyType: obj) : unit =
        ()
    
    abstract sendNotifications : anyType: obj -> unit
    default this.sendNotifications(anyType: obj) : unit =
        ()
    
    abstract isAnySensor : unit -> bool
    default this.isAnySensor() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(this.inputSensor, NoAllBinarySensor.getInstance())) then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret
    
    abstract setNoSensors : unit -> unit
    default this.setNoSensors() : unit =
        this.setInputSensor(NoAllBinarySensor.getInstance())


