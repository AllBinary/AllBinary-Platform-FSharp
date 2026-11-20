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
type BasicUserRoleFactory =
    [<DefaultValue(false)>] val mutable INACTIVITYTIMEOUT : int64
    [<DefaultValue(false)>] val mutable CUSTOMERTIMEOUT : int64
    [<DefaultValue(false)>] val mutable CUSTOMERMAXSESSIONTIME : int64
    [<DefaultValue(false)>] val mutable MAXSESSIONTIME : int64
    [<DefaultValue(false)>] val mutable INSTALLER : BasicUserRole
    [<DefaultValue(false)>] val mutable ADMINISTRATOR : BasicUserRole
    [<DefaultValue(false)>] val mutable CUSTOMER : BasicUserRole
    [<DefaultValue(false)>] val mutable SUBSCRIBERCUSTOMER : BasicUserRole
    [<DefaultValue(false)>] val mutable WHOLESALECUSTOMER : BasicUserRole
    [<DefaultValue(false)>] val mutable STOREMANAGER : BasicUserRole
    [<DefaultValue(false)>] val mutable PRODUCTMANAGER : BasicUserRole
    [<DefaultValue(false)>] val mutable CUSTOMERMANAGER : BasicUserRole
    [<DefaultValue(false)>] val mutable PAYMENTMANAGER : BasicUserRole
    [<DefaultValue(false)>] val mutable ORDERMANAGER : BasicUserRole
    [<DefaultValue(false)>] val mutable WEBMANAGER : BasicUserRole
    [<DefaultValue(false)>] val mutable REVIEWER : BasicUserRole
    [<DefaultValue(false)>] val mutable SHIPPING : BasicUserRole
    [<DefaultValue(false)>] val mutable ADJUSTER : BasicUserRole
    [<DefaultValue(false)>] val mutable WORKFLOWEDITOR : BasicUserRole
    [<DefaultValue(false)>] val mutable WIZARD : BasicUserRole
    [<DefaultValue(false)>] val mutable VIEWEDITOR : BasicUserRole
    [<DefaultValue(false)>] static val mutable private jcell_instance : BasicUserRoleFactory
    static member instance with get() : BasicUserRoleFactory = (BasicUserRoleFactory.jclinit(); BasicUserRoleFactory.jcell_instance) and set (jvalue: BasicUserRoleFactory) = (BasicUserRoleFactory.jclinit(); BasicUserRoleFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicUserRoleFactory.jclinitDone then
            BasicUserRoleFactory.jclinitDone <- true
            BasicUserRoleFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BasicUserRoleFactory.jcell_instance <- (new BasicUserRoleFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicUserRoleFactory()
    member this.jfields_BasicUserRoleFactory() : unit =
        this.INACTIVITYTIMEOUT <- 360000000L
        this.CUSTOMERTIMEOUT <- 360000000L
        this.CUSTOMERMAXSESSIONTIME <- 360000000L
        this.MAXSESSIONTIME <- 360000000L
        this.INSTALLER <- (new BasicUserRole("Installer", 16, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.ADMINISTRATOR <- (new BasicUserRole("Administrator", 0, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.CUSTOMER <- (new BasicUserRole("CustomerUser", "Customer User", 1, this.CUSTOMERTIMEOUT, this.CUSTOMERMAXSESSIONTIME))
        this.SUBSCRIBERCUSTOMER <- (new BasicUserRole("SubscriberUser", "Subscriber User", 2, this.CUSTOMERTIMEOUT, this.CUSTOMERMAXSESSIONTIME))
        this.WHOLESALECUSTOMER <- (new BasicUserRole("WholesaleUser", "Wholesale User", 3, this.CUSTOMERTIMEOUT, this.CUSTOMERMAXSESSIONTIME))
        this.STOREMANAGER <- (new BasicUserRole("StoreManager", "Store Manager", 4, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.PRODUCTMANAGER <- (new BasicUserRole("ProductManager", "Product Manager", 5, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.CUSTOMERMANAGER <- (new BasicUserRole("UserManager", "User Manager", 6, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.PAYMENTMANAGER <- (new BasicUserRole("PaymentManager", "Payment Manager", 7, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.ORDERMANAGER <- (new BasicUserRole("OrderManager", "Order Manager", 8, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.WEBMANAGER <- (new BasicUserRole("WebManager", "Web Manager", 9, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.REVIEWER <- (new BasicUserRole("Reviewer", 10, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.SHIPPING <- (new BasicUserRole("Shipping", 11, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.ADJUSTER <- (new BasicUserRole("Adjuster", 12, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.WORKFLOWEDITOR <- (new BasicUserRole("WorkFlowEditor", "WorkFlow Editor", 13, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.WIZARD <- (new BasicUserRole("WizardUser", "Wizard User", 14, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        this.VIEWEDITOR <- (new BasicUserRole("ViewEditor", "View Editor", 15, this.MAXSESSIONTIME, this.INACTIVITYTIMEOUT))
        ()
    
    static member getInstance() : BasicUserRoleFactory =
        BasicUserRoleFactory.instance


