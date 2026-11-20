namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type OpenGLESGraphics =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable gl : GL10
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESGraphics.jclinitDone then
            OpenGLESGraphics.jclinitDone <- true
            OpenGLESGraphics.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_OpenGLESGraphics() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.gl <- NullGL10.NULL_GL10
        ()
    
    new () as this =
        {  }
        then
            this.jfields_OpenGLESGraphics()
    
    abstract updateGL : gl: GL -> unit
    default this.updateGL(gl: GL) : unit =
        ()
    
    abstract set : gl: GL -> unit
    default this.set(gl: GL) : unit =
        ()
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract update : unit -> unit
    default this.update() : unit =
        ()
    
    abstract setOrthoginalMode : unit -> unit
    default this.setOrthoginalMode() : unit =
        ()
    
    abstract setCameraMode : unit -> unit
    default this.setCameraMode() : unit =
        ()
    
    abstract getGlP : unit -> GL10
    default this.getGlP() : GL10 =
        this.gl
    
    abstract setFontDebug : font: Font * fontDebug: FontDebugBase -> unit
    default this.setFontDebug(font: Font, fontDebug: FontDebugBase) : unit =
        raise ((new JRuntimeException()))
    interface OpenGLSurfaceChangedInterface with
        member this.set(jp0: GL) : unit = this.set(jp0)
    interface GraphicsInterface with
        member this.setFontDebug(jp0: Font, jp1: FontDebugBase) : unit = this.setFontDebug(jp0, jp1)


