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
type TestingInputSingleton =
    inherit AllBinaryGameLayer
    [<DefaultValue(false)>] val mutable inputProcessorArray : GameInputProcessor[]
    [<DefaultValue(false)>] val mutable testInputPaintable : PaintableInterface
    [<DefaultValue(false)>] static val mutable private jcell_instance : TestingInputSingleton
    static member instance with get() : TestingInputSingleton = (TestingInputSingleton.jclinit(); TestingInputSingleton.jcell_instance) and set (jvalue: TestingInputSingleton) = (TestingInputSingleton.jclinit(); TestingInputSingleton.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TestingInputSingleton.jclinitDone then
            TestingInputSingleton.jclinitDone <- true
            TestingInputSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        TestingInputSingleton.jcell_instance <- (new TestingInputSingleton())
        ()
    member this.jfields_TestingInputSingleton() : unit =
        this.inputProcessorArray <- (Array.zeroCreate<GameInputProcessor> (InputFactory.getInstance().MAX))
        this.testInputPaintable <- NullPaintable.getInstance()
        ()
    
    static member getInstance() : TestingInputSingleton =
        TestingInputSingleton.instance
    
    new () as this =
        { inherit AllBinaryGameLayer(StringUtil.getInstance().EMPTY_STRING, RectangleFactory.SINGLETON, ViewPosition.getInstanceD()) }
        then
            this.jfields_TestingInputSingleton()
            this.jctor1()
    member this.jctor1() : unit =
        ()
        GameInputProcessorUtil.init(this.inputProcessorArray)
        ()
    
    abstract initInputProcessors : unit -> unit
    default this.initInputProcessors() : unit =
        ()
    
    abstract initInputProcessorsForTestInput : aTestInputInterface: TestInputInterface -> unit
    default this.initInputProcessorsForTestInput(aTestInputInterface: TestInputInterface) : unit =
        let mutable testInputInterface : TestInputInterface = aTestInputInterface
        this.testInputPaintable <- testInputInterface
        this.inputProcessorArray.[Canvas.UP] <- (new TestingInputSingleton_jAnon1(this, testInputInterface))
        this.inputProcessorArray.[Canvas.DOWN] <- (new TestingInputSingleton_jAnon2(this, testInputInterface))
        this.inputProcessorArray.[Canvas.LEFT] <- (new TestingInputSingleton_jAnon3(this, testInputInterface))
        this.inputProcessorArray.[Canvas.RIGHT] <- (new TestingInputSingleton_jAnon4(this, testInputInterface))
        this.inputProcessorArray.[Canvas.KEY_NUM7] <- (new TestingInputSingleton_jAnon5(this, testInputInterface))
        this.inputProcessorArray.[Canvas.KEY_NUM9] <- (new TestingInputSingleton_jAnon6(this, testInputInterface))
        GameInputProcessorUtil.init(this.inputProcessorArray)
    
    abstract processInputList : allbinaryLayerManager: AllBinaryLayerManager * list_: BasicArrayList -> unit
    default this.processInputList(allbinaryLayerManager: AllBinaryLayerManager, list_: BasicArrayList) : unit =
        let mutable key : int = 0
        let mutable gameKeyEvent : GameKeyEvent = null
        let mutable size : int = list_.size()
        let mutable index : int = 0
        while index < size do
            gameKeyEvent <- ((box (list_.objectArray.[index]) :?> GameKeyEvent))
            key <- gameKeyEvent.getKey()
            this.inputProcessorArray.[key].processEvent(allbinaryLayerManager, GameKeyEvent.NONE)
            index <- index + 1
    
    override this.processInput(allbinaryLayerManager: AllBinaryLayerManager) : unit =
        this.processInputList(allbinaryLayerManager, this.getGameKeyEventList())
        this.getGameKeyEventList().clear()
    
    override this.paint(graphics: Graphics) : unit =
        this.testInputPaintable.paint(graphics)
    
    override this.implmentsGameInputInterface() : bool =
        true
    interface GameInputInterface with
        member this.processInput(jp0: AllBinaryLayerManager) : unit = this.processInput(jp0)
        member this.initInputProcessors() : unit = this.initInputProcessors()
    interface NamedInterface with
        member this.getName() : string = this.getName()


[<AllowNullLiteral>]
type TestingInputSingleton_jAnon1 =
    inherit GameInputProcessor
    [<DefaultValue(false)>] val mutable jouter : TestingInputSingleton
    [<DefaultValue(false)>] val mutable jc_testInputInterface : TestInputInterface
    new (jouter: TestingInputSingleton, jc_testInputInterface: TestInputInterface) as this =
        { inherit GameInputProcessor() }
        then
            this.jouter <- jouter
            this.jc_testInputInterface <- jc_testInputInterface
            ()
    override this.processEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        this.jc_testInputInterface.up()


[<AllowNullLiteral>]
type TestingInputSingleton_jAnon2 =
    inherit GameInputProcessor
    [<DefaultValue(false)>] val mutable jouter : TestingInputSingleton
    [<DefaultValue(false)>] val mutable jc_testInputInterface : TestInputInterface
    new (jouter: TestingInputSingleton, jc_testInputInterface: TestInputInterface) as this =
        { inherit GameInputProcessor() }
        then
            this.jouter <- jouter
            this.jc_testInputInterface <- jc_testInputInterface
            ()
    override this.processEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        this.jc_testInputInterface.down()


[<AllowNullLiteral>]
type TestingInputSingleton_jAnon3 =
    inherit GameInputProcessor
    [<DefaultValue(false)>] val mutable jouter : TestingInputSingleton
    [<DefaultValue(false)>] val mutable jc_testInputInterface : TestInputInterface
    new (jouter: TestingInputSingleton, jc_testInputInterface: TestInputInterface) as this =
        { inherit GameInputProcessor() }
        then
            this.jouter <- jouter
            this.jc_testInputInterface <- jc_testInputInterface
            ()
    override this.processEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        this.jc_testInputInterface.left()


[<AllowNullLiteral>]
type TestingInputSingleton_jAnon4 =
    inherit GameInputProcessor
    [<DefaultValue(false)>] val mutable jouter : TestingInputSingleton
    [<DefaultValue(false)>] val mutable jc_testInputInterface : TestInputInterface
    new (jouter: TestingInputSingleton, jc_testInputInterface: TestInputInterface) as this =
        { inherit GameInputProcessor() }
        then
            this.jouter <- jouter
            this.jc_testInputInterface <- jc_testInputInterface
            ()
    override this.processEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        this.jc_testInputInterface.right()


[<AllowNullLiteral>]
type TestingInputSingleton_jAnon5 =
    inherit GameInputProcessor
    [<DefaultValue(false)>] val mutable jouter : TestingInputSingleton
    [<DefaultValue(false)>] val mutable jc_testInputInterface : TestInputInterface
    new (jouter: TestingInputSingleton, jc_testInputInterface: TestInputInterface) as this =
        { inherit GameInputProcessor() }
        then
            this.jouter <- jouter
            this.jc_testInputInterface <- jc_testInputInterface
            ()
    override this.processEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        this.jc_testInputInterface.strafeLeft()


[<AllowNullLiteral>]
type TestingInputSingleton_jAnon6 =
    inherit GameInputProcessor
    [<DefaultValue(false)>] val mutable jouter : TestingInputSingleton
    [<DefaultValue(false)>] val mutable jc_testInputInterface : TestInputInterface
    new (jouter: TestingInputSingleton, jc_testInputInterface: TestInputInterface) as this =
        { inherit GameInputProcessor() }
        then
            this.jouter <- jouter
            this.jc_testInputInterface <- jc_testInputInterface
            ()
    override this.processEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        this.jc_testInputInterface.strafeRight()


