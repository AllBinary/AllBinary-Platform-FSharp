namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type LayerManager =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable systemWrapper : ABSystemWrapper
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable layerManagerLogging : LayerManagerLoggingBase
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable anyType : SynchObject
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerManager.jclinitDone then
            LayerManager.jclinitDone <- true
            LayerManager.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LayerManager() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.systemWrapper <- ABSystemWrapper.getInstance()
        this.tsUtil <- TsUtil.getInstance()
        this.list <- (new BasicArrayListD())
        this.anyType <- (new SynchObject())
        ()
    
    new (layerManagerLogging: LayerManagerLoggingBase) as this =
        {  }
        then
            this.jfields_LayerManager()
            this.jctor1(layerManagerLogging)
    member this.jctor1(layerManagerLogging: LayerManagerLoggingBase) : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        this.layerManagerLogging <- layerManagerLogging
        ()
    
    abstract contains : layerInterface: AllBinaryLayer -> bool
    default this.contains(layerInterface: AllBinaryLayer) : bool =
        this.list.contains(layerInterface)
    
    abstract update : layerInterface: AllBinaryLayer -> unit
    default this.update(layerInterface: AllBinaryLayer) : unit =
        let mutable jflow = 0
        let mutable had : bool = this.list.remove(layerInterface)
        if had then
            let mutable nextLayerInterface : AllBinaryLayer = null
            let mutable size : int = this.list.size()
            let mutable index : int = 0
            while jflow = 0 && (index < size) do
                nextLayerInterface <- (box (this.list.get(index)) :?> AllBinaryLayer)
                if layerInterface.getZP() > nextLayerInterface.getZP() then
                    this.list.addAt(index, layerInterface)
                    jflow <- 1
                if jflow = 200001 then jflow <- 0
                if jflow = 0 then index <- index + 1
            if jflow = 100001 then jflow <- 0
            if jflow = 0 then
                ignore (this.list.add(layerInterface))
    
    abstract insert : layerInterface: AllBinaryLayer -> unit
    default this.insert(layerInterface: AllBinaryLayer) : unit =
        let mutable jflow = 0
        let mutable nextLayerInterface : AllBinaryLayer = null
        let mutable size : int = this.list.size()
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            nextLayerInterface <- (box (this.list.get(index)) :?> AllBinaryLayer)
            if layerInterface.getZP() > nextLayerInterface.getZP() then
                this.appendAt(layerInterface, index)
                jflow <- 1
            if jflow = 200002 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            this.append(layerInterface)
    
    abstract append : layerInterface: AllBinaryLayer -> unit
    default this.append(layerInterface: AllBinaryLayer) : unit =
        this.layerManagerLogging.append(layerInterface)
        ignore (this.list.add(layerInterface))
    
    abstract appendAt : layerInterface: AllBinaryLayer * index: int -> unit
    default this.appendAt(layerInterface: AllBinaryLayer, index: int) : unit =
        this.layerManagerLogging.appendAt(layerInterface, index)
        this.list.addAt(index, layerInterface)
    
    abstract remove : layerInterface: AllBinaryLayer -> unit
    default this.remove(layerInterface: AllBinaryLayer) : unit =
        if true then
            ignore (this.layerManagerLogging.remove(layerInterface))
            let mutable result : bool = this.list.remove(layerInterface)
            this.layerManagerLogging.removeResult(this, layerInterface, result)
    
    abstract getLayerAt : index: int -> Layer
    default this.getLayerAt(index: int) : Layer =
        (box (this.list.objectArray.[index]) :?> Layer)
    
    abstract getSize : unit -> int
    default this.getSize() : int =
        this.list.size()
    
    abstract cleanup : unit -> unit
    default this.cleanup() : unit =
        if true then
            this.list.clear()
            this.layerManagerLogging.clear()
            this.tsUtil.gc()
            this.tsUtil.gc()
    
    abstract paint : g: Graphics * x: int * y: int -> unit
    default this.paint(g: Graphics, x: int, y: int) : unit =
        if true then
            let mutable comp : Layer = null
            let mutable index : int = this.list.size()
            while ((index <- index - 1; index)) >= 0 do
                comp <- (box (this.list.objectArray.[index]) :?> Layer)
                if (not (JR.same(comp, null))) && comp.isVisible() then
                    comp.paint(g)


