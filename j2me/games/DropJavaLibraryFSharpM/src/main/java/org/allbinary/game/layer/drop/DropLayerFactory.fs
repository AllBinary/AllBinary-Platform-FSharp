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
type DropLayerFactory =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable basicArrayListUtil : BasicArrayListUtil
    [<DefaultValue(false)>] static val mutable private jcell_DROP_LAYER_FACTORY : DropLayerFactory
    static member DROP_LAYER_FACTORY with get() : DropLayerFactory = (DropLayerFactory.jclinit(); DropLayerFactory.jcell_DROP_LAYER_FACTORY) and set (jvalue: DropLayerFactory) = (DropLayerFactory.jclinit(); DropLayerFactory.jcell_DROP_LAYER_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DropLayerFactory.jclinitDone then
            DropLayerFactory.jclinitDone <- true
            DropLayerFactory.jclinitBody()
    static member private jclinitBody() : unit =
        DropLayerFactory.jcell_DROP_LAYER_FACTORY <- (new DropLayerFactory())
        ()
    member this.jfields_DropLayerFactory() : unit =
        this.list <- (new BasicArrayListD())
        this.basicArrayListUtil <- BasicArrayListUtil.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_DropLayerFactory()
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.list.clear()
    
    static member getInstance() : DropLayerFactory =
        DropLayerFactory.DROP_LAYER_FACTORY
    
    abstract getSize : unit -> int
    default this.getSize() : int =
        this.list.size()
    
    abstract getRandomInstance : unit -> PickedUpLayerInterfaceFactoryInterface
    default this.getRandomInstance() : PickedUpLayerInterfaceFactoryInterface =
        (box (this.basicArrayListUtil.getRandom(this.list)) :?> PickedUpLayerInterfaceFactoryInterface)
    
    abstract add : layerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface -> unit
    default this.add(layerInterfaceFactoryInterface: PickedUpLayerInterfaceFactoryInterface) : unit =
        ignore (this.list.add(layerInterfaceFactoryInterface))
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.list


