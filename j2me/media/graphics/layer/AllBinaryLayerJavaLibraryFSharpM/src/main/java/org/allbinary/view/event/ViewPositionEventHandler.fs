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
type ViewPositionEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : ViewPositionEventHandler
    static member SINGLETON with get() : ViewPositionEventHandler = (ViewPositionEventHandler.jclinit(); ViewPositionEventHandler.jcell_SINGLETON) and set (jvalue: ViewPositionEventHandler) = (ViewPositionEventHandler.jclinit(); ViewPositionEventHandler.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ViewPositionEventHandler.jclinitDone then
            ViewPositionEventHandler.jclinitDone <- true
            ViewPositionEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        ViewPositionEventHandler.jcell_SINGLETON <- (new ViewPositionEventHandler())
        ()
    member this.jfields_ViewPositionEventHandler() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : ViewPositionEventHandler =
        ViewPositionEventHandler.SINGLETON
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_ViewPositionEventHandler()
    
    abstract addListener : layerInterface: AllBinaryLayer -> unit
    default this.addListener(layerInterface: AllBinaryLayer) : unit =
        if not (this.list.contains(layerInterface)) then
            ignore (this.list.add(layerInterface))
    
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
                let mutable layerInterface : AllBinaryLayer = (box (this.list.objectArray.[index]) :?> AllBinaryLayer)
                layerInterface.onChangeEvent((box (eventObject) :?> ViewPositionEvent))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        base.fireEvent(eventObject)
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable viewPositionEventListenerInterface : ViewPositionEventListenerInterface = ((box (eventListenerInterface) :?> ViewPositionEventListenerInterface))
        viewPositionEventListenerInterface.onChangeEvent((box (eventObject) :?> ViewPositionEvent))


