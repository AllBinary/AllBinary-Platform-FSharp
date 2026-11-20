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
type BasicHighScoresGameInfoFactory =
    [<DefaultValue(false)>] val mutable MULTI_PLAYER_SERVER : GameInfo
    [<DefaultValue(false)>] val mutable SINGLE_PLAYER_SERVER : GameInfo
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : BasicHighScoresGameInfoFactory
    static member SINGLETON with get() : BasicHighScoresGameInfoFactory = (BasicHighScoresGameInfoFactory.jclinit(); BasicHighScoresGameInfoFactory.jcell_SINGLETON) and set (jvalue: BasicHighScoresGameInfoFactory) = (BasicHighScoresGameInfoFactory.jclinit(); BasicHighScoresGameInfoFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicHighScoresGameInfoFactory.jclinitDone then
            BasicHighScoresGameInfoFactory.jclinitDone <- true
            BasicHighScoresGameInfoFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BasicHighScoresGameInfoFactory.jcell_SINGLETON <- (new BasicHighScoresGameInfoFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicHighScoresGameInfoFactory()
    member this.jfields_BasicHighScoresGameInfoFactory() : unit =
        this.MULTI_PLAYER_SERVER <- (new GameInfo(GameTypeFactory.getInstance().MULTI_PLAYER, GameMode.SERVER, PlayerTypesFactory.getInstance().PLAYER_TYPE_ONE, 0, 0))
        this.SINGLE_PLAYER_SERVER <- (new GameInfo(GameTypeFactory.getInstance().SINGLE_PLAYER, GameMode.SERVER, PlayerTypesFactory.getInstance().PLAYER_TYPE_ONE, 0, 0))
        ()
    
    static member getInstance() : BasicHighScoresGameInfoFactory =
        BasicHighScoresGameInfoFactory.SINGLETON


