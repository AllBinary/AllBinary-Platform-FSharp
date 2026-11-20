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
type RegistrationConfiguration =
    [<DefaultValue(false)>] val mutable registrationCode : string
    [<DefaultValue(false)>] val mutable NAME : string
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : RegistrationConfiguration
    static member SINGLETON with get() : RegistrationConfiguration = (RegistrationConfiguration.jclinit(); RegistrationConfiguration.jcell_SINGLETON) and set (jvalue: RegistrationConfiguration) = (RegistrationConfiguration.jclinit(); RegistrationConfiguration.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RegistrationConfiguration.jclinitDone then
            RegistrationConfiguration.jclinitDone <- true
            RegistrationConfiguration.jclinitBody()
    static member private jclinitBody() : unit =
        RegistrationConfiguration.jcell_SINGLETON <- (new RegistrationConfiguration())
        ()
    member this.jfields_RegistrationConfiguration() : unit =
        this.registrationCode <- "No Registration Code"
        this.NAME <- "registrationid"
        ()
    
    new () as this =
        {  }
        then
            this.jfields_RegistrationConfiguration()
    
    static member getInstance() : RegistrationConfiguration =
        RegistrationConfiguration.SINGLETON
    
    member this.read() : unit =
        ()
    
    abstract write : unit -> unit
    default this.write() : unit =
        ()
    
    override this.ToString() : string =
        (new StringMaker()).append("Registration Code: ").append(this.getRegistrationCode()).ToString()
    
    abstract setRegistrationCode : registrationCode: string -> unit
    default this.setRegistrationCode(registrationCode: string) : unit =
        this.registrationCode <- registrationCode
    
    abstract getRegistrationCode : unit -> string
    default this.getRegistrationCode() : string =
        this.registrationCode


