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
type OpenGLImageUtilBase =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLImageUtilBase.jclinitDone then
            OpenGLImageUtilBase.jclinitDone <- true
            OpenGLImageUtilBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract paint : alphaBitmap: OpenGLBitmap * originalBitmap: OpenGLBitmap * index: int -> OpenGLBitmap
    default this.paint(alphaBitmap: OpenGLBitmap, originalBitmap: OpenGLBitmap, index: int) : OpenGLBitmap =
        raise ((new JRuntimeException()))
    
    abstract paint : colorBitmap: OpenGLBitmap * originalBitmap: OpenGLBitmap * alpha: int * basicColor: BasicColor -> OpenGLBitmap
    default this.paint(colorBitmap: OpenGLBitmap, originalBitmap: OpenGLBitmap, alpha: int, basicColor: BasicColor) : OpenGLBitmap =
        raise ((new JRuntimeException()))
    
    abstract createImage : name: string -> OpenGLBitmap
    default this.createImage(name: string) : OpenGLBitmap =
        raise ((new JRuntimeException()))
    
    abstract createImageFromInputStream : inputStream: InputStream -> OpenGLBitmap
    default this.createImageFromInputStream(inputStream: InputStream) : OpenGLBitmap =
        raise ((new JRuntimeException()))


