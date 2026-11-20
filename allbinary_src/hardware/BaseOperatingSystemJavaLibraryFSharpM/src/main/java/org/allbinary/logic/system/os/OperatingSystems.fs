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
type OperatingSystems =
    [<DefaultValue(false)>] val mutable LINUX : string
    [<DefaultValue(false)>] val mutable WINDOWS : string
    [<DefaultValue(false)>] val mutable SOLARIS : string
    [<DefaultValue(false)>] val mutable WINDOWS2000 : string
    [<DefaultValue(false)>] val mutable WINDOWS_NT : string
    [<DefaultValue(false)>] val mutable WINDOWS_10 : string
    [<DefaultValue(false)>] val mutable WINDOWS_11 : string
    [<DefaultValue(false)>] val mutable WINDOWS_VISTA : string
    [<DefaultValue(false)>] val mutable WINDOWS_XP : string
    [<DefaultValue(false)>] val mutable ANDROID : string
    [<DefaultValue(false)>] val mutable HARMONY : string
    [<DefaultValue(false)>] val mutable unknownSpecificOSAllowed : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : OperatingSystems
    static member instance with get() : OperatingSystems = (OperatingSystems.jclinit(); OperatingSystems.jcell_instance) and set (jvalue: OperatingSystems) = (OperatingSystems.jclinit(); OperatingSystems.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OperatingSystems.jclinitDone then
            OperatingSystems.jclinitDone <- true
            OperatingSystems.jclinitBody()
    static member private jclinitBody() : unit =
        OperatingSystems.jcell_instance <- (new OperatingSystems())
        ()
    member this.jfields_OperatingSystems() : unit =
        this.LINUX <- "Linux"
        this.WINDOWS <- "Windows"
        this.SOLARIS <- "Solaris"
        this.WINDOWS2000 <- "Windows 2000"
        this.WINDOWS_NT <- "Windows NT"
        this.WINDOWS_10 <- "Windows 10"
        this.WINDOWS_11 <- "Windows 11"
        this.WINDOWS_VISTA <- "Windows Vista"
        this.WINDOWS_XP <- "Windows XP"
        this.ANDROID <- this.LINUX
        this.HARMONY <- "HarmonyOS"
        this.unknownSpecificOSAllowed <- true
        ()
    
    new () as this =
        {  }
        then
            this.jfields_OperatingSystems()
    
    abstract isUnknownSpecificOSAllowed : unit -> bool
    default this.isUnknownSpecificOSAllowed() : bool =
        this.unknownSpecificOSAllowed
    
    abstract setUnknownSpecificOSAllowed : aUnknownSpecificOSAllowed: bool -> unit
    default this.setUnknownSpecificOSAllowed(aUnknownSpecificOSAllowed: bool) : unit =
        this.unknownSpecificOSAllowed <- aUnknownSpecificOSAllowed
    
    static member getInstance() : OperatingSystems =
        OperatingSystems.instance


