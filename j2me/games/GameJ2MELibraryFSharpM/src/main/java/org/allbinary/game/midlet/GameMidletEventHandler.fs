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
type GameMidletEventHandler =
    inherit BasicEventHandler
    [<DefaultValue(false)>] static val mutable private jcell_gameKeyEventHandler : GameMidletEventHandler
    static member gameKeyEventHandler with get() : GameMidletEventHandler = (GameMidletEventHandler.jclinit(); GameMidletEventHandler.jcell_gameKeyEventHandler) and set (jvalue: GameMidletEventHandler) = (GameMidletEventHandler.jclinit(); GameMidletEventHandler.jcell_gameKeyEventHandler <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameMidletEventHandler.jclinitDone then
            GameMidletEventHandler.jclinitDone <- true
            GameMidletEventHandler.jclinitBody()
    static member private jclinitBody() : unit =
        GameMidletEventHandler.jcell_gameKeyEventHandler <- (new GameMidletEventHandler())
        ()
    
    new () =
        { inherit BasicEventHandler() }
    
    static member getInstance() : GameMidletEventHandler =
        GameMidletEventHandler.gameKeyEventHandler
    
    override this.process_(eventObject: AllBinaryEventObject, eventListenerInterface: EventListenerInterface) : unit =
        let mutable gameMidletEventListener : GameMidletEventListener = (box (eventListenerInterface) :?> GameMidletEventListener)
        gameMidletEventListener.onGameEnd(eventObject)


