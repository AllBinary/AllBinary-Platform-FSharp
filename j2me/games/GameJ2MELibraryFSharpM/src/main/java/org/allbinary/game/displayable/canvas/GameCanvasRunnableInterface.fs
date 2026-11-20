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
type GameCanvasRunnableInterface =
    inherit RunnableInterface
    inherit PaintableInterface
    inherit ItemStateListener
    inherit GameStateCompositeInterface
    abstract getTitle : unit -> string
    abstract isInitialized : unit -> bool
    abstract isPaused : unit -> bool
    abstract unPause : unit -> unit
    abstract pause : unit -> unit
    abstract isHighScoreSubmitted : unit -> bool
    abstract setHighScoreSubmitted : highScoreSubmitted: bool -> unit
    abstract processGameOver : unit -> unit
    abstract isGameOver : unit -> bool
    abstract initCommands : cmdListener: CommandListener -> unit
    abstract getCurrentStateHashtable : unit -> ABHashtable
    abstract getLoadStateHashtable : unit -> ABHashtable
    abstract setLoadStateHashtable : hashtable: ABHashtable -> unit
    abstract getType : unit -> int


