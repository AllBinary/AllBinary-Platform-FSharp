namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type OpenGLProcessor =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLProcessor.jclinitDone then
            OpenGLProcessor.jclinitDone <- true
            OpenGLProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_OpenGLProcessor()
    member this.jfields_OpenGLProcessor() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    abstract process_ : gl: GL10 -> unit
    default this.process_(gl: GL10) : unit =
        ()


