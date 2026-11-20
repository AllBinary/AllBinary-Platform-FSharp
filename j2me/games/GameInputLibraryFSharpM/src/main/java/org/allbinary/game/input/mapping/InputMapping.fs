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
type InputMapping =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] val mutable mappedList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputMapping.jclinitDone then
            InputMapping.jclinitDone <- true
            InputMapping.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_InputMapping() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.hashtable <- StdUtil.getInstance().createHashtable()
        this.mappedList <- (new BasicArrayListD())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_InputMapping()
    
    abstract getTotalMapped : unit -> int
    default this.getTotalMapped() : int =
        this.hashtable.size()
    
    abstract isDefaultNew : unit -> bool
    default this.isDefaultNew() : bool =
        false
    
    abstract getDefault : unit -> InputToGameKeyMapping
    default this.getDefault() : InputToGameKeyMapping =
        InputToGameKeyMapping.getNullInstance()
    
    abstract removeAll : unit -> unit
    default this.removeAll() : unit =
        this.hashtable.clear()
        this.mappedList.clear()
    
    abstract remove : input: Input * mappedToInput: Input -> unit
    default this.remove(input: Input, mappedToInput: Input) : unit =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable stringUtil : StringUtil = StringUtil.getInstance()
        ignore (stringBuffer.append(CommonLabels.getInstance().START_LABEL))
        ignore (stringBuffer.append(stringUtil.toString(input)))
        ignore (stringBuffer.append(" == "))
        ignore (stringBuffer.append(stringUtil.toString(mappedToInput)))
        this.logUtil.putF(stringBuffer.ToString(), this, "InputMapping::remove")
        let mutable list_ : BasicArrayList = this.getMappedInput(input)
        if list_.contains(mappedToInput) then
            ignore (list_.remove(mappedToInput))
            ignore (this.mappedList.remove(mappedToInput))
            ignore (stringBuffer.delete(0, stringBuffer.length()))
            ignore (stringBuffer.append("Removed: "))
            ignore (stringBuffer.append(stringUtil.toString(input)))
            ignore (stringBuffer.append(" == "))
            ignore (stringBuffer.append(stringUtil.toString(mappedToInput)))
            this.logUtil.putF(stringBuffer.ToString(), this, "InputMapping::remove")
        else
            ignore (stringBuffer.delete(0, stringBuffer.length()))
            ignore (stringBuffer.append("Not Deleted: "))
            ignore (stringBuffer.append(stringUtil.toString(input)))
            ignore (stringBuffer.append(" == "))
            ignore (stringBuffer.append(stringUtil.toString(mappedToInput)))
            this.logUtil.putF(stringBuffer.ToString(), this, "InputMapping::remove")
    
    abstract addMapping : inputToGameKeyMapping: InputToGameKeyMapping -> unit
    default this.addMapping(inputToGameKeyMapping: InputToGameKeyMapping) : unit =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract add : input: Input * mappedToInput: Input -> unit
    default this.add(input: Input, mappedToInput: Input) : unit =
        let mutable list_ : BasicArrayList = this.getMappedInput(input)
        if not (list_.contains(mappedToInput)) then
            ignore (list_.add(mappedToInput))
            ignore (this.mappedList.add(mappedToInput))
    
    abstract isMapped : input: Input -> bool
    default this.isMapped(input: Input) : bool =
        this.mappedList.contains(input)
    
    abstract getMappedInput : id_: Input -> BasicArrayList
    default this.getMappedInput(id_: Input) : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        let mutable mappingInputCanBeNullList : obj = this.hashtable.get(id_)
        if (JR.same(mappingInputCanBeNullList, null)) then
            let mutable list_ : BasicArrayList = (new BasicArrayListD())
            ignore (this.hashtable.put(id_, list_))
            jret <- list_
            jflow <- 1
        if jflow = 0 then
            jret <- (box (mappingInputCanBeNullList) :?> BasicArrayList)
            jflow <- 1
        jret
    
    abstract getHashtable : unit -> ABHashtable
    default this.getHashtable() : ABHashtable =
        this.hashtable


