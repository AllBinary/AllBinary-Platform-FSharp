namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type OpenGLObject3dProcessor =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLObject3dProcessor.jclinitDone then
            OpenGLObject3dProcessor.jclinitDone <- true
            OpenGLObject3dProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_OpenGLObject3dProcessor()
    member this.jfields_OpenGLObject3dProcessor() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    abstract process_ : gl: GL10 * object3d: obj -> unit
    default this.process_(gl: GL10, object3d: obj) : unit =
        ()
    
    abstract process_ : gl: GL10 * object3d: obj * index: int -> unit
    default this.process_(gl: GL10, object3d: obj, index: int) : unit =
        ()


