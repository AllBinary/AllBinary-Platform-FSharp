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
type GameConfigurationCentral =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable SCALE : GameConfiguration
    [<DefaultValue(false)>] val mutable ORIENTATION : GameConfiguration
    [<DefaultValue(false)>] val mutable SENSOR_UPDATE_RATE : GameConfiguration
    [<DefaultValue(false)>] val mutable VIBRATION : GameConfiguration
    [<DefaultValue(false)>] val mutable CHALLENGE_LEVEL : GameConfiguration
    [<DefaultValue(false)>] val mutable COLLIDE_DAMAGE : GameConfiguration
    [<DefaultValue(false)>] val mutable DURABILITY_CHALLENGE_LEVEL : GameConfiguration
    [<DefaultValue(false)>] val mutable SPEED_CHALLENGE_LEVEL : GameConfiguration
    [<DefaultValue(false)>] val mutable ATTACK_CHALLENGE_LEVEL : GameConfiguration
    [<DefaultValue(false)>] val mutable CONTROL_LEVEL : GameConfiguration
    [<DefaultValue(false)>] val mutable PLAYER_INPUT_WAIT : GameConfiguration
    [<DefaultValue(false)>] val mutable SPEED : GameConfiguration
    [<DefaultValue(false)>] val mutable SOUND_VOLUME : GameConfiguration
    [<DefaultValue(false)>] val mutable MAX_GAME_OBJECTS : GameConfiguration
    [<DefaultValue(false)>] val mutable MAX_LAYERS : GameConfiguration
    [<DefaultValue(false)>] val mutable gameControlFidelity : int
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : obj
    static member SINGLETON with get() : obj = (GameConfigurationCentral.jclinit(); GameConfigurationCentral.jcell_SINGLETON) and set (jvalue: obj) = (GameConfigurationCentral.jclinit(); GameConfigurationCentral.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameConfigurationCentral.jclinitDone then
            GameConfigurationCentral.jclinitDone <- true
            GameConfigurationCentral.jclinitBody()
    static member private jclinitBody() : unit =
        GameConfigurationCentral.jcell_SINGLETON <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_GameConfigurationCentral() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.gameControlFidelity <- 36
        ()
    
    static member getInstance() : GameConfigurationCentral =
        if (JR.same(GameConfigurationCentral.SINGLETON, NullUtil.getInstance().NULL_OBJECT)) then
            GameConfigurationCentral.SINGLETON <- (new GameConfigurationCentral())
        (box (GameConfigurationCentral.SINGLETON) :?> GameConfigurationCentral)
    
    new () as this =
        {  }
        then
            this.jfields_GameConfigurationCentral()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
        this.SCALE <- (new GameConfiguration("Scale", smallIntegerSingletonFactory.getAt(2), smallIntegerSingletonFactory.getAt(2), smallIntegerSingletonFactory.getAt(3)))
        this.ORIENTATION <- (new GameConfiguration("Orientation", smallIntegerSingletonFactory.getAt(0), smallIntegerSingletonFactory.getAt(0), smallIntegerSingletonFactory.getAt(8)))
        this.SENSOR_UPDATE_RATE <- (new GameConfiguration("Sensor Update Rate", smallIntegerSingletonFactory.getAt(0), smallIntegerSingletonFactory.getAt(0), smallIntegerSingletonFactory.getAt(3)))
        this.VIBRATION <- (new GameConfiguration("Vibration", smallIntegerSingletonFactory.getAt(0), smallIntegerSingletonFactory.getAt(0), smallIntegerSingletonFactory.getAt(3)))
        this.CHALLENGE_LEVEL <- (new GameConfiguration("Global Challenge Level", smallIntegerSingletonFactory.getAt(3), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(10)))
        this.COLLIDE_DAMAGE <- (new GameConfiguration("Collide Damage Challenge Level", smallIntegerSingletonFactory.getAt(3), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(10)))
        this.DURABILITY_CHALLENGE_LEVEL <- (new GameConfiguration("Enemy Durability Challenge Level", smallIntegerSingletonFactory.getAt(3), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(10)))
        this.SPEED_CHALLENGE_LEVEL <- (new GameConfiguration("Enemy Speed Challenge Level", smallIntegerSingletonFactory.getAt(3), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(10)))
        this.ATTACK_CHALLENGE_LEVEL <- (new GameConfiguration("Enemy Attack Challenge Level", smallIntegerSingletonFactory.getAt(3), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(10)))
        this.CONTROL_LEVEL <- (new GameConfiguration("Control Fidelity", smallIntegerSingletonFactory.getAt(5), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(10)))
        this.PLAYER_INPUT_WAIT <- (new GameConfiguration("Input Wait", smallIntegerSingletonFactory.getAt(5), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(10)))
        this.SPEED <- (new GameConfiguration("Game Speed (Device Specific)", smallIntegerSingletonFactory.getAt(5), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(10)))
        this.SOUND_VOLUME <- (new GameConfiguration("Sound Volume", smallIntegerSingletonFactory.getAt(6), smallIntegerSingletonFactory.getAt(0), smallIntegerSingletonFactory.getAt(10)))
        this.MAX_GAME_OBJECTS <- (new GameConfiguration("Max Game Objects", smallIntegerSingletonFactory.getAt(20), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(50)))
        this.MAX_LAYERS <- (new GameConfiguration("Max Layers", smallIntegerSingletonFactory.getAt(20), smallIntegerSingletonFactory.getAt(1), smallIntegerSingletonFactory.getAt(50)))
        ()
    
    abstract load : abeClientInformation: AbeClientInformationInterface -> unit
    default this.load(abeClientInformation: AbeClientInformationInterface) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        try
            let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
            let mutable keyValuePersistance : KeyValuePersistance = GameConfigurationPersistanceSingleton.getInstance()
            keyValuePersistance.clear()
            keyValuePersistance.loadAll(abeClientInformation)
            let mutable list_ : BasicArrayList = keyValuePersistance.getIds()
            if list_.size() > 0 then
                let mutable hashtable : ABHashtable = keyValuePersistance.get(0)
                let mutable anyType : obj = (box (this.SCALE.getName()))
                let mutable value : string = (box (hashtable.get(anyType)) :?> string)
                this.SCALE.setValue(smallIntegerSingletonFactory.getAt(Integer.valueOf(value).intValue()))
            else
                this.logUtil.putF("No Game Configuration To Load", this, commonStrings.LOAD)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.LOAD, e)
            | _ -> reraise ()
    
    abstract setGameControlFidelity : gameControlFidelity: int -> unit
    default this.setGameControlFidelity(gameControlFidelity: int) : unit =
        this.gameControlFidelity <- gameControlFidelity
    
    abstract getGameControlFidelity : unit -> int
    default this.getGameControlFidelity() : int =
        this.gameControlFidelity
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable commonStrings : CommonSeps = CommonSeps.getInstance()
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.SCALE.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.SCALE.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.ORIENTATION.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.ORIENTATION.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.SENSOR_UPDATE_RATE.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.SENSOR_UPDATE_RATE.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.VIBRATION.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.VIBRATION.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.CHALLENGE_LEVEL.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.CHALLENGE_LEVEL.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.COLLIDE_DAMAGE.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.COLLIDE_DAMAGE.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.DURABILITY_CHALLENGE_LEVEL.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.DURABILITY_CHALLENGE_LEVEL.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.SPEED_CHALLENGE_LEVEL.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.SPEED_CHALLENGE_LEVEL.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.ATTACK_CHALLENGE_LEVEL.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.ATTACK_CHALLENGE_LEVEL.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.CONTROL_LEVEL.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.CONTROL_LEVEL.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.SPEED.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.SPEED.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.MAX_GAME_OBJECTS.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.MAX_GAME_OBJECTS.getValue().intValue()))
        ignore (stringBuffer.append(commonStrings.COMMA_SEP))
        ignore (stringBuffer.append(this.MAX_LAYERS.getName()))
        ignore (stringBuffer.append(commonStrings.EQUALS))
        ignore (stringBuffer.appendint(this.MAX_LAYERS.getValue().intValue()))
        stringBuffer.ToString()


