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
type AdminRoleFactory =
    [<DefaultValue(false)>] val mutable adminRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable storeAdminRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable storeManagementRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable productManagementRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable reviewManagementRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable customerManagementRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable workflowManagementRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable orderManagementRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable adjusterManagementRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable shippingManagementRoles : BasicArrayList
    [<DefaultValue(false)>] val mutable webManagementRoles : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : AdminRoleFactory
    static member instance with get() : AdminRoleFactory = (AdminRoleFactory.jclinit(); AdminRoleFactory.jcell_instance) and set (jvalue: AdminRoleFactory) = (AdminRoleFactory.jclinit(); AdminRoleFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AdminRoleFactory.jclinitDone then
            AdminRoleFactory.jclinitDone <- true
            AdminRoleFactory.jclinitBody()
    static member private jclinitBody() : unit =
        AdminRoleFactory.jcell_instance <- (new AdminRoleFactory())
        ()
    member this.jfields_AdminRoleFactory() : unit =
        this.adminRoles <- (new BasicArrayListD())
        this.storeAdminRoles <- (new BasicArrayListD())
        this.storeManagementRoles <- (new BasicArrayListD())
        this.productManagementRoles <- (new BasicArrayListD())
        this.reviewManagementRoles <- (new BasicArrayListD())
        this.customerManagementRoles <- (new BasicArrayListD())
        this.workflowManagementRoles <- (new BasicArrayListD())
        this.orderManagementRoles <- (new BasicArrayListD())
        this.adjusterManagementRoles <- (new BasicArrayListD())
        this.shippingManagementRoles <- (new BasicArrayListD())
        this.webManagementRoles <- (new BasicArrayListD())
        ()
    
    static member getInstance() : AdminRoleFactory =
        AdminRoleFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_AdminRoleFactory()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable basicUserRoleFactory : BasicUserRoleFactory = BasicUserRoleFactory.getInstance()
        ignore (this.adminRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.storeAdminRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.storeAdminRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.storeManagementRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.storeManagementRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.storeManagementRoles.add(basicUserRoleFactory.CUSTOMERMANAGER))
        ignore (this.storeManagementRoles.add(basicUserRoleFactory.ADJUSTER))
        ignore (this.storeManagementRoles.add(basicUserRoleFactory.PRODUCTMANAGER))
        ignore (this.storeManagementRoles.add(basicUserRoleFactory.REVIEWER))
        ignore (this.storeManagementRoles.add(basicUserRoleFactory.SHIPPING))
        ignore (this.productManagementRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.productManagementRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.productManagementRoles.add(basicUserRoleFactory.PRODUCTMANAGER))
        ignore (this.reviewManagementRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.reviewManagementRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.reviewManagementRoles.add(basicUserRoleFactory.REVIEWER))
        ignore (this.customerManagementRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.customerManagementRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.customerManagementRoles.add(basicUserRoleFactory.CUSTOMERMANAGER))
        ignore (this.workflowManagementRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.workflowManagementRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.workflowManagementRoles.add(basicUserRoleFactory.WORKFLOWEDITOR))
        ignore (this.orderManagementRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.orderManagementRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.adjusterManagementRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.adjusterManagementRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.adjusterManagementRoles.add(basicUserRoleFactory.ADJUSTER))
        ignore (this.shippingManagementRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.shippingManagementRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.shippingManagementRoles.add(basicUserRoleFactory.SHIPPING))
        ignore (this.webManagementRoles.add(basicUserRoleFactory.ADMINISTRATOR))
        ignore (this.webManagementRoles.add(basicUserRoleFactory.STOREMANAGER))
        ignore (this.webManagementRoles.add(basicUserRoleFactory.WEBMANAGER))
        ignore (this.webManagementRoles.add(basicUserRoleFactory.WORKFLOWEDITOR))
        ignore (this.webManagementRoles.add(basicUserRoleFactory.VIEWEDITOR))
        ()
    
    abstract getProductManagementRoles : unit -> BasicArrayList
    default this.getProductManagementRoles() : BasicArrayList =
        this.productManagementRoles
    
    abstract getAdminRoles : unit -> BasicArrayList
    default this.getAdminRoles() : BasicArrayList =
        this.adminRoles
    
    abstract getStoreAdminRoles : unit -> BasicArrayList
    default this.getStoreAdminRoles() : BasicArrayList =
        this.storeAdminRoles
    
    abstract getStoreManagementRoles : unit -> BasicArrayList
    default this.getStoreManagementRoles() : BasicArrayList =
        this.storeManagementRoles
    
    abstract getReviewManagementRoles : unit -> BasicArrayList
    default this.getReviewManagementRoles() : BasicArrayList =
        this.reviewManagementRoles
    
    abstract getCustomerManagementRoles : unit -> BasicArrayList
    default this.getCustomerManagementRoles() : BasicArrayList =
        this.customerManagementRoles
    
    abstract getWorkflowManagementRoles : unit -> BasicArrayList
    default this.getWorkflowManagementRoles() : BasicArrayList =
        this.workflowManagementRoles
    
    abstract getWebManagementRoles : unit -> BasicArrayList
    default this.getWebManagementRoles() : BasicArrayList =
        this.webManagementRoles
    
    abstract getShippingManagementRoles : unit -> BasicArrayList
    default this.getShippingManagementRoles() : BasicArrayList =
        this.shippingManagementRoles
    
    abstract getAdjusterManagementRoles : unit -> BasicArrayList
    default this.getAdjusterManagementRoles() : BasicArrayList =
        this.adjusterManagementRoles
    
    abstract getOrderManagementRoles : unit -> BasicArrayList
    default this.getOrderManagementRoles() : BasicArrayList =
        this.orderManagementRoles


