namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type CacheTypeFactory =
    [<DefaultValue(false)>] val mutable NO_CACHE : CacheType
    [<DefaultValue(false)>] val mutable CACHE : CacheType
    [<DefaultValue(false)>] val mutable SET : CacheType
    [<DefaultValue(false)>] val mutable CACHE_VECTOR : CacheType
    [<DefaultValue(false)>] static val mutable private jcell_instance : CacheTypeFactory
    static member instance with get() : CacheTypeFactory = (CacheTypeFactory.jclinit(); CacheTypeFactory.jcell_instance) and set (jvalue: CacheTypeFactory) = (CacheTypeFactory.jclinit(); CacheTypeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CacheTypeFactory.jclinitDone then
            CacheTypeFactory.jclinitDone <- true
            CacheTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CacheTypeFactory.jcell_instance <- (new CacheTypeFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_CacheTypeFactory()
    member this.jfields_CacheTypeFactory() : unit =
        this.NO_CACHE <- (new CacheType(StringUtil.getInstance().EMPTY_STRING, StringUtil.getInstance().EMPTY_STRING))
        this.CACHE <- (new CacheType(StringUtil.getInstance().EMPTY_STRING, StringUtil.getInstance().EMPTY_STRING))
        this.SET <- (new CacheType(StringUtil.getInstance().EMPTY_STRING, "Set"))
        this.CACHE_VECTOR <- (new CacheType(StringUtil.getInstance().EMPTY_STRING, StringUtil.getInstance().EMPTY_STRING))
        ()
    
    static member getInstance() : CacheTypeFactory =
        CacheTypeFactory.instance


