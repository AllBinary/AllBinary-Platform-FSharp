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
type AppletUtil =
    [<DefaultValue(false)>] static val mutable private jcell_applet : bool
    static member applet with get() : bool = (AppletUtil.jclinit(); AppletUtil.jcell_applet) and set (jvalue: bool) = (AppletUtil.jclinit(); AppletUtil.jcell_applet <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AppletUtil.jclinitDone then
            AppletUtil.jclinitDone <- true
            AppletUtil.jclinitBody()
    static member private jclinitBody() : unit =
        AppletUtil.jcell_applet <- false
        ()
    
    new () =
        {  }
    
    static member setApplet() : unit =
        AppletUtil.applet <- true
    
    static member isAppletLoader(anyType: obj) : bool =
        AppletUtil.applet


