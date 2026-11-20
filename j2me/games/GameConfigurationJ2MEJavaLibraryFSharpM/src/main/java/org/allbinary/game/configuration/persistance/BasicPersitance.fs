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
type BasicPersitance =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable persistanceStrings : PersistanceStrings
    [<DefaultValue(false)>] val mutable platformRecordIdUtil : PlatformRecordIdUtil
    [<DefaultValue(false)>] val mutable recordId : string
    [<DefaultValue(false)>] val mutable valueList : BasicArrayList
    [<DefaultValue(false)>] val mutable idList : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicPersitance.jclinitDone then
            BasicPersitance.jclinitDone <- true
            BasicPersitance.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicPersitance() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.persistanceStrings <- PersistanceStrings.getInstance()
        this.platformRecordIdUtil <- PlatformRecordIdUtil.getInstance()
        this.valueList <- (new BasicArrayListD())
        this.idList <- (new BasicArrayListD())
        ()
    
    new (recordId: string) as this =
        {  }
        then
            this.jfields_BasicPersitance()
            this.jctor1(recordId)
    member this.jctor1(recordId: string) : unit =
        this.recordId <- recordId
        ()
    
    abstract deleteRecoreStore : abeClientInformation: AbeClientInformationInterface -> unit
    default this.deleteRecoreStore(abeClientInformation: AbeClientInformationInterface) : unit =
        RecordStore.deleteRecordStore(this.getRecordId(abeClientInformation))
    
    abstract deleteAll : abeClientInformation: AbeClientInformationInterface -> unit
    default this.deleteAll(abeClientInformation: AbeClientInformationInterface) : unit =
        let mutable size : int = this.idList.size()
        let mutable index : int = 0
        while index < size do
            let mutable integer : Integer = (box (this.idList.objectArray.[index]) :?> Integer)
            this.delete(abeClientInformation, integer.intValue())
            index <- index + 1
        this.clear()
    
    abstract delete : abeClientInformation: AbeClientInformationInterface * deleteId: int -> unit
    default this.delete(abeClientInformation: AbeClientInformationInterface, deleteId: int) : unit =
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                this.logUtil.putF((new StringMaker()).append(this.persistanceStrings.DELETING_WITH_ID).appendint(deleteId).ToString(), this, this.commonStrings.delete)
                recordStore <- RecordStore.openRecordStore(this.getRecordId(abeClientInformation), true)
                recordStore.deleteRecord(deleteId)
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    raise (e)
                | _ -> reraise ()
        finally
            if not (JR.same(recordStore, null)) then
                PreLogUtil.put(this.persistanceStrings.CLOSING_RECORDSTORE, this, this.commonStrings.delete)
                recordStore.closeRecordStore()
    
    abstract getRecordId : abeClientInformation: AbeClientInformationInterface -> string
    default this.getRecordId(abeClientInformation: AbeClientInformationInterface) : string =
        this.platformRecordIdUtil.getRecordId(abeClientInformation, this.recordId)
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.valueList
    
    abstract getIds : unit -> BasicArrayList
    default this.getIds() : BasicArrayList =
        this.idList
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.valueList.clear()
        this.idList.clear()


