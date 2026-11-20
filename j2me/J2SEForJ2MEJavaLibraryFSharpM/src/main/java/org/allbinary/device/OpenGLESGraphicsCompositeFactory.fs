namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type OpenGLESGraphicsCompositeFactory =
    [<DefaultValue(false)>] val mutable openGLESGraphicsFactory : OpenGLESGraphicsFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLESGraphicsCompositeFactory
    static member instance with get() : OpenGLESGraphicsCompositeFactory = (OpenGLESGraphicsCompositeFactory.jclinit(); OpenGLESGraphicsCompositeFactory.jcell_instance) and set (jvalue: OpenGLESGraphicsCompositeFactory) = (OpenGLESGraphicsCompositeFactory.jclinit(); OpenGLESGraphicsCompositeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESGraphicsCompositeFactory.jclinitDone then
            OpenGLESGraphicsCompositeFactory.jclinitDone <- true
            OpenGLESGraphicsCompositeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLESGraphicsCompositeFactory.jcell_instance <- (new OpenGLESGraphicsCompositeFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_OpenGLESGraphicsCompositeFactory()
    member this.jfields_OpenGLESGraphicsCompositeFactory() : unit =
        this.openGLESGraphicsFactory <- (new OpenGLESGraphicsFactory())
        ()
    
    static member getInstance() : OpenGLESGraphicsCompositeFactory =
        OpenGLESGraphicsCompositeFactory.instance
    
    abstract set : openGLESGraphicsFactory: OpenGLESGraphicsFactory -> unit
    default this.set(openGLESGraphicsFactory: OpenGLESGraphicsFactory) : unit =
        this.openGLESGraphicsFactory <- openGLESGraphicsFactory
    
    abstract get : unit -> OpenGLESGraphicsFactory
    default this.get() : OpenGLESGraphicsFactory =
        this.openGLESGraphicsFactory


