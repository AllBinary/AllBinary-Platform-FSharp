namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type XmlRpcException =
    inherit JException
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not XmlRpcException.jclinitDone then
            XmlRpcException.jclinitDone <- true
            XmlRpcException.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (code: int, message: string) =
        { inherit JException(message) }


