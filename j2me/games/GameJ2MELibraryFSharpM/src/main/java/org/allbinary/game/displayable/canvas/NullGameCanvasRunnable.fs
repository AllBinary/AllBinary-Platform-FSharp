namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NullGameCanvasRunnable =
    [<DefaultValue(false)>] val mutable gameStateFactory : GameStateFactory
    [<DefaultValue(false)>] static val mutable private jcell_NULL_GAME_CANVAS_RUNNABLE : NullGameCanvasRunnable
    static member NULL_GAME_CANVAS_RUNNABLE with get() : NullGameCanvasRunnable = (NullGameCanvasRunnable.jclinit(); NullGameCanvasRunnable.jcell_NULL_GAME_CANVAS_RUNNABLE) and set (jvalue: NullGameCanvasRunnable) = (NullGameCanvasRunnable.jclinit(); NullGameCanvasRunnable.jcell_NULL_GAME_CANVAS_RUNNABLE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullGameCanvasRunnable.jclinitDone then
            NullGameCanvasRunnable.jclinitDone <- true
            NullGameCanvasRunnable.jclinitBody()
    static member private jclinitBody() : unit =
        NullGameCanvasRunnable.jcell_NULL_GAME_CANVAS_RUNNABLE <- (new NullGameCanvasRunnable())
        ()
    new () as this =
        {  }
        then
            this.jfields_NullGameCanvasRunnable()
    member this.jfields_NullGameCanvasRunnable() : unit =
        this.gameStateFactory <- GameStateFactory.getInstance()
        ()
    
    abstract getTitle : unit -> string
    default this.getTitle() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract isInitialized : unit -> bool
    default this.isInitialized() : bool =
        false
    
    abstract isPaused : unit -> bool
    default this.isPaused() : bool =
        false
    
    abstract unPause : unit -> unit
    default this.unPause() : unit =
        ()
    
    abstract pause : unit -> unit
    default this.pause() : unit =
        ()
    
    abstract isHighScoreSubmitted : unit -> bool
    default this.isHighScoreSubmitted() : bool =
        false
    
    abstract setHighScoreSubmitted : highScoreSubmitted: bool -> unit
    default this.setHighScoreSubmitted(highScoreSubmitted: bool) : unit =
        ()
    
    abstract processGameOver : unit -> unit
    default this.processGameOver() : unit =
        ()
    
    abstract isGameOver : unit -> bool
    default this.isGameOver() : bool =
        false
    
    abstract initCommands : cmdListener: CommandListener -> unit
    default this.initCommands(cmdListener: CommandListener) : unit =
        ()
    
    abstract getCurrentStateHashtable : unit -> ABHashtable
    default this.getCurrentStateHashtable() : ABHashtable =
        StdUtil.getInstance().NULL_TABLE
    
    abstract getLoadStateHashtable : unit -> ABHashtable
    default this.getLoadStateHashtable() : ABHashtable =
        StdUtil.getInstance().NULL_TABLE
    
    abstract setLoadStateHashtable : hashtable: ABHashtable -> unit
    default this.setLoadStateHashtable(hashtable: ABHashtable) : unit =
        ()
    
    abstract getType : unit -> int
    default this.getType() : int =
        -1
    
    abstract setGameState : gameState: GameState -> unit
    default this.setGameState(gameState: GameState) : unit =
        ()
    
    abstract getGameState : unit -> GameState
    default this.getGameState() : GameState =
        this.gameStateFactory.NO_GAME_STATE
    
    abstract itemStateChanged : item: LcduiItem -> unit
    default this.itemStateChanged(item: LcduiItem) : unit =
        ()
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        ()
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    
    abstract isRunning : unit -> bool
    default this.isRunning() : bool =
        false
    
    abstract setRunning : isRunning: bool -> unit
    default this.setRunning(isRunning: bool) : unit =
        ()
    
    abstract setThread : thread: Thread -> unit
    default this.setThread(thread: Thread) : unit =
        ()
    
    abstract run : unit -> unit
    default this.run() : unit =
        ()
    interface GameCanvasRunnableInterface with
        member this.getTitle() : string = this.getTitle()
        member this.isInitialized() : bool = this.isInitialized()
        member this.isPaused() : bool = this.isPaused()
        member this.unPause() : unit = this.unPause()
        member this.pause() : unit = this.pause()
        member this.isHighScoreSubmitted() : bool = this.isHighScoreSubmitted()
        member this.setHighScoreSubmitted(jp0: bool) : unit = this.setHighScoreSubmitted(jp0)
        member this.processGameOver() : unit = this.processGameOver()
        member this.isGameOver() : bool = this.isGameOver()
        member this.initCommands(jp0: CommandListener) : unit = this.initCommands(jp0)
        member this.getCurrentStateHashtable() : ABHashtable = this.getCurrentStateHashtable()
        member this.getLoadStateHashtable() : ABHashtable = this.getLoadStateHashtable()
        member this.setLoadStateHashtable(jp0: ABHashtable) : unit = this.setLoadStateHashtable(jp0)
        member this.getType() : int = this.getType()
    interface RunnableInterface with
        member this.isRunning() : bool = this.isRunning()
        member this.setRunning(jp0: bool) : unit = this.setRunning(jp0)
        member this.setThread(jp0: Thread) : unit = this.setThread(jp0)
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)
    interface ItemStateListener with
        member this.itemStateChanged(jp0: LcduiItem) : unit = this.itemStateChanged(jp0)
    interface GameStateCompositeInterface with
        member this.setGameState(jp0: GameState) : unit = this.setGameState(jp0)
        member this.getGameState() : GameState = this.getGameState()
    interface Runnable with
        member this.run() : unit = this.run()


