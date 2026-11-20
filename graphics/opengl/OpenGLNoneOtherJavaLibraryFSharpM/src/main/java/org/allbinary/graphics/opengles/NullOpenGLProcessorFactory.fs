namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type NullOpenGLProcessorFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : OpenGLProcessor
    static member instance with get() : OpenGLProcessor = (NullOpenGLProcessorFactory.jclinit(); NullOpenGLProcessorFactory.jcell_instance) and set (jvalue: OpenGLProcessor) = (NullOpenGLProcessorFactory.jclinit(); NullOpenGLProcessorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullOpenGLProcessorFactory.jclinitDone then
            NullOpenGLProcessorFactory.jclinitDone <- true
            NullOpenGLProcessorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NullOpenGLProcessorFactory.jcell_instance <- (new OpenGLProcessor())
        ()
    new () =
        {  }
    
    static member getInstance() : OpenGLProcessor =
        NullOpenGLProcessorFactory.instance


