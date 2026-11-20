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
type BasicEventHandler =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable eventStrings : EventStrings
    [<DefaultValue(false)>] val mutable eventListenerInterfaceList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicEventHandler.jclinitDone then
            BasicEventHandler.jclinitDone <- true
            BasicEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicEventHandler() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.eventStrings <- EventStrings.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_BasicEventHandler()
            this.jctor1()
    member this.jctor1() : unit =
        this.eventListenerInterfaceList <- (new BasicArrayListD())
        ()
    
    abstract removeAllListeners : unit -> unit
    default this.removeAllListeners() : unit =
        this.eventListenerInterfaceList <- (new BasicArrayListD())
    
    abstract addListeners : vector: BasicArrayList -> unit
    default this.addListeners(vector: BasicArrayList) : unit =
        let mutable eventListenerInterface : EventListenerInterface = null
        let mutable size : int = vector.size()
        let mutable index : int = 0
        while index < size do
            eventListenerInterface <- (box (vector.get(index)) :?> EventListenerInterface)
            this.addListenerInterface(eventListenerInterface)
            index <- index + 1
    
    abstract removeListeners : vector: BasicArrayList -> unit
    default this.removeListeners(vector: BasicArrayList) : unit =
        let mutable eventListenerInterface : EventListenerInterface = null
        let mutable size : int = vector.size()
        let mutable index : int = 0
        while index < size do
            eventListenerInterface <- (box (vector.get(index)) :?> EventListenerInterface)
            this.removeListener(eventListenerInterface)
            index <- index + 1
    
    abstract addListenerSingleThreaded : eventListenerInterface: EventListenerInterface -> unit
    default this.addListenerSingleThreaded(eventListenerInterface: EventListenerInterface) : unit =
        if not (this.eventListenerInterfaceList.contains(eventListenerInterface)) then
            ignore (this.eventListenerInterfaceList.add(eventListenerInterface))
    
    abstract addListenerInterface : eventListenerInterface: EventListenerInterface -> unit
    default this.addListenerInterface(eventListenerInterface: EventListenerInterface) : unit =
        if not (this.eventListenerInterfaceList.contains(eventListenerInterface)) then
            ignore (this.eventListenerInterfaceList.add(eventListenerInterface))
    
    abstract removeListenerSingleThreaded : eventListenerInterface: EventListenerInterface -> unit
    default this.removeListenerSingleThreaded(eventListenerInterface: EventListenerInterface) : unit =
        ignore (this.eventListenerInterfaceList.remove(eventListenerInterface))
    
    abstract removeListener : eventListenerInterface: EventListenerInterface -> unit
    default this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        ignore (this.eventListenerInterfaceList.remove(eventListenerInterface))
    
    abstract fireEvent : eventObject: AllBinaryEventObject -> unit
    default this.fireEvent(eventObject: AllBinaryEventObject) : unit =
        let mutable eventListenerInterface : EventListenerInterface = null
        let mutable index : int = 0
        while index < this.eventListenerInterfaceList.size() do
            try
                eventListenerInterface <- (box (this.eventListenerInterfaceList.get(index)) :?> EventListenerInterface)
                this.process_(eventObject, eventListenerInterface)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.eventStrings.FIRE_EVENT, e)
                | _ -> reraise ()
            index <- index + 1
    
    abstract process_ : eventObject: AllBinaryEventObject * eventListenerInterface: EventListenerInterface -> unit
    default this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        eventListenerInterface.onEvent(eventObject)
    
    abstract getEventListenerInterfaceListP : unit -> BasicArrayList
    default this.getEventListenerInterfaceListP() : BasicArrayList =
        this.eventListenerInterfaceList
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(this.eventStrings.TOTAL_LISTENERS))
        ignore (stringBuffer.appendint(this.eventListenerInterfaceList.size()))
        let mutable eventListenerInterface : EventListenerInterface = null
        let mutable index : int = 0
        while index < this.eventListenerInterfaceList.size() do
            try
                eventListenerInterface <- (box (this.eventListenerInterfaceList.get(index)) :?> EventListenerInterface)
                ignore (stringBuffer.append(this.eventStrings.LISTENER_LABEL))
                ignore (stringBuffer.append(eventListenerInterface.ToString()))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.TOSTRING, e)
                | _ -> reraise ()
            index <- index + 1
        stringBuffer.ToString()
    interface BasicEventHandlerInterface with
        member this.addListenerInterface(jp0: EventListenerInterface) : unit = this.addListenerInterface(jp0)
        member this.fireEvent(jp0: AllBinaryEventObject) : unit = this.fireEvent(jp0)
        member this.removeAllListeners() : unit = this.removeAllListeners()
        member this.removeListener(jp0: EventListenerInterface) : unit = this.removeListener(jp0)
        member this.addListeners(jp0: BasicArrayList) : unit = this.addListeners(jp0)


