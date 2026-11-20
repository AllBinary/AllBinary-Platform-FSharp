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
type GameTypeFactory =
    [<DefaultValue(false)>] val mutable NULL_GAME_TYPE_ARRAY : GameType[]
    [<DefaultValue(false)>] val mutable NONE : GameType
    [<DefaultValue(false)>] val mutable SINGLE_PLAYER : GameType
    [<DefaultValue(false)>] val mutable MULTI_PLAYER : GameType
    [<DefaultValue(false)>] val mutable BOT : GameType
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameTypeFactory
    static member instance with get() : GameTypeFactory = (GameTypeFactory.jclinit(); GameTypeFactory.jcell_instance) and set (jvalue: GameTypeFactory) = (GameTypeFactory.jclinit(); GameTypeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameTypeFactory.jclinitDone then
            GameTypeFactory.jclinitDone <- true
            GameTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameTypeFactory.jcell_instance <- (new GameTypeFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameTypeFactory()
    member this.jfields_GameTypeFactory() : unit =
        this.NULL_GAME_TYPE_ARRAY <- (Array.zeroCreate<GameType> (0))
        this.NONE <- (new GameType(StringUtil.getInstance().NULL_STRING))
        this.SINGLE_PLAYER <- (new GameType("Single Player"))
        this.MULTI_PLAYER <- (new GameType("Multi Player"))
        this.BOT <- (new GameType("Artificial Player"))
        ()
    
    static member getInstance() : GameTypeFactory =
        GameTypeFactory.instance


