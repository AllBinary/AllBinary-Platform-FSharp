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
type AnalogControllerConfigurationEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : AnalogControllerConfigurationEventHandler
    static member instance with get() : AnalogControllerConfigurationEventHandler = (AnalogControllerConfigurationEventHandler.jclinit(); AnalogControllerConfigurationEventHandler.jcell_instance) and set (jvalue: AnalogControllerConfigurationEventHandler) = (AnalogControllerConfigurationEventHandler.jclinit(); AnalogControllerConfigurationEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnalogControllerConfigurationEventHandler.jclinitDone then
            AnalogControllerConfigurationEventHandler.jclinitDone <- true
            AnalogControllerConfigurationEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        AnalogControllerConfigurationEventHandler.jcell_instance <- (new AnalogControllerConfigurationEventHandler())
        ()
    member this.jfields_AnalogControllerConfigurationEventHandler() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : AnalogControllerConfigurationEventHandler =
        AnalogControllerConfigurationEventHandler.instance
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_AnalogControllerConfigurationEventHandler()
    
    abstract addListener : analogControllerConfigurationEventListenerInterface: AnalogControllerConfigurationEventListenerInterface -> unit
    default this.addListener(analogControllerConfigurationEventListenerInterface: AnalogControllerConfigurationEventListenerInterface) : unit =
        if not (this.list.contains(analogControllerConfigurationEventListenerInterface)) then
            ignore (this.list.add(analogControllerConfigurationEventListenerInterface))
    
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
                let mutable playerGameInput : AnalogControllerConfigurationEventListenerInterface = (box (this.list.objectArray.[index]) :?> AnalogControllerConfigurationEventListenerInterface)
                playerGameInput.onAnalogControllerConfigurationEvent((box (eventObject) :?> AnalogControllerConfigurationEvent))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        base.fireEvent(eventObject)
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable analogControllerConfigurationEventListenerInterface : AnalogControllerConfigurationEventListenerInterface = ((box (eventListenerInterface) :?> AnalogControllerConfigurationEventListenerInterface))
        analogControllerConfigurationEventListenerInterface.onAnalogControllerConfigurationEvent((box (eventObject) :?> AnalogControllerConfigurationEvent))


