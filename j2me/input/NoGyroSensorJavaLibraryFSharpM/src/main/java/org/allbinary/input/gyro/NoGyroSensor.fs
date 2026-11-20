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
type NoGyroSensor =
    inherit AllBinaryOrientationSensor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoGyroSensor.jclinitDone then
            NoGyroSensor.jclinitDone <- true
            NoGyroSensor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () as this =
        { inherit AllBinaryOrientationSensor() }
        then
            this.jctor1()
    member this.jctor1() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        ()
    
    override this.getOrientation() : Orientation =
        Orientation.NONE
    
    override this.onSensorChange() : unit =
        ()
    interface AllBinarySensorListener with
        member this.onSensorChange() : unit = this.onSensorChange()


