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
type GameInfo =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable gameInfoData : GameInfoData
    [<DefaultValue(false)>] val mutable gameType : GameType
    [<DefaultValue(false)>] val mutable gameMode : GameMode
    [<DefaultValue(false)>] val mutable playerType : PlayerType
    [<DefaultValue(false)>] val mutable highestLevel : int
    [<DefaultValue(false)>] val mutable currentLevel : int
    [<DefaultValue(false)>] val mutable NEW_LEVEL : string
    [<DefaultValue(false)>] val mutable SET_CURRENT_LEVEL : string
    [<DefaultValue(false)>] val mutable NEXT_GAME_LEVEL : string
    [<DefaultValue(false)>] static val mutable private jcell_NONE : GameInfo
    static member NONE with get() : GameInfo = (GameInfo.jclinit(); GameInfo.jcell_NONE) and set (jvalue: GameInfo) = (GameInfo.jclinit(); GameInfo.jcell_NONE <- jvalue)
    static member LEVEL_NAME : string = "LEVEL"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInfo.jclinitDone then
            GameInfo.jclinitDone <- true
            GameInfo.jclinitBody()
    static member private jclinitBody() : unit =
        GameInfo.jcell_NONE <- (new GameInfo(GameTypeFactory.getInstance().NONE, GameMode.NONE, PlayerTypesFactory.getInstance().PLAYER_TYPE_ONE, -1, -1))
        ()
    member this.jfields_GameInfo() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.gameInfoData <- GameInfoData.getInstance()
        this.NEW_LEVEL <- "New Level: "
        this.SET_CURRENT_LEVEL <- "setCurrentLevel"
        this.NEXT_GAME_LEVEL <- "nextGameLevel"
        ()
    
    new (gameType: GameType, gameMode: GameMode, playerType: PlayerType, highestLevel: int, currentLevel: int) as this =
        {  }
        then
            this.jfields_GameInfo()
            this.jctor1(gameType, gameMode, playerType, highestLevel, currentLevel)
    member this.jctor1(gameType: GameType, gameMode: GameMode, playerType: PlayerType, highestLevel: int, currentLevel: int) : unit =
        this.gameType <- gameType
        this.gameMode <- gameMode
        this.setHighestLevel(highestLevel)
        this.currentLevel <- currentLevel
        this.playerType <- playerType
        ()
    
    abstract getGameType : unit -> GameType
    default this.getGameType() : GameType =
        this.gameType
    
    abstract getGameMode : unit -> GameMode
    default this.getGameMode() : GameMode =
        this.gameMode
    
    abstract getPlayerType : unit -> PlayerType
    default this.getPlayerType() : PlayerType =
        this.playerType
    
    abstract getHighestLevel : unit -> int
    default this.getHighestLevel() : int =
        this.highestLevel
    
    abstract setHighestLevel : highestLevel: int -> unit
    default this.setHighestLevel(highestLevel: int) : unit =
        this.highestLevel <- highestLevel
    
    abstract getCurrentLevel : unit -> int
    default this.getCurrentLevel() : int =
        this.currentLevel
    
    abstract setCurrentLevel : currentLevel: int -> unit
    default this.setCurrentLevel(currentLevel: int) : unit =
        this.currentLevel <- currentLevel
        this.logUtil.putF((new StringMaker()).append(this.NEW_LEVEL).appendint(this.getCurrentLevel()).ToString(), this, this.SET_CURRENT_LEVEL)
    
    abstract nextGameLevel : unit -> unit
    default this.nextGameLevel() : unit =
        if this.getCurrentLevel() < this.getHighestLevel() then
            this.currentLevel <- this.currentLevel + 1
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().NEXT).append(CommonSeps.getInstance().SPACE).append(this.NEW_LEVEL).appendint(this.getCurrentLevel()).ToString(), this, this.NEXT_GAME_LEVEL)
    
    abstract previousGameLevel : unit -> unit
    default this.previousGameLevel() : unit =
        if this.getCurrentLevel() > 1 then
            this.currentLevel <- this.currentLevel - 1
    
    abstract isLastLevel : unit -> bool
    default this.isLastLevel() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.getCurrentLevel() >= this.getHighestLevel() then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract toHashtable : unit -> ABHashtable
    default this.toHashtable() : ABHashtable =
        let mutable hashtable : ABHashtable = StdUtil.getInstance().createHashtable()
        ignore (hashtable.put(this.gameInfoData.GAME_TYPE, this.getGameType().ToString()))
        ignore (hashtable.put(this.gameInfoData.GAME_MODE, this.gameMode.ToString()))
        ignore (hashtable.put(this.gameInfoData.PLAYER_TYPE, this.playerType.ToString()))
        ignore (hashtable.put(this.gameInfoData.HIGHEST_LEVEL, Integer.toString(this.getHighestLevel())))
        ignore (hashtable.put(this.gameInfoData.CURRENT_LEVEL, Integer.toString(this.currentLevel)))
        hashtable
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        ignore (stringBuffer.append(this.gameInfoData.GAME_TYPE))
        ignore (stringBuffer.append(commonSeps.EQUALS))
        ignore (stringBuffer.append(this.getGameType().ToString()))
        ignore (stringBuffer.append(commonSeps.COMMA_SEP))
        ignore (stringBuffer.append(this.gameInfoData.GAME_MODE))
        ignore (stringBuffer.append(commonSeps.EQUALS))
        ignore (stringBuffer.append(this.gameMode.ToString()))
        ignore (stringBuffer.append(commonSeps.COMMA_SEP))
        ignore (stringBuffer.append(this.gameInfoData.PLAYER_TYPE))
        ignore (stringBuffer.append(commonSeps.EQUALS))
        ignore (stringBuffer.append(StringUtil.getInstance().toString(this.playerType)))
        ignore (stringBuffer.append(commonSeps.COMMA_SEP))
        ignore (stringBuffer.append(this.gameInfoData.HIGHEST_LEVEL))
        ignore (stringBuffer.append(commonSeps.EQUALS))
        ignore (stringBuffer.appendint(this.getHighestLevel()))
        ignore (stringBuffer.append(commonSeps.COMMA_SEP))
        ignore (stringBuffer.append(this.gameInfoData.CURRENT_LEVEL))
        ignore (stringBuffer.append(commonSeps.EQUALS))
        ignore (stringBuffer.appendint(this.currentLevel))
        stringBuffer.ToString()


