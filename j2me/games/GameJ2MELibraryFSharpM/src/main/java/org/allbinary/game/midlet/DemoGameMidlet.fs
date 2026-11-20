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
type DemoGameMidlet =
    inherit GameMidlet
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoGameMidlet.jclinitDone then
            DemoGameMidlet.jclinitDone <- true
            DemoGameMidlet.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (clientInformationFactory: ClientInformationFactory) =
        { inherit GameMidlet(clientInformationFactory) }
    
    abstract isContinue : unit -> bool
    default this.isContinue() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable hashtable : ABHashtable = this.getStartStateHashtable()
        if (not (JR.same(hashtable, null))) && (hashtable.size() > 0) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract getHighestLevel : unit -> int
    default this.getHighestLevel() : int =
        1
    
    abstract createDemoGameCanvasRunnableInterface : unit -> GameCanvasRunnableInterface
    default this.createDemoGameCanvasRunnableInterface() : GameCanvasRunnableInterface =
        this.logUtil.putF(this.commonStrings.NOT_IMPLEMENTED, this, this.commonStrings.CREATE)
        NullGameCanvasRunnable.NULL_GAME_CANVAS_RUNNABLE
    
    abstract createGameCanvasRunnable : allBinaryGameLayerManager: AllBinaryGameLayerManager -> GameCanvasRunnableInterface
    default this.createGameCanvasRunnable(allBinaryGameLayerManager: AllBinaryGameLayerManager) : GameCanvasRunnableInterface =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract createGameCanvasRunnableInterface : unit -> GameCanvasRunnableInterface
    default this.createGameCanvasRunnableInterface() : GameCanvasRunnableInterface =
        this.createGameCanvasRunnable(this.createGameLayerManager())
    
    abstract demoSetup : unit -> unit
    default this.demoSetup() : unit =
        ()
    
    abstract postDemoSetup : unit -> unit
    default this.postDemoSetup() : unit =
        ()
    
    override this.setDemo() : unit =
        this.logUtil.putF(this.commonStrings.START, this, "setDemo")
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        progressCanvas.start()
        PrimaryThreadPool.getInstance().runTask((new DemoRunnable(this)))
    
    override this.createGame() : unit =
        let mutable CREATE_GAME : string = "createGame"
        this.logUtil.putF(this.commonStrings.START, this, CREATE_GAME)
        let mutable progressCanvas : ProgressCanvas = ProgressCanvasFactory.getInstance()
        progressCanvas.start()
        let mutable hashtable : ABHashtable = this.getStartStateHashtable()
        this.setStartStateHashtable(StdUtil.getInstance().NULL_TABLE)
        PrimaryThreadPool.getInstance().runTask((new CreateGameRunnable(this, hashtable)))
        this.logUtil.putF(this.commonStrings.END, this, CREATE_GAME)
    
    abstract isReady : unit -> bool
    default this.isReady() : bool =
        true


