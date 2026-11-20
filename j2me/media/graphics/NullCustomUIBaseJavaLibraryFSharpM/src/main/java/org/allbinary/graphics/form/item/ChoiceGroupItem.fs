namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ChoiceGroupItem =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ChoiceGroupItem.jclinitDone then
            ChoiceGroupItem.jclinitDone <- true
            ChoiceGroupItem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }


