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
type CompositeGroup =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable groupInterface : Group
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CompositeGroup.jclinitDone then
            CompositeGroup.jclinitDone <- true
            CompositeGroup.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CompositeGroup() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.list <- (new BasicArrayListD())
        ()
    
    new (groupInterface: Group) as this =
        {  }
        then
            this.jfields_CompositeGroup()
            this.jctor1(groupInterface)
    member this.jctor1(groupInterface: Group) : unit =
        this.groupInterface <- groupInterface
        ()
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.list.clear()
    
    abstract add : groupInterface: Group -> unit
    default this.add(groupInterface: Group) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        let mutable groupCommonFactory : GroupCommonFactory = GroupCommonFactory.getInstance()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(groupCommonFactory.ADDING_LABEL))
        ignore (stringBuffer.append(groupInterface.ToString()))
        ignore (stringBuffer.append(groupCommonFactory.TO_LABEL))
        ignore (stringBuffer.append(StringUtil.getInstance().toString(this.groupInterface)))
        this.logUtil.putF(stringBuffer.ToString(), this, commonStrings.ADD)
        ignore (this.list.add(groupInterface))
    
    abstract isInGroup : groupInterface: Group -> bool
    default this.isInGroup(groupInterface: Group) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.list.contains(groupInterface) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract getGroup : unit -> Group
    default this.getGroup() : Group =
        this.groupInterface


