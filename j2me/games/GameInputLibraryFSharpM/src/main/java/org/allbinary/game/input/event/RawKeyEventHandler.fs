namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type RawKeyEventHandler =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable eventListenerInterfaceList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : RawKeyEventHandler
    static member instance with get() : RawKeyEventHandler = (RawKeyEventHandler.jclinit(); RawKeyEventHandler.jcell_instance) and set (jvalue: RawKeyEventHandler) = (RawKeyEventHandler.jclinit(); RawKeyEventHandler.jcell_instance <- jvalue)
    static member TOTAL_LISTENERS : string = "Total Listeners: "
    static member LISTENER_LABEL : string = " Listener: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RawKeyEventHandler.jclinitDone then
            RawKeyEventHandler.jclinitDone <- true
            RawKeyEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        RawKeyEventHandler.jcell_instance <- (new RawKeyEventHandler())
        ()
    member this.jfields_RawKeyEventHandler() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : RawKeyEventHandler =
        RawKeyEventHandler.instance
    
    new () as this =
        {  }
        then
            this.jfields_RawKeyEventHandler()
            this.jctor1()
    member this.jctor1() : unit =
        this.eventListenerInterfaceList <- (new BasicArrayListD())
        ()
    
    abstract removeAllListeners : unit -> unit
    default this.removeAllListeners() : unit =
        this.eventListenerInterfaceList <- (new BasicArrayListD())
    
    abstract addListeners : vector: BasicArrayList -> unit
    default this.addListeners(vector: BasicArrayList) : unit =
        let mutable eventListenerInterface : RawKeyEventListener = null
        let mutable size : int = vector.size()
        let mutable index : int = 0
        while index < size do
            eventListenerInterface <- (box (vector.get(index)) :?> RawKeyEventListener)
            this.addListener(eventListenerInterface)
            index <- index + 1
    
    abstract addListenerSingleThreaded : eventListenerInterface: RawKeyEventListener -> unit
    default this.addListenerSingleThreaded(eventListenerInterface: RawKeyEventListener) : unit =
        if not (this.eventListenerInterfaceList.contains(eventListenerInterface)) then
            ignore (this.eventListenerInterfaceList.add(eventListenerInterface))
    
    abstract addListener : eventListenerInterface: RawKeyEventListener -> unit
    default this.addListener(eventListenerInterface: RawKeyEventListener) : unit =
        if not (this.eventListenerInterfaceList.contains(eventListenerInterface)) then
            ignore (this.eventListenerInterfaceList.add(eventListenerInterface))
    
    abstract removeListenerSingleThreaded : eventListenerInterface: RawKeyEventListener -> unit
    default this.removeListenerSingleThreaded(eventListenerInterface: RawKeyEventListener) : unit =
        ignore (this.eventListenerInterfaceList.remove(eventListenerInterface))
    
    abstract removeListener : eventListenerInterface: RawKeyEventListener -> unit
    default this.removeListener(eventListenerInterface: RawKeyEventListener) : unit =
        ignore (this.eventListenerInterfaceList.remove(eventListenerInterface))
    
    abstract fireEvent : keyCode: int * deviceId: int * repeated: bool -> unit
    default this.fireEvent(keyCode: int, deviceId: int, repeated: bool) : unit =
        let mutable eventListenerInterface : RawKeyEventListener = null
        let mutable index : int = 0
        while index < this.eventListenerInterfaceList.size() do
            try
                eventListenerInterface <- (box (this.eventListenerInterfaceList.get(index)) :?> RawKeyEventListener)
                this.process_(keyCode, deviceId, repeated, eventListenerInterface)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                    this.logUtil.put(commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
            index <- index + 1
    
    abstract process_ : keyCode: int * deviceId: int * repeated: bool * eventListenerInterface: RawKeyEventListener -> unit
    default this.process_(keyCode: int, deviceId: int, repeated: bool, eventListenerInterface: RawKeyEventListener) : unit =
        eventListenerInterface.onEventRaw(keyCode, deviceId, repeated)
    
    abstract getEventListenerInterfaceListP : unit -> BasicArrayList
    default this.getEventListenerInterfaceListP() : BasicArrayList =
        this.eventListenerInterfaceList
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(RawKeyEventHandler.TOTAL_LISTENERS))
        ignore (stringBuffer.appendint(this.eventListenerInterfaceList.size()))
        let mutable eventListenerInterface : RawKeyEventListener = null
        let mutable index : int = 0
        while index < this.eventListenerInterfaceList.size() do
            try
                eventListenerInterface <- (box (this.eventListenerInterfaceList.get(index)) :?> RawKeyEventListener)
                ignore (stringBuffer.append(RawKeyEventHandler.LISTENER_LABEL))
                ignore (stringBuffer.append(eventListenerInterface.ToString()))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                    this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.TOSTRING, e)
                | _ -> reraise ()
            index <- index + 1
        stringBuffer.ToString()


