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
type PATH_GLOBALS =
    [<DefaultValue(false)>] val mutable DATA_PATH : string
    [<DefaultValue(false)>] val mutable INIT_PATH : string
    [<DefaultValue(false)>] val mutable VIEWS_PATH : string
    [<DefaultValue(false)>] val mutable LOG_PATH : string
    [<DefaultValue(false)>] val mutable BACKUP_PATH : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : PATH_GLOBALS
    static member instance with get() : PATH_GLOBALS = (PATH_GLOBALS.jclinit(); PATH_GLOBALS.jcell_instance) and set (jvalue: PATH_GLOBALS) = (PATH_GLOBALS.jclinit(); PATH_GLOBALS.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PATH_GLOBALS.jclinitDone then
            PATH_GLOBALS.jclinitDone <- true
            PATH_GLOBALS.jclinitBody()
    static member private jclinitBody() : unit =
        PATH_GLOBALS.jcell_instance <- (new PATH_GLOBALS())
        ()
    
    static member getInstance() : PATH_GLOBALS =
        PATH_GLOBALS.instance
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable abPathData : AbPathData = AbPathData.getInstance()
        ignore (stringBuffer.append("data"))
        ignore (stringBuffer.append(abPathData.SEPARATOR))
        this.DATA_PATH <- stringBuffer.ToString()
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        ignore (stringBuffer.append(this.DATA_PATH))
        ignore (stringBuffer.append(CommonStrings.getInstance().INIT))
        ignore (stringBuffer.append(abPathData.SEPARATOR))
        this.INIT_PATH <- stringBuffer.ToString()
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        ignore (stringBuffer.append(this.DATA_PATH))
        ignore (stringBuffer.append("log"))
        ignore (stringBuffer.append(abPathData.SEPARATOR))
        this.LOG_PATH <- stringBuffer.ToString()
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        ignore (stringBuffer.append(this.DATA_PATH))
        ignore (stringBuffer.append("backup"))
        ignore (stringBuffer.append(abPathData.SEPARATOR))
        this.BACKUP_PATH <- stringBuffer.ToString()
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        ignore (stringBuffer.append(this.INIT_PATH))
        ignore (stringBuffer.append("views"))
        ignore (stringBuffer.append(abPathData.SEPARATOR))
        this.VIEWS_PATH <- stringBuffer.ToString()
        ()


