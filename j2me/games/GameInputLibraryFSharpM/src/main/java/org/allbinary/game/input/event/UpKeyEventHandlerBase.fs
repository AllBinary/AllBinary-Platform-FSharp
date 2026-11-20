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
type UpKeyEventHandlerBase =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    static member TOTAL_LISTENERS : string = " Total PlayerGameInput Listeners: "
    static member LISTENER_LABEL : string = " PlayerGameInput Listener: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not UpKeyEventHandlerBase.jclinitDone then
            UpKeyEventHandlerBase.jclinitDone <- true
            UpKeyEventHandlerBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_UpKeyEventHandlerBase() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_UpKeyEventHandlerBase()
    
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
    
    abstract fireEventForInteger : eventObject: Integer -> unit
    default this.fireEventForInteger(eventObject: Integer) : unit =
        let mutable index : int = this.list.size()
        while ((index <- index - 1; index)) >= 0 do
            try
                let mutable playerGameInput : PlayerGameInput = (box (this.list.objectArray.[index]) :?> PlayerGameInput)
                playerGameInput.onUpKeyEvent(eventObject)
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
                this.processForInteger(eventObject, eventListenerInterface)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
            index <- index + 1
    
    abstract processForInteger : eventObject: Integer * eventListenerInterface: EventListenerInterface -> unit
    default this.processForInteger(eventObject: Integer, eventListenerInterface: EventListenerInterface) : unit =
        let mutable upKeyEventListenerInterface : UpKeyEventListenerInterface = (box (eventListenerInterface) :?> UpKeyEventListenerInterface)
        upKeyEventListenerInterface.onUpKeyEvent(eventObject)
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(base.ToString()))
        ignore (stringBuffer.append(UpKeyEventHandlerBase.TOTAL_LISTENERS))
        ignore (stringBuffer.appendint(this.list.size()))
        let mutable index : int = 0
        while index < this.list.size() do
            try
                let mutable eventListenerInterface : EventListenerInterface = (box (this.list.get(index)) :?> EventListenerInterface)
                ignore (stringBuffer.append(UpKeyEventHandlerBase.LISTENER_LABEL))
                ignore (stringBuffer.append(eventListenerInterface.ToString()))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.TOSTRING, e)
                | _ -> reraise ()
            index <- index + 1
        stringBuffer.ToString()


