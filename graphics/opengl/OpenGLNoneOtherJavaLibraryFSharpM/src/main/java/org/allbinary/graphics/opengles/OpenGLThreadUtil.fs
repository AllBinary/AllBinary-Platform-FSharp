namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type OpenGLThreadUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLThreadUtil
    static member instance with get() : OpenGLThreadUtil = (OpenGLThreadUtil.jclinit(); OpenGLThreadUtil.jcell_instance) and set (jvalue: OpenGLThreadUtil) = (OpenGLThreadUtil.jclinit(); OpenGLThreadUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLThreadUtil.jclinitDone then
            OpenGLThreadUtil.jclinitDone <- true
            OpenGLThreadUtil.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLThreadUtil.jcell_instance <- (new OpenGLThreadUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : OpenGLThreadUtil =
        OpenGLThreadUtil.instance
    
    abstract set : glSurfaceView: obj -> unit
    default this.set(glSurfaceView: obj) : unit =
        ()
    
    abstract onPause : unit -> unit
    default this.onPause() : unit =
        ()
    
    abstract onResume : unit -> unit
    default this.onResume() : unit =
        ()


