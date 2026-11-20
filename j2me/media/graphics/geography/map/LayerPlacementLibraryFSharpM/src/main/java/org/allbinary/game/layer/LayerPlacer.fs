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
type LayerPlacer =
    [<DefaultValue(false)>] val mutable enumerationUtil : EnumerationUtil
    [<DefaultValue(false)>] val mutable layerInterfaceVisitor : LayerInterfaceVisitor
    [<DefaultValue(false)>] val mutable dimension : GPoint
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerPlacer.jclinitDone then
            LayerPlacer.jclinitDone <- true
            LayerPlacer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LayerPlacer() : unit =
        this.enumerationUtil <- EnumerationUtil.getInstance()
        ()
    
    new (layerInterfaceVisitor: LayerInterfaceVisitor, dimension: GPoint) as this =
        {  }
        then
            this.jfields_LayerPlacer()
            this.jctor1(layerInterfaceVisitor, dimension)
    member this.jctor1(layerInterfaceVisitor: LayerInterfaceVisitor, dimension: GPoint) : unit =
        this.layerInterfaceVisitor <- layerInterfaceVisitor
        this.dimension <- dimension
        ()
    
    abstract processList : list_: BasicArrayList -> unit
    default this.processList(list_: BasicArrayList) : unit =
        let mutable size : int = list_.size()
        let mutable layerPlacementInterface : LayerPlacementInterface = null
        let mutable index : int = 0
        while index < size do
            layerPlacementInterface <- (box (list_.objectArray.[index]) :?> LayerPlacementInterface)
            this.process_(layerPlacementInterface)
            index <- index + 1
    
    abstract process_ : layerPlacementInterface: LayerPlacementInterface -> unit
    default this.process_(layerPlacementInterface: LayerPlacementInterface) : unit =
        let mutable relativePoint : GPoint = this.getPoint(layerPlacementInterface)
        let mutable layerInterfaceFactory : LayerInterfaceFactory = LayerInterfaceFactory.getInstance()
        let mutable hashtable : ABHashtable = layerPlacementInterface.getInstance()
        let mutable enumeration : Enumeration = hashtable.keys()
        let mutable point : GPoint = null
        let mutable layerHashtable : ABHashtable = null
        let mutable x : int = 0
        let mutable y : int = 0
        let mutable z : int = 0
        let mutable layerInterface : AllBinaryLayer = null
        while this.enumerationUtil.hasMoreElements(enumeration) do
            point <- (box (this.enumerationUtil.nextElement(enumeration)) :?> GPoint)
            layerHashtable <- (box (hashtable.get(point)) :?> ABHashtable)
            x <- point.getX() + relativePoint.getX()
            y <- point.getY() + relativePoint.getY()
            z <- point.getZ() + relativePoint.getZ()
            layerInterface <- layerInterfaceFactory.getNexInstance(layerHashtable, x, y, z)
            this.layerInterfaceVisitor.visit(layerInterface)
    
    abstract getPoint : layerPlacementInterface: LayerPlacementInterface -> GPoint
    default this.getPoint(layerPlacementInterface: LayerPlacementInterface) : GPoint =
        let mutable jflow = 0
        let mutable jret : GPoint = Unchecked.defaultof<GPoint>
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable layerPlacementType : LayerPlacementType = layerPlacementInterface.getLayerType()
        if (JR.same(layerPlacementType, LayerPlacementTypeFactory.getInstance().MAP)) then
            let mutable width : int = layerPlacementInterface.getWidth()
            let mutable height : int = layerPlacementInterface.getHeight()
            let mutable x : int = ((this.dimension.getX() - width) / 2)
            let mutable y : int = ((this.dimension.getY() - height) / 2)
            jret <- pointFactory.createXY(x, y)
            jflow <- 1
        elif (JR.same(layerPlacementType, LayerPlacementTypeFactory.getInstance().UP)) then
            let mutable width : int = layerPlacementInterface.getWidth()
            let mutable height : int = layerPlacementInterface.getHeight()
            let mutable x : int = ((this.dimension.getX() - width) / 2)
            let mutable y : int = -(height)
            jret <- pointFactory.createXY(x, y)
            jflow <- 1
        else
            raise ((new JException("PlacementType Not Recognized")))
        jret


