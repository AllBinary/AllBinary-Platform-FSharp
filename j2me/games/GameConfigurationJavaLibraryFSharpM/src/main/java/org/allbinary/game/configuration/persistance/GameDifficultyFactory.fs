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
type GameDifficultyFactory =
    [<DefaultValue(false)>] val mutable level : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameDifficultyFactory
    static member instance with get() : GameDifficultyFactory = (GameDifficultyFactory.jclinit(); GameDifficultyFactory.jcell_instance) and set (jvalue: GameDifficultyFactory) = (GameDifficultyFactory.jclinit(); GameDifficultyFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameDifficultyFactory.jclinitDone then
            GameDifficultyFactory.jclinitDone <- true
            GameDifficultyFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameDifficultyFactory.jcell_instance <- (new GameDifficultyFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameDifficultyFactory()
    member this.jfields_GameDifficultyFactory() : unit =
        this.level <- 0
        ()
    
    static member getInstance() : GameDifficultyFactory =
        GameDifficultyFactory.instance
    
    abstract setLevel : level: int -> unit
    default this.setLevel(level: int) : unit =
        this.level <- level
    
    abstract getLevel : unit -> int
    default this.getLevel() : int =
        this.level


