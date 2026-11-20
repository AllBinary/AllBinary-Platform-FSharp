namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type CachePolicyFactory =
    [<DefaultValue(false)>] val mutable NAME : string
    [<DefaultValue(false)>] val mutable MAX_TIME_THOUSAND_MAX : CachePolicy
    [<DefaultValue(false)>] val mutable THIRTY_MINUTES_TEN_THOUSAND_MAX : CachePolicy
    [<DefaultValue(false)>] val mutable THIRTY_MINUTES_FIFTY_THOUSAND_MAX : CachePolicy
    [<DefaultValue(false)>] val mutable ONE_MINUTE_FIVE_MAX : CachePolicy
    [<DefaultValue(false)>] val mutable ONE_MINUTE_TEN_MAX : CachePolicy
    [<DefaultValue(false)>] val mutable ONE_MINUTE_ONE_HUNDRED_MAX : CachePolicy
    [<DefaultValue(false)>] static val mutable private jcell_instance : CachePolicyFactory
    static member instance with get() : CachePolicyFactory = (CachePolicyFactory.jclinit(); CachePolicyFactory.jcell_instance) and set (jvalue: CachePolicyFactory) = (CachePolicyFactory.jclinit(); CachePolicyFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CachePolicyFactory.jclinitDone then
            CachePolicyFactory.jclinitDone <- true
            CachePolicyFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CachePolicyFactory.jcell_instance <- (new CachePolicyFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_CachePolicyFactory()
    member this.jfields_CachePolicyFactory() : unit =
        this.NAME <- "lru"
        this.MAX_TIME_THOUSAND_MAX <- (new CachePolicy(this.NAME, Long.MAX_VALUE, 1000L))
        this.THIRTY_MINUTES_TEN_THOUSAND_MAX <- (new CachePolicy(this.NAME, int64 ((1000 * 60) * 30), 10000L))
        this.THIRTY_MINUTES_FIFTY_THOUSAND_MAX <- (new CachePolicy(this.NAME, int64 ((1000 * 60) * 30), 100000L))
        this.ONE_MINUTE_FIVE_MAX <- (new CachePolicy(this.NAME, int64 ((1000 * 60) * 1), 5L))
        this.ONE_MINUTE_TEN_MAX <- (new CachePolicy(this.NAME, int64 ((1000 * 60) * 1), 10L))
        this.ONE_MINUTE_ONE_HUNDRED_MAX <- (new CachePolicy(this.NAME, int64 ((1000 * 60) * 1), 100L))
        ()
    
    static member getInstance() : CachePolicyFactory =
        CachePolicyFactory.instance


