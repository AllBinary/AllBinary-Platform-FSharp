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
type SetAndRemoveProcessor =
    inherit Processor
    [<DefaultValue(false)>] val mutable updateMeasurementProcessor : PlayerGameNotificationHud
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SetAndRemoveProcessor.jclinitDone then
            SetAndRemoveProcessor.jclinitDone <- true
            SetAndRemoveProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (updateMeasurementProcessor: PlayerGameNotificationHud) as this =
        { inherit Processor() }
        then
            this.jctor1(updateMeasurementProcessor)
    member this.jctor1(updateMeasurementProcessor: PlayerGameNotificationHud) : unit =
        this.updateMeasurementProcessor <- updateMeasurementProcessor
        ()
    
    override this.process_() : unit =
        this.updateMeasurementProcessor.setAndRemoveProcess()


