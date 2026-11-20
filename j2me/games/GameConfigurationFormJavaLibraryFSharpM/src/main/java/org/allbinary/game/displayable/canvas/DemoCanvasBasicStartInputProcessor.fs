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
type DemoCanvasBasicStartInputProcessor =
    inherit BasicMenuInputProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DemoCanvasBasicStartInputProcessor.jclinitDone then
            DemoCanvasBasicStartInputProcessor.jclinitDone <- true
            DemoCanvasBasicStartInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (gameKeyEventList: BasicArrayList, gameCanvas: RunnableCanvas) =
        { inherit BasicMenuInputProcessor(gameKeyEventList, -1, gameCanvas) }
    
    override this.processInputList() : int =
        let mutable list_ : BasicArrayList = this.getGameKeyEventList()
        let mutable size : int = list_.size()
        let mutable gameKeyEvent : GameKeyEvent = null
        let mutable index : int = 0
        while index < size do
            gameKeyEvent <- (box (list_.objectArray.[index]) :?> GameKeyEvent)
            this.logUtil.putF((new StringMaker()).append("Start GameKey: ").append(StringUtil.getInstance().toString(gameKeyEvent)).ToString(), this, GameInputStrings.getInstance().PROCESS_INPUT)
            index <- index + 1
        this.getCanvas().getCustomCommandListener().commandAction(GameCommandsFactory.getInstance().START_COMMAND, NullCanvas.NULL_CANVAS)
        size


