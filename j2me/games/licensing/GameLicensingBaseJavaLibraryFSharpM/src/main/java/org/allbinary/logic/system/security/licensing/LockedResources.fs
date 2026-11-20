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
type LockedResources =
    [<DefaultValue(false)>] val mutable LOCKED_DEMO_GAME_FEATURE_RESOURCE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : LockedResources
    static member instance with get() : LockedResources = (LockedResources.jclinit(); LockedResources.jcell_instance) and set (jvalue: LockedResources) = (LockedResources.jclinit(); LockedResources.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LockedResources.jclinitDone then
            LockedResources.jclinitDone <- true
            LockedResources.jclinitBody()
    static member private jclinitBody() : unit =
        LockedResources.jcell_instance <- (new LockedResources())
        ()
    new () as this =
        {  }
        then
            this.jfields_LockedResources()
    member this.jfields_LockedResources() : unit =
        this.LOCKED_DEMO_GAME_FEATURE_RESOURCE <- "/locked_demo_game_feature_64_by_64.png"
        ()
    
    static member getInstance() : LockedResources =
        LockedResources.instance


