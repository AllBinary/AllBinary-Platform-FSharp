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
type TouchButtonInput =
    inherit Input
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable gameKeyEventFactory : GameKeyEventFactory
    [<DefaultValue(false)>] val mutable TOUCH_BUTTON_SOURCE_ID : int
    [<DefaultValue(false)>] val mutable gameKeyEvent : GameKeyEvent
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonInput.jclinitDone then
            TouchButtonInput.jclinitDone <- true
            TouchButtonInput.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TouchButtonInput() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.gameKeyEventFactory <- GameKeyEventFactory.getInstance()
        this.TOUCH_BUTTON_SOURCE_ID <- this.gameKeyEventFactory.TOUCH_BUTTON_SOURCE_ID
        this.gameKeyEvent <- GameKeyEvent.NONE
        ()
    
    new (id_: int, name: string) as this =
        { inherit Input(id_, name) }
        then
            this.jfields_TouchButtonInput()
            this.jctor1(id_, name)
    member this.jctor1(id_: int, name: string) : unit =
        ()
        let mutable inputFactory : InputFactory = InputFactory.getInstance()
        inputFactory.add(this.getId(), this)
        ()
    
    member this.update(inputToGameKeyMapping: InputToGameKeyMapping) : unit =
        try
            let mutable gameKey : GameKey = inputToGameKeyMapping.getInstance(this.getId())
            this.gameKeyEvent <- this.gameKeyEventFactory.getInstanceForInput(this, gameKey)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.UPDATE, e)
            | _ -> reraise ()
    
    member this.getSourceId() : int =
        this.TOUCH_BUTTON_SOURCE_ID
    
    member this.getGameKeyEvent() : GameKeyEvent =
        this.gameKeyEvent
    interface GameKeyEventSourceInterface with
        member this.getSourceId() : int = this.getSourceId()


