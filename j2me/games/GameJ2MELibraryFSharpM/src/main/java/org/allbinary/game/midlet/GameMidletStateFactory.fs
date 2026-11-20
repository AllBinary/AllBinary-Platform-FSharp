namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type GameMidletStateFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable currentGameState : GameState
    [<DefaultValue(false)>] static val mutable private jcell_INSTANCE : GameMidletStateFactory
    static member INSTANCE with get() : GameMidletStateFactory = (GameMidletStateFactory.jclinit(); GameMidletStateFactory.jcell_INSTANCE) and set (jvalue: GameMidletStateFactory) = (GameMidletStateFactory.jclinit(); GameMidletStateFactory.jcell_INSTANCE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameMidletStateFactory.jclinitDone then
            GameMidletStateFactory.jclinitDone <- true
            GameMidletStateFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameMidletStateFactory.jcell_INSTANCE <- (new GameMidletStateFactory())
        ()
    member this.jfields_GameMidletStateFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.currentGameState <- GameStateFactory.getInstance().NO_GAME_STATE
        ()
    
    new () as this =
        {  }
        then
            this.jfields_GameMidletStateFactory()
    
    static member getInstance() : GameMidletStateFactory =
        GameMidletStateFactory.INSTANCE
    
    abstract getCurrentGameState : unit -> GameState
    default this.getCurrentGameState() : GameState =
        this.currentGameState
    
    abstract setCurrentGameState : currentGameState: GameState -> unit
    default this.setCurrentGameState(currentGameState: GameState) : unit =
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().CURRENT).append(" GameState: ").append(StringUtil.getInstance().toString(currentGameState)).ToString(), this, "setCurrentGameState")
        this.currentGameState <- currentGameState


