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
type CountedPickedUpLayerInterfaceFactoryPool =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : CountedPickedUpLayerInterfaceFactoryPool
    static member SINGLETON with get() : CountedPickedUpLayerInterfaceFactoryPool = (CountedPickedUpLayerInterfaceFactoryPool.jclinit(); CountedPickedUpLayerInterfaceFactoryPool.jcell_SINGLETON) and set (jvalue: CountedPickedUpLayerInterfaceFactoryPool) = (CountedPickedUpLayerInterfaceFactoryPool.jclinit(); CountedPickedUpLayerInterfaceFactoryPool.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CountedPickedUpLayerInterfaceFactoryPool.jclinitDone then
            CountedPickedUpLayerInterfaceFactoryPool.jclinitDone <- true
            CountedPickedUpLayerInterfaceFactoryPool.jclinitBody()
    static member private jclinitBody() : unit =
        CountedPickedUpLayerInterfaceFactoryPool.jcell_SINGLETON <- (new CountedPickedUpLayerInterfaceFactoryPool())
        ()
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.list
    
    static member getInstance() : CountedPickedUpLayerInterfaceFactoryPool =
        CountedPickedUpLayerInterfaceFactoryPool.SINGLETON
    
    static member init() : unit =
        CountedPickedUpLayerInterfaceFactoryPool.SINGLETON <- (new CountedPickedUpLayerInterfaceFactoryPool())


