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
type RecordStoreHighScores =
    inherit HighScores
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable platformRecordIdUtil : PlatformRecordIdUtil
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable RECORD_ID : string
    [<DefaultValue(false)>] val mutable MAXHIGHSCORES : int
    [<DefaultValue(false)>] val mutable gameInfo : GameInfo
    [<DefaultValue(false)>] val mutable abeClientInformation : AbeClientInformationInterface
    [<DefaultValue(false)>] val mutable recordComparatorInterface : RecordComparator
    [<DefaultValue(false)>] static val mutable private jcell_hashTable : ABHashtable
    static member hashTable with get() : ABHashtable = (RecordStoreHighScores.jclinit(); RecordStoreHighScores.jcell_hashTable) and set (jvalue: ABHashtable) = (RecordStoreHighScores.jclinit(); RecordStoreHighScores.jcell_hashTable <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RecordStoreHighScores.jclinitDone then
            RecordStoreHighScores.jclinitDone <- true
            RecordStoreHighScores.jclinitBody()
    static member private jclinitBody() : unit =
        RecordStoreHighScores.jcell_hashTable <- StdUtil.getInstance().createHashtable()
        ()
    member this.jfields_RecordStoreHighScores() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.platformRecordIdUtil <- PlatformRecordIdUtil.getInstance()
        this.tsUtil <- TsUtil.getInstance()
        this.RECORD_ID <- "_HS"
        this.MAXHIGHSCORES <- 100
        ()
    
    new (abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo, name: string, heading: string, columnTwoHeading: string, recordComparatorInterface: RecordComparator) as this =
        { inherit HighScores(name, heading, columnTwoHeading) }
        then
            this.jfields_RecordStoreHighScores()
            this.jctor1(abeClientInformation, gameInfo, name, heading, columnTwoHeading, recordComparatorInterface)
    member this.jctor1(abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo, name: string, heading: string, columnTwoHeading: string, recordComparatorInterface: RecordComparator) : unit =
        ()
        this.abeClientInformation <- abeClientInformation
        this.gameInfo <- gameInfo
        this.recordComparatorInterface <- recordComparatorInterface
        this.load()
        ()
    
    static member getInstance(abeClientInformation: AbeClientInformationInterface, gameInfo: GameInfo, highScoreName: string, heading: string, columnTwoHeading: string, recordComparatorInterface: RecordComparator) : HighScores =
        let mutable jflow = 0
        let mutable jret : HighScores = Unchecked.defaultof<HighScores>
        let mutable highScoresCanBeNull : obj = RecordStoreHighScores.hashTable.get((box (highScoreName)))
        if (JR.same(highScoresCanBeNull, null)) then
            let mutable highScores : HighScores = (new RecordStoreHighScores(abeClientInformation, gameInfo, highScoreName, heading, columnTwoHeading, recordComparatorInterface))
            ignore (RecordStoreHighScores.hashTable.put(highScores.getName(), highScores))
            jret <- highScores
            jflow <- 1
        if jflow = 0 then
            jret <- (box (highScoresCanBeNull) :?> HighScores)
            jflow <- 1
        jret
    
    member this.getRecordId(abeClientInformation: AbeClientInformationInterface) : string =
        this.platformRecordIdUtil.getRecordId(abeClientInformation, (new StringMaker()).append(CommonSeps.getInstance().UNDERSCORE).append(this.getName()).append(this.RECORD_ID).ToString())
    
    override this.addHighScore(newHighScore: HighScore) : unit =
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                this.logUtil.putF((new StringMaker()).append("Adding HighScore: ").appendlong(newHighScore.getScore()).ToString(), this, this.commonStrings.ADD)
                if this.isTooManyHighScores() then
                    this.logUtil.putF("Removing Lowest Score", this, this.commonStrings.ADD)
                    this.removeLowestHighScore()
                recordStore <- RecordStore.openRecordStore(this.getRecordId(this.abeClientInformation), true)
                let mutable highScoreBytes : sbyte[] = newHighScore.getAsBytes()
                let mutable recordId : int = recordStore.addRecord(highScoreBytes, 0, highScoreBytes.Length)
                this.load()
            with jex ->
                match JR.throwable(jex) with
                | :? RecordStoreException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.ADD, e)
                | :? JIOException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.ADD, e)
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.ADD, e)
                | _ -> reraise ()
        finally
            try
                if not (JR.same(recordStore, null)) then
                    PreLogUtil.put("Closing RecordStore", this, this.commonStrings.ADD)
                    recordStore.closeRecordStore()
            with jex ->
                match JR.throwable(jex) with
                | :? RecordStoreException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.ADD, e)
                | _ -> reraise ()
    
    member this.removeLowestHighScore() : unit =
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                recordStore <- RecordStore.openRecordStore(this.getRecordId(this.abeClientInformation), true)
                let mutable recordEnum : RecordEnumeration = recordStore.enumerateRecords(NullRecordFilter.NULL_RECORD_FILTER, NullRecordComparator.NULL_RECORD_COMPARATOR, true)
                let mutable scoreComparator : ScoreComparator = ((box (this.recordComparatorInterface) :?> ScoreComparator))
                let mutable bestHighScore : HighScore = (new HighScore(-1, "none", GameInfo.NONE, scoreComparator.getBestScore()))
                let mutable recordAsBytes : sbyte[] = null
                let mutable byteArrayInputStream : ByteArrayInputStream = null
                let mutable inputStream : DataInputStream = null
                while recordEnum.hasNextElement() do
                    let mutable id_ : int = recordEnum.nextRecordId()
                    recordAsBytes <- this.tsUtil.getRecord(recordStore, id_)
                    if not (JR.same(recordAsBytes, null)) then
                        byteArrayInputStream <- (new ByteArrayInputStream(recordAsBytes))
                        inputStream <- (new DataInputStream(byteArrayInputStream))
                        let mutable name : string = inputStream.readUTF()
                        let mutable nextScore : int64 = inputStream.readLong()
                        let mutable nextCurrentHighScore : HighScore = (new HighScore(id_, name, GameInfo.NONE, nextScore))
                        if this.recordComparatorInterface.compare(nextCurrentHighScore.getAsBytes(), bestHighScore.getAsBytes()) = RecordComparator.FOLLOWS then
                            bestHighScore <- nextCurrentHighScore
                if bestHighScore.getId() <> (-1) then
                    this.logUtil.putF((new StringMaker()).append("Removing Lowest HighScore: ").appendlong(bestHighScore.getScore()).ToString(), this, this.commonStrings.LOAD)
                    recordStore.deleteRecord(bestHighScore.getId())
            with jex ->
                match JR.throwable(jex) with
                | :? RecordStoreException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, "removeLowestHighScore", e)
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, "removeLowestHighScore", e)
                | _ -> reraise ()
        finally
            try
                if not (JR.same(recordStore, null)) then
                    PreLogUtil.put("Closing RecordStore", this, "removeLowestHighScore")
                    recordStore.closeRecordStore()
            with jex ->
                match JR.throwable(jex) with
                | :? RecordStoreException as e ->
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, "removeLowestHighScore", e)
                | _ -> reraise ()
    
    member this.load() : unit =
        let mutable jflow = 0
        let mutable recordStore : RecordStore = NullRecordStore.NULL_RECORD_STORE
        try
            try
                recordStore <- RecordStore.openRecordStore(this.getRecordId(this.abeClientInformation), true)
                this.setList((new BasicArrayListD()))
                let mutable recordEnum : RecordEnumeration = recordStore.enumerateRecords(NullRecordFilter.NULL_RECORD_FILTER, NullRecordComparator.NULL_RECORD_COMPARATOR, true)
                let mutable recordAsBytes : sbyte[] = null
                let mutable byteArrayInputStream : ByteArrayInputStream = null
                let mutable inputStream : DataInputStream = null
                while jflow = 0 && (recordEnum.hasNextElement()) do
                    let mutable id_ : int = recordEnum.nextRecordId()
                    recordAsBytes <- this.tsUtil.getRecord(recordStore, id_)
                    if not (JR.same(recordAsBytes, null)) then
                        byteArrayInputStream <- (new ByteArrayInputStream(recordAsBytes))
                        inputStream <- (new DataInputStream(byteArrayInputStream))
                        try
                            let mutable name : string = inputStream.readUTF()
                            let mutable score : int64 = inputStream.readLong()
                            let mutable newHighScore : HighScore = (new HighScore(id_, name, GameInfo.NONE, score))
                            let mutable list_ : BasicArrayList = this.getList()
                            let mutable size : int = list_.size()
                            let mutable lastIndex : int = size
                            let mutable index : int = 0
                            while jflow = 0 && (index < size) do
                                let mutable highScore : HighScore = (box (list_.objectArray.[index]) :?> HighScore)
                                if this.recordComparatorInterface.compare(newHighScore.getAsBytes(), highScore.getAsBytes()) = RecordComparator.PRECEDES then
                                    lastIndex <- index
                                    jflow <- 100003
                                if jflow = 200003 then jflow <- 0
                                if jflow = 0 then index <- index + 1
                            if jflow = 100003 then jflow <- 0
                            if jflow = 0 then
                                list_.addAt(lastIndex, newHighScore)
                        with jex ->
                            match JR.throwable(jex) with
                            | :? JEOFException as e ->
                                this.logUtil.put("EOF", this, this.commonStrings.LOAD, e)
                                raise (e)
                            | _ -> reraise ()
                    if jflow = 200002 then jflow <- 0
                if jflow = 100002 then jflow <- 0
            with jex ->
                match JR.throwable(jex) with
                | :? RecordStoreNotFoundException as e ->
                    this.logUtil.put("No High Scores", this, this.commonStrings.LOAD, e)
                | :? RecordStoreException as e ->
                    this.logUtil.put(this.commonStrings.UNKNOWN, this, this.commonStrings.LOAD, e)
                | :? JIOException as e ->
                    this.logUtil.put(this.commonStrings.UNKNOWN, this, this.commonStrings.LOAD, e)
                | :? JException as e ->
                    this.logUtil.put(this.commonStrings.UNKNOWN, this, this.commonStrings.LOAD, e)
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
    
    member this.isTooManyHighScores() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (not (JR.same(this.getList(), null))) && (this.getList().size() < this.MAXHIGHSCORES) then
            jret <- false
            jflow <- 1
        else
            this.logUtil.putF((new StringMaker()).append("HighScores RecordStore Max Reached: ").appendint(this.MAXHIGHSCORES).ToString(), this, "isTooManyHighScores")
            jret <- true
            jflow <- 1
        jret
    
    override this.isBestScore(newHighScore: HighScore) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        try
            if not (this.isTooManyHighScores()) then
                this.logUtil.putF("Slot Available for a High Score", this, "isBestScore")
                jret <- true
                jflow <- 1
            else
                let mutable list_ : BasicArrayList = this.getList()
                let mutable size : int = list_.size()
                let mutable index : int = 0
                while jflow = 0 && (index < size) do
                    let mutable highScore : HighScore = (box (list_.objectArray.[index]) :?> HighScore)
                    if this.recordComparatorInterface.compare(newHighScore.getAsBytes(), highScore.getAsBytes()) = RecordComparator.FOLLOWS then
                        this.logUtil.putF("Obtained a High Score", this, "isBestScore")
                        jret <- true
                        jflow <- 1
                    if jflow = 200004 then jflow <- 0
                    if jflow = 0 then index <- index + 1
                if jflow = 100004 then jflow <- 0
            if jflow = 0 then
                this.logUtil.putF("Not a High Score", this, "isBestScore")
                jret <- false
                jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.ADD, e)
                raise (e)
            | _ -> reraise ()
        jret
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(base.ToString()))
        let mutable list_ : BasicArrayList = this.getList()
        let mutable size : int = list_.size()
        let mutable index : int = 0
        while index < size do
            let mutable highScore : HighScore = (box (list_.objectArray.[index]) :?> HighScore)
            ignore (stringBuffer.append(highScore.getScoreString()))
            ignore (stringBuffer.append(CommonSeps.getInstance().COMMA_SEP))
            index <- index + 1
        stringBuffer.ToString()


