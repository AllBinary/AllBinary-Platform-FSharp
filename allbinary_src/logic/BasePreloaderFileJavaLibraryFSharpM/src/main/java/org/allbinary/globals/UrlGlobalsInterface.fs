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
type UrlGlobalsInterface =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UrlGlobalsInterface.jclinitDone then
            UrlGlobalsInterface.jclinitDone <- true
            UrlGlobalsInterface.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getMainPath : unit -> string
    default this.getMainPath() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract getTestHtmlPath : unit -> string
    default this.getTestHtmlPath() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract getWebappPath : unit -> string
    default this.getWebappPath() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract isTestingMode : unit -> bool
    default this.isTestingMode() : bool =
        false


