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
type BasicArrayListPool =
    inherit AbstractArrayListPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicArrayListPool.jclinitDone then
            BasicArrayListPool.jclinitDone <- true
            BasicArrayListPool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (cacheableInterfaceFactoryInterface: CacheableInterfaceFactoryInterface) =
        { inherit AbstractArrayListPool(cacheableInterfaceFactoryInterface) }
    
    override this.clear() : unit =
        this.buffers.clear()
    
    override this.remove(key: obj) : CacheableInterface =
        let mutable jflow = 0
        let mutable jret : CacheableInterface = Unchecked.defaultof<CacheableInterface>
        let mutable size : int = this.buffers.size()
        if size > 0 then
            jret <- (box (this.buffers.removeAt((size - 1))) :?> CacheableInterface)
            jflow <- 1
        else
            jret <- this.cacheableInterfaceFactoryInterface.getInstance(key)
            jflow <- 1
        jret
    
    abstract addAll : usedList: BasicArrayList -> unit
    default this.addAll(usedList: BasicArrayList) : unit =
        let mutable index : int = usedList.size()
        while ((index <- index - 1; index)) >= 0 do
            let mutable anyType : CacheableInterface = (box (usedList.objectArray.[index]) :?> CacheableInterface)
            ignore (this.add(anyType))
        usedList.clear()
    
    abstract releaseUsedBackToPool : usedList: BasicArrayList -> unit
    default this.releaseUsedBackToPool(usedList: BasicArrayList) : unit =
        let mutable index : int = usedList.size()
        while ((index <- index - 1; index)) >= 0 do
            let mutable list_ : BasicArrayListCacheable = (box (usedList.objectArray.[index]) :?> BasicArrayListCacheable)
            if list_.size() = 0 then
                ignore (usedList.removeAt(index))
                ignore (this.add(list_))


