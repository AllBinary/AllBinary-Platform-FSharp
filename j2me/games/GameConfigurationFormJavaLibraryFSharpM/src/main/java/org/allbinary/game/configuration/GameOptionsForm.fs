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
type GameOptionsForm =
    inherit CommandForm
    [<DefaultValue(false)>] val mutable meUtil : MIDPUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameOptionsForm.jclinitDone then
            GameOptionsForm.jclinitDone <- true
            GameOptionsForm.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameOptionsForm() : unit =
        this.meUtil <- MIDPUtil.getInstance()
        ()
    
    new (commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit CommandForm(commandListener, title, backgrounBasicColor, foregroundBasicColor) }
        then
            this.jfields_GameOptionsForm()
            this.jctor1(commandListener, title, backgrounBasicColor, foregroundBasicColor)
    member this.jctor1(commandListener: CommandListener, title: string, backgrounBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        this.addConfiguration()
        let mutable gameFeatureFormUtil : GameFeatureFormUtil = GameFeatureFormUtil.getInstance()
        gameFeatureFormUtil.addChoiceGroup(this, GameFeatureChoiceGroups.getExclusiveInstance().get(), Choice.EXCLUSIVE)
        gameFeatureFormUtil.addChoiceGroup(this, GameFeatureChoiceGroups.getMultipleInstance().get(), Choice.MULTIPLE)
        this.initCommands(commandListener)
        this.setItemStateListener((new GameFeatureItemStateListener(this)))
        this.addTextFieldsIfSimulated()
        ()
    
    abstract closeClientInformation : abeClientInformation: AbeClientInformationInterface -> unit
    default this.closeClientInformation(abeClientInformation: AbeClientInformationInterface) : unit =
        base.close()
        this.save(abeClientInformation)
    
    member this.addTextFieldsIfSimulated() : unit =
        let mutable key : string = OrientationData.getInstance().ORIENTATION_SENSOR_INPUT
        let mutable hashtable : ABHashtable = GameFeatureChoiceGroups.getExclusiveInstance().get()
        if not (JR.same(hashtable, null)) then
            let mutable listCanBeNull : obj = hashtable.get(key)
            if not (JR.same(listCanBeNull, null)) then
                let mutable list_ : BasicArrayList = (box (listCanBeNull) :?> BasicArrayList)
                if list_.contains(SensorFeatureFactory.getInstance().SIMULATED_ORIENTATION_SENSORS) then
                    this.addTextFields()
    
    member this.addTextFields() : unit =
        let mutable hashtable : ABHashtable = GameConfigurationTextInput.getHashtable()
        let mutable size : int = hashtable.size()
        let mutable objectArray : obj[] = HashtableUtil.getInstance().getKeysAsArray(hashtable)
        let mutable gameConfigurationTextInput : GameConfigurationTextInput = null
        let mutable textField : TextField = null
        let mutable index : int = 0
        while index < size do
            gameConfigurationTextInput <- (box (hashtable.get((box (objectArray.[index])))) :?> GameConfigurationTextInput)
            textField <- (new TextField(gameConfigurationTextInput.getLabel(), gameConfigurationTextInput.getText(), 30, TextField.ANY))
            ignore (this.meUtil.appendItem(this, textField))
            index <- index + 1
    
    member this.addConfiguration() : unit =
        let mutable METHOD_NAME : string = "addConfiguration"
        let mutable NAME : string = "Name: "
        let mutable list_ : BasicArrayList = GameConfigurationSingleton.getInstance().getOptionsBasicArrayList()
        let mutable GAUGE_CHANGE : Command = MyCommandsFactory.getInstance().GAUGE_CHANGE
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable size : int = list_.size()
        let mutable gameConfiguration : GameConfiguration = null
        let mutable gauge : GameConfigurationGauge = null
        let mutable index : int = 0
        while index < size do
            gameConfiguration <- (box (list_.objectArray.[index]) :?> GameConfiguration)
            ignore (stringMaker.delete(0, stringMaker.length()))
            this.logUtil.putF(stringMaker.append(NAME).append(gameConfiguration.ToString()).ToString(), this, METHOD_NAME)
            gauge <- (new GameConfigurationGauge(gameConfiguration))
            gauge.setDefaultCommand(GAUGE_CHANGE)
            gauge.setItemCommandListener((new GameFeatureItemCommandListener(this)))
            ignore (this.meUtil.appendItem(this, gauge))
            index <- index + 1
    
    override this.initCommands(cmdListener: CommandListener) : unit =
        let mutable gameCommandsFactory : GameCommandsFactory = GameCommandsFactory.getInstance()
        this.removeAllCommands()
        this.addCommand(gameCommandsFactory.CLOSE_OPTIONS)
        this.addCommand(gameCommandsFactory.DEFAULT_OPTIONS)
        this.setCommandListener(cmdListener)
    
    abstract save : abeClientInformation: AbeClientInformationInterface -> unit
    default this.save(abeClientInformation: AbeClientInformationInterface) : unit =
        let mutable size : int = this.size()
        let mutable item : LcduiItem = null
        let mutable index : int = 0
        while index < size do
            item <- this.get(index)
            if (box (item) :? GameConfigurationGauge) then
                GameConfigurationUtil.getInstance().update((box (item) :?> GameConfigurationGauge))
            elif (box (item) :? TextField) then
                GameConfigurationTextInput.update((box (item) :?> TextField))
            index <- index + 1
        GameConfigurationUtil.getInstance().updateCompetitionValue()
        let mutable hashtable : ABHashtable = StdUtil.getInstance().createHashtable()
        let mutable SCALE : GameConfiguration = GameConfigurationCentral.getInstance().SCALE
        ignore (hashtable.put(SCALE.getName(), Integer.toString(SCALE.getValue().intValue())))
        let mutable keyValuePersistance : KeyValuePersistance = GameConfigurationPersistanceSingleton.getInstance()
        keyValuePersistance.clear()
        keyValuePersistance.loadAll(abeClientInformation)
        let mutable list_ : BasicArrayList = keyValuePersistance.getIds()
        keyValuePersistance.save(abeClientInformation, hashtable)
        let mutable size2 : int = list_.size()
        let mutable integer : Integer = null
        let mutable index : int = 0
        while index < size2 do
            integer <- (box (list_.objectArray.[index]) :?> Integer)
            ignore (keyValuePersistance.delete(abeClientInformation, integer.intValue()))
            index <- index + 1


