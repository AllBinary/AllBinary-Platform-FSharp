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
type LayerPlacementTypeFactory =
    [<DefaultValue(false)>] val mutable MAP : LayerPlacementType
    [<DefaultValue(false)>] val mutable LEFT : LayerPlacementType
    [<DefaultValue(false)>] val mutable DOWN : LayerPlacementType
    [<DefaultValue(false)>] val mutable UP : LayerPlacementType
    [<DefaultValue(false)>] val mutable RIGHT : LayerPlacementType
    [<DefaultValue(false)>] static val mutable private jcell_instance : LayerPlacementTypeFactory
    static member instance with get() : LayerPlacementTypeFactory = (LayerPlacementTypeFactory.jclinit(); LayerPlacementTypeFactory.jcell_instance) and set (jvalue: LayerPlacementTypeFactory) = (LayerPlacementTypeFactory.jclinit(); LayerPlacementTypeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerPlacementTypeFactory.jclinitDone then
            LayerPlacementTypeFactory.jclinitDone <- true
            LayerPlacementTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LayerPlacementTypeFactory.jcell_instance <- (new LayerPlacementTypeFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_LayerPlacementTypeFactory()
    member this.jfields_LayerPlacementTypeFactory() : unit =
        this.MAP <- (new LayerPlacementType(Integer.MAX_VALUE))
        this.LEFT <- (new LayerPlacementType(DirectionFactory.getInstance().LEFT.getValue()))
        this.DOWN <- (new LayerPlacementType(DirectionFactory.getInstance().DOWN.getValue()))
        this.UP <- (new LayerPlacementType(DirectionFactory.getInstance().UP.getValue()))
        this.RIGHT <- (new LayerPlacementType(DirectionFactory.getInstance().RIGHT.getValue()))
        ()
    
    static member getInstance() : LayerPlacementTypeFactory =
        LayerPlacementTypeFactory.instance


