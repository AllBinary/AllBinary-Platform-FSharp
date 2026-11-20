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
type OpenGLImageFactory =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_OPENGL_IMAGE_FACTORY : OpenGLImageFactory
    static member NULL_OPENGL_IMAGE_FACTORY with get() : OpenGLImageFactory = (OpenGLImageFactory.jclinit(); OpenGLImageFactory.jcell_NULL_OPENGL_IMAGE_FACTORY) and set (jvalue: OpenGLImageFactory) = (OpenGLImageFactory.jclinit(); OpenGLImageFactory.jcell_NULL_OPENGL_IMAGE_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLImageFactory.jclinitDone then
            OpenGLImageFactory.jclinitDone <- true
            OpenGLImageFactory.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLImageFactory.jcell_NULL_OPENGL_IMAGE_FACTORY <- (new OpenGLImageFactory())
        ()
    new () =
        {  }
    
    abstract getInstance : image: Image * bitmapFactory: PlatformBitmapBaseFactory * textureFactory: PlatformTextureBaseFactory -> Image
    default this.getInstance(image: Image, bitmapFactory: PlatformBitmapBaseFactory, textureFactory: PlatformTextureBaseFactory) : Image =
        raise ((new JRuntimeException()))


