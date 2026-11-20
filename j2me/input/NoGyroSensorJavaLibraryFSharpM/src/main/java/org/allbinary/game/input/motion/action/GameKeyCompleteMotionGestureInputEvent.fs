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
type GameKeyCompleteMotionGestureInputEvent =
    inherit CompleteMotionGestureInputEvent
    [<DefaultValue(false)>] val mutable gameKey : GameKey
    [<DefaultValue(false)>] val mutable gameKeyEvent : GameKeyEvent
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameKeyCompleteMotionGestureInputEvent.jclinitDone then
            GameKeyCompleteMotionGestureInputEvent.jclinitDone <- true
            GameKeyCompleteMotionGestureInputEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameKeyCompleteMotionGestureInputEvent() : unit =
        this.gameKey <- GameKey.NULL_GAME_KEY
        this.gameKeyEvent <- GameKeyEvent.NONE
        ()
    
    new (name: string, motionGestureInput: MotionGestureInput, inputToGameKeyMapping: InputToGameKeyMapping) as this =
        { inherit CompleteMotionGestureInputEvent(name, motionGestureInput) }
        then
            this.jfields_GameKeyCompleteMotionGestureInputEvent()
    
    abstract getSourceId : unit -> int
    default this.getSourceId() : int =
        0
    
    abstract update : unit -> unit
    default this.update() : unit =
        ()
    
    abstract setGameKeyEvent : gameKeyEvent: GameKeyEvent -> unit
    default this.setGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        this.gameKeyEvent <- gameKeyEvent
    
    abstract getGameKeyEvent : unit -> GameKeyEvent
    default this.getGameKeyEvent() : GameKeyEvent =
        this.gameKeyEvent
    
    abstract setGameKey : gameKey: GameKey -> unit
    default this.setGameKey(gameKey: GameKey) : unit =
        this.gameKey <- gameKey
    
    abstract getGameKey : unit -> GameKey
    default this.getGameKey() : GameKey =
        this.gameKey
    interface GameKeyEventSourceInterface with
        member this.getSourceId() : int = this.getSourceId()


