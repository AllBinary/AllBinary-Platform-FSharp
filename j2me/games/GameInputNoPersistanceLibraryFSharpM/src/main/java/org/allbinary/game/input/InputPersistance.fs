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
type InputPersistance =
    inherit BasicPersitance
    [<DefaultValue(false)>] val mutable hashtableUtil : HashtableUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputPersistance.jclinitDone then
            InputPersistance.jclinitDone <- true
            InputPersistance.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_InputPersistance() : unit =
        this.hashtableUtil <- HashtableUtil.getInstance()
        ()
    
    new (name: string) as this =
        { inherit BasicPersitance(name) }
        then
            this.jfields_InputPersistance()
    
    abstract loadAll : abeClientInformation: AbeClientInformationInterface -> unit
    default this.loadAll(abeClientInformation: AbeClientInformationInterface) : unit =
        let mutable recordStore : RecordStore = RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
        let mutable recordEnum : RecordEnumeration = recordStore.enumerateRecords(NullRecordFilter.NULL_RECORD_FILTER, NullRecordComparator.NULL_RECORD_COMPARATOR, true)
        let mutable hashtable : ABHashtable = null
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
        let mutable id_ : int = 0
        while recordEnum.hasNextElement() do
            id_ <- recordEnum.nextRecordId()
            ignore (stringBuffer.delete(0, stringBuffer.length()))
            this.logUtil.putF(stringBuffer.append(this.persistanceStrings.LOADING_ID).appendint(id_).ToString(), this, this.persistanceStrings.LOAD_ALL)
            hashtable <- StdUtil.getInstance().createHashtable()
            ignore (this.valueList.add(hashtable))
            ignore (this.idList.add(smallIntegerSingletonFactory.getAt(id_)))
        recordStore.closeRecordStore()
    
    abstract save : abeClientInformation: AbeClientInformationInterface * hashtable: ABHashtable -> unit
    default this.save(abeClientInformation: AbeClientInformationInterface, hashtable: ABHashtable) : unit =
        PreLogUtil.put((new StringMaker()).append(this.persistanceStrings.NOT_SAVING).append(StringUtil.getInstance().toString(hashtable)).ToString(), this, this.commonStrings.SAVE)
        let mutable recordStore : RecordStore = RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
        let mutable gameActionInput : Input = null
        let mutable list_ : BasicArrayList = null
        let mutable input : Input = null
        let mutable inputObjectArray : obj[] = this.hashtableUtil.getKeysAsArray(hashtable)
        let mutable size : int = inputObjectArray.Length
        let mutable index : int = 0
        while index < size do
            gameActionInput <- (box (inputObjectArray.[index]) :?> Input)
            list_ <- (box (hashtable.get(inputObjectArray.[index])) :?> BasicArrayList)
            let mutable index2 : int = 0
            while index2 < list_.size() do
                input <- (box (list_.get(index2)) :?> Input)
                index2 <- index2 + 1
            index <- index + 1
        recordStore.closeRecordStore()


