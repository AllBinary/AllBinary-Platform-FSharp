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
type EndGameProcessor =
    inherit Processor
    [<DefaultValue(false)>] val mutable gameStateFactory : GameStateFactory
    [<DefaultValue(false)>] val mutable gameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] val mutable WAIT : int64
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not EndGameProcessor.jclinitDone then
            EndGameProcessor.jclinitDone <- true
            EndGameProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_EndGameProcessor() : unit =
        this.gameStateFactory <- GameStateFactory.getInstance()
        this.WAIT <- 5000L
        ()
    
    new (gameCanvas: AllBinaryGameCanvas) as this =
        { inherit Processor() }
        then
            this.jfields_EndGameProcessor()
            this.jctor1(gameCanvas)
    member this.jctor1(gameCanvas: AllBinaryGameCanvas) : unit =
        this.gameCanvas <- gameCanvas
        ()
    
    override this.process_() : unit =
        if this.gameCanvas.isHighScoreSubmitted() then
            if this.gameCanvas.getGameStateTimeHelper().isElapsedTNT(this.WAIT) then
                if (JR.same(this.gameCanvas.getGameState(), this.gameStateFactory.SHOW_END_RESULT_GAME_STATE)) then
                    let mutable highScoresBase : HighScoresHelperBase = (box (this.gameCanvas.highScoresHelper) :?> HighScoresHelperBase)
                    let mutable highScores : HighScores = highScoresBase.getSelectedHighScores()
                    if not (JR.same(highScores, NullHighScoresSingletonFactory.getInstance())) then
                        highScoresBase.selectHighScores()
                        this.gameCanvas.getRealHighScoresPaintable().setHighScores(highScores)
                        this.gameCanvas.setGameState(this.gameStateFactory.SHOW_HIGH_SCORE_GAME_STATE)
                        this.gameCanvas.setHighScoresPaintable(this.gameCanvas.getRealHighScoresPaintable())
                elif (JR.same(this.gameCanvas.getGameState(), this.gameStateFactory.SHOW_HIGH_SCORE_GAME_STATE)) then
                    this.gameCanvas.setGameState(this.gameStateFactory.SHOW_END_RESULT_GAME_STATE)
                    this.gameCanvas.setHighScoresPaintable(NullPaintable.getInstance())


