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
type HighScoreNamePersistanceSingleton =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable platformRecordIdUtil : PlatformRecordIdUtil
    [<DefaultValue(false)>] val mutable RECORD_ID : string
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable nameBasicArrayList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : HighScoreNamePersistanceSingleton
    static member SINGLETON with get() : HighScoreNamePersistanceSingleton = (HighScoreNamePersistanceSingleton.jclinit(); HighScoreNamePersistanceSingleton.jcell_SINGLETON) and set (jvalue: HighScoreNamePersistanceSingleton) = (HighScoreNamePersistanceSingleton.jclinit(); HighScoreNamePersistanceSingleton.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScoreNamePersistanceSingleton.jclinitDone then
            HighScoreNamePersistanceSingleton.jclinitDone <- true
            HighScoreNamePersistanceSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        HighScoreNamePersistanceSingleton.jcell_SINGLETON <- (new HighScoreNamePersistanceSingleton())
        ()
    new () as this =
        {  }
        then
            this.jfields_HighScoreNamePersistanceSingleton()
    member this.jfields_HighScoreNamePersistanceSingleton() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.tsUtil <- TsUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.platformRecordIdUtil <- PlatformRecordIdUtil.getInstance()
        this.RECORD_ID <- "_SN"
        this.name <- StringUtil.getInstance().EMPTY_STRING
        this.nameBasicArrayList <- (new BasicArrayListD())
        ()
    
    static member getInstance() : HighScoreNamePersistanceSingleton =
        HighScoreNamePersistanceSingleton.SINGLETON
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.name <- StringUtil.getInstance().EMPTY_STRING
    
    abstract deleteAll : abeClientInformation: AbeClientInformationInterface * gameInfo: GameInfo -> unit
    default this.deleteAll(abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo) : unit =
        let mutable size : int = this.nameBasicArrayList.size()
        let mutable index : int = 0
        while index < size do
            let mutable integer : Integer = (box (this.nameBasicArrayList.objectArray.[index]) :?> Integer)
            this.delete(abeClientInformation, gameInfo, integer.intValue())
            index <- index + 1
        this.clear()
    
    member this.getRecordId(abeClientInformation: AbeClientInformationInterface) : string =
        this.platformRecordIdUtil.getRecordId(abeClientInformation, this.RECORD_ID)
    
    abstract delete : abeClientInformation: AbeClientInformationInterface * gameInfo: GameInfo * deleteId: int -> unit
    default this.delete(abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo, deleteId: int) : unit =
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                this.logUtil.putF((new StringMaker()).append("Deleting: ").appendint(deleteId).ToString(), this, this.commonStrings.delete)
                recordStore <- RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
                recordStore.deleteRecord(deleteId)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    raise (e)
                | _ -> reraise ()
        finally
            if not (JR.same(recordStore, null)) then
                PreLogUtil.put("Closing RecordStore", this, this.commonStrings.delete)
                recordStore.closeRecordStore()
    
    abstract getIds : unit -> BasicArrayList
    default this.getIds() : BasicArrayList =
        this.nameBasicArrayList
    
    abstract load : abeClientInformation: AbeClientInformationInterface * gameInfo: GameInfo -> string
    default this.load(abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo) : string =
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                if (JR.sameString(this.name, StringUtil.getInstance().EMPTY_STRING)) then
                    let mutable LOADING_ID : string = "Loading id: "
                    recordStore <- RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
                    let mutable recordEnum : RecordEnumeration = recordStore.enumerateRecords(NullRecordFilter.NULL_RECORD_FILTER, NullRecordComparator.NULL_RECORD_COMPARATOR, true)
                    let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
                    let mutable recordAsBytes : sbyte[] = null
                    let mutable byteArrayInputStream : ByteArrayInputStream = null
                    let mutable inputStream : DataInputStream = null
                    while recordEnum.hasNextElement() do
                        let mutable id_ : int = recordEnum.nextRecordId()
                        this.logUtil.putF((new StringMaker()).append(LOADING_ID).appendint(id_).ToString(), this, this.commonStrings.LOAD)
                        recordAsBytes <- this.tsUtil.getRecord(recordStore, id_)
                        byteArrayInputStream <- (new ByteArrayInputStream(recordAsBytes))
                        inputStream <- (new DataInputStream(byteArrayInputStream))
                        while inputStream.available() > 0 do
                            this.name <- inputStream.readUTF()
                        ignore (this.nameBasicArrayList.add(smallIntegerSingletonFactory.getAt(id_)))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.save(abeClientInformation, gameInfo, this.name)
                    this.logUtil.putF((new StringMaker()).append(this.commonStrings.EXCEPTION_LABEL).append(ExceptionUtil.getInstance().getStackTrace(e)).ToString(), this, this.commonStrings.LOAD)
                | _ -> reraise ()
        finally
            try
                if not (JR.same(recordStore, null)) then
                    PreLogUtil.put("Closing RecordStore", this, this.commonStrings.LOAD)
                    recordStore.closeRecordStore()
            with jex ->
                match JR.throwable(jex) with
                | :? RecordStoreException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.LOAD, e)
                | _ -> reraise ()
        this.name
    
    abstract save : abeClientInformation: AbeClientInformationInterface * gameInfo: GameInfo * name: string -> unit
    default this.save(abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo, name: string) : unit =
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                this.logUtil.putF((new StringMaker()).append("Saving: ").append(name).ToString(), this, this.commonStrings.SAVE)
                recordStore <- RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
                let mutable byteArrayOutputStream : ByteArrayOutputStream = (new ByteArrayOutputStream())
                let mutable outputStream : DataOutputStream = (new DataOutputStream(byteArrayOutputStream))
                ignore (outputStream.writeUTF(name))
                let mutable savedGameBytes : sbyte[] = byteArrayOutputStream.toByteArray()
                ignore (recordStore.addRecord(savedGameBytes, 0, savedGameBytes.Length))
                this.name <- name
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.SAVE, e)
                | _ -> reraise ()
        finally
            try
                if not (JR.same(recordStore, null)) then
                    PreLogUtil.put("Closing RecordStore", this, this.commonStrings.SAVE)
                    recordStore.closeRecordStore()
            with jex ->
                match JR.throwable(jex) with
                | :? RecordStoreException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.SAVE, e)
                | _ -> reraise ()


