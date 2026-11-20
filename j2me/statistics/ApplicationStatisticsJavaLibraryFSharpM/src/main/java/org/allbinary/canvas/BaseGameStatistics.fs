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
type BaseGameStatistics =
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable updateDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable totalRefreshes : int64
    [<DefaultValue(false)>] val mutable totalFrames : int64
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] val mutable DEFAULT_SCALE_FACTOR : int
    [<DefaultValue(false)>] val mutable NOT : string
    [<DefaultValue(false)>] val mutable EMPTY_STRING : string
    [<DefaultValue(false)>] val mutable STRING_ARRAY : string[]
    [<DefaultValue(false)>] val mutable SPACE_CHAR : char
    [<DefaultValue(false)>] val mutable PLUS_CHAR : char
    [<DefaultValue(false)>] val mutable X_CHAR : char
    [<DefaultValue(false)>] val mutable CHAR_ARRAY : char[][]
    [<DefaultValue(false)>] val mutable primitiveLongSingleton : PrimitiveLongSingleton
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseGameStatistics.jclinitDone then
            BaseGameStatistics.jclinitDone <- true
            BaseGameStatistics.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BaseGameStatistics() : unit =
        this.timeDelayHelper <- (new TimeDelayHelper(Integer.MAX_VALUE))
        this.updateDelayHelper <- (new TimeDelayHelper(2000))
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        this.DEFAULT_SCALE_FACTOR <- ScaleFactorFactory.getInstance().DEFAULT_SCALE_FACTOR
        this.NOT <- "Not enough Time to Calculate"
        this.EMPTY_STRING <- StringUtil.getInstance().EMPTY_STRING
        this.STRING_ARRAY <- ([| " Total Time: "; this.EMPTY_STRING; " Total Frames: "; this.EMPTY_STRING; " Frames/10 Sec: "; this.EMPTY_STRING; " Total Paints: "; this.EMPTY_STRING; " Paints/10 Sec: "; this.EMPTY_STRING |] : string[])
        this.SPACE_CHAR <- ' '
        this.PLUS_CHAR <- '+'
        this.X_CHAR <- 'X'
        this.CHAR_ARRAY <- ([| ([| 'F'; 'r'; 'a'; 'm'; 'e'; 's'; '/'; '1'; '0'; ' '; 'S'; 'e'; 'c'; ':' |] : char[]); ([| 'X'; 'X' |] : char[]); ([| 'P'; 'a'; 'i'; 'n'; 't'; 's'; '/'; '1'; '0'; ' '; 'S'; 'e'; 'c'; ':' |] : char[]); ([| 'X'; 'X' |] : char[]) |] : char[][])
        this.primitiveLongSingleton <- PrimitiveLongSingleton.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_BaseGameStatistics()
    
    abstract init : unit -> unit
    default this.init() : unit =
        this.timeDelayHelper.setStartTimeTNT()
        this.totalRefreshes <- 0L
        this.totalFrames <- 0L
    
    abstract add : string_: string -> unit
    default this.add(string_: string) : unit =
        ()
    
    abstract process_ : unit -> unit
    default this.process_() : unit =
        ()
    
    abstract nextFrame : unit -> unit
    default this.nextFrame() : unit =
        this.totalFrames <- this.totalFrames + 1L
    
    abstract nextRefresh : unit -> unit
    default this.nextRefresh() : unit =
        this.totalRefreshes <- this.totalRefreshes + 1L
    
    abstract getRefreshRate : unit -> int16
    default this.getRefreshRate() : int16 =
        let mutable jflow = 0
        let mutable jret : int16 = Unchecked.defaultof<int16>
        let mutable elapsed : int64 = this.timeDelayHelper.getElapsed(this.gameTickTimeDelayHelper.startTime)
        if elapsed > 1L then
            let mutable time : int16 = int16 ((this.totalRefreshes / (elapsed >>> this.DEFAULT_SCALE_FACTOR)))
            jret <- time
            jflow <- 1
        else
            jret <- (0s)
            jflow <- 1
        jret
    
    abstract getTimeDelayHelper : unit -> TimeDelayHelper
    default this.getTimeDelayHelper() : TimeDelayHelper =
        this.timeDelayHelper
    
    abstract to2DCharArray : unit -> char[][]
    default this.to2DCharArray() : char[][] =
        let mutable totalTime : int64 = this.timeDelayHelper.getElapsed(this.gameTickTimeDelayHelper.startTime)
        totalTime <- (totalTime >>> this.DEFAULT_SCALE_FACTOR)
        if (totalTime > 0L) && this.updateDelayHelper.isTime(this.gameTickTimeDelayHelper.startTime) then
            let mutable framesPerSec : int = int ((this.totalFrames / totalTime))
            if framesPerSec < 10 then
                this.CHAR_ARRAY.[1].[0] <- this.SPACE_CHAR
                this.CHAR_ARRAY.[1].[1] <- this.primitiveLongSingleton.NUMBER_CHAR_ARRAY.[framesPerSec]
            elif framesPerSec < 100 then
                let mutable tens : int = framesPerSec / 10
                let mutable removeTens : int = tens * 10
                this.CHAR_ARRAY.[1].[0] <- this.primitiveLongSingleton.NUMBER_CHAR_ARRAY.[tens]
                this.CHAR_ARRAY.[1].[1] <- this.primitiveLongSingleton.NUMBER_CHAR_ARRAY.[framesPerSec - removeTens]
            else
                this.CHAR_ARRAY.[1].[0] <- this.PLUS_CHAR
                this.CHAR_ARRAY.[1].[1] <- this.PLUS_CHAR
            let mutable refreshesPerSec : int = int ((this.totalRefreshes / totalTime))
            if refreshesPerSec < 10 then
                this.CHAR_ARRAY.[3].[0] <- this.X_CHAR
                this.CHAR_ARRAY.[3].[1] <- this.primitiveLongSingleton.NUMBER_CHAR_ARRAY.[refreshesPerSec]
            elif refreshesPerSec < 100 then
                let mutable tens : int = refreshesPerSec / 10
                let mutable removeTens : int = tens * 10
                this.CHAR_ARRAY.[3].[0] <- this.primitiveLongSingleton.NUMBER_CHAR_ARRAY.[refreshesPerSec / 10]
                this.CHAR_ARRAY.[3].[1] <- this.primitiveLongSingleton.NUMBER_CHAR_ARRAY.[refreshesPerSec - removeTens]
            else
                this.CHAR_ARRAY.[3].[0] <- this.PLUS_CHAR
                this.CHAR_ARRAY.[3].[1] <- this.PLUS_CHAR
        this.CHAR_ARRAY
    
    abstract toStringArray : unit -> string[]
    default this.toStringArray() : string[] =
        let mutable totalTime : int64 = this.timeDelayHelper.getElapsed(this.gameTickTimeDelayHelper.startTime)
        totalTime <- (totalTime / 10000L)
        if totalTime > 0L then
            this.STRING_ARRAY.[1] <- Long.toString(totalTime)
            this.STRING_ARRAY.[3] <- Long.toString(this.totalFrames)
            this.STRING_ARRAY.[5] <- Long.toString((this.totalFrames / totalTime))
            this.STRING_ARRAY.[7] <- Long.toString(this.totalRefreshes)
            this.STRING_ARRAY.[9] <- Long.toString((this.totalRefreshes / totalTime))
        else
            let mutable string_ : string = this.EMPTY_STRING
            this.STRING_ARRAY.[1] <- string_
            this.STRING_ARRAY.[3] <- string_
            this.STRING_ARRAY.[5] <- string_
            this.STRING_ARRAY.[7] <- string_
            this.STRING_ARRAY.[9] <- string_
        this.STRING_ARRAY
    
    abstract toStringAt : totalTime: int64 -> string
    default this.toStringAt(totalTime: int64) : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(this.STRING_ARRAY.[0]))
        ignore (stringBuffer.appendlong(totalTime))
        ignore (stringBuffer.append(this.STRING_ARRAY.[2]))
        ignore (stringBuffer.appendlong(this.totalFrames))
        ignore (stringBuffer.append(this.STRING_ARRAY.[4]))
        ignore (stringBuffer.appendlong((this.totalFrames / totalTime)))
        if this.totalRefreshes > 0L then
            ignore (stringBuffer.append(this.STRING_ARRAY.[6]))
            ignore (stringBuffer.appendlong(this.totalRefreshes))
            ignore (stringBuffer.append(this.STRING_ARRAY.[8]))
            ignore (stringBuffer.appendlong((this.totalRefreshes / totalTime)))
            ignore (stringBuffer.append(CommonSeps.getInstance().NEW_LINE))
        stringBuffer.ToString()
    
    override this.ToString() : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable totalTime : int64 = this.timeDelayHelper.getElapsed(this.gameTickTimeDelayHelper.startTime)
        totalTime <- (totalTime / 1000L)
        if totalTime > 0L then
            jret <- this.toStringAt(totalTime)
            jflow <- 1
        else
            jret <- this.NOT
            jflow <- 1
        jret


