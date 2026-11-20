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
type SystemProperties =
    [<DefaultValue(false)>] val mutable OS_NAME : string
    [<DefaultValue(false)>] val mutable OS_ARCH : string
    [<DefaultValue(false)>] val mutable OS_VERSION : string
    [<DefaultValue(false)>] val mutable USER_HOME : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : SystemProperties
    static member instance with get() : SystemProperties = (SystemProperties.jclinit(); SystemProperties.jcell_instance) and set (jvalue: SystemProperties) = (SystemProperties.jclinit(); SystemProperties.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SystemProperties.jclinitDone then
            SystemProperties.jclinitDone <- true
            SystemProperties.jclinitBody()
    static member private jclinitBody() : unit =
        SystemProperties.jcell_instance <- (new SystemProperties())
        ()
    member this.jfields_SystemProperties() : unit =
        this.OS_NAME <- "os.name"
        this.OS_ARCH <- "os.arch"
        this.OS_VERSION <- "os.version"
        this.USER_HOME <- "user.home"
        ()
    
    static member getInstance() : SystemProperties =
        SystemProperties.instance
    
    new () as this =
        {  }
        then
            this.jfields_SystemProperties()
    
    abstract getName : unit -> string
    default this.getName() : string =
        JSystem.getProperty(this.OS_NAME)
    
    abstract getArch : unit -> string
    default this.getArch() : string =
        JSystem.getProperty(this.OS_ARCH)
    
    abstract getVersion : unit -> string
    default this.getVersion() : string =
        JSystem.getProperty(this.OS_VERSION)
    
    abstract getUserHomePath : unit -> string
    default this.getUserHomePath() : string =
        JSystem.getProperty(this.USER_HOME)


