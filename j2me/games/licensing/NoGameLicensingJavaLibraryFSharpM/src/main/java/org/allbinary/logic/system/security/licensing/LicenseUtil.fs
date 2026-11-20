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
type LicenseUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : LicenseUtil
    static member instance with get() : LicenseUtil = (LicenseUtil.jclinit(); LicenseUtil.jcell_instance) and set (jvalue: LicenseUtil) = (LicenseUtil.jclinit(); LicenseUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LicenseUtil.jclinitDone then
            LicenseUtil.jclinitDone <- true
            LicenseUtil.jclinitBody()
    static member private jclinitBody() : unit =
        LicenseUtil.jcell_instance <- (new LicenseUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : LicenseUtil =
        LicenseUtil.instance
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract isRunning : unit -> bool
    default this.isRunning() : bool =
        false
    
    abstract setRunning : running: bool -> unit
    default this.setRunning(running: bool) : unit =
        ()
    
    abstract shouldWait : commandListener: CommandListener -> bool
    default this.shouldWait(commandListener: CommandListener) : bool =
        this.isRunning()


