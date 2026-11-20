namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type XmlRpcClient =
    [<DefaultValue(false)>] val mutable url : URL
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not XmlRpcClient.jclinitDone then
            XmlRpcClient.jclinitDone <- true
            XmlRpcClient.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (url: string) as this =
        {  }
        then
            this.jctor1(url)
    member this.jctor1(url: string) : unit =
        this.url <- (new URL(url))
        ()
    
    abstract getURL : unit -> URL
    default this.getURL() : URL =
        this.url
    
    abstract setBasicAuthentication : user: string * password: string -> unit
    default this.setBasicAuthentication(user: string, password: string) : unit =
        ()
    
    abstract execute : method_: string * params_: BasicArrayList -> obj
    default this.execute(method_: string, params_: BasicArrayList) : obj =
        NullUtil.getInstance().NULL_OBJECT
    
    abstract executeWithCrypt : method_: string * params_: BasicArrayList * cryptInterface: CryptInterface -> obj
    default this.executeWithCrypt(method_: string, params_: BasicArrayList, cryptInterface: CryptInterface) : obj =
        NullUtil.getInstance().NULL_OBJECT
    interface XmlRpcHandler with
        member this.execute(jp0: string, jp1: BasicArrayList) : obj = this.execute(jp0, jp1)


