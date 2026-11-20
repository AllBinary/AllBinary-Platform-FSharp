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
type DemoGameMidletEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_gameKeyEventHandler : DemoGameMidletEventHandler
    static member gameKeyEventHandler with get() : DemoGameMidletEventHandler = (DemoGameMidletEventHandler.jclinit(); DemoGameMidletEventHandler.jcell_gameKeyEventHandler) and set (jvalue: DemoGameMidletEventHandler) = (DemoGameMidletEventHandler.jclinit(); DemoGameMidletEventHandler.jcell_gameKeyEventHandler <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoGameMidletEventHandler.jclinitDone then
            DemoGameMidletEventHandler.jclinitDone <- true
            DemoGameMidletEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        DemoGameMidletEventHandler.jcell_gameKeyEventHandler <- (new DemoGameMidletEventHandler())
        ()
    
    new () =
        { inherit BasicEventHandler() }
    
    static member getInstance() : DemoGameMidletEventHandler =
        DemoGameMidletEventHandler.gameKeyEventHandler
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable demoGameMidletEventListener : DemoGameMidletEventListener = (box (eventListenerInterface) :?> DemoGameMidletEventListener)
        demoGameMidletEventListener.onDemoGameMidletEvent((box (eventObject) :?> DemoGameMidletEvent))


