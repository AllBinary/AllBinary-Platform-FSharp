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
type BasicLayerPlacement =
    [<DefaultValue(false)>] val mutable layerType : LayerPlacementType
    [<DefaultValue(false)>] val mutable width : int
    [<DefaultValue(false)>] val mutable height : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicLayerPlacement.jclinitDone then
            BasicLayerPlacement.jclinitDone <- true
            BasicLayerPlacement.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (layerType: LayerPlacementType, width: int, height: int) as this =
        {  }
        then
            this.jctor1(layerType, width, height)
    member this.jctor1(layerType: LayerPlacementType, width: int, height: int) : unit =
        this.layerType <- layerType
        this.width <- width
        this.height <- height
        ()
    
    abstract getWidth : unit -> int
    default this.getWidth() : int =
        this.width
    
    abstract getHeight : unit -> int
    default this.getHeight() : int =
        this.height
    
    abstract getLayerType : unit -> LayerPlacementType
    default this.getLayerType() : LayerPlacementType =
        this.layerType
    
    abstract setLayerType : layerType: LayerPlacementType -> unit
    default this.setLayerType(layerType: LayerPlacementType) : unit =
        this.layerType <- layerType


