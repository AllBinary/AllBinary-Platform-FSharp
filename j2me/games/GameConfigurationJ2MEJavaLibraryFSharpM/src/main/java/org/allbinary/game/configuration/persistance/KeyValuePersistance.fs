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
type KeyValuePersistance =
    inherit BasicPersitance
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KeyValuePersistance.jclinitDone then
            KeyValuePersistance.jclinitDone <- true
            KeyValuePersistance.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_KeyValuePersistance() : unit =
        this.tsUtil <- TsUtil.getInstance()
        ()
    
    new (recordId: string) as this =
        { inherit BasicPersitance(recordId) }
        then
            this.jfields_KeyValuePersistance()
    
    abstract loadAll : abeClientInformation: AbeClientInformationInterface -> unit
    default this.loadAll(abeClientInformation: AbeClientInformationInterface) : unit =
        this.loadAllSize(abeClientInformation, 1)
    
    abstract loadAllSize : abeClientInformation: AbeClientInformationInterface * size: int -> unit
    default this.loadAllSize(abeClientInformation: AbeClientInformationInterface, size: int) : unit =
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                recordStore <- RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
                let mutable recordEnum : RecordEnumeration = recordStore.enumerateRecords(NullRecordFilter.NULL_RECORD_FILTER, NullRecordComparator.NULL_RECORD_COMPARATOR, true)
                let mutable hashtable : ABHashtable = null
                let mutable name : string = null
                let mutable value : string = null
                let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
                let mutable stringBuffer : StringMaker = (new StringMaker())
                let mutable recordAsBytes : sbyte[] = null
                let mutable byteArrayInputStream : ByteArrayInputStream = null
                let mutable inputStream : DataInputStream = null
                while recordEnum.hasNextElement() do
                    let mutable id_ : int = recordEnum.nextRecordId()
                    ignore (stringBuffer.delete(0, stringBuffer.length()))
                    this.logUtil.putF(stringBuffer.append(this.persistanceStrings.LOADING_ID).appendint(id_).ToString(), this, this.persistanceStrings.LOAD_ALL)
                    recordAsBytes <- this.tsUtil.getRecord(recordStore, id_)
                    if not (JR.same(recordAsBytes, null)) then
                        byteArrayInputStream <- (new ByteArrayInputStream(recordAsBytes))
                        inputStream <- (new DataInputStream(byteArrayInputStream))
                        hashtable <- (new ABHashtable())
                        let mutable index : int = 0
                        while index < size do
                            name <- inputStream.readUTF()
                            ignore (inputStream.readUTF())
                            value <- inputStream.readUTF()
                            ignore (hashtable.put(name, value))
                            index <- index + 1
                        ignore (this.valueList.add(hashtable))
                        ignore (this.idList.add(smallIntegerSingletonFactory.getAt(id_)))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    raise (e)
                | _ -> reraise ()
        finally
            if not (JR.same(recordStore, null)) then
                PreLogUtil.put(this.persistanceStrings.CLOSING_RECORDSTORE, this, this.persistanceStrings.LOAD_ALL)
                recordStore.closeRecordStore()
    
    abstract save : abeClientInformation: AbeClientInformationInterface * hashtable: ABHashtable -> unit
    default this.save(abeClientInformation: AbeClientInformationInterface, hashtable: ABHashtable) : unit =
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                this.logUtil.putF((new StringMaker()).append(this.persistanceStrings.SAVING).append(StringUtil.getInstance().toString(hashtable)).ToString(), this, this.commonStrings.SAVE)
                recordStore <- RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
                let mutable byteArrayOutputStream : ByteArrayOutputStream = (new ByteArrayOutputStream())
                let mutable outputStream : DataOutputStream = (new DataOutputStream(byteArrayOutputStream))
                let mutable value : string = null
                let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
                let mutable objectArray : obj[] = HashtableUtil.getInstance().getKeysAsArray(hashtable)
                let mutable anyType : obj = null
                let mutable size : int = objectArray.Length
                let mutable index : int = 0
                while index < size do
                    ignore (outputStream.writeUTF((box (objectArray.[index]) :?> string)))
                    ignore (outputStream.writeUTF(commonSeps.EQUALS))
                    anyType <- (box (objectArray.[index]))
                    value <- (box (hashtable.get(anyType)) :?> string)
                    ignore (outputStream.writeUTF(value))
                    index <- index + 1
                let mutable tsUtil : TsUtil = TsUtil.getInstance()
                let mutable savedGameBytes : sbyte[] = tsUtil.getByteArray(byteArrayOutputStream.ToString())
                ignore (recordStore.addRecord(savedGameBytes, 0, savedGameBytes.Length))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    raise (e)
                | _ -> reraise ()
        finally
            if not (JR.same(recordStore, null)) then
                PreLogUtil.put(this.persistanceStrings.CLOSING_RECORDSTORE, this, this.commonStrings.SAVE)
                recordStore.closeRecordStore()
    
    abstract get : index: int -> ABHashtable
    default this.get(index: int) : ABHashtable =
        let mutable hashtable : ABHashtable = (box (this.valueList.objectArray.[index]) :?> ABHashtable)
        hashtable


