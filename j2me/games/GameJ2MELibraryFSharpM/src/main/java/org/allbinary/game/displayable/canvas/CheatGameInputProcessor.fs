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
type CheatGameInputProcessor =
    inherit PlayerGameInput
    [<DefaultValue(false)>] val mutable PROCESS_GAME : string
    [<DefaultValue(false)>] val mutable gameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] val mutable gameKeyFactory : GameKeyFactory
    [<DefaultValue(false)>] static val mutable private jcell_inputProcessor : SpecialGameInputInterface
    static member inputProcessor with get() : SpecialGameInputInterface = (CheatGameInputProcessor.jclinit(); CheatGameInputProcessor.jcell_inputProcessor) and set (jvalue: SpecialGameInputInterface) = (CheatGameInputProcessor.jclinit(); CheatGameInputProcessor.jcell_inputProcessor <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CheatGameInputProcessor.jclinitDone then
            CheatGameInputProcessor.jclinitDone <- true
            CheatGameInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        CheatGameInputProcessor.jcell_inputProcessor <- SpecialGameInputFactory.NO_SPECIAL_GAME_INPUT
        ()
    member this.jfields_CheatGameInputProcessor() : unit =
        this.PROCESS_GAME <- "processGame"
        this.gameKeyFactory <- GameKeyFactory.getInstance()
        ()
    
    new (gameCanvas: AllBinaryGameCanvas) as this =
        { inherit PlayerGameInput((new BasicArrayListD()), (new BasicArrayListD()), -1) }
        then
            this.jfields_CheatGameInputProcessor()
            this.jctor1(gameCanvas)
    member this.jctor1(gameCanvas: AllBinaryGameCanvas) : unit =
        ()
        this.gameCanvas <- gameCanvas
        ()
    
    override this.update() : unit =
        let mutable jflow = 0
        try
            let mutable gameLayerManager : AllBinaryGameLayerManager = this.gameCanvas.getLayerManager()
            let mutable list_ : BasicArrayList = this.getGameKeyEventList()
            let mutable size : int = list_.size()
            let mutable index : int = 0
            while jflow = 0 && (index < size) do
                let mutable anyType : obj = list_.objectArray.[index]
                let mutable key : int = GameKeyEventUtil.getKey(anyType)
                if key = this.gameKeyFactory.LEVEL_DOWN.getId() then
                    CheatGameInputProcessor.inputProcessor.strafeLeft()
                    jflow <- 100001
                elif key = this.gameKeyFactory.LEVEL_UP.getId() then
                    CheatGameInputProcessor.inputProcessor.strafeRight()
                    jflow <- 100001
                if jflow = 0 then
                    if key = this.gameKeyFactory.LEFT.getId() then
                        CheatGameInputProcessor.inputProcessor.left()
                        jflow <- 100001
                    elif key = this.gameKeyFactory.RIGHT.getId() then
                        CheatGameInputProcessor.inputProcessor.right()
                        jflow <- 100001
                    elif key = this.gameKeyFactory.UP.getId() then
                        CheatGameInputProcessor.inputProcessor.up()
                        jflow <- 100001
                    elif key = this.gameKeyFactory.DOWN.getId() then
                        CheatGameInputProcessor.inputProcessor.down()
                        jflow <- 100001
                    elif key = this.gameKeyFactory.KEY_NUM1.getId() then
                        CheatGameInputProcessor.inputProcessor.special1(gameLayerManager, GameKeyEvent.NONE)
                        jflow <- 100001
                    elif key = this.gameKeyFactory.KEY_NUM3.getId() then
                        CheatGameInputProcessor.inputProcessor.special2(gameLayerManager, GameKeyEvent.NONE)
                        jflow <- 100001
                if jflow = 200001 then jflow <- 0
                if jflow = 0 then index <- index + 1
            if jflow = 100001 then jflow <- 0
            if jflow = 0 then
                list_.clear()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.UPDATE, e)
            | _ -> reraise ()


