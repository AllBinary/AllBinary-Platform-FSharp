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
type ScoreComparator =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable isHighestBest : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScoreComparator.jclinitDone then
            ScoreComparator.jclinitDone <- true
            ScoreComparator.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ScoreComparator() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (isHighestBest: bool) as this =
        {  }
        then
            this.jfields_ScoreComparator()
            this.jctor1(isHighestBest)
    member this.jctor1(isHighestBest: bool) : unit =
        this.isHighestBest <- isHighestBest
        ()
    
    abstract getBestScore : unit -> int64
    default this.getBestScore() : int64 =
        (if this.isHighestBest then Long.MAX_VALUE else 0)
    
    abstract compare : recordOne: sbyte[] * recordTwo: sbyte[] -> int
    default this.compare(recordOne: sbyte[], recordTwo: sbyte[]) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable byteArrayInputStreamOne : ByteArrayInputStream = (new ByteArrayInputStream(recordOne))
        let mutable inputStreamOne : DataInputStream = (new DataInputStream(byteArrayInputStreamOne))
        let mutable byteArrayInputStreamTwo : ByteArrayInputStream = (new ByteArrayInputStream(recordTwo))
        let mutable inputStreamTwo : DataInputStream = (new DataInputStream(byteArrayInputStreamTwo))
        let mutable scoreOne : int64 = 0L
        let mutable scoreTwo : int64 = 0L
        try
            ignore (inputStreamOne.readUTF())
            ignore (inputStreamTwo.readUTF())
            scoreOne <- inputStreamOne.readLong()
            scoreTwo <- inputStreamTwo.readLong()
        with jex ->
            match JR.throwable(jex) with
            | :? JEOFException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "compare", e)
            | :? JIOException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "compare", e)
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "compare", e)
            | _ -> reraise ()
        if this.isHighestBest then
            jret <- this.getHighTooLow(scoreOne, scoreTwo)
            jflow <- 1
        else
            jret <- this.getLowTooHigh(scoreOne, scoreTwo)
            jflow <- 1
        jret
    
    abstract getHighTooLow : scoreOne: int64 * scoreTwo: int64 -> int
    default this.getHighTooLow(scoreOne: int64, scoreTwo: int64) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if scoreOne > scoreTwo then
            jret <- RecordComparator.PRECEDES
            jflow <- 1
        elif scoreOne < scoreTwo then
            jret <- RecordComparator.FOLLOWS
            jflow <- 1
        else
            jret <- RecordComparator.EQUIVALENT
            jflow <- 1
        jret
    
    abstract getLowTooHigh : scoreOne: int64 * scoreTwo: int64 -> int
    default this.getLowTooHigh(scoreOne: int64, scoreTwo: int64) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if scoreOne < scoreTwo then
            jret <- RecordComparator.PRECEDES
            jflow <- 1
        elif scoreOne > scoreTwo then
            jret <- RecordComparator.FOLLOWS
            jflow <- 1
        else
            jret <- RecordComparator.EQUIVALENT
            jflow <- 1
        jret
    interface RecordComparator with
        member this.compare(jp0: sbyte[], jp1: sbyte[]) : int = this.compare(jp0, jp1)


