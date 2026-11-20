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
type BasicUserRole =
    [<DefaultValue(false)>] val mutable m_int_RoleId : int
    [<DefaultValue(false)>] val mutable role : string
    [<DefaultValue(false)>] val mutable displayValue : string
    [<DefaultValue(false)>] val mutable sessionTimeout : int64
    [<DefaultValue(false)>] val mutable sessionInactivityTimeout : int64
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicUserRole.jclinitDone then
            BasicUserRole.jclinitDone <- true
            BasicUserRole.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (aRole: string, a_int_RoleId: int, aSessionTimeout: int64, aSessionInactivityTimeout: int64) =
        BasicUserRole(aRole, aRole, a_int_RoleId, aSessionTimeout, aSessionInactivityTimeout)
    
    new (aRole: string, aDisplayValue: string, a_int_RoleId: int, aSessionTimeout: int64, aSessionInactivityTimeout: int64) as this =
        {  }
        then
            this.jctor2(aRole, aDisplayValue, a_int_RoleId, aSessionTimeout, aSessionInactivityTimeout)
    member this.jctor2(aRole: string, aDisplayValue: string, a_int_RoleId: int, aSessionTimeout: int64, aSessionInactivityTimeout: int64) : unit =
        this.m_int_RoleId <- a_int_RoleId
        this.role <- aRole
        this.displayValue <- aDisplayValue
        this.sessionTimeout <- aSessionTimeout
        this.sessionInactivityTimeout <- aSessionInactivityTimeout
        ignore (BasicUserRoles.getInstance().roleVector.add(this))
        ()
    
    member this.getRoleId() : int =
        this.m_int_RoleId
    
    abstract getRole : unit -> string
    default this.getRole() : string =
        this.role
    
    abstract getSessionTimeout : unit -> int64
    default this.getSessionTimeout() : int64 =
        this.sessionTimeout
    
    abstract getSessionInactivityTimeout : unit -> int64
    default this.getSessionInactivityTimeout() : int64 =
        this.sessionInactivityTimeout
    
    abstract equals : basicUserRole: BasicUserRole -> bool
    default this.equals(basicUserRole: BasicUserRole) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.getRoleId() = basicUserRole.getRoleId() then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    override this.ToString() : string =
        this.getRole()
    interface Serializable


