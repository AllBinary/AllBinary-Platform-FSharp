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
type GameFeatureEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_gameKeyEventHandler : GameFeatureEventHandler
    static member gameKeyEventHandler with get() : GameFeatureEventHandler = (GameFeatureEventHandler.jclinit(); GameFeatureEventHandler.jcell_gameKeyEventHandler) and set (jvalue: GameFeatureEventHandler) = (GameFeatureEventHandler.jclinit(); GameFeatureEventHandler.jcell_gameKeyEventHandler <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameFeatureEventHandler.jclinitDone then
            GameFeatureEventHandler.jclinitDone <- true
            GameFeatureEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        GameFeatureEventHandler.jcell_gameKeyEventHandler <- (new GameFeatureEventHandler())
        ()
    
    new () =
        { inherit BasicEventHandler() }
    
    static member getInstance() : GameFeatureEventHandler =
        GameFeatureEventHandler.gameKeyEventHandler
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable gameFeatureListenerInterface : GameFeatureListenerInterface = ((box (eventListenerInterface) :?> GameFeatureListenerInterface))
        gameFeatureListenerInterface.onGameFeatureChange((box (eventObject) :?> GameFeatureEvent))


