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
type GameConfigurationUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable GAUGE_UPDATE : string
    [<DefaultValue(false)>] val mutable FROM : string
    [<DefaultValue(false)>] val mutable TO : string
    [<DefaultValue(false)>] val mutable COMPETITION_VALUE : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameConfigurationUtil
    static member instance with get() : GameConfigurationUtil = (GameConfigurationUtil.jclinit(); GameConfigurationUtil.jcell_instance) and set (jvalue: GameConfigurationUtil) = (GameConfigurationUtil.jclinit(); GameConfigurationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameConfigurationUtil.jclinitDone then
            GameConfigurationUtil.jclinitDone <- true
            GameConfigurationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        GameConfigurationUtil.jcell_instance <- (new GameConfigurationUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameConfigurationUtil()
    member this.jfields_GameConfigurationUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.GAUGE_UPDATE <- "Gauge Update: "
        this.FROM <- " from: "
        this.TO <- " to: "
        this.COMPETITION_VALUE <- 1
        ()
    
    static member getInstance() : GameConfigurationUtil =
        GameConfigurationUtil.instance
    
    abstract change : gameOptionsForm: GameOptionsForm * gauge: GameConfigurationGauge -> unit
    default this.change(gameOptionsForm: GameOptionsForm, gauge: GameConfigurationGauge) : unit =
        this.update(gauge)
        let mutable gameConfigurationSingleton : GameConfigurationSingleton = GameConfigurationSingleton.getInstance()
        let mutable gameConfiguration : GameConfiguration = gameConfigurationSingleton.getInstanceByName(gauge.getLabel())
        this.updateChallange(gameOptionsForm, gameConfiguration)
    
    abstract update : gauge: GameConfigurationGauge -> unit
    default this.update(gauge: GameConfigurationGauge) : unit =
        let mutable gameConfigurationSingleton : GameConfigurationSingleton = GameConfigurationSingleton.getInstance()
        let mutable gameConfiguration : GameConfiguration = gameConfigurationSingleton.getInstanceByName(gauge.getLabel())
        let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
        let mutable value : Integer = smallIntegerSingletonFactory.getAt((gauge.getValue() + gameConfiguration.getMinValue().intValue()))
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(this.GAUGE_UPDATE))
        ignore (stringBuffer.append(gameConfiguration.getName()))
        ignore (stringBuffer.append(this.FROM))
        ignore (stringBuffer.appendint(gameConfiguration.getValue().intValue()))
        ignore (stringBuffer.append(this.TO))
        ignore (stringBuffer.appendint(value.intValue()))
        this.logUtil.putF(stringBuffer.ToString(), this, this.commonStrings.UPDATE)
        gameConfiguration.setValue(value)
    
    abstract setDefault : gauge: GameConfigurationGauge -> unit
    default this.setDefault(gauge: GameConfigurationGauge) : unit =
        let mutable gameConfigurationSingleton : GameConfigurationSingleton = GameConfigurationSingleton.getInstance()
        let mutable gameConfiguration : GameConfiguration = gameConfigurationSingleton.getInstanceByName(gauge.getLabel())
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Gauge Default: "))
        ignore (stringBuffer.append(gameConfiguration.getName()))
        ignore (stringBuffer.append(this.TO))
        ignore (stringBuffer.appendint(gameConfiguration.getDefaultValue().intValue()))
        this.logUtil.putF(stringBuffer.ToString(), this, "setDefault")
        gauge.setValue((gameConfiguration.getDefaultValue().intValue() - gameConfiguration.getMinValue().intValue()))
        gameConfiguration.setValue(gameConfiguration.getDefaultValue())
    
    abstract updateChallange : gameOptionsForm: GameOptionsForm * gameConfiguration: GameConfiguration -> unit
    default this.updateChallange(gameOptionsForm: GameOptionsForm, gameConfiguration: GameConfiguration) : unit =
        let mutable gameConfigurationSingleton : GameConfigurationSingleton = GameConfigurationSingleton.getInstance()
        let mutable gameConfigurationCentral : GameConfigurationCentral = GameConfigurationCentral.getInstance()
        if (JR.same(gameConfiguration, gameConfigurationCentral.CHALLENGE_LEVEL)) then
            this.logUtil.putF(this.commonStrings.START, this, "updateChallange")
            gameConfigurationCentral.COLLIDE_DAMAGE.setValue(gameConfiguration.getValue())
            gameConfigurationCentral.ATTACK_CHALLENGE_LEVEL.setValue(gameConfiguration.getValue())
            gameConfigurationCentral.DURABILITY_CHALLENGE_LEVEL.setValue(gameConfiguration.getValue())
            gameConfigurationCentral.SPEED_CHALLENGE_LEVEL.setValue(gameConfiguration.getValue())
            let mutable size : int = gameOptionsForm.size()
            let mutable index : int = 0
            while index < size do
                let mutable item : LcduiItem = gameOptionsForm.get(index)
                if (box (item) :? GameConfigurationGauge) then
                    let mutable gauge : GameConfigurationGauge = (box (item) :?> GameConfigurationGauge)
                    let mutable name : string = item.getLabel()
                    let mutable nextGameConfiguration : GameConfiguration = gameConfigurationSingleton.getInstanceByName(name)
                    if (JR.same(nextGameConfiguration, gameConfigurationCentral.COLLIDE_DAMAGE)) then
                        gauge.setValue((gameConfigurationCentral.COLLIDE_DAMAGE.getValue().intValue() - gameConfiguration.getMinValue().intValue()))
                    elif (JR.same(nextGameConfiguration, gameConfigurationCentral.DURABILITY_CHALLENGE_LEVEL)) then
                        gauge.setValue((gameConfigurationCentral.DURABILITY_CHALLENGE_LEVEL.getValue().intValue() - gameConfiguration.getMinValue().intValue()))
                    elif (JR.same(nextGameConfiguration, gameConfigurationCentral.ATTACK_CHALLENGE_LEVEL)) then
                        gauge.setValue((gameConfigurationCentral.ATTACK_CHALLENGE_LEVEL.getValue().intValue() - gameConfiguration.getMinValue().intValue()))
                    elif (JR.same(nextGameConfiguration, gameConfigurationCentral.SPEED_CHALLENGE_LEVEL)) then
                        gauge.setValue((gameConfigurationCentral.SPEED_CHALLENGE_LEVEL.getValue().intValue() - gameConfiguration.getMinValue().intValue()))
                index <- index + 1
    
    abstract updateCompetitionValue : unit -> unit
    default this.updateCompetitionValue() : unit =
        this.logUtil.putF(this.commonStrings.START, this, "updateCompetitionValue")
        let mutable gameConfigurationCentral : GameConfigurationCentral = GameConfigurationCentral.getInstance()
        this.COMPETITION_VALUE <- ((gameConfigurationCentral.COLLIDE_DAMAGE.getValue().intValue() + gameConfigurationCentral.ATTACK_CHALLENGE_LEVEL.getValue().intValue()) + gameConfigurationCentral.DURABILITY_CHALLENGE_LEVEL.getValue().intValue()) + gameConfigurationCentral.SPEED_CHALLENGE_LEVEL.getValue().intValue()
        this.COMPETITION_VALUE <- (this.COMPETITION_VALUE >>> 2)
    
    abstract getCompetitionValue : unit -> int
    default this.getCompetitionValue() : int =
        this.COMPETITION_VALUE


