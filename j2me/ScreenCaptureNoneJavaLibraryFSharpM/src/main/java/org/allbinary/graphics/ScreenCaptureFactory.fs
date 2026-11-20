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
type ScreenCaptureFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ScreenCapture
    static member instance with get() : ScreenCapture = (ScreenCaptureFactory.jclinit(); ScreenCaptureFactory.jcell_instance) and set (jvalue: ScreenCapture) = (ScreenCaptureFactory.jclinit(); ScreenCaptureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScreenCaptureFactory.jclinitDone then
            ScreenCaptureFactory.jclinitDone <- true
            ScreenCaptureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ScreenCaptureFactory.jcell_instance <- ScreenCaptureNoneFactory.getInstance()
        ()
    new () =
        {  }
    
    static member getInstance() : ScreenCapture =
        ScreenCaptureFactory.instance


