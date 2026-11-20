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
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable hashtableUtil : HashtableUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputPersistance.jclinitDone then
            InputPersistance.jclinitDone <- true
            InputPersistance.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_InputPersistance() : unit =
        this.tsUtil <- TsUtil.getInstance()
        this.hashtableUtil <- HashtableUtil.getInstance()
        ()
    
    new (name: string) as this =
        { inherit BasicPersitance(name) }
        then
            this.jfields_InputPersistance()
    
    abstract loadAll : abeClientInformation: AbeClientInformationInterface -> unit
    default this.loadAll(abeClientInformation: AbeClientInformationInterface) : unit =
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                recordStore <- RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
                let mutable recordEnum : RecordEnumeration = recordStore.enumerateRecords(NullRecordFilter.NULL_RECORD_FILTER, NullRecordComparator.NULL_RECORD_COMPARATOR, true)
                let mutable gameActionInputId : int64 = 0L
                let mutable inputId : int64 = 0L
                let mutable gameActionInput : Input = null
                let mutable input : Input = null
                let mutable hashtable : ABHashtable = null
                let mutable gameKeyFactory : GameKeyMappingFactory = GameKeyMappingFactory.getInstance()
                let mutable stringBuffer : StringMaker = (new StringMaker())
                let mutable inputFactory : InputFactory = InputFactory.getInstance()
                let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
                let mutable stdUtil : StdUtil = StdUtil.getInstance()
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
                        hashtable <- stdUtil.createHashtable()
                        let mutable value : int = 0
                        while inputStream.available() > 0 do
                            let mutable gameActionInputIdAsString : string = inputStream.readUTF()
                            value <- Integer.parseInt(gameActionInputIdAsString)
                            gameActionInputId <- int64 (value)
                            ignore (inputStream.readUTF())
                            value <- Integer.parseInt(inputStream.readUTF())
                            inputId <- int64 (value)
                            gameActionInput <- gameKeyFactory.getGameKey(int (gameActionInputId))
                            input <- inputFactory.getInstanceById(int (inputId))
                            if ((JR.same(input, inputFactory.NO_INPUT))) || ((JR.same(gameActionInput, null))) then
                                ignore (stringBuffer.delete(0, stringBuffer.length()))
                                if (JR.same(input, inputFactory.NO_INPUT)) then
                                    ignore (stringBuffer.append(this.persistanceStrings.ERROR_LOADING_ID))
                                    ignore (stringBuffer.appendlong(inputId))
                                    ignore (stringBuffer.append(this.persistanceStrings.GAME_ACTION_INPUT))
                                    ignore (stringBuffer.appendlong(gameActionInputId))
                                    PreLogUtil.put(stringBuffer.ToString(), this, this.persistanceStrings.LOAD_ALL)
                                if (JR.same(gameActionInput, null)) then
                                    ignore (stringBuffer.delete(0, stringBuffer.length()))
                                    ignore (stringBuffer.append(this.persistanceStrings.ERROR_LOADING))
                                    ignore (stringBuffer.appendlong(gameActionInputId))
                                    ignore (stringBuffer.append(this.persistanceStrings.ID))
                                    ignore (stringBuffer.appendlong(inputId))
                                    PreLogUtil.put(stringBuffer.ToString(), this, this.persistanceStrings.LOAD_ALL)
                            else
                                ()
                            ignore (hashtable.put(input, gameActionInput))
                        ignore (this.valueList.add(hashtable))
                        ignore (this.idList.add(smallIntegerSingletonFactory.getAt(id_)))
                    else
                        ()
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
                let mutable stringBuffer : StringMaker = (new StringMaker())
                PreLogUtil.put(stringBuffer.append(this.persistanceStrings.SAVING).append(StringUtil.getInstance().toString(hashtable)).ToString(), this, this.commonStrings.SAVE)
                recordStore <- RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
                let mutable byteArrayOutputStream : ByteArrayOutputStream = (new ByteArrayOutputStream())
                let mutable outputStream : DataOutputStream = (new DataOutputStream(byteArrayOutputStream))
                let mutable gameActionInput : Input = null
                let mutable list_ : BasicArrayList = null
                let mutable input : Input = null
                let mutable savedGameBytes : sbyte[] = null
                let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
                let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
                let mutable inputObjectArray : obj[] = this.hashtableUtil.getKeysAsArray(hashtable)
                let mutable size : int = inputObjectArray.Length
                let mutable index : int = 0
                while index < size do
                    gameActionInput <- (box (inputObjectArray.[index]) :?> Input)
                    list_ <- (box (hashtable.get((box (inputObjectArray.[index])))) :?> BasicArrayList)
                    let mutable index2 : int = 0
                    while index2 < list_.size() do
                        let mutable gameActionInputIdAsString : string = smallIntegerSingletonFactory.getAt(gameActionInput.getId()).ToString()
                        ignore (outputStream.writeUTF(gameActionInputIdAsString))
                        ignore (outputStream.writeUTF(commonSeps.EQUALS))
                        input <- (box (list_.objectArray.[index2]) :?> Input)
                        let mutable inputIdAsString : string = smallIntegerSingletonFactory.getAt(input.getId()).ToString()
                        ignore (outputStream.writeUTF(inputIdAsString))
                        index2 <- index2 + 1
                    index <- index + 1
                savedGameBytes <- byteArrayOutputStream.toByteArray()
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


