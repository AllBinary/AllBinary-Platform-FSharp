namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type OpenGLESGraphicsFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESGraphicsFactory.jclinitDone then
            OpenGLESGraphicsFactory.jclinitDone <- true
            OpenGLESGraphicsFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getOpenGLESGraphicsInstance : unit -> OpenGLESGraphics
    default this.getOpenGLESGraphicsInstance() : OpenGLESGraphics =
        OpenGLESNullGraphicsFactory.getInstance()


