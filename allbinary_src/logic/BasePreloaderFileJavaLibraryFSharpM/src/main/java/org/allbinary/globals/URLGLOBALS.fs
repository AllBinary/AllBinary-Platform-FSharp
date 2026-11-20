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
type URLGLOBALS =
    [<DefaultValue(false)>] static val mutable private jcell_urlGlobalsInterface : UrlGlobalsInterface
    static member urlGlobalsInterface with get() : UrlGlobalsInterface = (URLGLOBALS.jclinit(); URLGLOBALS.jcell_urlGlobalsInterface) and set (jvalue: UrlGlobalsInterface) = (URLGLOBALS.jclinit(); URLGLOBALS.jcell_urlGlobalsInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not URLGLOBALS.jclinitDone then
            URLGLOBALS.jclinitDone <- true
            URLGLOBALS.jclinitBody()
    static member private jclinitBody() : unit =
        URLGLOBALS.jcell_urlGlobalsInterface <- AppUrlGlobals.NULL_APP_URL_GLOBALS
        ()
    new () =
        {  }
    
    static member init(urlGlobalsInterface: UrlGlobalsInterface) : unit =
        URLGLOBALS.urlGlobalsInterface <- urlGlobalsInterface
    
    static member isTestingMode() : bool =
        URLGLOBALS.urlGlobalsInterface.isTestingMode()
    
    static member getWebappPath() : string =
        URLGLOBALS.urlGlobalsInterface.getWebappPath()
    
    static member getTestHtmlPath() : string =
        URLGLOBALS.urlGlobalsInterface.getTestHtmlPath()
    
    static member getMainPath() : string =
        URLGLOBALS.urlGlobalsInterface.getMainPath()


