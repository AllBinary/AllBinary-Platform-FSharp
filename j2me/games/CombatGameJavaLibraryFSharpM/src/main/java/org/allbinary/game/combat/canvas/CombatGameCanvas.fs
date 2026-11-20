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
type CombatGameCanvas =
    inherit AllBinaryGameCanvas
    [<DefaultValue(false)>] static val mutable private jcell_basicLayerProcessor : BasicLayerProcessor[]
    static member basicLayerProcessor with get() : BasicLayerProcessor[] = (CombatGameCanvas.jclinit(); CombatGameCanvas.jcell_basicLayerProcessor) and set (jvalue: BasicLayerProcessor[]) = (CombatGameCanvas.jclinit(); CombatGameCanvas.jcell_basicLayerProcessor <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CombatGameCanvas.jclinitDone then
            CombatGameCanvas.jclinitDone <- true
            CombatGameCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        CombatGameCanvas.jcell_basicLayerProcessor <- (Array.zeroCreate<BasicLayerProcessor> (0))
        ()
    
    new (cmdListener: CommandListener, gameLayerManager: AllBinaryGameLayerManager, highScoresFactoryInterface: HighScoresFactoryInterface, gameInitializationInterfaceFactoryInterface: BasicBuildGameInitializerFactory, buffered: bool) =
        { inherit AllBinaryGameCanvas(cmdListener, gameLayerManager, highScoresFactoryInterface, gameInitializationInterfaceFactoryInterface, buffered) }
    
    member this.CombatGameCanvas_init() : unit =
        DestroyEventCircularStaticPool.getInstance().init(this)
        ProgressCanvasFactory.getInstance().addNormalPortion(50, "Destroy Events")
    
    override this.initApp(abeClientInformation: AbeClientInformationInterface) : unit =
        this.CombatGameCanvas_init()
        base.initApp(abeClientInformation)
    
    abstract initConfigurablePortion : portion: int -> unit
    default this.initConfigurablePortion(portion: int) : unit =
        DestroyedLayerProcessor.init()
        ProgressCanvasFactory.getInstance().addNormalPortion(portion, "Basic Processors")
        let mutable features : Features = Features.getInstance()
        let mutable gameFeatureFactory : GameFeatureFactory = GameFeatureFactory.getInstance()
        if features.isFeature(gameFeatureFactory.DROPPED_ITEMS) && features.isFeature(gameFeatureFactory.DROPPED_ITEMS_FROM_DEATH) then
            CombatGameCanvas.basicLayerProcessor <- (Array.zeroCreate<BasicLayerProcessor> (2))
            CombatGameCanvas.basicLayerProcessor.[0] <- DestroyedLayerProcessor.getInstance()
            CombatGameCanvas.basicLayerProcessor.[1] <- DropLayerProcessor.getInstance()
        else
            CombatGameCanvas.basicLayerProcessor <- (Array.zeroCreate<BasicLayerProcessor> (1))
            CombatGameCanvas.basicLayerProcessor.[0] <- DestroyedLayerProcessor.getInstance()
    
    override this.processPlayingGame() : unit =
        base.processPlayingGame()
        let mutable index : int = CombatGameCanvas.basicLayerProcessor.Length
        while ((index <- index - 1; index)) >= 0 do
            CombatGameCanvas.basicLayerProcessor.[index].process_(this.gameLayerManager)
    
    override this.cleanupGame() : unit =
        base.cleanupGame()
        let mutable index : int = CombatGameCanvas.basicLayerProcessor.Length
        while ((index <- index - 1; index)) >= 0 do
            CombatGameCanvas.basicLayerProcessor.[index].getList().clear()
        GroupLayerManagerListener.getInstance().clear()
        GroupLayerManagerListener.getInstance().log()
        DestroyedEventHandler.getInstance().removeAllListeners()
        this.cleanupManager()
    
    abstract cleanupManager : unit -> unit
    default this.cleanupManager() : unit =
        this.gameLayerManager.cleanup()


