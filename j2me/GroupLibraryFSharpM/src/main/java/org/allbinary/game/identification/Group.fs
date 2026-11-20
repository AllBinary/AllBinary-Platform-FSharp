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
type Group =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable teamId : int16
    [<DefaultValue(false)>] val mutable string : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Group.jclinitDone then
            Group.jclinitDone <- true
            Group.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_Group() : unit =
        this.name <- StringUtil.getInstance().EMPTY_STRING
        this.string <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new (teamName: string, teamId: int16) as this =
        {  }
        then
            this.jfields_Group()
            this.jctor1(teamName, teamId)
    member this.jctor1(teamName: string, teamId: int16) : unit =
        this.teamId <- teamId
        this.setName(teamName)
        ()
    
    abstract getGroupName : unit -> string
    default this.getGroupName() : string =
        this.name
    
    abstract setName : name: string -> unit
    default this.setName(name: string) : unit =
        this.name <- name
        let mutable groupCommonFactory : GroupCommonFactory = GroupCommonFactory.getInstance()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(groupCommonFactory.GROUP_NAME_LABEL))
        ignore (stringBuffer.append(this.name))
        ignore (stringBuffer.append(groupCommonFactory.ID_LABEL))
        ignore (stringBuffer.appendshort(this.teamId))
        this.string <- stringBuffer.ToString()
    
    abstract getGroupId : unit -> int16
    default this.getGroupId() : int16 =
        this.teamId
    
    override this.ToString() : string =
        this.string
    interface GroupInterface with
        member this.getGroupName() : string = this.getGroupName()
        member this.getGroupId() : int16 = this.getGroupId()


