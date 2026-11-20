namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type BouncyCastleProvider =
    inherit Provider
    [<DefaultValue(false)>] static val mutable private jcell_info : string
    static member info with get() : string = (BouncyCastleProvider.jclinit(); BouncyCastleProvider.jcell_info) and set (jvalue: string) = (BouncyCastleProvider.jclinit(); BouncyCastleProvider.jcell_info <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_PROVIDER_NAME : string
    static member PROVIDER_NAME with get() : string = (BouncyCastleProvider.jclinit(); BouncyCastleProvider.jcell_PROVIDER_NAME) and set (jvalue: string) = (BouncyCastleProvider.jclinit(); BouncyCastleProvider.jcell_PROVIDER_NAME <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BouncyCastleProvider.jclinitDone then
            BouncyCastleProvider.jclinitDone <- true
            BouncyCastleProvider.jclinitBody()
    static member private jclinitBody() : unit =
        BouncyCastleProvider.jcell_info <- "BouncyCastle Security Provider v1.41"
        BouncyCastleProvider.jcell_PROVIDER_NAME <- "BC"
        ()
    
    new () =
        { inherit Provider(BouncyCastleProvider.PROVIDER_NAME, 1.41, BouncyCastleProvider.info) }
    
    member this.setParameter(parameterName: string, parameter: obj) : unit =
        ()


