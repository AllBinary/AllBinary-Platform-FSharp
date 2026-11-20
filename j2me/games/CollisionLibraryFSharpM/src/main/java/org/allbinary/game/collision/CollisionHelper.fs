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
type CollisionHelper =
    [<DefaultValue(false)>] val mutable sourceLayerInterface : AllBinaryLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollisionHelper.jclinitDone then
            CollisionHelper.jclinitDone <- true
            CollisionHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (sourceLayerInterface: AllBinaryLayer) as this =
        {  }
        then
            this.jctor1(sourceLayerInterface)
    member this.jctor1(sourceLayerInterface: AllBinaryLayer) : unit =
        this.sourceLayerInterface <- sourceLayerInterface
        ()
    
    abstract isCollidable : layerInterface: CollidableCompositeLayer -> bool
    default this.isCollidable(layerInterface: CollidableCompositeLayer) : bool =
        true
    
    abstract getOwnerLayerInterface : unit -> AllBinaryLayer
    default this.getOwnerLayerInterface() : AllBinaryLayer =
        this.sourceLayerInterface
    
    abstract setOwnerLayerInterface : sourceLayerInterface: AllBinaryLayer -> unit
    default this.setOwnerLayerInterface(sourceLayerInterface: AllBinaryLayer) : unit =
        this.sourceLayerInterface <- sourceLayerInterface


