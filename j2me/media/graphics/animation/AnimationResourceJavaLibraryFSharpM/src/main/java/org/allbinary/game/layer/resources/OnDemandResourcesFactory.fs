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
type OnDemandResourcesFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OnDemandResourcesFactory.jclinitDone then
            OnDemandResourcesFactory.jclinitDone <- true
            OnDemandResourcesFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract size : unit -> int
    default this.size() : int =
        0
    
    abstract remove : layerId: int -> OnDemandResources
    default this.remove(layerId: int) : OnDemandResources =
        OnDemandResources.NULL_ON_DEMAND_RESOURCES


