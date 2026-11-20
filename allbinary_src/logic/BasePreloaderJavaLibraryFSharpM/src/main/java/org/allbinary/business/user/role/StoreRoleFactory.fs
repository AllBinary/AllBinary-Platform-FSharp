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
type StoreRoleFactory =
    [<DefaultValue(false)>] val mutable roles : BasicArrayList
    [<DefaultValue(false)>] val mutable subscriberRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable wholesaleRoles : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : StoreRoleFactory
    static member instance with get() : StoreRoleFactory = (StoreRoleFactory.jclinit(); StoreRoleFactory.jcell_instance) and set (jvalue: StoreRoleFactory) = (StoreRoleFactory.jclinit(); StoreRoleFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StoreRoleFactory.jclinitDone then
            StoreRoleFactory.jclinitDone <- true
            StoreRoleFactory.jclinitBody()
    static member private jclinitBody() : unit =
        StoreRoleFactory.jcell_instance <- (new StoreRoleFactory())
        ()
    member this.jfields_StoreRoleFactory() : unit =
        this.roles <- (new BasicArrayListD())
        this.subscriberRoles <- (new BasicArrayListD())
        this.wholesaleRoles <- (new BasicArrayListD())
        ()
    
    static member getInstance() : StoreRoleFactory =
        StoreRoleFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_StoreRoleFactory()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable basicUserRoleFactory : BasicUserRoleFactory = BasicUserRoleFactory.getInstance()
        ignore (this.roles.add(basicUserRoleFactory.CUSTOMER))
        ignore (this.roles.add(basicUserRoleFactory.SUBSCRIBERCUSTOMER))
        ignore (this.roles.add(basicUserRoleFactory.WHOLESALECUSTOMER))
        ignore (this.subscriberRoles.add(basicUserRoleFactory.SUBSCRIBERCUSTOMER))
        ignore (this.wholesaleRoles.add(basicUserRoleFactory.WHOLESALECUSTOMER))
        ()
    
    abstract getRoles : unit -> BasicArrayList
    default this.getRoles() : BasicArrayList =
        this.roles
    
    abstract getSubscriberRoles : unit -> BasicArrayList
    default this.getSubscriberRoles() : BasicArrayList =
        this.subscriberRoles
    
    abstract getWholesaleRoles : unit -> BasicArrayList
    default this.getWholesaleRoles() : BasicArrayList =
        this.wholesaleRoles


