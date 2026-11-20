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
type UniformCameraPositionOpenGLProcessor =
    inherit OpenGLObject3dProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UniformCameraPositionOpenGLProcessor.jclinitDone then
            UniformCameraPositionOpenGLProcessor.jclinitDone <- true
            UniformCameraPositionOpenGLProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (shaderComposite: ShaderComposite, handleIndex: int) =
        { inherit OpenGLObject3dProcessor() }
    
    override this.process_(gl: GL10, anyType: obj) : unit =
        ()


