namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type Resource =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Resource.jclinitDone then
            Resource.jclinitDone <- true
            Resource.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract dispose : unit -> unit
    default this.dispose() : unit =
        ()
    
    abstract isDisposed : unit -> bool
    default this.isDisposed() : bool =
        false


