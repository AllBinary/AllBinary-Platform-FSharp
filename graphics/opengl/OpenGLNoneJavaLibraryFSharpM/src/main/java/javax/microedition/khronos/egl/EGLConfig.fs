namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type EGLConfig =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not EGLConfig.jclinitDone then
            EGLConfig.jclinitDone <- true
            EGLConfig.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        raise ((new JRuntimeException()))
        ()


