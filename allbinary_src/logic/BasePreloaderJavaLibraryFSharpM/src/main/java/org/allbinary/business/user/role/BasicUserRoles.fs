namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2026 AllBinary 
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
type BasicUserRoles =
    [<DefaultValue(false)>] val mutable roleVector : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : BasicUserRoles
    static member instance with get() : BasicUserRoles = (BasicUserRoles.jclinit(); BasicUserRoles.jcell_instance) and set (jvalue: BasicUserRoles) = (BasicUserRoles.jclinit(); BasicUserRoles.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicUserRoles.jclinitDone then
            BasicUserRoles.jclinitDone <- true
            BasicUserRoles.jclinitBody()
    static member private jclinitBody() : unit =
        BasicUserRoles.jcell_instance <- (new BasicUserRoles())
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicUserRoles()
    member this.jfields_BasicUserRoles() : unit =
        this.roleVector <- (new BasicArrayListD())
        ()
    
    static member getInstance() : BasicUserRoles =
        BasicUserRoles.instance
    
    abstract getRole : role: string -> BasicUserRole
    default this.getRole(role: string) : BasicUserRole =
        let mutable jflow = 0
        let mutable jret : BasicUserRole = Unchecked.defaultof<BasicUserRole>
        let mutable roleVector : BasicArrayList = this.getAll()
        let mutable size : int = roleVector.size()
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            let mutable userRole : BasicUserRole = (box (roleVector.get(index)) :?> BasicUserRole)
            if JString.compareTo(role, userRole.ToString()) = 0 then
                jret <- userRole
                jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            raise ((new JException("Unable to get role - Unknown Role")))
        jret
    
    abstract getAll : unit -> BasicArrayList
    default this.getAll() : BasicArrayList =
        this.roleVector


