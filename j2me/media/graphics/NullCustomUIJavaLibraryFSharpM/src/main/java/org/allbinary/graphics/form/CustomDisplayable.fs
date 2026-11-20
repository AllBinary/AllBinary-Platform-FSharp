namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type CustomDisplayable =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomDisplayable.jclinitDone then
            CustomDisplayable.jclinitDone <- true
            CustomDisplayable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract setTitle : title: string -> unit
    default this.setTitle(title: string) : unit =
        ()


