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
type GameInputProcessor =
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameInputProcessor
    static member instance with get() : GameInputProcessor = (GameInputProcessor.jclinit(); GameInputProcessor.jcell_instance) and set (jvalue: GameInputProcessor) = (GameInputProcessor.jclinit(); GameInputProcessor.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInputProcessor.jclinitDone then
            GameInputProcessor.jclinitDone <- true
            GameInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        GameInputProcessor.jcell_instance <- (new GameInputProcessor())
        ()
    
    static member getInstance() : GameInputProcessor =
        GameInputProcessor.instance
    
    new () =
        {  }
    
    abstract processEvent : allbinaryLayerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.processEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract processReleasedEvent : allbinaryLayerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.processReleasedEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract processAnalog : allbinaryLayerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent * analogValue: int -> unit
    default this.processAnalog(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent, analogValue: int) : unit =
        ()
    
    abstract process_ : allbinaryLayerManager: AllBinaryLayerManager * keyAsInteger: Integer -> unit
    default this.process_(allbinaryLayerManager: AllBinaryLayerManager, keyAsInteger: Integer) : unit =
        ()
    
    abstract processReleased : allbinaryLayerManager: AllBinaryLayerManager * keyAsInteger: Integer -> unit
    default this.processReleased(allbinaryLayerManager: AllBinaryLayerManager, keyAsInteger: Integer) : unit =
        ()


