namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type V =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not V.jclinitDone then
            V.jclinitDone <- true
            V.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getId : unit -> int
    default this.getId() : int =
        0


