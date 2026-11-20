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
type WebappClassLoaderInfo =
    [<DefaultValue(false)>] static val mutable private jcell_classLoader : obj
    static member classLoader with get() : obj = (WebappClassLoaderInfo.jclinit(); WebappClassLoaderInfo.jcell_classLoader) and set (jvalue: obj) = (WebappClassLoaderInfo.jclinit(); WebappClassLoaderInfo.jcell_classLoader <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not WebappClassLoaderInfo.jclinitDone then
            WebappClassLoaderInfo.jclinitDone <- true
            WebappClassLoaderInfo.jclinitBody()
    static member private jclinitBody() : unit =
        WebappClassLoaderInfo.jcell_classLoader <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    new () =
        {  }
    
    static member setLoader(classLoader: ClassLoader) : unit =
        WebappClassLoaderInfo.classLoader <- classLoader
    
    static member getLoader() : ClassLoader =
        (box (WebappClassLoaderInfo.classLoader) :?> ClassLoader)


