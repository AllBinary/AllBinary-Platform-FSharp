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
type LayerDistanceUtil =
    [<DefaultValue(false)>] val mutable mathUtil : MathUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : LayerDistanceUtil
    static member instance with get() : LayerDistanceUtil = (LayerDistanceUtil.jclinit(); LayerDistanceUtil.jcell_instance) and set (jvalue: LayerDistanceUtil) = (LayerDistanceUtil.jclinit(); LayerDistanceUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerDistanceUtil.jclinitDone then
            LayerDistanceUtil.jclinitDone <- true
            LayerDistanceUtil.jclinitBody()
    static member private jclinitBody() : unit =
        LayerDistanceUtil.jcell_instance <- (new LayerDistanceUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_LayerDistanceUtil()
    member this.jfields_LayerDistanceUtil() : unit =
        this.mathUtil <- MathUtil.getInstance()
        ()
    
    static member getInstance() : LayerDistanceUtil =
        LayerDistanceUtil.instance
    
    abstract getDistance : layerInterface: AllBinaryLayer * layerInterface2: AllBinaryLayer -> int
    default this.getDistance(layerInterface: AllBinaryLayer, layerInterface2: AllBinaryLayer) : int =
        let mutable dx : int = (layerInterface.getXP() + layerInterface.getHalfWidth()) - (layerInterface2.getXP() + layerInterface2.getHalfWidth())
        let mutable dy : int = (layerInterface.getYP() + layerInterface.getHalfHeight()) - (layerInterface2.getYP() + layerInterface2.getHalfHeight())
        this.mathUtil.sqrt(((dx * dx) + (dy * dy)))
    
    abstract getDistance3D : layerInterface: AllBinaryLayer * layerInterface2: AllBinaryLayer -> int
    default this.getDistance3D(layerInterface: AllBinaryLayer, layerInterface2: AllBinaryLayer) : int =
        let mutable dx : int = (layerInterface.getXP() + layerInterface.getHalfWidth()) - (layerInterface2.getXP() + layerInterface2.getHalfWidth())
        let mutable dy : int = (layerInterface.getYP() + layerInterface.getHalfHeight()) - (layerInterface2.getYP() + layerInterface2.getHalfHeight())
        let mutable dz : int = (layerInterface.getZP() + layerInterface.getHalfDepth()) - (layerInterface2.getZP() + layerInterface2.getHalfDepth())
        this.mathUtil.sqrt((((dx * dx) + (dy * dy)) + (dz * dz)))
    
    abstract getDistanceAt : layerInterface: AllBinaryLayer * point: GPoint -> int
    default this.getDistanceAt(layerInterface: AllBinaryLayer, point: GPoint) : int =
        let mutable dx : int = layerInterface.getXP() - point.getX()
        let mutable dy : int = layerInterface.getYP() - point.getY()
        this.mathUtil.sqrt(((dx * dx) + (dy * dy)))


