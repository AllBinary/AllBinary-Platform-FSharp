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
type GameInputMapping =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable gameKey : GameKey
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInputMapping.jclinitDone then
            GameInputMapping.jclinitDone <- true
            GameInputMapping.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameInputMapping() : unit =
        this.name <- StringUtil.getInstance().EMPTY_STRING
        this.gameKey <- GameKey.NULL_GAME_KEY
        ()
    
    new (name: string, gameKey: GameKey) as this =
        {  }
        then
            this.jfields_GameInputMapping()
            this.jctor1(name, gameKey)
    member this.jctor1(name: string, gameKey: GameKey) : unit =
        this.setName(name)
        this.setGameKey(gameKey)
        ()
    
    member this.setGameKey(gameKey: GameKey) : unit =
        this.gameKey <- gameKey
    
    abstract getGameKey : unit -> GameKey
    default this.getGameKey() : GameKey =
        this.gameKey
    
    member this.setName(name: string) : unit =
        this.name <- name
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name


