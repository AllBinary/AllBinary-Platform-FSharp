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
type PlayerGameInput =
    inherit GameInput
    [<DefaultValue(false)>] val mutable gameInputStrings : GameInputStrings
    [<DefaultValue(false)>] val mutable playerInputId : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlayerGameInput.jclinitDone then
            PlayerGameInput.jclinitDone <- true
            PlayerGameInput.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PlayerGameInput() : unit =
        this.gameInputStrings <- GameInputStrings.getInstance()
        ()
    
    new (gameKeyEventList: BasicArrayList, removalGameKeyEventList: BasicArrayList, playerInputId: int) as this =
        { inherit GameInput(gameKeyEventList, removalGameKeyEventList) }
        then
            this.jfields_PlayerGameInput()
            this.jctor1(gameKeyEventList, removalGameKeyEventList, playerInputId)
    member this.jctor1(gameKeyEventList: BasicArrayList, removalGameKeyEventList: BasicArrayList, playerInputId: int) : unit =
        ()
        this.playerInputId <- playerInputId
        ()
    
    abstract onPressGameKeyEvent : gameKeyEvent: GameKeyEvent -> unit
    default this.onPressGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        ignore (this.add(gameKeyEvent))
        this.addForRemoval(gameKeyEvent)
    
    abstract onDownGameKeyEvent : gameKeyEvent: GameKeyEvent -> unit
    default this.onDownGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        ignore (this.add(gameKeyEvent))
    
    abstract onDownKeyEvent : gameKeyEvent: GameKeyEvent -> unit
    default this.onDownKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        ignore (this.add(gameKeyEvent))
        this.addForRemoval(gameKeyEvent)
    
    abstract onDownKey : gameKeyEvent: Integer -> unit
    default this.onDownKey(gameKeyEvent: Integer) : unit =
        PreLogUtil.put((new StringMaker()).append(CommonLabels.getInstance().START_LABEL).append(gameKeyEvent.ToString()).ToString(), this, this.gameInputStrings.ON_DOWN_GAME_KEY)
    
    abstract onUpGameKeyEvent : gameKeyEvent: GameKeyEvent -> unit
    default this.onUpGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        this.addForRemoval(gameKeyEvent)
    
    abstract onUpKeyEvent : gameKeyEvent: Integer -> unit
    default this.onUpKeyEvent(gameKeyEvent: Integer) : unit =
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract getPlayerInputId : unit -> int
    default this.getPlayerInputId() : int =
        this.playerInputId
    interface GameKeyEventListenerInterface
    interface DownGameKeyEventListenerInterface with
        member this.onDownGameKeyEvent(jp0: GameKeyEvent) : unit = this.onDownGameKeyEvent(jp0)
    interface UpGameKeyEventListenerInterface with
        member this.onUpGameKeyEvent(jp0: GameKeyEvent) : unit = this.onUpGameKeyEvent(jp0)
    interface PressGameKeyEventListenerInterface with
        member this.onPressGameKeyEvent(jp0: GameKeyEvent) : unit = this.onPressGameKeyEvent(jp0)
    interface EventListenerInterface with
        member this.onEvent(jp0: AllBinaryEventObject) : unit = this.onEvent(jp0)


