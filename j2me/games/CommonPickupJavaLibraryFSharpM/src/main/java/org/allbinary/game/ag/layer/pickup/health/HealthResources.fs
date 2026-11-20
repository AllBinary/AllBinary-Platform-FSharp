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
type HealthResources =
    [<DefaultValue(false)>] val mutable RESOURCE : string
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : HealthResources
    static member SINGLETON with get() : HealthResources = (HealthResources.jclinit(); HealthResources.jcell_SINGLETON) and set (jvalue: HealthResources) = (HealthResources.jclinit(); HealthResources.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HealthResources.jclinitDone then
            HealthResources.jclinitDone <- true
            HealthResources.jclinitBody()
    static member private jclinitBody() : unit =
        HealthResources.jcell_SINGLETON <- (new HealthResources())
        ()
    member this.jfields_HealthResources() : unit =
        this.RESOURCE <- "health_drop_20_by_20.png"
        ()
    
    new () as this =
        {  }
        then
            this.jfields_HealthResources()
    
    static member getInstance() : HealthResources =
        HealthResources.SINGLETON


