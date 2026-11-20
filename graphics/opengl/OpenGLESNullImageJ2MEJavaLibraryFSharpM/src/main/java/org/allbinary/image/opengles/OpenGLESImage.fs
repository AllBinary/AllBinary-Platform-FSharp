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
type OpenGLESImage =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable textureFactory : PlatformTextureBaseFactory
    [<DefaultValue(false)>] val mutable openGLBitmap : PlatformBitmapBase
    [<DefaultValue(false)>] val mutable openGLESImageProperties : OpenGLESImageProperties
    [<DefaultValue(false)>] static val mutable private jcell_NULL_OPENGL_IMAGE : OpenGLESImage
    static member NULL_OPENGL_IMAGE with get() : OpenGLESImage = (OpenGLESImage.jclinit(); OpenGLESImage.jcell_NULL_OPENGL_IMAGE) and set (jvalue: OpenGLESImage) = (OpenGLESImage.jclinit(); OpenGLESImage.jcell_NULL_OPENGL_IMAGE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_texture2dList : BasicArrayList
    static member texture2dList with get() : BasicArrayList = (OpenGLESImage.jclinit(); OpenGLESImage.jcell_texture2dList) and set (jvalue: BasicArrayList) = (OpenGLESImage.jclinit(); OpenGLESImage.jcell_texture2dList <- jvalue)
    static member TYPE : int = 4
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESImage.jclinitDone then
            OpenGLESImage.jclinitDone <- true
            OpenGLESImage.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLESImage.jcell_NULL_OPENGL_IMAGE <- (new OpenGLESImage(NullImage.NULL_IMAGE, PlatformBitmapBaseFactory.NULL_PLATFORM_BITMAP_BASE_FACTORY, PlatformTextureBaseFactory.NULL_PLATFORM_TEXTURE_BASE_FACTORY))
        OpenGLESImage.jcell_texture2dList <- (new BasicArrayListD())
        ()
    member this.jfields_OpenGLESImage() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.openGLESImageProperties <- (new OpenGLESImageProperties())
        ()
    
    new (image: Image, bitmapFactory: PlatformBitmapBaseFactory, textureFactory: PlatformTextureBaseFactory) as this =
        {  }
        then
            this.jfields_OpenGLESImage()
            this.jctor1(image, bitmapFactory, textureFactory)
    member this.jctor1(image: Image, bitmapFactory: PlatformBitmapBaseFactory, textureFactory: PlatformTextureBaseFactory) : unit =
        this.openGLBitmap <- bitmapFactory.createBitmap(image)
        this.textureFactory <- textureFactory
        ()
    
    abstract set : gl: GL -> unit
    default this.set(gl: GL) : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract initTexture : gl: GL10 -> bool
    default this.initTexture(gl: GL10) : bool =
        false
    
    abstract drawRegion : gl: GL10 * viewHeight: int * x_src: float32 * y_src: float32 * width: float32 * height: float32 * x: int * y: int * z: int -> unit
    default this.drawRegion(gl: GL10, viewHeight: int, x_src: float32, y_src: float32, width: float32, height: float32, x: int, y: int, z: int) : unit =
        ()
    
    abstract draw : gl: GL10 * x: int * y: int * z: int -> unit
    default this.draw(gl: GL10, x: int, y: int, z: int) : unit =
        ()
    
    abstract getType : unit -> int
    default this.getType() : int =
        OpenGLESImage.TYPE
    interface OpenGLSurfaceChangedInterface with
        member this.set(jp0: GL) : unit = this.set(jp0)


