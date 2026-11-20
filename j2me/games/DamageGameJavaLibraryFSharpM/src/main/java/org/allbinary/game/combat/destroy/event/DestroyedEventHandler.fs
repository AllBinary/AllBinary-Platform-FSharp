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
type DestroyedEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : DestroyedEventHandler
    static member instance with get() : DestroyedEventHandler = (DestroyedEventHandler.jclinit(); DestroyedEventHandler.jcell_instance) and set (jvalue: DestroyedEventHandler) = (DestroyedEventHandler.jclinit(); DestroyedEventHandler.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DestroyedEventHandler.jclinitDone then
            DestroyedEventHandler.jclinitDone <- true
            DestroyedEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        DestroyedEventHandler.jcell_instance <- (new DestroyedEventHandler())
        ()
    member this.jfields_DestroyedEventHandler() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : DestroyedEventHandler =
        DestroyedEventHandler.instance
    
    new () as this =
        { inherit BasicEventHandler() }
        then
            this.jfields_DestroyedEventHandler()
    
    abstract addListener : collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer -> unit
    default this.addListener(collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer) : unit =
        if not (this.list.contains(collidableDestroyableDamageableLayer)) then
            ignore (this.list.add(collidableDestroyableDamageableLayer))
    
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
                let mutable collidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer = (box (this.list.objectArray.[index]) :?> CollidableDestroyableDamageableLayer)
                collidableDestroyableDamageableLayer.onDestroyed((box (eventObject) :?> DestroyedEvent))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, EventStrings.getInstance().FIRE_EVENT, e)
                | _ -> reraise ()
        base.fireEvent(eventObject)
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable destroyedEventListenerInterface : DestroyedEventListenerInterface = (box (eventListenerInterface) :?> DestroyedEventListenerInterface)
        destroyedEventListenerInterface.onDestroyed((box (eventObject) :?> DestroyedEvent))


