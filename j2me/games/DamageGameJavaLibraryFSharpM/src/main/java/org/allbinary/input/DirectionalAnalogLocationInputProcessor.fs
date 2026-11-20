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
type DirectionalAnalogLocationInputProcessor =
    inherit AnalogLocationInputProcessor
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable inputProcessorArray : GameInputProcessor[]
    [<DefaultValue(false)>] val mutable gameKeyFactory : GameKeyFactory
    [<DefaultValue(false)>] val mutable leftGameKeyEvent : GameKeyEvent
    [<DefaultValue(false)>] val mutable rightGameKeyEvent : GameKeyEvent
    [<DefaultValue(false)>] val mutable upGameKeyEvent : GameKeyEvent
    [<DefaultValue(false)>] val mutable downGameKeyEvent : GameKeyEvent
    [<DefaultValue(false)>] val mutable leftTriggerGameKeyEvent : GameKeyEvent
    [<DefaultValue(false)>] val mutable rightTriggerGameKeyEvent : GameKeyEvent
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DirectionalAnalogLocationInputProcessor.jclinitDone then
            DirectionalAnalogLocationInputProcessor.jclinitDone <- true
            DirectionalAnalogLocationInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DirectionalAnalogLocationInputProcessor() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.gameKeyFactory <- GameKeyFactory.getInstance()
        this.leftGameKeyEvent <- GameKeyEvent.NONE
        this.rightGameKeyEvent <- GameKeyEvent.NONE
        this.upGameKeyEvent <- GameKeyEvent.NONE
        this.downGameKeyEvent <- GameKeyEvent.NONE
        this.leftTriggerGameKeyEvent <- GameKeyEvent.NONE
        this.rightTriggerGameKeyEvent <- GameKeyEvent.NONE
        ()
    
    new (inputProcessorArray: GameInputProcessor[]) as this =
        { inherit AnalogLocationInputProcessor() }
        then
            this.jfields_DirectionalAnalogLocationInputProcessor()
            this.jctor1(inputProcessorArray)
    member this.jctor1(inputProcessorArray: GameInputProcessor[]) : unit =
        this.inputProcessorArray <- inputProcessorArray
        try
            this.leftGameKeyEvent <- GameKeyEventFactory.getInstance().getInstanceForInput(this, this.gameKeyFactory.LEFT)
            this.rightGameKeyEvent <- GameKeyEventFactory.getInstance().getInstanceForInput(this, this.gameKeyFactory.RIGHT)
            this.upGameKeyEvent <- GameKeyEventFactory.getInstance().getInstanceForInput(this, this.gameKeyFactory.UP)
            this.downGameKeyEvent <- GameKeyEventFactory.getInstance().getInstanceForInput(this, this.gameKeyFactory.DOWN)
            this.leftTriggerGameKeyEvent <- GameKeyEventFactory.getInstance().getInstanceForInput(this, this.gameKeyFactory.KEY_NUM0)
            this.rightTriggerGameKeyEvent <- GameKeyEventFactory.getInstance().getInstanceForInput(this, this.gameKeyFactory.KEY_NUM5)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        ()
    
    override this.process_(allbinaryLayerManager: AllBinaryLayerManager, analogLocationInput: AnalogLocationInput) : unit =
        try
            let mutable customGPoint : CustomGPoint = null
            customGPoint <- analogLocationInput.getCustomGPoint()
            let mutable x : int = customGPoint.getX()
            let mutable y : int = customGPoint.getY()
            let mutable leftTrigger : int = analogLocationInput.getLeftTrigger()
            let mutable rightTrigger : int = analogLocationInput.getRightTrigger()
            if x < 0 then
                this.inputProcessorArray.[this.leftGameKeyEvent.getKey()].processAnalog(allbinaryLayerManager, this.leftGameKeyEvent, x)
            elif x > 0 then
                this.inputProcessorArray.[this.rightGameKeyEvent.getKey()].processAnalog(allbinaryLayerManager, this.rightGameKeyEvent, x)
            if y < 0 then
                this.inputProcessorArray.[this.downGameKeyEvent.getKey()].processAnalog(allbinaryLayerManager, this.downGameKeyEvent, y)
            elif y > 0 then
                this.inputProcessorArray.[this.upGameKeyEvent.getKey()].processAnalog(allbinaryLayerManager, this.upGameKeyEvent, y)
            if leftTrigger > 0 then
                this.inputProcessorArray.[this.leftTriggerGameKeyEvent.getKey()].processAnalog(allbinaryLayerManager, this.leftTriggerGameKeyEvent, leftTrigger)
            if rightTrigger > 0 then
                this.inputProcessorArray.[this.rightTriggerGameKeyEvent.getKey()].processAnalog(allbinaryLayerManager, this.rightTriggerGameKeyEvent, rightTrigger)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put("Unable to process analog input", this, commonStrings.PROCESS, e)
            | _ -> reraise ()
    
    abstract getSourceId : unit -> int
    default this.getSourceId() : int =
        0
    interface GameKeyEventSourceInterface with
        member this.getSourceId() : int = this.getSourceId()


