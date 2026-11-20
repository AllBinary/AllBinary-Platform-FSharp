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
type GameFeatureFormUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable meUtil : MIDPUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameFeatureFormUtil
    static member instance with get() : GameFeatureFormUtil = (GameFeatureFormUtil.jclinit(); GameFeatureFormUtil.jcell_instance) and set (jvalue: GameFeatureFormUtil) = (GameFeatureFormUtil.jclinit(); GameFeatureFormUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameFeatureFormUtil.jclinitDone then
            GameFeatureFormUtil.jclinitDone <- true
            GameFeatureFormUtil.jclinitBody()
    static member private jclinitBody() : unit =
        GameFeatureFormUtil.jcell_instance <- (new GameFeatureFormUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameFeatureFormUtil()
    member this.jfields_GameFeatureFormUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.meUtil <- MIDPUtil.getInstance()
        ()
    
    static member getInstance() : GameFeatureFormUtil =
        GameFeatureFormUtil.instance
    
    abstract getChoiceGroup : hashtable: ABHashtable * name: string * option_: int -> ChoiceGroup
    default this.getChoiceGroup(hashtable: ABHashtable, name: string, option_: int) : ChoiceGroup =
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable choiceGroup : ChoiceGroup = (new ChoiceGroup(name, option_, StringUtil.getInstance().getArrayInstance(), NullImage.NULL_IMAGE_ARRAY))
        let mutable list_ : BasicArrayList = (box (hashtable.get((box (name)))) :?> BasicArrayList)
        let mutable features : Features = Features.getInstance()
        let mutable ADD_CHOICE : string = ": Adding Choice: "
        let mutable GET_CHOICE_GROUP : string = "getChoiceGroup"
        let mutable size : int = list_.size()
        let mutable index : int = 0
        while index < size do
            let mutable gameFeature : Feature = (box (list_.objectArray.[index]) :?> Feature)
            ignore (stringMaker.delete(0, stringMaker.length()))
            this.logUtil.putF(stringMaker.append(name).append(ADD_CHOICE).append(gameFeature.ToString()).ToString(), this, GET_CHOICE_GROUP)
            ignore (choiceGroup.append(gameFeature.ToString(), NullImage.NULL_IMAGE))
            if features.isFeature(gameFeature) then
                choiceGroup.setSelectedIndex(index, true)
            index <- index + 1
        choiceGroup
    
    abstract addChoiceGroup : form: CommandForm * hashtable: ABHashtable * option_: int -> unit
    default this.addChoiceGroup(form: CommandForm, hashtable: ABHashtable, option_: int) : unit =
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable ADDING_CHOICE_GROUP : string = "Adding Choice Group: "
        let mutable ADD_CHOICE_GROUP : string = "addChoiceGroup"
        let mutable size : int = hashtable.size()
        let mutable objectArray : obj[] = HashtableUtil.getInstance().getKeysAsArray(hashtable)
        let mutable name : string = null
        let mutable index : int = 0
        while index < size do
            name <- (box (objectArray.[index]) :?> string)
            ignore (stringMaker.delete(0, stringMaker.length()))
            this.logUtil.putF(stringMaker.append(ADDING_CHOICE_GROUP).append(name).ToString(), this, ADD_CHOICE_GROUP)
            ignore (this.meUtil.appendItem(form, this.getChoiceGroup(hashtable, name, option_)))
            index <- index + 1
    
    abstract setDefault : form: CommandForm -> unit
    default this.setDefault(form: CommandForm) : unit =
        let mutable size : int = form.size()
        let mutable index : int = 0
        while index < size do
            let mutable item : LcduiItem = form.get(index)
            if (box (item) :? GameConfigurationGauge) then
                GameConfigurationUtil.getInstance().setDefault((box (item) :?> GameConfigurationGauge))
            elif (box (item) :? ChoiceGroup) then
                GameFeatureUtil.getInstance().setDefault((box (item) :?> ChoiceGroup))
            index <- index + 1


