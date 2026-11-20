namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type Deprecated =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Deprecated.jclinitDone then
            Deprecated.jclinitDone <- true
            Deprecated.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }


