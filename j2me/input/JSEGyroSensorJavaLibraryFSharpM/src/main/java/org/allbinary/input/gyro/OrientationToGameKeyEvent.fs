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
type OrientationToGameKeyEvent =
    [<DefaultValue(false)>] val mutable allBinaryGyroSensor : AllBinaryOrientationSensor
    [<DefaultValue(false)>] val mutable MIN : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OrientationToGameKeyEvent.jclinitDone then
            OrientationToGameKeyEvent.jclinitDone <- true
            OrientationToGameKeyEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_OrientationToGameKeyEvent() : unit =
        this.MIN <- 15
        ()
    
    new () as this =
        {  }
        then
            this.jfields_OrientationToGameKeyEvent()
            this.jctor1()
    member this.jctor1() : unit =
        if Features.getInstance().isFeature(SensorFeatureFactory.getInstance().NO_ORIENTATION) then
            this.allBinaryGyroSensor <- (new NoGyroSensor())
        else
            raise ((new JException("Not Such Feature")))
        ()
    
    abstract setAllBinaryGyroSensor : allBinaryGyroSensor: AllBinaryOrientationSensor -> unit
    default this.setAllBinaryGyroSensor(allBinaryGyroSensor: AllBinaryOrientationSensor) : unit =
        this.allBinaryGyroSensor <- allBinaryGyroSensor
    
    abstract getAllBinaryGyroSensor : unit -> AllBinaryOrientationSensor
    default this.getAllBinaryGyroSensor() : AllBinaryOrientationSensor =
        this.allBinaryGyroSensor
    
    abstract process_ : unit -> unit
    default this.process_() : unit =
        ()
    
    member this.updateGameKeyEvents(orientation: Orientation, yaw: int, pitch: int, roll: int) : unit =
        ()


