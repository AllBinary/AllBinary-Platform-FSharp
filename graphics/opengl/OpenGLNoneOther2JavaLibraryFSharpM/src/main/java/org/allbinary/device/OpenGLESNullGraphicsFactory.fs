namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type OpenGLESNullGraphicsFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLESGraphics
    static member instance with get() : OpenGLESGraphics = (OpenGLESNullGraphicsFactory.jclinit(); OpenGLESNullGraphicsFactory.jcell_instance) and set (jvalue: OpenGLESGraphics) = (OpenGLESNullGraphicsFactory.jclinit(); OpenGLESNullGraphicsFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLESNullGraphicsFactory.jclinitDone then
            OpenGLESNullGraphicsFactory.jclinitDone <- true
            OpenGLESNullGraphicsFactory.jclinitBody()
    static member private jclinitBody() : unit =
        OpenGLESNullGraphicsFactory.jcell_instance <- (new OpenGLESGraphics())
        ()
    new () =
        {  }
    
    static member getInstance() : OpenGLESGraphics =
        OpenGLESNullGraphicsFactory.instance


