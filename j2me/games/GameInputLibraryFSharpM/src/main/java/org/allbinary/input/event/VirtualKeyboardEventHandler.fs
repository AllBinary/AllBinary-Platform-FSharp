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
type VirtualKeyboardEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable SHOW_EVENT : VirtualKeyboardEvent
    [<DefaultValue(false)>] val mutable HIDE_EVENT : VirtualKeyboardEvent
    [<DefaultValue(false)>] static val mutable private jcell_gameKeyEventHandler : VirtualKeyboardEventHandler
    static member gameKeyEventHandler with get() : VirtualKeyboardEventHandler = (VirtualKeyboardEventHandler.jclinit(); VirtualKeyboardEventHandler.jcell_gameKeyEventHandler) and set (jvalue: VirtualKeyboardEventHandler) = (VirtualKeyboardEventHandler.jclinit(); VirtualKeyboardEventHandler.jcell_gameKeyEventHandler <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VirtualKeyboardEventHandler.jclinitDone then
            VirtualKeyboardEventHandler.jclinitDone <- true
            VirtualKeyboardEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        VirtualKeyboardEventHandler.jcell_gameKeyEventHandler <- (new VirtualKeyboardEventHandler())
        ()
    member this.jfields_VirtualKeyboardEventHandler() : unit =
        this.SHOW_EVENT <- (new VirtualKeyboardEvent(BooleanFactory.getInstance().TRUE))
        this.HIDE_EVENT <- (new VirtualKeyboardEvent(BooleanFactory.getInstance().FALSE))
        ()
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_VirtualKeyboardEventHandler()
    
    static member getInstance() : VirtualKeyboardEventHandler =
        VirtualKeyboardEventHandler.gameKeyEventHandler
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable virtualKeyboardEventListenerInterface : VirtualKeyboardEventListenerInterface = (box (eventListenerInterface) :?> VirtualKeyboardEventListenerInterface)
        virtualKeyboardEventListenerInterface.onVirtualKeyboardEvent((box (eventObject) :?> VirtualKeyboardEvent))
    
    abstract open_ : unit -> unit
    default this.open_() : unit =
        try
            ignore (Thread.sleep(120))
            this.fireEvent(this.SHOW_EVENT)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "open", e)
            | _ -> reraise ()
    
    abstract close : unit -> unit
    default this.close() : unit =
        try
            ignore (Thread.sleep(120))
            this.fireEvent(this.HIDE_EVENT)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.CLOSE, e)
            | _ -> reraise ()


