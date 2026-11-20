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
type GDResources =
    [<DefaultValue(false)>] val mutable resourceStringArray : string[]
    [<DefaultValue(false)>] val mutable currentLayoutRequiredTotal : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : GDResources
    static member instance with get() : GDResources = (GDResources.jclinit(); GDResources.jcell_instance) and set (jvalue: GDResources) = (GDResources.jclinit(); GDResources.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GDResources.jclinitDone then
            GDResources.jclinitDone <- true
            GDResources.jclinitBody()
    static member private jclinitBody() : unit =
        GDResources.jcell_instance <- (new GDResources())
        ()
    new () as this =
        {  }
        then
            this.jfields_GDResources()
    member this.jfields_GDResources() : unit =
        this.resourceStringArray <- ([|  |] : string[])
        ()
    
    static member getInstance() : GDResources =
        GDResources.instance


