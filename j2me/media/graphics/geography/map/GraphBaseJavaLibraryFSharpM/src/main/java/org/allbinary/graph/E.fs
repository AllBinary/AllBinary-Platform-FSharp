namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type E =
    [<DefaultValue(false)>] static val mutable private jcell_e : E
    static member e with get() : E = (E.jclinit(); E.jcell_e) and set (jvalue: E) = (E.jclinit(); E.jcell_e <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not E.jclinitDone then
            E.jclinitDone <- true
            E.jclinitBody()
    static member private jclinitBody() : unit =
        E.jcell_e <- (new E())
        ()
    new () =
        {  }
    
    abstract newInstance : unit -> E
    default this.newInstance() : E =
        E.e


