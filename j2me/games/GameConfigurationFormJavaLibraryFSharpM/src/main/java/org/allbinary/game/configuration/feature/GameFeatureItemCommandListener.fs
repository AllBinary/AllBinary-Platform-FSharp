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
type GameFeatureItemCommandListener =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable gameOptionsForm : GameOptionsForm
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameFeatureItemCommandListener.jclinitDone then
            GameFeatureItemCommandListener.jclinitDone <- true
            GameFeatureItemCommandListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameFeatureItemCommandListener() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (gameOptionsForm: GameOptionsForm) as this =
        {  }
        then
            this.jfields_GameFeatureItemCommandListener()
            this.jctor1(gameOptionsForm)
    member this.jctor1(gameOptionsForm: GameOptionsForm) : unit =
        this.gameOptionsForm <- gameOptionsForm
        ()
    
    abstract commandAction : command: Command * item: LcduiItem -> unit
    default this.commandAction(command: Command, item: LcduiItem) : unit =
        try
            let mutable itemLabel : string = item.getLabel()
            this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().ITEM_LABEL).append(itemLabel).ToString(), this, MidletStrings.getInstance().COMMAND_ACTION)
            if (box (item) :? GameConfigurationGauge) then
                GameConfigurationUtil.getInstance().change(this.gameOptionsForm, (box (item) :?> GameConfigurationGauge))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, MidletStrings.getInstance().COMMAND_ACTION, e)
            | _ -> reraise ()
    interface ItemCommandListener with
        member this.commandAction(jp0: Command, jp1: LcduiItem) : unit = this.commandAction(jp0, jp1)


