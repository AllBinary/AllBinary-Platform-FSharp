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
type RelativeLayerRelationship =
    inherit RelativeRelationship
    [<DefaultValue(false)>] val mutable layer : AllBinaryLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RelativeLayerRelationship.jclinitDone then
            RelativeLayerRelationship.jclinitDone <- true
            RelativeLayerRelationship.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_RelativeLayerRelationship() : unit =
        this.layer <- AllBinaryLayer.NULL_ALLBINARY_LAYER
        ()
    
    new (layer: AllBinaryLayer, point: GPoint, typesAllowedList: BasicArrayList) as this =
        { inherit RelativeRelationship(point, typesAllowedList) }
        then
            this.jfields_RelativeLayerRelationship()
            this.jctor1(layer, point, typesAllowedList)
    member this.jctor1(layer: AllBinaryLayer, point: GPoint, typesAllowedList: BasicArrayList) : unit =
        ()
        this.layer <- layer
        ()
    
    override this.getX() : int =
        this.layer.getXP() + base.getX()
    
    override this.getY() : int =
        this.layer.getYP() + base.getY()
    
    override this.getZ() : int =
        this.layer.getZP() + base.getZ()


