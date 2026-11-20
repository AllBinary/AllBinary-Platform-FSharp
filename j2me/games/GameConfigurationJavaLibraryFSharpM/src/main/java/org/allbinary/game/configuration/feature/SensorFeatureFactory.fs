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
type SensorFeatureFactory =
    [<DefaultValue(false)>] val mutable NO_ORIENTATION : SensorFeature
    [<DefaultValue(false)>] val mutable ORIENTATION_SENSORS : SensorFeature
    [<DefaultValue(false)>] val mutable SIMULATED_ORIENTATION_SENSORS : SensorFeature
    [<DefaultValue(false)>] val mutable YAW : SensorFeature
    [<DefaultValue(false)>] val mutable YAW_MINUS_RIGHT_PLUS_LEFT : SensorFeature
    [<DefaultValue(false)>] val mutable YAW_MINUS_LEFT_PLUS_RIGHT : SensorFeature
    [<DefaultValue(false)>] val mutable PITCH : SensorFeature
    [<DefaultValue(false)>] val mutable ROLL : SensorFeature
    [<DefaultValue(false)>] static val mutable private jcell_instance : SensorFeatureFactory
    static member instance with get() : SensorFeatureFactory = (SensorFeatureFactory.jclinit(); SensorFeatureFactory.jcell_instance) and set (jvalue: SensorFeatureFactory) = (SensorFeatureFactory.jclinit(); SensorFeatureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SensorFeatureFactory.jclinitDone then
            SensorFeatureFactory.jclinitDone <- true
            SensorFeatureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        SensorFeatureFactory.jcell_instance <- (new SensorFeatureFactory())
        ()
    member this.jfields_SensorFeatureFactory() : unit =
        this.NO_ORIENTATION <- (new SensorFeature("No Orientation"))
        this.ORIENTATION_SENSORS <- (new SensorFeature("Orientation Sensors"))
        this.SIMULATED_ORIENTATION_SENSORS <- (new SensorFeature("Simulated Orientation Sensors"))
        this.YAW <- (new SensorFeature("Yaw"))
        this.YAW_MINUS_RIGHT_PLUS_LEFT <- (new SensorFeature("Yaw -Right +Left"))
        this.YAW_MINUS_LEFT_PLUS_RIGHT <- (new SensorFeature("Yaw -Left +Right "))
        this.PITCH <- (new SensorFeature("Pitch"))
        this.ROLL <- (new SensorFeature("Roll"))
        ()
    
    static member getInstance() : SensorFeatureFactory =
        SensorFeatureFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_SensorFeatureFactory()


