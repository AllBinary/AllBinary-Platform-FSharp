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
type GameLevelDisplayChangeEventListenersFactory =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameLevelDisplayChangeEventListenersFactory
    static member instance with get() : GameLevelDisplayChangeEventListenersFactory = (GameLevelDisplayChangeEventListenersFactory.jclinit(); GameLevelDisplayChangeEventListenersFactory.jcell_instance) and set (jvalue: GameLevelDisplayChangeEventListenersFactory) = (GameLevelDisplayChangeEventListenersFactory.jclinit(); GameLevelDisplayChangeEventListenersFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameLevelDisplayChangeEventListenersFactory.jclinitDone then
            GameLevelDisplayChangeEventListenersFactory.jclinitDone <- true
            GameLevelDisplayChangeEventListenersFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameLevelDisplayChangeEventListenersFactory.jcell_instance <- (new GameLevelDisplayChangeEventListenersFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameLevelDisplayChangeEventListenersFactory()
    member this.jfields_GameLevelDisplayChangeEventListenersFactory() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : GameLevelDisplayChangeEventListenersFactory =
        GameLevelDisplayChangeEventListenersFactory.instance
    
    member this.add(displayChangeEventListener: DisplayChangeEventListener) : unit =
        ignore (this.list.add(displayChangeEventListener))
        DisplayChangeEventHandler.getInstance().addListenerInterface(displayChangeEventListener)
    
    member this.clear() : unit =
        let mutable displayChangeEventHandler : BasicEventHandler = DisplayChangeEventHandler.getInstance()
        let mutable displayChangeEventListener : DisplayChangeEventListener = null
        let mutable index : int = this.list.size()
        while ((index <- index - 1; index)) >= 0 do
            displayChangeEventListener <- (box (this.list.objectArray.[index]) :?> DisplayChangeEventListener)
            displayChangeEventHandler.removeListener(displayChangeEventListener)
        this.list.clear()


