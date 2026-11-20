namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ShaderOpenGLProcessor =
    inherit OpenGLProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ShaderOpenGLProcessor.jclinitDone then
            ShaderOpenGLProcessor.jclinitDone <- true
            ShaderOpenGLProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit OpenGLProcessor() }
    
    abstract process0 : gl: GL10 -> unit
    default this.process0(gl: GL10) : unit =
        ()
    
    abstract process1 : gl: GL10 -> unit
    default this.process1(gl: GL10) : unit =
        ()
    
    override this.process_(gl: GL10) : unit =
        ()
    
    abstract process2 : gl: GL10 -> unit
    default this.process2(gl: GL10) : unit =
        ()
    
    abstract process3 : gl: GL10 -> unit
    default this.process3(gl: GL10) : unit =
        ()


