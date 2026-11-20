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
type GameInitializedEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_gameKeyEventHandler : GameInitializedEventHandler
    static member gameKeyEventHandler with get() : GameInitializedEventHandler = (GameInitializedEventHandler.jclinit(); GameInitializedEventHandler.jcell_gameKeyEventHandler) and set (jvalue: GameInitializedEventHandler) = (GameInitializedEventHandler.jclinit(); GameInitializedEventHandler.jcell_gameKeyEventHandler <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInitializedEventHandler.jclinitDone then
            GameInitializedEventHandler.jclinitDone <- true
            GameInitializedEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        GameInitializedEventHandler.jcell_gameKeyEventHandler <- (new GameInitializedEventHandler())
        ()
    
    new () =
        { inherit BasicEventHandler() }
    
    static member getInstance() : GameInitializedEventHandler =
        GameInitializedEventHandler.gameKeyEventHandler
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable gameInitializedListenerInterface : GameInitializedListenerInterface = ((box (eventListenerInterface) :?> GameInitializedListenerInterface))
        gameInitializedListenerInterface.onGameInitialized((box (eventObject) :?> GameInitializedEvent))


