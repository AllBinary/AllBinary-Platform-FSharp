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
type ScrollMapEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : ScrollMapEventHandler
    static member SINGLETON with get() : ScrollMapEventHandler = (ScrollMapEventHandler.jclinit(); ScrollMapEventHandler.jcell_SINGLETON) and set (jvalue: ScrollMapEventHandler) = (ScrollMapEventHandler.jclinit(); ScrollMapEventHandler.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScrollMapEventHandler.jclinitDone then
            ScrollMapEventHandler.jclinitDone <- true
            ScrollMapEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        ScrollMapEventHandler.jcell_SINGLETON <- (new ScrollMapEventHandler())
        ()
    
    new () =
        { inherit BasicEventHandler() }
    
    static member getInstance() : ScrollMapEventHandler =
        ScrollMapEventHandler.SINGLETON
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable scrollMapEventListenerInterface : ScrollMapEventListenerInterface = ((box (eventListenerInterface) :?> ScrollMapEventListenerInterface))
        scrollMapEventListenerInterface.onMoveEvent((box (eventObject) :?> ScrollMapEvent))


