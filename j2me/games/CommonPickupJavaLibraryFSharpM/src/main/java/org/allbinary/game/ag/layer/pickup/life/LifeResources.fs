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
type LifeResources =
    [<DefaultValue(false)>] val mutable RESOURCE : string
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : LifeResources
    static member SINGLETON with get() : LifeResources = (LifeResources.jclinit(); LifeResources.jcell_SINGLETON) and set (jvalue: LifeResources) = (LifeResources.jclinit(); LifeResources.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LifeResources.jclinitDone then
            LifeResources.jclinitDone <- true
            LifeResources.jclinitBody()
    static member private jclinitBody() : unit =
        LifeResources.jcell_SINGLETON <- (new LifeResources())
        ()
    member this.jfields_LifeResources() : unit =
        this.RESOURCE <- "life_drop_20_by_20.png"
        ()
    
    new () as this =
        {  }
        then
            this.jfields_LifeResources()
    
    static member getInstance() : LifeResources =
        LifeResources.SINGLETON


