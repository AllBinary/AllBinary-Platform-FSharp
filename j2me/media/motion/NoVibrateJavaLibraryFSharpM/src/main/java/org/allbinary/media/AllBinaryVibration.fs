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
type AllBinaryVibration =
    inherit AllBinaryVibrationME
    [<DefaultValue(false)>] static val mutable private jcell_VIBRATION : AllBinaryVibrationME
    static member VIBRATION with get() : AllBinaryVibrationME = (AllBinaryVibration.jclinit(); AllBinaryVibration.jcell_VIBRATION) and set (jvalue: AllBinaryVibrationME) = (AllBinaryVibration.jclinit(); AllBinaryVibration.jcell_VIBRATION <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryVibration.jclinitDone then
            AllBinaryVibration.jclinitDone <- true
            AllBinaryVibration.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryVibration.jcell_VIBRATION <- AllBinaryNoVibration.NO_VIBRATION
        ()
    
    new () =
        { inherit AllBinaryVibrationME() }
    
    static member getInstance() : AllBinaryVibrationME =
        AllBinaryVibration.VIBRATION
    
    static member init() : unit =
        if GameConfigurationCentral.getInstance().VIBRATION.getValue().intValue() = 0 then
            AllBinaryVibration.VIBRATION <- AllBinaryNoVibration.NO_VIBRATION
        else
            AllBinaryVibration.VIBRATION <- (new AllBinaryVibration())
    
    override this.vibrate(duration: int, type_: int, volume: int) : unit =
        ()


