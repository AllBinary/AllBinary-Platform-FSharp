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
type OpenGLESImageProcessor =
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLESImageProcessor
    static member instance with get() : OpenGLESImageProcessor = (OpenGLESImageProcessor.jclinit(); OpenGLESImageProcessor.jcell_instance) and set (jvalue: OpenGLESImageProcessor) = (OpenGLESImageProcessor.jclinit(); OpenGLESImageProcessor.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESImageProcessor.jclinitDone then
            OpenGLESImageProcessor.jclinitDone <- true
            OpenGLESImageProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLESImageProcessor.jcell_instance <- (new OpenGLESImageProcessor())
        ()
    new () =
        {  }
    
    static member getInstance() : OpenGLESImageProcessor =
        OpenGLESImageProcessor.instance
    
    abstract translate : gl: GL10 * translateX: float32 * translateY: float32 -> unit
    default this.translate(gl: GL10, translateX: float32, translateY: float32) : unit =
        ()
    
    abstract rotate : gl: GL10 * angle: float32 -> unit
    default this.rotate(gl: GL10, angle: float32) : unit =
        ()
    
    abstract scale : gl: GL10 * scaleX: float32 * scaleY: float32 -> unit
    default this.scale(gl: GL10, scaleX: float32, scaleY: float32) : unit =
        ()
    
    abstract colorMask : gl: GL10 * red: float32 * green: float32 * blue: float32 * alpha: float32 -> unit
    default this.colorMask(gl: GL10, red: float32, green: float32, blue: float32, alpha: float32) : unit =
        ()


