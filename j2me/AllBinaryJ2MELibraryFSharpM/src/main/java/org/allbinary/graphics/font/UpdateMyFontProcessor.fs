namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type UpdateMyFontProcessor =
    inherit MyFontProcessor
    [<DefaultValue(false)>] val mutable updateMeasurementProcessor : UpdateMyFontInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UpdateMyFontProcessor.jclinitDone then
            UpdateMyFontProcessor.jclinitDone <- true
            UpdateMyFontProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (keyValueDrawCharArray: UpdateMyFontInterface) as this =
        { inherit MyFontProcessor() }
        then
            this.jctor1(keyValueDrawCharArray)
    member this.jctor1(keyValueDrawCharArray: UpdateMyFontInterface) : unit =
        this.updateMeasurementProcessor <- keyValueDrawCharArray
        ()
    
    override this.process_(graphics: Graphics) : unit =
        this.updateMeasurementProcessor.updateMeasurement(graphics)


