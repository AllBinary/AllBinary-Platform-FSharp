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
type AbstractArrayListPool =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable buffers : BasicArrayList
    [<DefaultValue(false)>] val mutable cacheableInterfaceFactoryInterface : CacheableInterfaceFactoryInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbstractArrayListPool.jclinitDone then
            AbstractArrayListPool.jclinitDone <- true
            AbstractArrayListPool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AbstractArrayListPool() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.buffers <- (new BasicArrayListD())
        ()
    
    new (cacheableInterfaceFactoryInterface: CacheableInterfaceFactoryInterface) as this =
        {  }
        then
            this.jfields_AbstractArrayListPool()
            this.jctor1(cacheableInterfaceFactoryInterface)
    member this.jctor1(cacheableInterfaceFactoryInterface: CacheableInterfaceFactoryInterface) : unit =
        this.cacheableInterfaceFactoryInterface <- cacheableInterfaceFactoryInterface
        ()
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract remove : key: obj -> CacheableInterface
    default this.remove(key: obj) : CacheableInterface =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract add : cacheableInterface: CacheableInterface -> unit
    default this.add(cacheableInterface: CacheableInterface) : unit =
        ignore (this.buffers.add(cacheableInterface))
    
    abstract addArray : cacheableInterfaces: CacheableInterface[] -> unit
    default this.addArray(cacheableInterfaces: CacheableInterface[]) : unit =
        let mutable index : int = 0
        while index < cacheableInterfaces.Length do
            ignore (this.buffers.add(cacheableInterfaces.[index]))
            index <- index + 1
    interface PoolInterface with
        member this.remove(jp0: obj) : CacheableInterface = this.remove(jp0)
    interface CacheInterface with
        member this.add(jp0: CacheableInterface) : unit = this.add(jp0)
        member this.addArray(jp0: CacheableInterface[]) : unit = this.addArray(jp0)
        member this.clear() : unit = this.clear()


