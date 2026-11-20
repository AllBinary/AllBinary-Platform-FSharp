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
type OpenGLESImageTranslate =
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLESImageTranslate
    static member instance with get() : OpenGLESImageTranslate = (OpenGLESImageTranslate.jclinit(); OpenGLESImageTranslate.jcell_instance) and set (jvalue: OpenGLESImageTranslate) = (OpenGLESImageTranslate.jclinit(); OpenGLESImageTranslate.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESImageTranslate.jclinitDone then
            OpenGLESImageTranslate.jclinitDone <- true
            OpenGLESImageTranslate.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLESImageTranslate.jcell_instance <- (new OpenGLESImageTranslate())
        ()
    new () =
        {  }
    
    static member getInstance() : OpenGLESImageTranslate =
        OpenGLESImageTranslate.instance
    
    abstract translate : gl: GL10 * openGLESImage: OpenGLESImage * x: float32 * y: float32 -> unit
    default this.translate(gl: GL10, openGLESImage: OpenGLESImage, x: float32, y: float32) : unit =
        ()
    
    abstract translate2 : gl: GL10 * openGLESImage: OpenGLESImage -> unit
    default this.translate2(gl: GL10, openGLESImage: OpenGLESImage) : unit =
        ()


