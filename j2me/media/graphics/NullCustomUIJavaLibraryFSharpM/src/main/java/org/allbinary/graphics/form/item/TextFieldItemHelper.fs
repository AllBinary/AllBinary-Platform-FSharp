namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type TextFieldItemHelper =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TextFieldItemHelper.jclinitDone then
            TextFieldItemHelper.jclinitDone <- true
            TextFieldItemHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }


