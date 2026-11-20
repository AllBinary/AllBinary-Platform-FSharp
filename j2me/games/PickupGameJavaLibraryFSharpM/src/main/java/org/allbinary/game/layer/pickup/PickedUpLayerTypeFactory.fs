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
type PickedUpLayerTypeFactory =
    [<DefaultValue(false)>] val mutable NONE : PickedUpLayerType
    [<DefaultValue(false)>] val mutable BEAM : PickedUpLayerType
    [<DefaultValue(false)>] val mutable MINE : PickedUpLayerType
    [<DefaultValue(false)>] val mutable PROJECTILE : PickedUpLayerType
    [<DefaultValue(false)>] val mutable ENHANCEMENT : PickedUpLayerType
    [<DefaultValue(false)>] val mutable MORPH : PickedUpLayerType
    [<DefaultValue(false)>] val mutable PART : PickedUpLayerType
    [<DefaultValue(false)>] val mutable HEAL : PickedUpLayerType
    [<DefaultValue(false)>] val mutable LIFE : PickedUpLayerType
    [<DefaultValue(false)>] val mutable POINTS : PickedUpLayerType
    [<DefaultValue(false)>] static val mutable private jcell_instance : PickedUpLayerTypeFactory
    static member instance with get() : PickedUpLayerTypeFactory = (PickedUpLayerTypeFactory.jclinit(); PickedUpLayerTypeFactory.jcell_instance) and set (jvalue: PickedUpLayerTypeFactory) = (PickedUpLayerTypeFactory.jclinit(); PickedUpLayerTypeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PickedUpLayerTypeFactory.jclinitDone then
            PickedUpLayerTypeFactory.jclinitDone <- true
            PickedUpLayerTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PickedUpLayerTypeFactory.jcell_instance <- (new PickedUpLayerTypeFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_PickedUpLayerTypeFactory()
    member this.jfields_PickedUpLayerTypeFactory() : unit =
        this.NONE <- (new PickedUpLayerType(StringUtil.getInstance().NULL_STRING))
        this.BEAM <- (new PickedUpLayerType("BEAM"))
        this.MINE <- (new PickedUpLayerType("MINE"))
        this.PROJECTILE <- (new PickedUpLayerType("PROJECTILE"))
        this.ENHANCEMENT <- (new PickedUpLayerType("Enhancement"))
        this.MORPH <- (new PickedUpLayerType("Morph"))
        this.PART <- (new PickedUpLayerType("Part"))
        this.HEAL <- (new PickedUpLayerType("Heal"))
        this.LIFE <- (new PickedUpLayerType("Life"))
        this.POINTS <- (new PickedUpLayerType("Points"))
        ()
    
    static member getInstance() : PickedUpLayerTypeFactory =
        PickedUpLayerTypeFactory.instance


