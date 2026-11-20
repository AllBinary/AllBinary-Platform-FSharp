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
type BasicArrayListResetablePool =
    inherit AbstractArrayListPool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicArrayListResetablePool.jclinitDone then
            BasicArrayListResetablePool.jclinitDone <- true
            BasicArrayListResetablePool.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (cacheableInterfaceFactoryInterface: CacheableInterfaceFactoryInterface) =
        { inherit AbstractArrayListPool(cacheableInterfaceFactoryInterface) }
    
    override this.clear() : unit =
        ()
    
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


