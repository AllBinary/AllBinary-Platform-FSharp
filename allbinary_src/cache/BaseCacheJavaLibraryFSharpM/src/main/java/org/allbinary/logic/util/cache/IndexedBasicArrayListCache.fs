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
type IndexedBasicArrayListCache =
    inherit BaseBasicArrayListCache
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable size : int
    [<DefaultValue(false)>] val mutable index : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not IndexedBasicArrayListCache.jclinitDone then
            IndexedBasicArrayListCache.jclinitDone <- true
            IndexedBasicArrayListCache.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_IndexedBasicArrayListCache() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.size <- 0
        this.index <- 0
        ()
    
    static member createCache(size: int) : IndexedBasicArrayListCache =
        let mutable indexedBasicArrayListCache : IndexedBasicArrayListCache = (new IndexedBasicArrayListCache())
        indexedBasicArrayListCache.init(size)
        indexedBasicArrayListCache
    
    new () as this =
        { inherit BaseBasicArrayListCache() }
        then
            this.jfields_IndexedBasicArrayListCache()
    
    abstract init : size: int -> unit
    default this.init(size: int) : unit =
        if this.size < size then
            this.list.ensureCapacity(size)
            let mutable index : int = size - 1
            while index >= this.size do
                this.addDefault()
                index <- index - 1
            this.size <- size
    
    abstract getAt : index: int -> obj
    default this.getAt(index: int) : obj =
        this.list.objectArray.[index]
    
    abstract addDefault : unit -> unit
    default this.addDefault() : unit =
        ()
    
    abstract addObject : anyType: obj -> unit
    default this.addObject(anyType: obj) : unit =
        ignore (this.list.add(anyType))
    
    abstract add : cacheableInterface: CacheableInterface -> unit
    default this.add(cacheableInterface: CacheableInterface) : unit =
        ignore (this.list.add(cacheableInterface))
    
    abstract addArray : cacheableInterfaces: CacheableInterface[] -> unit
    default this.addArray(cacheableInterfaces: CacheableInterface[]) : unit =
        raise ((new JException("No Imple")))
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.index <- 0
    interface CacheInterface with
        member this.add(jp0: CacheableInterface) : unit = this.add(jp0)
        member this.addArray(jp0: CacheableInterface[]) : unit = this.addArray(jp0)
        member this.clear() : unit = this.clear()


