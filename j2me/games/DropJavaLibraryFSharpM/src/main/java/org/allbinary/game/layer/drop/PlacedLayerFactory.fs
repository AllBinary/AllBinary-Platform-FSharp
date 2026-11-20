namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type PlacedLayerFactory =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable basicArrayListUtil : BasicArrayListUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : PlacedLayerFactory
    static member instance with get() : PlacedLayerFactory = (PlacedLayerFactory.jclinit(); PlacedLayerFactory.jcell_instance) and set (jvalue: PlacedLayerFactory) = (PlacedLayerFactory.jclinit(); PlacedLayerFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlacedLayerFactory.jclinitDone then
            PlacedLayerFactory.jclinitDone <- true
            PlacedLayerFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PlacedLayerFactory.jcell_instance <- (new PlacedLayerFactory())
        ()
    member this.jfields_PlacedLayerFactory() : unit =
        this.list <- (new BasicArrayListD())
        this.basicArrayListUtil <- BasicArrayListUtil.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_PlacedLayerFactory()
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.list.clear()
    
    static member getInstance() : PlacedLayerFactory =
        PlacedLayerFactory.instance
    
    abstract getSize : unit -> int
    default this.getSize() : int =
        this.list.size()
    
    abstract getRandomInstance : unit -> AllBinaryLayerFactoryInterface
    default this.getRandomInstance() : AllBinaryLayerFactoryInterface =
        (box (this.basicArrayListUtil.getRandom(this.list)) :?> AllBinaryLayerFactoryInterface)
    
    abstract add : layerInterfaceFactoryInterface: AllBinaryLayerFactoryInterface -> unit
    default this.add(layerInterfaceFactoryInterface: AllBinaryLayerFactoryInterface) : unit =
        ignore (this.list.add(layerInterfaceFactoryInterface))


