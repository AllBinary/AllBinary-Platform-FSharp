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
type OpenGLImageSpecificFactory =
    [<DefaultValue(false)>] val mutable updating : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLImageSpecificFactory
    static member instance with get() : OpenGLImageSpecificFactory = (OpenGLImageSpecificFactory.jclinit(); OpenGLImageSpecificFactory.jcell_instance) and set (jvalue: OpenGLImageSpecificFactory) = (OpenGLImageSpecificFactory.jclinit(); OpenGLImageSpecificFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLImageSpecificFactory.jclinitDone then
            OpenGLImageSpecificFactory.jclinitDone <- true
            OpenGLImageSpecificFactory.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLImageSpecificFactory.jcell_instance <- (new OpenGLImageSpecificFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_OpenGLImageSpecificFactory()
    member this.jfields_OpenGLImageSpecificFactory() : unit =
        this.updating <- false
        ()
    
    static member getInstance() : OpenGLImageSpecificFactory =
        OpenGLImageSpecificFactory.instance


