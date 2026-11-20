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
type AppUrlGlobals =
    inherit UrlGlobalsInterface
    [<DefaultValue(false)>] val mutable path : string
    [<DefaultValue(false)>] static val mutable private jcell_NULL_APP_URL_GLOBALS : AppUrlGlobals
    static member NULL_APP_URL_GLOBALS with get() : AppUrlGlobals = (AppUrlGlobals.jclinit(); AppUrlGlobals.jcell_NULL_APP_URL_GLOBALS) and set (jvalue: AppUrlGlobals) = (AppUrlGlobals.jclinit(); AppUrlGlobals.jcell_NULL_APP_URL_GLOBALS <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AppUrlGlobals.jclinitDone then
            AppUrlGlobals.jclinitDone <- true
            AppUrlGlobals.jclinitBody()
    static member private jclinitBody() : unit =
        AppUrlGlobals.jcell_NULL_APP_URL_GLOBALS <- (new AppUrlGlobals())
        ()
    new () as this =
        { inherit UrlGlobalsInterface() }
        then
            this.jfields_AppUrlGlobals()
    member this.jfields_AppUrlGlobals() : unit =
        this.path <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    override this.isTestingMode() : bool =
        false
    
    override this.getWebappPath() : string =
        this.path
    
    abstract setWebappPath : path: string -> unit
    default this.setWebappPath(path: string) : unit =
        this.path <- path
        if not ((JString.endsWith(this.path, "\\") || JString.endsWith(this.path, "/"))) then
            this.path <- JR.nn(this.path) + JR.nn("\\")
    
    override this.getTestHtmlPath() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    override this.getMainPath() : string =
        this.path


