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
type OpenGLFeatureFactory =
    [<DefaultValue(false)>] val mutable OPENGL_OPTIONS : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_SURFACE_VIEW : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_2D : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_3D : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_2D_AND_3D : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_AUTO_SELECT : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_MINIMUM : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_AS_GAME_THREAD : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_AND_GAME_HAVE_DIFFERENT_THREADS : OpenGLFeature
    [<DefaultValue(false)>] val mutable IMAGE_COLOR_DEPTH_4444 : OpenGLFeature
    [<DefaultValue(false)>] val mutable IMAGE_COLOR_DEPTH_8888 : OpenGLFeature
    [<DefaultValue(false)>] val mutable IMAGE_COLOR_DEPTH_565 : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_COLOR_DEPTH_4444 : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_COLOR_DEPTH_8888 : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_COLOR_DEPTH_565 : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_DRAW_TEXTURE : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_VERTEX_BUFFER_OBJECT : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_SIMPLE_OBJECT3D_PROCESSOR : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_COMPLEX_OBJECT3D_PROCESSOR : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_SIMPLE_TEXTURE_PROCESSOR : OpenGLFeature
    [<DefaultValue(false)>] val mutable OPENGL_COMPLEX_TEXTURE_PROCESSOR : OpenGLFeature
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLFeatureFactory
    static member instance with get() : OpenGLFeatureFactory = (OpenGLFeatureFactory.jclinit(); OpenGLFeatureFactory.jcell_instance) and set (jvalue: OpenGLFeatureFactory) = (OpenGLFeatureFactory.jclinit(); OpenGLFeatureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLFeatureFactory.jclinitDone then
            OpenGLFeatureFactory.jclinitDone <- true
            OpenGLFeatureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLFeatureFactory.jcell_instance <- (new OpenGLFeatureFactory())
        ()
    member this.jfields_OpenGLFeatureFactory() : unit =
        this.OPENGL_OPTIONS <- (new OpenGLFeature("OpenGL Options"))
        this.OPENGL <- (new OpenGLFeature("OpenGL"))
        this.OPENGL_SURFACE_VIEW <- (new OpenGLFeature("GLSurfaceView"))
        this.OPENGL_2D <- (new OpenGLFeature("OpenGL 2D"))
        this.OPENGL_3D <- (new OpenGLFeature("OpenGL 3D"))
        this.OPENGL_2D_AND_3D <- (new OpenGLFeature("OpenGL 2D/3D"))
        this.OPENGL_AUTO_SELECT <- (new OpenGLFeature("Auto Select"))
        this.OPENGL_MINIMUM <- (new OpenGLFeature("Minimum"))
        this.OPENGL_AS_GAME_THREAD <- (new OpenGLFeature("As game thread"))
        this.OPENGL_AND_GAME_HAVE_DIFFERENT_THREADS <- (new OpenGLFeature("As different threads"))
        this.IMAGE_COLOR_DEPTH_4444 <- (new OpenGLFeature("4444"))
        this.IMAGE_COLOR_DEPTH_8888 <- (new OpenGLFeature("8888"))
        this.IMAGE_COLOR_DEPTH_565 <- (new OpenGLFeature("565"))
        this.OPENGL_COLOR_DEPTH_4444 <- (new OpenGLFeature("4444"))
        this.OPENGL_COLOR_DEPTH_8888 <- (new OpenGLFeature("8888"))
        this.OPENGL_COLOR_DEPTH_565 <- (new OpenGLFeature("565"))
        this.OPENGL_DRAW_TEXTURE <- (new OpenGLFeature("GL_OES_draw_texture"))
        this.OPENGL_VERTEX_BUFFER_OBJECT <- (new OpenGLFeature("vertex_buffer_object"))
        this.OPENGL_SIMPLE_OBJECT3D_PROCESSOR <- (new OpenGLFeature("Simple Object3d Processor"))
        this.OPENGL_COMPLEX_OBJECT3D_PROCESSOR <- (new OpenGLFeature("Complex Object3d Processor"))
        this.OPENGL_SIMPLE_TEXTURE_PROCESSOR <- (new OpenGLFeature("Simple Texture Processor"))
        this.OPENGL_COMPLEX_TEXTURE_PROCESSOR <- (new OpenGLFeature("Complex Texture Processor"))
        ()
    
    static member getInstance() : OpenGLFeatureFactory =
        OpenGLFeatureFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_OpenGLFeatureFactory()


