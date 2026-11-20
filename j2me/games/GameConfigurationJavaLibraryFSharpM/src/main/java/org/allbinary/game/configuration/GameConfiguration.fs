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
type GameConfiguration =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable defaultValue : Integer
    [<DefaultValue(false)>] val mutable value : Integer
    [<DefaultValue(false)>] val mutable minValue : Integer
    [<DefaultValue(false)>] val mutable maxValue : Integer
    [<DefaultValue(false)>] val mutable modifiable : Boolean
    [<DefaultValue(false)>] static val mutable private jcell_MIN_VALUE : Integer
    static member MIN_VALUE with get() : Integer = (GameConfiguration.jclinit(); GameConfiguration.jcell_MIN_VALUE) and set (jvalue: Integer) = (GameConfiguration.jclinit(); GameConfiguration.jcell_MIN_VALUE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameConfiguration.jclinitDone then
            GameConfiguration.jclinitDone <- true
            GameConfiguration.jclinitBody()
    static member private jclinitBody() : unit =
        GameConfiguration.jcell_MIN_VALUE <- (new Integer(Integer.MIN_VALUE))
        ()
    member this.jfields_GameConfiguration() : unit =
        this.name <- StringUtil.getInstance().EMPTY_STRING
        this.defaultValue <- SmallIntegerSingletonFactory.getInstance().getAt(0)
        this.value <- GameConfiguration.MIN_VALUE
        this.minValue <- this.defaultValue
        this.maxValue <- this.defaultValue
        this.modifiable <- BooleanFactory.getInstance().TRUE
        ()
    
    new (name: string, defaultValue: Integer, minValue: Integer, maxValue: Integer) as this =
        {  }
        then
            this.jfields_GameConfiguration()
            this.jctor1(name, defaultValue, minValue, maxValue)
    member this.jctor1(name: string, defaultValue: Integer, minValue: Integer, maxValue: Integer) : unit =
        this.setName(name)
        this.setDefaultValue(defaultValue)
        this.value <- this.getDefaultValue()
        this.setMinValue(minValue)
        this.setMaxValue(maxValue)
        ignore (GameConfigurationSingleton.getInstance().getHashtable().put(this.getName(), this))
        ()
    
    abstract setValue : value: Integer -> unit
    default this.setValue(value: Integer) : unit =
        if not (JR.same(this.value, value)) then
            let mutable oldValue : Integer = this.value
            this.value <- value
            GameFeatureEventHandler.getInstance().fireEvent((new GameFeatureEvent(this, (new StringMaker()).append(this.name).append(" value: from: ").appendint(oldValue.intValue()).append(" to ").appendint(this.value.intValue()).ToString())))
    
    abstract getValue : unit -> Integer
    default this.getValue() : Integer =
        this.value
    
    abstract setMaxValue : maxValue: Integer -> unit
    default this.setMaxValue(maxValue: Integer) : unit =
        this.maxValue <- maxValue
    
    abstract getMaxValue : unit -> Integer
    default this.getMaxValue() : Integer =
        this.maxValue
    
    abstract setMinValue : minValue: Integer -> unit
    default this.setMinValue(minValue: Integer) : unit =
        this.minValue <- minValue
    
    abstract getMinValue : unit -> Integer
    default this.getMinValue() : Integer =
        this.minValue
    
    abstract setName : name: string -> unit
    default this.setName(name: string) : unit =
        this.name <- name
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract setDefaultValue : defaultValue: Integer -> unit
    default this.setDefaultValue(defaultValue: Integer) : unit =
        this.defaultValue <- defaultValue
    
    abstract getDefaultValue : unit -> Integer
    default this.getDefaultValue() : Integer =
        this.defaultValue
    
    abstract setDefault : unit -> unit
    default this.setDefault() : unit =
        this.setValue(this.getDefaultValue())
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Name: "))
        ignore (stringBuffer.append(this.name))
        ignore (stringBuffer.append(" Min: "))
        ignore (stringBuffer.appendint(this.getMinValue().intValue()))
        ignore (stringBuffer.append(" Max: "))
        ignore (stringBuffer.appendint(this.getMaxValue().intValue()))
        ignore (stringBuffer.append(" Value: "))
        ignore (stringBuffer.appendint(this.getValue().intValue()))
        ignore (stringBuffer.append(" Default: "))
        ignore (stringBuffer.appendint(this.getDefaultValue().intValue()))
        ignore (stringBuffer.append(" Modifiable: "))
        ignore (stringBuffer.appendboolean(this.isModifiable().booleanValue()))
        stringBuffer.ToString()
    
    abstract setModifiable : modifiable: Boolean -> unit
    default this.setModifiable(modifiable: Boolean) : unit =
        this.modifiable <- modifiable
    
    abstract isModifiable : unit -> Boolean
    default this.isModifiable() : Boolean =
        this.modifiable


