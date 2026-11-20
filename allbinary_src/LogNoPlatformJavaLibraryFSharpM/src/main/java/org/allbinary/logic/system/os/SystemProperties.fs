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
    
    static member getInstance() : SystemProperties =
        SystemProperties.instance
    
    new () =
        {  }
    
    abstract getName : unit -> string
    default this.getName() : string =
        raise ((new JRuntimeException()))
    
    abstract getArch : unit -> string
    default this.getArch() : string =
        raise ((new JRuntimeException()))
    
    abstract getVersion : unit -> string
    default this.getVersion() : string =
        raise ((new JRuntimeException()))
    
    abstract getUserHomePath : unit -> string
    default this.getUserHomePath() : string =
        raise ((new JRuntimeException()))


