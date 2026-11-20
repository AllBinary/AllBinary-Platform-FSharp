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
type GroupLayerManagerListener =
    inherit LayerManagerEventListener
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : GroupLayerManagerListener
    static member SINGLETON with get() : GroupLayerManagerListener = (GroupLayerManagerListener.jclinit(); GroupLayerManagerListener.jcell_SINGLETON) and set (jvalue: GroupLayerManagerListener) = (GroupLayerManagerListener.jclinit(); GroupLayerManagerListener.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GroupLayerManagerListener.jclinitDone then
            GroupLayerManagerListener.jclinitDone <- true
            GroupLayerManagerListener.jclinitBody()
    static member private jclinitBody() : unit =
        GroupLayerManagerListener.jcell_SINGLETON <- (new GroupLayerManagerListener())
        ()
    member this.jfields_GroupLayerManagerListener() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : GroupLayerManagerListener =
        GroupLayerManagerListener.SINGLETON
    
    new () as this =
        { inherit LayerManagerEventListener() }
        then
            this.jfields_GroupLayerManagerListener()
            this.jctor1()
    member this.jctor1() : unit =
        LayerManagerEventHandler.getInstance().addListener(this)
        ()
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        let mutable groupList : BasicArrayList = null
        let mutable size : int = this.list.size()
        let mutable index : int = size - 1
        while index >= 0 do
            groupList <- (box (this.list.objectArray.[index]) :?> BasicArrayList)
            groupList.clear()
            index <- index - 1
    
    abstract getGroupSizeFromInterface : groupInterfaceCompositeInterface: GroupInterfaceCompositeInterface -> int
    default this.getGroupSizeFromInterface(groupInterfaceCompositeInterface: GroupInterfaceCompositeInterface) : int =
        let mutable groupInterfaceArray : Group[] = groupInterfaceCompositeInterface.getGroupInterface()
        this.getGroupSize(groupInterfaceArray.[0])
    
    abstract getGroupSize : groupInterface: Group -> int
    default this.getGroupSize(groupInterface: Group) : int =
        let mutable id_ : int = int (groupInterface.getGroupId())
        this.getGroupSizeById(id_)
    
    abstract getList : groupInterface: Group -> BasicArrayList
    default this.getList(groupInterface: Group) : BasicArrayList =
        let mutable id_ : int = int (groupInterface.getGroupId())
        this.getListById(id_)
    
    member this.getListById(groupId: int) : BasicArrayList =
        let mutable groupList : BasicArrayList = (box (this.list.objectArray.[groupId]) :?> BasicArrayList)
        groupList
    
    member this.getGroupSizeById(groupId: int) : int =
        let mutable groupList : BasicArrayList = (box (this.list.objectArray.[groupId]) :?> BasicArrayList)
        let mutable size : int = groupList.size()
        size
    
    abstract areAllOtherGroupsEmpty : groupInterface: Group -> bool
    default this.areAllOtherGroupsEmpty(groupInterface: Group) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable id_ : int = int (groupInterface.getGroupId())
        let mutable size : int = this.list.size()
        let mutable index : int = size - 1
        while jflow = 0 && (index >= 0) do
            if id_ <> index then
                let mutable groupSize : int = this.getGroupSizeById(index)
                if groupSize <> 0 then
                    this.logUtil.putF((new StringMaker()).append("Group Size: ").appendint(groupSize).ToString(), this, "areAllOtherGroupsEmpty")
                    jret <- false
                    jflow <- 1
            if jflow = 200002 then jflow <- 0
            if jflow = 0 then index <- index - 1
        if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret
    
    member this.isIdInList(id_: int, excludeGroupList: BasicArrayList) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable size : int = excludeGroupList.size()
        let mutable groupInterfaceArray : Group[] = null
        let mutable groupInterface : Group = null
        let mutable groupId : int = 0
        let mutable index : int = size - 1
        while jflow = 0 && (index >= 0) do
            groupInterfaceArray <- (box (excludeGroupList.objectArray.[index]) :?> Group[])
            let mutable size2 : int = groupInterfaceArray.Length
            let mutable index2 : int = 0
            while jflow = 0 && (index2 < size2) do
                groupInterface <- groupInterfaceArray.[index2]
                groupId <- int (groupInterface.getGroupId())
                if groupId = id_ then
                    jret <- true
                    jflow <- 1
                if jflow = 200004 then jflow <- 0
                if jflow = 0 then index2 <- index2 + 1
            if jflow = 100004 then jflow <- 0
            if jflow = 200003 then jflow <- 0
            if jflow = 0 then index <- index - 1
        if jflow = 100003 then jflow <- 0
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract areAllOtherGroupsLessThan : excludeGroupList: BasicArrayList * maxSize: int -> bool
    default this.areAllOtherGroupsLessThan(excludeGroupList: BasicArrayList, maxSize: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable size : int = this.list.size()
        let mutable index : int = size - 1
        while jflow = 0 && (index >= 0) do
            if not (this.isIdInList(index, excludeGroupList)) then
                let mutable groupSize : int = this.getGroupSizeById(index)
                if groupSize >= maxSize then
                    jret <- false
                    jflow <- 1
            if jflow = 200005 then jflow <- 0
            if jflow = 0 then index <- index - 1
        if jflow = 100005 then jflow <- 0
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret
    
    abstract init : total: int -> unit
    default this.init(total: int) : unit =
        while this.list.size() <= (total + 1) do
            ignore (this.list.add((new BasicArrayListD())))
    
    override this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    override this.onCreateLayerManagerEvent(layerManagerEvent: LayerManagerEvent) : unit =
        let mutable layerInterface : AllBinaryLayer = layerManagerEvent.getLayerInterface()
        let mutable groupInterfaceArray : Group[] = layerInterface.getGroupInterface()
        let mutable size : int = groupInterfaceArray.Length
        let mutable id_ : int = 0
        let mutable groupList : BasicArrayList = null
        let mutable index : int = 0
        while index < size do
            id_ <- int (groupInterfaceArray.[index].getGroupId())
            groupList <- (box (this.list.objectArray.[id_]) :?> BasicArrayList)
            if (JR.same(groupList, null)) then
                this.logUtil.putF((new StringMaker()).append("id: ").appendint(id_).ToString(), this, "onCreateLayerManagerEvent")
            if not (groupList.contains(layerInterface)) then
                ignore (groupList.add(layerInterface))
            else
                ()
            index <- index + 1
    
    override this.onDeleteLayerManagerEvent(layerManagerEvent: LayerManagerEvent) : unit =
        let mutable layerInterface : AllBinaryLayer = layerManagerEvent.getLayerInterface()
        let mutable groupInterfaceArray : Group[] = layerInterface.getGroupInterface()
        let mutable size : int = groupInterfaceArray.Length
        let mutable id_ : int = 0
        let mutable groupList : BasicArrayList = null
        let mutable index : int = 0
        while index < size do
            id_ <- int (groupInterfaceArray.[index].getGroupId())
            groupList <- (box (this.list.objectArray.[id_]) :?> BasicArrayList)
            ignore (groupList.remove(layerInterface))
            index <- index + 1
    
    abstract log : unit -> unit
    default this.log() : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable GROUP : string = "Group: "
        let mutable SPACE : string = CommonSeps.getInstance().SPACE
        let mutable TOTAL_LABEL : string = CommonLabels.getInstance().TOTAL_LABEL
        let mutable size : int = this.list.size()
        let mutable index : int = size - 1
        while index >= 0 do
            let mutable groupList : BasicArrayList = (box (this.list.objectArray.[index]) :?> BasicArrayList)
            ignore (stringBuffer.append(GROUP))
            ignore (stringBuffer.appendint(index))
            ignore (stringBuffer.append(SPACE))
            ignore (stringBuffer.append(TOTAL_LABEL))
            ignore (stringBuffer.appendint(groupList.size()))
            ignore (stringBuffer.append(SPACE))
            index <- index - 1
        this.logUtil.putF(stringBuffer.ToString(), this, "log")


