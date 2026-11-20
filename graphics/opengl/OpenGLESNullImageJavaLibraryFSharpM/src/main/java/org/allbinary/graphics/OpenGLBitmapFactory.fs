namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type OpenGLBitmapFactory =
    inherit PlatformBitmapBaseFactory
    [<DefaultValue(false)>] val mutable ARGB_8888 : OpenGLBitmapConfig
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLBitmapFactory
    static member instance with get() : OpenGLBitmapFactory = (OpenGLBitmapFactory.jclinit(); OpenGLBitmapFactory.jcell_instance) and set (jvalue: OpenGLBitmapFactory) = (OpenGLBitmapFactory.jclinit(); OpenGLBitmapFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLBitmapFactory.jclinitDone then
            OpenGLBitmapFactory.jclinitDone <- true
            OpenGLBitmapFactory.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLBitmapFactory.jcell_instance <- (new OpenGLBitmapFactory())
        ()
    new () as this =
        { inherit PlatformBitmapBaseFactory() }
        then
            this.jfields_OpenGLBitmapFactory()
    member this.jfields_OpenGLBitmapFactory() : unit =
        this.ARGB_8888 <- (new OpenGLBitmapConfig(NullUtil.getInstance().NULL_OBJECT))
        ()
    
    static member getInstance() : OpenGLBitmapFactory =
        OpenGLBitmapFactory.instance
    
    abstract createBitmap : width: int * height: int * config: OpenGLBitmapConfig -> OpenGLBitmap
    default this.createBitmap(width: int, height: int, config: OpenGLBitmapConfig) : OpenGLBitmap =
        (new OpenGLBitmap(NullUtil.getInstance().NULL_OBJECT))
    
    abstract decodeStream : inputStream: InputStream -> OpenGLBitmap
    default this.decodeStream(inputStream: InputStream) : OpenGLBitmap =
        (new OpenGLBitmap(NullUtil.getInstance().NULL_OBJECT))
    
    override this.createBitmap(image: Image) : PlatformBitmapBase =
        (new OpenGLBitmap(NullUtil.getInstance().NULL_OBJECT))


