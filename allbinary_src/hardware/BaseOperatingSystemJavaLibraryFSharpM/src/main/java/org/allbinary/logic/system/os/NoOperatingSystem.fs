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
type NoOperatingSystem =
    inherit GenericOperatingSystem
    [<DefaultValue(false)>] static val mutable private jcell_NO_OPERATING_SYSTEM : GenericOperatingSystem
    static member NO_OPERATING_SYSTEM with get() : GenericOperatingSystem = (NoOperatingSystem.jclinit(); NoOperatingSystem.jcell_NO_OPERATING_SYSTEM) and set (jvalue: GenericOperatingSystem) = (NoOperatingSystem.jclinit(); NoOperatingSystem.jcell_NO_OPERATING_SYSTEM <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoOperatingSystem.jclinitDone then
            NoOperatingSystem.jclinitDone <- true
            NoOperatingSystem.jclinitBody()
    static member private jclinitBody() : unit =
        NoOperatingSystem.jcell_NO_OPERATING_SYSTEM <- (new GenericOperatingSystem())
        ()
    
    new () =
        { inherit GenericOperatingSystem() }


