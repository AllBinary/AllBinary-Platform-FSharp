namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type ABImageStringItem =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ABImageStringItem.jclinitDone then
            ABImageStringItem.jclinitDone <- true
            ABImageStringItem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }


