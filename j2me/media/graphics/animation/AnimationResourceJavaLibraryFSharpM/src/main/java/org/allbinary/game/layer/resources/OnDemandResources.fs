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
type OnDemandResources =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ON_DEMAND_RESOURCES : OnDemandResources
    static member NULL_ON_DEMAND_RESOURCES with get() : OnDemandResources = (OnDemandResources.jclinit(); OnDemandResources.jcell_NULL_ON_DEMAND_RESOURCES) and set (jvalue: OnDemandResources) = (OnDemandResources.jclinit(); OnDemandResources.jcell_NULL_ON_DEMAND_RESOURCES <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OnDemandResources.jclinitDone then
            OnDemandResources.jclinitDone <- true
            OnDemandResources.jclinitBody()
    static member private jclinitBody() : unit =
        OnDemandResources.jcell_NULL_ON_DEMAND_RESOURCES <- (new OnDemandResources())
        ()
    member this.jfields_OnDemandResources() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_OnDemandResources()
    
    abstract waitFor : unit -> unit
    default this.waitFor() : unit =
        ()
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract initAt : imageCache: ImageCache * resourceAnimationInterfaceFactoryInterfaceFactory: BaseResourceAnimationInterfaceFactoryInterfaceFactory * portion: int * loadingString: string * index: int -> int
    default this.initAt(imageCache: ImageCache, resourceAnimationInterfaceFactoryInterfaceFactory: BaseResourceAnimationInterfaceFactoryInterfaceFactory, portion: int, loadingString: string, index: int) : int =
        0


