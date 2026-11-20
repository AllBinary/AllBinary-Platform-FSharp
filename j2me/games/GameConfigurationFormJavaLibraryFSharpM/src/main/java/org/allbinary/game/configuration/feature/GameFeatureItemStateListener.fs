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
type GameFeatureItemStateListener =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable gameOptionsForm : GameOptionsForm
    [<DefaultValue(false)>] static val mutable private jcell_toggleList : BasicArrayList
    static member toggleList with get() : BasicArrayList = (GameFeatureItemStateListener.jclinit(); GameFeatureItemStateListener.jcell_toggleList) and set (jvalue: BasicArrayList) = (GameFeatureItemStateListener.jclinit(); GameFeatureItemStateListener.jcell_toggleList <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameFeatureItemStateListener.jclinitDone then
            GameFeatureItemStateListener.jclinitDone <- true
            GameFeatureItemStateListener.jclinitBody()
    static member private jclinitBody() : unit =
        GameFeatureItemStateListener.jcell_toggleList <- (new BasicArrayListD())
        ()
    member this.jfields_GameFeatureItemStateListener() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (gameOptionsForm: GameOptionsForm) as this =
        {  }
        then
            this.jfields_GameFeatureItemStateListener()
            this.jctor1(gameOptionsForm)
    member this.jctor1(gameOptionsForm: GameOptionsForm) : unit =
        this.gameOptionsForm <- gameOptionsForm
        let mutable gameFeatureFactory : GameFeatureFactory = GameFeatureFactory.getInstance()
        ignore (GameFeatureItemStateListener.add(gameFeatureFactory.ARTIFICIAL_INTELLEGENCE_PROCESSOR))
        ignore (GameFeatureItemStateListener.add(gameFeatureFactory.COLLIDABLE_INTERFACE_LAYER_PROCESSOR))
        ignore (GameFeatureItemStateListener.add(gameFeatureFactory.DAMAGE_FLOATERS))
        ignore (GameFeatureItemStateListener.add(gameFeatureFactory.DROPPED_ITEMS))
        ignore (GameFeatureItemStateListener.add(gameFeatureFactory.GAME_INPUT_LAYER_PROCESSOR))
        ignore (GameFeatureItemStateListener.add(gameFeatureFactory.HEALTH_BARS))
        ignore (GameFeatureItemStateListener.add(gameFeatureFactory.SOUND))
        ignore (GameFeatureItemStateListener.add(gameFeatureFactory.TICKABLE_LAYER_PROCESSOR))
        ()
    
    static member add(gameFeature: GameFeature) : unit =
        if not (GameFeatureItemStateListener.toggleList.contains(gameFeature)) then
            ignore (GameFeatureItemStateListener.toggleList.add(gameFeature))
    
    abstract itemStateChanged : item: LcduiItem -> unit
    default this.itemStateChanged(item: LcduiItem) : unit =
        try
            let mutable itemLabel : string = item.getLabel()
            this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().ITEM_LABEL).append(itemLabel).ToString(), this, "itemStateChanged")
            if (box (item) :? GameConfigurationGauge) then
                GameConfigurationUtil.getInstance().change(this.gameOptionsForm, (box (item) :?> GameConfigurationGauge))
            elif (box (item) :? ChoiceGroup) then
                let mutable gameFeatureUtil : GameFeatureUtil = GameFeatureUtil.getInstance()
                if gameFeatureUtil.isExclusive(itemLabel) then
                    gameFeatureUtil.updateExclusiveForChoiceGroup((box (item) :?> ChoiceGroup))
                else
                    gameFeatureUtil.updateMultiple((box (item) :?> ChoiceGroup))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "itemStateChanged", e)
            | _ -> reraise ()
    interface ItemStateListener with
        member this.itemStateChanged(jp0: LcduiItem) : unit = this.itemStateChanged(jp0)


