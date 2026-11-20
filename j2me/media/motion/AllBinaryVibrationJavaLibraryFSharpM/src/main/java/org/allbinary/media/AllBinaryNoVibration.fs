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
type AllBinaryNoVibration =
    inherit AllBinaryVibrationME
    [<DefaultValue(false)>] static val mutable private jcell_NO_VIBRATION : AllBinaryVibrationME
    static member NO_VIBRATION with get() : AllBinaryVibrationME = (AllBinaryNoVibration.jclinit(); AllBinaryNoVibration.jcell_NO_VIBRATION) and set (jvalue: AllBinaryVibrationME) = (AllBinaryNoVibration.jclinit(); AllBinaryNoVibration.jcell_NO_VIBRATION <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryNoVibration.jclinitDone then
            AllBinaryNoVibration.jclinitDone <- true
            AllBinaryNoVibration.jclinitBody()
    static member private jclinitBody() : unit =
        AllBinaryNoVibration.jcell_NO_VIBRATION <- (new AllBinaryNoVibration())
        ()
    new () =
        { inherit AllBinaryVibrationME() }
    
    override this.vibrate(duration: int, type_: int, volume: int) : unit =
        ()


