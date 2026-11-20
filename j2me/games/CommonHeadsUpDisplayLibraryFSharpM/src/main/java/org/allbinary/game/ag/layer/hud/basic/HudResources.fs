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
type HudResources =
    [<DefaultValue(false)>] val mutable RESOURCE_LIFE : string
    [<DefaultValue(false)>] val mutable RESOURCE_HEALTH : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : HudResources
    static member instance with get() : HudResources = (HudResources.jclinit(); HudResources.jcell_instance) and set (jvalue: HudResources) = (HudResources.jclinit(); HudResources.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HudResources.jclinitDone then
            HudResources.jclinitDone <- true
            HudResources.jclinitBody()
    static member private jclinitBody() : unit =
        HudResources.jcell_instance <- (new HudResources())
        ()
    member this.jfields_HudResources() : unit =
        this.RESOURCE_LIFE <- "/hud_life_10_by_10.png"
        this.RESOURCE_HEALTH <- "/hud_health_10_by_10.png"
        ()
    
    static member getInstance() : HudResources =
        HudResources.instance
    
    new () as this =
        {  }
        then
            this.jfields_HudResources()


