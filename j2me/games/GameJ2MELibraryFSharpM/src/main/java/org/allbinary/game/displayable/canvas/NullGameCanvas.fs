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
type NullGameCanvas =
    inherit AllBinaryGameCanvas
    [<DefaultValue(false)>] val mutable runningNull : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (NullGameCanvas.jclinit(); NullGameCanvas.jcell_instance) and set (jvalue: obj) = (NullGameCanvas.jclinit(); NullGameCanvas.jcell_instance <- jvalue)
    static member NO_GAME : string = "No Background Game"
    static member TYPE : int = 1
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullGameCanvas.jclinitDone then
            NullGameCanvas.jclinitDone <- true
            NullGameCanvas.jclinitBody()
    static member private jclinitBody() : unit =
        NullGameCanvas.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_NullGameCanvas() : unit =
        this.runningNull <- true
        ()
    
    static member createNull() : NullGameCanvas =
        let mutable jflow = 0
        let mutable jret : NullGameCanvas = Unchecked.defaultof<NullGameCanvas>
        try
            jret <- (new NullGameCanvas(AllBinaryGameLayerManager.getNullInstance()))
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                LogUtil.getInstance().put(CommonStrings.getInstance().EXCEPTION, "NullGameCanvas", CommonStrings.getInstance().GET_INSTANCE, e)
                raise ((new JRuntimeException()))
            | _ -> reraise ()
        jret
    
    static member getInstance() : NullGameCanvas =
        if (JR.same(NullGameCanvas.instance, NullUtil.getInstance().NULL_OBJECT)) then
            NullGameCanvas.instance <- NullGameCanvas.createNull()
        (box (NullGameCanvas.instance) :?> NullGameCanvas)
    
    static member createCanvas(gameLayerManager: AllBinaryGameLayerManager) : NullGameCanvas =
        let mutable nullGameCanvas : NullGameCanvas = (new NullGameCanvas(gameLayerManager))
        nullGameCanvas.setInitialized(true)
        nullGameCanvas.setTitle(NullGameCanvas.NO_GAME)
        nullGameCanvas
    
    new (gameLayerManager: AllBinaryGameLayerManager) as this =
        { inherit AllBinaryGameCanvas(NullCommandListener.NULL_COMMAND_LISTENER, gameLayerManager, NoHighScoresFactory.getInstance(), BasicBuildGameInitializerFactory.NULL_BASE_BUILD_GMAE_INITIALIZER_FACTORY, false) }
        then
            this.jfields_NullGameCanvas()
            this.jctor1(gameLayerManager)
    member this.jctor1(gameLayerManager: AllBinaryGameLayerManager) : unit =
        ()
        base.setWait(1200)
        ()
    
    override this.isGameOver() : bool =
        false
    
    override this.setRunning(running: bool) : unit =
        this.runningNull <- running
    
    override this.isRunning() : bool =
        this.runningNull
    
    override this.pause() : unit =
        this.setPaused(true)
    
    override this.unPause() : unit =
        this.setPaused(false)
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        this.removeAllCommands()
        this.setCommandListener(cmdListener)
    
    override this.buildGameInit(isProgress: bool) : unit =
        ()
    
    override this.draw(graphics: Graphics) : unit =
        ()
    
    override this.run() : unit =
        try
            this.logUtil.putF(this.commonStrings.START_RUNNABLE, this, this.commonStrings.RUN)
            this.logUtil.putF(this.commonStrings.END_RUNNABLE, this, this.commonStrings.RUN)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.RUN, e)
            | _ -> reraise ()
    
    override this.getType() : int =
        NullGameCanvas.TYPE


