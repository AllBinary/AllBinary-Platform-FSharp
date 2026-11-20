namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2007 AllBinary 
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
type PoolType =
    [<DefaultValue(false)>] val mutable cacheType : CacheType
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PoolType.jclinitDone then
            PoolType.jclinitDone <- true
            PoolType.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (cacheType: CacheType) as this =
        {  }
        then
            this.jctor1(cacheType)
    member this.jctor1(cacheType: CacheType) : unit =
        this.cacheType <- cacheType
        ()
    
    abstract getCacheType : unit -> CacheType
    default this.getCacheType() : CacheType =
        this.cacheType
    
    override this.ToString() : string =
        let mutable POOL_TYPE : string = "PoolType: "
        JR.nn(POOL_TYPE) + JR.nn(this.getCacheType().ToString())


