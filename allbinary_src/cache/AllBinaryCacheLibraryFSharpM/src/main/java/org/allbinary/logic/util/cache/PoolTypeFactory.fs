namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type PoolTypeFactory =
    [<DefaultValue(false)>] val mutable VECTOR_POOL : PoolType
    [<DefaultValue(false)>] static val mutable private jcell_instance : PoolTypeFactory
    static member instance with get() : PoolTypeFactory = (PoolTypeFactory.jclinit(); PoolTypeFactory.jcell_instance) and set (jvalue: PoolTypeFactory) = (PoolTypeFactory.jclinit(); PoolTypeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PoolTypeFactory.jclinitDone then
            PoolTypeFactory.jclinitDone <- true
            PoolTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PoolTypeFactory.jcell_instance <- (new PoolTypeFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_PoolTypeFactory()
    member this.jfields_PoolTypeFactory() : unit =
        this.VECTOR_POOL <- (new PoolType(CacheTypeFactory.getInstance().NO_CACHE))
        ()
    
    static member getInstance() : PoolTypeFactory =
        PoolTypeFactory.instance


