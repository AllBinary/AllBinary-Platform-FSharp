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
type ExplosionResources =
    [<DefaultValue(false)>] val mutable EXPLOSION_90_RESOURCE : string
    [<DefaultValue(false)>] val mutable EXPLOSION_60_RESOURCE : string
    [<DefaultValue(false)>] val mutable HALF_EXPLOSION_RESOURCE : string
    [<DefaultValue(false)>] val mutable THIRD_EXPLOSION_RESOURCE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : ExplosionResources
    static member instance with get() : ExplosionResources = (ExplosionResources.jclinit(); ExplosionResources.jcell_instance) and set (jvalue: ExplosionResources) = (ExplosionResources.jclinit(); ExplosionResources.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ExplosionResources.jclinitDone then
            ExplosionResources.jclinitDone <- true
            ExplosionResources.jclinitBody()
    static member private jclinitBody() : unit =
        ExplosionResources.jcell_instance <- (new ExplosionResources())
        ()
    member this.jfields_ExplosionResources() : unit =
        this.EXPLOSION_90_RESOURCE <- "/explosion_sprite_90_by_90.png"
        this.EXPLOSION_60_RESOURCE <- "/explosion_sprite_60_by_60.png"
        this.HALF_EXPLOSION_RESOURCE <- "/explosion_sprite_30_by_30.png"
        this.THIRD_EXPLOSION_RESOURCE <- "/explosion_sprite_15_by_15.png"
        ()
    
    static member getInstance() : ExplosionResources =
        ExplosionResources.instance
    
    new () as this =
        {  }
        then
            this.jfields_ExplosionResources()


