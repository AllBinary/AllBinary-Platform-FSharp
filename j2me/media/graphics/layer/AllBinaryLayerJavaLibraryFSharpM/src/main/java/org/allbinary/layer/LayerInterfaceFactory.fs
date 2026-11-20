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
type LayerInterfaceFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable HASHTABLE_LABEL : string
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : LayerInterfaceFactory
    static member SINGLETON with get() : LayerInterfaceFactory = (LayerInterfaceFactory.jclinit(); LayerInterfaceFactory.jcell_SINGLETON) and set (jvalue: LayerInterfaceFactory) = (LayerInterfaceFactory.jclinit(); LayerInterfaceFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerInterfaceFactory.jclinitDone then
            LayerInterfaceFactory.jclinitDone <- true
            LayerInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LayerInterfaceFactory.jcell_SINGLETON <- (new LayerInterfaceFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_LayerInterfaceFactory()
    member this.jfields_LayerInterfaceFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.list <- BasicArrayListUtil.getInstance().getImmutableInstance()
        this.HASHTABLE_LABEL <- "Hashtable: "
        ()
    
    static member getInstance() : LayerInterfaceFactory =
        LayerInterfaceFactory.SINGLETON
    
    abstract init : unit -> unit
    default this.init() : unit =
        this.list <- (new BasicArrayListD())
    
    abstract getNexInstance : hashtable: ABHashtable * x: int * y: int * z: int -> AllBinaryLayer
    default this.getNexInstance(hashtable: ABHashtable, x: int, y: int, z: int) : AllBinaryLayer =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        this.logUtil.putF((new StringMaker()).append(this.HASHTABLE_LABEL).append(StringUtil.getInstance().toString(hashtable)).ToString(), this, commonStrings.GET_INSTANCE)
        let mutable typeInteger : Integer = (box (hashtable.get((box (Layer.ID)))) :?> Integer)
        let mutable layerInterfaceFactoryInterface : LayerInterfaceFactoryInterface = (box (this.list.objectArray.[typeInteger.intValue() - 1]) :?> LayerInterfaceFactoryInterface)
        layerInterfaceFactoryInterface.getNextInstance(hashtable, x, y, z)
    
    abstract add : layerInterfaceFactoryInterface: LayerInterfaceFactoryInterface -> unit
    default this.add(layerInterfaceFactoryInterface: LayerInterfaceFactoryInterface) : unit =
        ignore (this.list.add(layerInterfaceFactoryInterface))


