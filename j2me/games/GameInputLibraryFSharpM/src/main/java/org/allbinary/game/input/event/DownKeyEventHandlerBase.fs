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
type DownKeyEventHandlerBase =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    static member TOTAL_LISTENERS : string = " Total PlayerGameInput Listeners: "
    static member LISTENER_LABEL : string = " PlayerGameInput Listener: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DownKeyEventHandlerBase.jclinitDone then
            DownKeyEventHandlerBase.jclinitDone <- true
            DownKeyEventHandlerBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DownKeyEventHandlerBase() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_DownKeyEventHandlerBase()
    
    abstract addListener : playerGameInput: PlayerGameInput -> unit
    default this.addListener(playerGameInput: PlayerGameInput) : unit =
        if not (this.list.contains(playerGameInput)) then
            ignore (this.list.add(playerGameInput))
    
    override this.removeAllListeners() : unit =
        this.list.clear()
        base.removeAllListeners()
    
    override this.removeListenerSingleThreaded(eventListenerInterface: EventListenerInterface) : unit =
        ignore (this.list.remove(eventListenerInterface))
        base.removeListenerSingleThreaded(eventListenerInterface)
    
    override this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        ignore (this.list.remove(eventListenerInterface))
        base.removeListener(eventListenerInterface)
    
    abstract fireEventI : eventObject: Integer -> unit
    default this.fireEventI(eventObject: Integer) : unit =
        let mutable index : int = this.list.size()
        while ((index <- index - 1; index)) >= 0 do
            try
                let mutable playerGameInput : PlayerGameInput = (box (this.list.objectArray.[index]) :?> PlayerGameInput)
                playerGameInput.onDownKey(eventObject)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        let mutable index : int = 0
        let mutable eventListenerInterface : EventListenerInterface = null
        while index < this.eventListenerInterfaceList.size() do
            try
                eventListenerInterface <- (box (this.eventListenerInterfaceList.get(index)) :?> EventListenerInterface)
                this.processI(eventObject, eventListenerInterface)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
            index <- index + 1
    
    abstract fireEventForGameKeyEvent : eventObject: GameKeyEvent -> unit
    default this.fireEventForGameKeyEvent(eventObject: GameKeyEvent) : unit =
        let mutable size : int = this.list.size()
        let mutable index : int = size
        while ((index <- index - 1; index)) >= 0 do
            try
                let mutable playerGameInput : PlayerGameInput = (box (this.list.objectArray.[index]) :?> PlayerGameInput)
                playerGameInput.onDownKeyEvent(eventObject)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        let mutable index : int = 0
        let mutable eventListenerInterface : EventListenerInterface = null
        while index < this.eventListenerInterfaceList.size() do
            try
                eventListenerInterface <- (box (this.eventListenerInterfaceList.get(index)) :?> EventListenerInterface)
                this.processEvent(eventObject, eventListenerInterface)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
            index <- index + 1
    
    abstract processI : eventObject: Integer * eventListenerInterface: EventListenerInterface -> unit
    default this.processI(eventObject: Integer, eventListenerInterface: EventListenerInterface) : unit =
        let mutable downKeyEventListenerInterface : DownKeyEventListenerInterface = (box (eventListenerInterface) :?> DownKeyEventListenerInterface)
        downKeyEventListenerInterface.onDownKey(eventObject)
    
    abstract processEvent : eventObject: GameKeyEvent * eventListenerInterface: EventListenerInterface -> unit
    default this.processEvent(eventObject: GameKeyEvent, eventListenerInterface: EventListenerInterface) : unit =
        let mutable downKeyEventListenerInterface : DownKeyEventListenerInterface = (box (eventListenerInterface) :?> DownKeyEventListenerInterface)
        downKeyEventListenerInterface.onDownKeyEvent(eventObject)
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(base.ToString()))
        ignore (stringBuffer.append(DownKeyEventHandlerBase.TOTAL_LISTENERS))
        ignore (stringBuffer.appendint(this.list.size()))
        let mutable eventListenerInterface : EventListenerInterface = null
        let mutable index : int = 0
        while index < this.list.size() do
            try
                eventListenerInterface <- (box (this.list.get(index)) :?> EventListenerInterface)
                ignore (stringBuffer.append(DownKeyEventHandlerBase.LISTENER_LABEL))
                ignore (stringBuffer.append(eventListenerInterface.ToString()))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.TOSTRING, e)
                | _ -> reraise ()
            index <- index + 1
        stringBuffer.ToString()


