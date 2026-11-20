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
type GameFeatureUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable enumerationUtil : EnumerationUtil
    [<DefaultValue(false)>] val mutable ON_GAME_FEATURE_CHANGE : string
    [<DefaultValue(false)>] val mutable GAME_FEATURE_CHANGED : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameFeatureUtil
    static member instance with get() : GameFeatureUtil = (GameFeatureUtil.jclinit(); GameFeatureUtil.jcell_instance) and set (jvalue: GameFeatureUtil) = (GameFeatureUtil.jclinit(); GameFeatureUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameFeatureUtil.jclinitDone then
            GameFeatureUtil.jclinitDone <- true
            GameFeatureUtil.jclinitBody()
    static member private jclinitBody() : unit =
        GameFeatureUtil.jcell_instance <- (new GameFeatureUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameFeatureUtil()
    member this.jfields_GameFeatureUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.tsUtil <- TsUtil.getInstance()
        this.enumerationUtil <- EnumerationUtil.getInstance()
        this.ON_GAME_FEATURE_CHANGE <- "onGameFeatureChange"
        this.GAME_FEATURE_CHANGED <- "Game Feature Changed: "
        ()
    
    static member getInstance() : GameFeatureUtil =
        GameFeatureUtil.instance
    
    abstract setDefault : choiceGroup: ChoiceGroup -> unit
    default this.setDefault(choiceGroup: ChoiceGroup) : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable METHOD_NAME : string = "setDefault"
        let mutable SELECTED_ARRAY_RETURN : string = "selectedArray_return["
        let mutable SELECTED_SEP : string = "] = "
        let mutable selectedArray_return : bool[] = (Array.zeroCreate<bool> (choiceGroup.size()))
        let mutable total : int = choiceGroup.getSelectedFlags(selectedArray_return)
        ignore (stringBuffer.append("Multiple Total Choices: "))
        ignore (stringBuffer.appendint(total))
        this.logUtil.putF(stringBuffer.ToString(), this, METHOD_NAME)
        let mutable features : Features = Features.getInstance()
        let mutable index : int = 0
        while index < selectedArray_return.Length do
            let mutable isSelected : bool = selectedArray_return.[index]
            ignore (stringBuffer.delete(0, stringBuffer.length()))
            ignore (stringBuffer.append(SELECTED_ARRAY_RETURN))
            ignore (stringBuffer.appendint(index))
            ignore (stringBuffer.append(SELECTED_SEP))
            ignore (stringBuffer.appendboolean(isSelected))
            this.logUtil.putF(stringBuffer.ToString(), this, METHOD_NAME)
            let mutable selectedChoiceLabel : string = choiceGroup.getString(index)
            let mutable gameFeature : Feature = Feature.getInstance(selectedChoiceLabel)
            if features.isDefault(gameFeature) then
                ignore (features.add(gameFeature))
                choiceGroup.setSelectedIndex(index, true)
            else
                ignore (features.remove(gameFeature))
                choiceGroup.setSelectedIndex(index, false)
            index <- index + 1
    
    abstract updateMultiple : choiceGroup: ChoiceGroup -> unit
    default this.updateMultiple(choiceGroup: ChoiceGroup) : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable METHOD_NAME : string = "updateMultiple"
        let mutable SELECTED_ARRAY_RETURN : string = "selectedArray_return["
        let mutable SELECTED_SEP : string = "] = "
        let mutable selectedArray_return : bool[] = (Array.zeroCreate<bool> (choiceGroup.size()))
        let mutable total : int = choiceGroup.getSelectedFlags(selectedArray_return)
        ignore (stringBuffer.append("Multiple Total Choices: "))
        ignore (stringBuffer.appendint(total))
        this.logUtil.putF(stringBuffer.ToString(), this, METHOD_NAME)
        let mutable features : Features = Features.getInstance()
        let mutable index : int = 0
        while index < selectedArray_return.Length do
            let mutable isSelected : bool = selectedArray_return.[index]
            ignore (stringBuffer.delete(0, stringBuffer.length()))
            ignore (stringBuffer.append(SELECTED_ARRAY_RETURN))
            ignore (stringBuffer.appendint(index))
            ignore (stringBuffer.append(SELECTED_SEP))
            ignore (stringBuffer.appendboolean(isSelected))
            this.logUtil.putF(stringBuffer.ToString(), this, METHOD_NAME)
            let mutable selectedChoiceLabel : string = choiceGroup.getString(index)
            let mutable gameFeature : Feature = Feature.getInstance(selectedChoiceLabel)
            if (not (isSelected)) && features.isFeature(gameFeature) then
                ignore (features.remove(gameFeature))
            elif isSelected && (not (features.isFeature(gameFeature))) then
                ignore (features.add(gameFeature))
            index <- index + 1
    
    abstract updateExclusiveForChoiceGroup : choiceGroup: ChoiceGroup -> unit
    default this.updateExclusiveForChoiceGroup(choiceGroup: ChoiceGroup) : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable METHOD_NAME : string = "updateExclusive"
        let mutable SELECTED_ARRAY_RETURN : string = "selectedArray_return["
        let mutable SELECTED_SEP : string = "] = "
        let mutable selectedArray_return : bool[] = (Array.zeroCreate<bool> (choiceGroup.size()))
        let mutable total : int = choiceGroup.getSelectedFlags(selectedArray_return)
        ignore (stringBuffer.append("Exclusive Total Choices: 1=="))
        ignore (stringBuffer.appendint(total))
        this.logUtil.putF(stringBuffer.ToString(), this, METHOD_NAME)
        let mutable index : int = 0
        while index < selectedArray_return.Length do
            let mutable isSelected : bool = selectedArray_return.[index]
            ignore (stringBuffer.delete(0, stringBuffer.length()))
            ignore (stringBuffer.append(SELECTED_ARRAY_RETURN))
            ignore (stringBuffer.appendint(index))
            ignore (stringBuffer.append(SELECTED_SEP))
            ignore (stringBuffer.appendboolean(isSelected))
            this.logUtil.putF(stringBuffer.ToString(), this, METHOD_NAME)
            if isSelected then
                let mutable selectedChoiceLabel : string = choiceGroup.getString(index)
                this.updateExclusive(selectedChoiceLabel)
            index <- index + 1
    
    abstract isExclusive : itemLabel: string -> bool
    default this.isExclusive(itemLabel: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable enumeration : Enumeration = GameFeatureChoiceGroups.getExclusiveInstance().get().keys()
        let mutable name : string = null
        while jflow = 0 && (this.enumerationUtil.hasMoreElements(enumeration)) do
            name <- (box (this.enumerationUtil.nextElement(enumeration)) :?> string)
            if this.tsUtil.compareTo(itemLabel, name) = 0 then
                jret <- true
                jflow <- 1
            if jflow = 200004 then jflow <- 0
        if jflow = 100004 then jflow <- 0
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    member this.updateExclusive(selectedChoiceLabel: string) : unit =
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().ITEM_LABEL).append(selectedChoiceLabel).ToString(), this, "updateExclusive")
        let mutable gameFeature : Feature = Feature.getInstance(selectedChoiceLabel)
        let mutable hashtable : ABHashtable = GameFeatureChoiceGroups.getExclusiveInstance().get()
        let mutable objectArray : obj[] = HashtableUtil.getInstance().getKeysAsArray(hashtable)
        let mutable basicArrayList : BasicArrayList = null
        let mutable anyType : obj = null
        let mutable size : int = objectArray.Length
        let mutable index : int = 0
        while index < size do
            anyType <- (box (objectArray.[index]))
            basicArrayList <- (box (hashtable.get(anyType)) :?> BasicArrayList)
            this.updateExclusiveList(gameFeature, basicArrayList)
            index <- index + 1
    
    abstract updateExclusiveList : gameFeature: Feature * list_: BasicArrayList -> unit
    default this.updateExclusiveList(gameFeature: Feature, list_: BasicArrayList) : unit =
        if list_.contains(gameFeature) then
            let mutable features : Features = Features.getInstance()
            let mutable addIndex : int = list_.indexOf(gameFeature)
            let mutable size : int = list_.size()
            let mutable index : int = 0
            while index < size do
                if addIndex <> index then
                    ignore (features.remove((box (list_.objectArray.[index]) :?> Feature)))
                else
                    ignore (features.add((box (list_.objectArray.[index]) :?> Feature)))
                index <- index + 1


