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
type PersistentInputMapping =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable enumerationUtil : EnumerationUtil
    [<DefaultValue(false)>] val mutable inputMapping : InputToGameKeyMapping
    [<DefaultValue(false)>] val mutable inputMappingEventListenerInterface : InputMappingEventListenerInterface
    [<DefaultValue(false)>] val mutable inputPersistance : InputPersistance
    [<DefaultValue(false)>] val mutable inputMappingEvent : InputMappingEvent
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (PersistentInputMapping.jclinit(); PersistentInputMapping.jcell_instance) and set (jvalue: obj) = (PersistentInputMapping.jclinit(); PersistentInputMapping.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PersistentInputMapping.jclinitDone then
            PersistentInputMapping.jclinitDone <- true
            PersistentInputMapping.jclinitBody()
    static member private jclinitBody() : unit =
        PersistentInputMapping.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_PersistentInputMapping() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.enumerationUtil <- EnumerationUtil.getInstance()
        this.inputMapping <- (new InputToGameKeyMapping())
        this.inputMappingEventListenerInterface <- NullInputMappingEventListener.NULL_INPUT_MAPPING_EVENT_LISTENER
        this.inputMappingEvent <- (new InputMappingEvent(this))
        ()
    
    static member getNullInstance() : PersistentInputMapping =
        if (JR.same(PersistentInputMapping.instance, NullUtil.getInstance().NULL_OBJECT)) then
            PersistentInputMapping.instance <- (new PersistentInputMapping(GamePersistanceStrings.getInstance().SAVED_INPUT_CONFIGURATION_RECORD_ID))
        (box (PersistentInputMapping.instance) :?> PersistentInputMapping)
    
    new (name: string) as this =
        {  }
        then
            this.jfields_PersistentInputMapping()
            this.jctor1(name)
    member this.jctor1(name: string) : unit =
        this.inputPersistance <- (new InputPersistance(name))
        ()
    
    abstract getTotalMapped : unit -> int
    default this.getTotalMapped() : int =
        this.getInputMapping().getHashtable().size()
    
    abstract isDefaultNew : unit -> bool
    default this.isDefaultNew() : bool =
        false
    
    abstract getDefault : unit -> InputToGameKeyMapping
    default this.getDefault() : InputToGameKeyMapping =
        InputToGameKeyMapping.getNullInstance()
    
    abstract setDefault : abeClientInformation: AbeClientInformationInterface -> unit
    default this.setDefault(abeClientInformation: AbeClientInformationInterface) : unit =
        this.getInputMapping().removeAll()
        this.getInputMapping().addMapping(this.getDefault())
        this.save(abeClientInformation)
    
    abstract update : abeClientInformation: AbeClientInformationInterface -> unit
    default this.update(abeClientInformation: AbeClientInformationInterface) : unit =
        this.inputPersistance.deleteAll(abeClientInformation)
        this.save(abeClientInformation)
    
    abstract save : abeClientInformation: AbeClientInformationInterface -> unit
    default this.save(abeClientInformation: AbeClientInformationInterface) : unit =
        this.inputPersistance.save(abeClientInformation, this.getInputMapping().getHashtable())
        this.inputMappingEvent.setInputToGameKeyMapping(this.getInputMapping())
        if not (JR.same(this.getInputMappingEventListenerInterface(), null)) then
            this.getInputMappingEventListenerInterface().onInputMappingEvent(this.inputMappingEvent)
    
    abstract init : abeClientInformation: AbeClientInformationInterface -> unit
    default this.init(abeClientInformation: AbeClientInformationInterface) : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.INIT)
        try
            this.inputPersistance.loadAll(abeClientInformation)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putOE(this.commonStrings.EXCEPTION, this, this.commonStrings.INIT, e)
                this.inputPersistance.deleteRecoreStore(abeClientInformation)
                this.setDefault(abeClientInformation)
                this.inputPersistance.loadAll(abeClientInformation)
            | _ -> reraise ()
        let mutable list_ : BasicArrayList = this.inputPersistance.getList()
        let mutable totalMappedTo : int = 0
        let mutable size : int = list_.size()
        let mutable hashtable : ABHashtable = null
        let mutable enumeration : Enumeration = null
        let mutable mappedToInput : Input = null
        let mutable gameActionInput : Input = null
        let mutable index : int = 0
        while index < size do
            hashtable <- (box (list_.objectArray.[index]) :?> ABHashtable)
            enumeration <- hashtable.keys()
            while this.enumerationUtil.hasMoreElements(enumeration) do
                mappedToInput <- (box (this.enumerationUtil.nextElement(enumeration)) :?> Input)
                gameActionInput <- (box (hashtable.get(mappedToInput)) :?> Input)
                totalMappedTo <- totalMappedTo + 1
                this.getInputMapping().add(gameActionInput, mappedToInput)
            index <- index + 1
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("End - Total Loaded Keys Mapped: "))
        ignore (stringBuffer.appendint(this.getTotalMapped()))
        ignore (stringBuffer.append(" to: "))
        ignore (stringBuffer.appendint(totalMappedTo))
        this.logUtil.putF(stringBuffer.ToString(), this, this.commonStrings.INIT)
    
    abstract setInputMappingEventListenerInterface : inputMappingEventListenerInterface: InputMappingEventListenerInterface -> unit
    default this.setInputMappingEventListenerInterface(inputMappingEventListenerInterface: InputMappingEventListenerInterface) : unit =
        this.inputMappingEventListenerInterface <- inputMappingEventListenerInterface
    
    member this.getInputMappingEventListenerInterface() : InputMappingEventListenerInterface =
        this.inputMappingEventListenerInterface
    
    abstract getInputMapping : unit -> InputToGameKeyMapping
    default this.getInputMapping() : InputToGameKeyMapping =
        this.inputMapping
    
    abstract isDelete : input: Input -> bool
    default this.isDelete(input: Input) : bool =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract isSystemInput : input: Input -> bool
    default this.isSystemInput(input: Input) : bool =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))


