namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NullOpenGLTextureProcessor =
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLObject3dProcessor
    static member instance with get() : OpenGLObject3dProcessor = (NullOpenGLTextureProcessor.jclinit(); NullOpenGLTextureProcessor.jcell_instance) and set (jvalue: OpenGLObject3dProcessor) = (NullOpenGLTextureProcessor.jclinit(); NullOpenGLTextureProcessor.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullOpenGLTextureProcessor.jclinitDone then
            NullOpenGLTextureProcessor.jclinitDone <- true
            NullOpenGLTextureProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        NullOpenGLTextureProcessor.jcell_instance <- (new OpenGLObject3dProcessor())
        ()
    new () =
        {  }
    
    static member getInstance() : OpenGLObject3dProcessor =
        NullOpenGLTextureProcessor.instance


