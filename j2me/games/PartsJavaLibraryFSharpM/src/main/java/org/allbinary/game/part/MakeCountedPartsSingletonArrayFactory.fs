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
type MakeCountedPartsSingletonArrayFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : MakeCountedPartsSingletonArrayFactory
    static member instance with get() : MakeCountedPartsSingletonArrayFactory = (MakeCountedPartsSingletonArrayFactory.jclinit(); MakeCountedPartsSingletonArrayFactory.jcell_instance) and set (jvalue: MakeCountedPartsSingletonArrayFactory) = (MakeCountedPartsSingletonArrayFactory.jclinit(); MakeCountedPartsSingletonArrayFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MakeCountedPartsSingletonArrayFactory.jclinitDone then
            MakeCountedPartsSingletonArrayFactory.jclinitDone <- true
            MakeCountedPartsSingletonArrayFactory.jclinitBody()
    static member private jclinitBody() : unit =
        MakeCountedPartsSingletonArrayFactory.jcell_instance <- (new MakeCountedPartsSingletonArrayFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_MakeCountedPartsSingletonArrayFactory()
    member this.jfields_MakeCountedPartsSingletonArrayFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.list <- BasicArrayListUtil.getInstance().getImmutableInstance()
        ()
    
    static member getInstance() : MakeCountedPartsSingletonArrayFactory =
        MakeCountedPartsSingletonArrayFactory.instance
    
    abstract getUpdated : partInterfaceArray: PartInterface[] -> PartInterface[]
    default this.getUpdated(partInterfaceArray: PartInterface[]) : PartInterface[] =
        this.list <- (new BasicArrayListD())
        let mutable index : int = 0
        while index < partInterfaceArray.Length do
            ignore (this.list.add(partInterfaceArray.[index]))
            index <- index + 1
        let mutable countedBasicArrayList : BasicArrayList = CountedPickedUpLayerInterfaceFactoryPool.getInstance().getList()
        let mutable layerInterfaceFactoryInterface : CountedPickedUpLayerInterfaceFactory = null
        let mutable size : int = countedBasicArrayList.size()
        let mutable index : int = 0
        while index < size do
            layerInterfaceFactoryInterface <- (box (countedBasicArrayList.objectArray.[index]) :?> CountedPickedUpLayerInterfaceFactory)
            ignore (this.list.add((new CountedLayerInterfaceFactoryPart(0, layerInterfaceFactoryInterface))))
            index <- index + 1
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Total Parts: "))
        ignore (stringBuffer.appendint(this.list.size()))
        ignore (stringBuffer.append(" Counted: "))
        ignore (stringBuffer.appendint(countedBasicArrayList.size()))
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        this.logUtil.putF(stringBuffer.ToString(), this, commonStrings.GET_INSTANCE)
        let mutable newPartInterfaceArray : PartInterface[] = (Array.zeroCreate<PartInterface> (this.list.size()))
        let mutable newSize : int = newPartInterfaceArray.Length
        let mutable index : int = 0
        while index < newSize do
            newPartInterfaceArray.[index] <- (box (this.list.get(index)) :?> PartInterface)
            index <- index + 1
        newPartInterfaceArray


