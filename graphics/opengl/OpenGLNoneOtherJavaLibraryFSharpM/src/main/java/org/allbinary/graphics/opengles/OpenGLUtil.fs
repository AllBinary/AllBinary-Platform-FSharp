namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type OpenGLUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLUtil
    static member instance with get() : OpenGLUtil = (OpenGLUtil.jclinit(); OpenGLUtil.jcell_instance) and set (jvalue: OpenGLUtil) = (OpenGLUtil.jclinit(); OpenGLUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLUtil.jclinitDone then
            OpenGLUtil.jclinitDone <- true
            OpenGLUtil.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLUtil.jcell_instance <- (new OpenGLUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : OpenGLUtil =
        OpenGLUtil.instance
    
    abstract addImage : image: Image -> Image
    default this.addImage(image: Image) : Image =
        image
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        ()
    
    abstract addRunnable : runnable: Runnable -> unit
    default this.addRunnable(runnable: Runnable) : unit =
        ()


