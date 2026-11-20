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
type LicenseStupidTimerFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : StupidTimer
    static member instance with get() : StupidTimer = (LicenseStupidTimerFactory.jclinit(); LicenseStupidTimerFactory.jcell_instance) and set (jvalue: StupidTimer) = (LicenseStupidTimerFactory.jclinit(); LicenseStupidTimerFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LicenseStupidTimerFactory.jclinitDone then
            LicenseStupidTimerFactory.jclinitDone <- true
            LicenseStupidTimerFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LicenseStupidTimerFactory.jcell_instance <- (new StupidTimer())
        ()
    new () =
        {  }
    
    static member getInstance() : StupidTimer =
        LicenseStupidTimerFactory.instance


