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
type GroupFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable NULL_GROUP_ARRAY : Group[]
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] val mutable index : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : GroupFactory
    static member instance with get() : GroupFactory = (GroupFactory.jclinit(); GroupFactory.jcell_instance) and set (jvalue: GroupFactory) = (GroupFactory.jclinit(); GroupFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GroupFactory.jclinitDone then
            GroupFactory.jclinitDone <- true
            GroupFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GroupFactory.jcell_instance <- (new GroupFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_GroupFactory()
    member this.jfields_GroupFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.NULL_GROUP_ARRAY <- (Array.zeroCreate<Group> (0))
        this.list <- (new BasicArrayListD())
        this.index <- 0
        ()
    
    static member getInstance() : GroupFactory =
        GroupFactory.instance
    
    abstract getNextGroup : unit -> Group
    default this.getNextGroup() : Group =
        let mutable group : Group = (box (this.list.objectArray.[this.index]) :?> Group)
        this.index <- this.index + 1
        group
    
    abstract getNextGroupByName : name: string -> Group
    default this.getNextGroupByName(name: string) : Group =
        let mutable group : Group = this.getNextGroup()
        group.setName(name)
        group
    
    abstract init : groups: int16 * nameArray: string[] -> unit
    default this.init(groups: int16, nameArray: string[]) : unit =
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable stringUtil : StringUtil = StringUtil.getInstance()
        let mutable TEAM : string = "Team "
        this.list.clear()
        this.index <- 0
        let mutable size : int = this.list.size()
        let mutable name : string = null
        while size < int (int (groups)) do
            name <- stringUtil.EMPTY_STRING
            if size < nameArray.Length then
                name <- nameArray.[size]
            else
                ignore (stringMaker.delete(0, stringMaker.length()))
                name <- stringMaker.append(TEAM).appendint(size).ToString()
            ignore (this.list.add((new Group(name, int16 ((size + 3))))))
            size <- size + 1


