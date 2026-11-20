namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type CustomScreen =
    inherit CustomDisplayable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomScreen.jclinitDone then
            CustomScreen.jclinitDone <- true
            CustomScreen.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        { inherit CustomDisplayable() }


