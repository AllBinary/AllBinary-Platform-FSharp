namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type GroupCommonFactory =
    [<DefaultValue(false)>] val mutable ID : Integer
    [<DefaultValue(false)>] val mutable GROUP_NAME_LABEL : string
    [<DefaultValue(false)>] val mutable ID_LABEL : string
    [<DefaultValue(false)>] val mutable ADDING_LABEL : string
    [<DefaultValue(false)>] val mutable TO_LABEL : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (GroupCommonFactory.jclinit(); GroupCommonFactory.jcell_instance) and set (jvalue: obj) = (GroupCommonFactory.jclinit(); GroupCommonFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GroupCommonFactory.jclinitDone then
            GroupCommonFactory.jclinitDone <- true
            GroupCommonFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GroupCommonFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    new () as this =
        {  }
        then
            this.jfields_GroupCommonFactory()
    member this.jfields_GroupCommonFactory() : unit =
        this.ID <- SmallIntegerSingletonFactory.getInstance().getAt(10)
        this.GROUP_NAME_LABEL <- "Group Name: "
        this.ID_LABEL <- " Id: "
        this.ADDING_LABEL <- "Adding: "
        this.TO_LABEL <- " to: "
        ()
    
    static member getInstance() : GroupCommonFactory =
        if (JR.same(GroupCommonFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            GroupCommonFactory.instance <- (new GroupCommonFactory())
        (box (GroupCommonFactory.instance) :?> GroupCommonFactory)


