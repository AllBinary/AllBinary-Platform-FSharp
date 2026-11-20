namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ImageItem =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageItem.jclinitDone then
            ImageItem.jclinitDone <- true
            ImageItem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }


