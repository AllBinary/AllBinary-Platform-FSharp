namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type BaseGameBehavior =
    inherit DemoGameBehavior
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : BaseGameBehavior
    static member instanceC with get() : BaseGameBehavior = (BaseGameBehavior.jclinit(); BaseGameBehavior.jcell_instanceC) and set (jvalue: BaseGameBehavior) = (BaseGameBehavior.jclinit(); BaseGameBehavior.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseGameBehavior.jclinitDone then
            BaseGameBehavior.jclinitDone <- true
            BaseGameBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        BaseGameBehavior.jcell_instanceC <- (new BaseGameBehavior())
        ()
    new () =
        { inherit DemoGameBehavior() }
    
    static member getInstance() : DemoGameBehavior =
        BaseGameBehavior.instanceC
    
    override this.init() : unit =
        let mutable gameAdState : GameAdState = GameAdStateFactory.getInstance().getCurrentInstance()
        gameAdState.playingAdState()
    
    override this.pause(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        let mutable features : Features = Features.getInstance()
        if features.isDefault(OpenGLFeatureFactory.getInstance().OPENGL_AS_GAME_THREAD) then
            let mutable currentDisplayableFactory : CurrentDisplayableFactory = CurrentDisplayableFactory.getInstance()
            currentDisplayableFactory.setRunnable(allBinaryGameCanvas.gamePauseRunnable)
    
    override this.unPause(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        if Features.getInstance().isDefault(OpenGLFeatureFactory.getInstance().OPENGL_AS_GAME_THREAD) then
            let mutable currentDisplayableFactory : CurrentDisplayableFactory = CurrentDisplayableFactory.getInstance()
            currentDisplayableFactory.setRunnable(allBinaryGameCanvas.gameRunnable)
            currentDisplayableFactory.setDisplayable(allBinaryGameCanvas)
    
    override this.updateTouch(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.updateTouch2()
    
    override this.updateScreenButtonPaintable(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.updateScreenButtonPaintable2()
    
    override this.setGameState(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.updateGameState()
    
    override this.removeAllGameKeyInputListeners(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.removeAllGameKeyInputListeners2()
    
    override this.updateEndGameProcessor(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.updateEndGameProcessor2()
    
    override this.buildGame(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.buildGame2()
    
    override this.run(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.run2()
    
    override this.setHighScore(abeClientInformation: AbeClientInformationInterface, allBinaryGameCanvas: AllBinaryGameCanvas, name: string, score: int64, autoSubmit: bool, isLast: bool) : unit =
        allBinaryGameCanvas.setHighScore2(abeClientInformation, name, score, autoSubmit, isLast)


