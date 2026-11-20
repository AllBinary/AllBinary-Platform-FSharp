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
type Globals =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : Globals
    static member instance with get() : Globals = (Globals.jclinit(); Globals.jcell_instance) and set (jvalue: Globals) = (Globals.jclinit(); Globals.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Globals.jclinitDone then
            Globals.jclinitDone <- true
            Globals.jclinitBody()
    static member private jclinitBody() : unit =
        Globals.jcell_instance <- (new Globals())
        ()
    member this.jfields_Globals() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : Globals =
        Globals.instance
    
    new () as this =
        {  }
        then
            this.jfields_Globals()
    
    abstract init : classLoader: ClassLoader * pathString: string -> unit
    default this.init(classLoader: ClassLoader, pathString: string) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        let mutable appUrlGlobals : AppUrlGlobals = (new AppUrlGlobals())
        appUrlGlobals.setWebappPath(pathString)
        URLGLOBALS.init(appUrlGlobals)
        WebappClassLoaderInfo.setLoader(classLoader)
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Setting Up AllBinary System Configuration Args: "))
        ignore (stringBuffer.append(pathString))
        ignore (stringBuffer.append(" ClassLoader: "))
        ignore (stringBuffer.append(JR.getClass(classLoader)))
        this.logUtil.putF(stringBuffer.ToString(), this, commonStrings.INIT)
        let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
        if stringValidationUtil.isEmpty(pathString) then
            ignore (stringBuffer.delete(0, stringBuffer.length()))
            ignore (stringBuffer.append("No Path Provided. Using Process Path: "))
            ignore (stringBuffer.append(pathString))
            ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
            ignore (stringBuffer.append(CommonSeps.getInstance().EQUALS))
            ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
            ignore (stringBuffer.append(URLGLOBALS.getWebappPath()))
            this.logUtil.putF(stringBuffer.ToString(), this, commonStrings.INIT)
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        ignore (stringBuffer.append("Webapp Path Set To: "))
        ignore (stringBuffer.append(URLGLOBALS.getWebappPath()))
        this.logUtil.putF(stringBuffer.ToString(), this, commonStrings.INIT)


