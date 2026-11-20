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
type PressGameKeyEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : PressGameKeyEventHandler
    static member instance with get() : PressGameKeyEventHandler = (PressGameKeyEventHandler.jclinit(); PressGameKeyEventHandler.jcell_instance) and set (jvalue: PressGameKeyEventHandler) = (PressGameKeyEventHandler.jclinit(); PressGameKeyEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PressGameKeyEventHandler.jclinitDone then
            PressGameKeyEventHandler.jclinitDone <- true
            PressGameKeyEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        PressGameKeyEventHandler.jcell_instance <- (new PressGameKeyEventHandler())
        ()
    member this.jfields_PressGameKeyEventHandler() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : PressGameKeyEventHandler =
        PressGameKeyEventHandler.instance
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_PressGameKeyEventHandler()
    
    abstract addListener : playerGameInput: PlayerGameInput -> unit
    default this.addListener(playerGameInput: PlayerGameInput) : unit =
        if not (this.list.contains(playerGameInput)) then
            ignore (this.list.add(playerGameInput))
    
    override this.removeAllListeners() : unit =
        this.list.clear()
        base.removeAllListeners()
    
    override this.removeListener(eventListenerInterface: EventListenerInterface) : unit =
        ignore (this.list.remove(eventListenerInterface))
        base.removeListener(eventListenerInterface)
    
    override this.fireEvent(eventObject: AllBinaryEventObject) : unit =
        let mutable index : int = this.list.size()
        while ((index <- index - 1; index)) >= 0 do
            try
                let mutable playerGameInput : PlayerGameInput = (box (this.list.objectArray.[index]) :?> PlayerGameInput)
                playerGameInput.onPressGameKeyEvent((box (eventObject) :?> GameKeyEvent))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        base.fireEvent(eventObject)
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable pressGameKeyEventListenerInterface : PressGameKeyEventListenerInterface = ((box (eventListenerInterface) :?> PressGameKeyEventListenerInterface))
        pressGameKeyEventListenerInterface.onPressGameKeyEvent((box (eventObject) :?> GameKeyEvent))


