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
type LicenseStrings =
    [<DefaultValue(false)>] val mutable LOCKED : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : LicenseStrings
    static member instance with get() : LicenseStrings = (LicenseStrings.jclinit(); LicenseStrings.jcell_instance) and set (jvalue: LicenseStrings) = (LicenseStrings.jclinit(); LicenseStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LicenseStrings.jclinitDone then
            LicenseStrings.jclinitDone <- true
            LicenseStrings.jclinitBody()
    static member private jclinitBody() : unit =
        LicenseStrings.jcell_instance <- (new LicenseStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_LicenseStrings()
    member this.jfields_LicenseStrings() : unit =
        this.LOCKED <- "Demo Locked Feature"
        ()
    
    static member getInstance() : LicenseStrings =
        LicenseStrings.instance


