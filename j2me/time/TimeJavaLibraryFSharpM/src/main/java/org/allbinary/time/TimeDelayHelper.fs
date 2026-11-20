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
type TimeDelayHelper =
    [<DefaultValue(false)>] val mutable startTime : int64
    [<DefaultValue(false)>] val mutable elapsedTimeAtPause : int64
    [<DefaultValue(false)>] val mutable delay : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TimeDelayHelper.jclinitDone then
            TimeDelayHelper.jclinitDone <- true
            TimeDelayHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TimeDelayHelper() : unit =
        this.startTime <- int64 (-1)
        this.elapsedTimeAtPause <- Long.MIN_VALUE
        ()
    
    new (delay: int) as this =
        {  }
        then
            this.jfields_TimeDelayHelper()
            this.jctor1(delay)
    member this.jctor1(delay: int) : unit =
        this.delay <- delay
        this.setStartTimeTNT()
        ()
    
    abstract isTimeTNT : unit -> bool
    default this.isTimeTNT() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable currentTime : int64 = JSystem.currentTimeMillis()
        if (currentTime - this.startTime) > int64 (this.delay) then
            this.startTime <- currentTime
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isTimeSinceTNT : delay: int -> bool
    default this.isTimeSinceTNT(delay: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable currentTime : int64 = JSystem.currentTimeMillis()
        if (currentTime - this.startTime) > int64 (delay) then
            this.startTime <- currentTime
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isTime : currentTime: int64 -> bool
    default this.isTime(currentTime: int64) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (currentTime - this.startTime) > int64 (this.delay) then
            this.startTime <- currentTime
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isTimeWithoutReset : currentTime: int64 -> bool
    default this.isTimeWithoutReset(currentTime: int64) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (currentTime - this.startTime) > int64 (this.delay) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract isTimeSince : delay: int * currentTime: int64 -> bool
    default this.isTimeSince(delay: int, currentTime: int64) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (currentTime - this.startTime) > int64 (this.delay) then
            this.startTime <- currentTime
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract getElapsedTNT : unit -> int64
    default this.getElapsedTNT() : int64 =
        JSystem.currentTimeMillis() - this.startTime
    
    abstract getElapsed : currentTime: int64 -> int64
    default this.getElapsed(currentTime: int64) : int64 =
        currentTime - this.startTime
    
    abstract isElapsed : currentTime: int64 * time: int64 -> bool
    default this.isElapsed(currentTime: int64, time: int64) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.getElapsed(currentTime) > time then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract isElapsedTNT : time: int64 -> bool
    default this.isElapsedTNT(time: int64) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.getElapsedTNT() > time then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract setStartTime : startTime: int64 -> unit
    default this.setStartTime(startTime: int64) : unit =
        this.startTime <- startTime
    
    abstract getStartTime : unit -> int64
    default this.getStartTime() : int64 =
        this.startTime
    
    abstract setStartTimeTNT : unit -> unit
    default this.setStartTimeTNT() : unit =
        this.startTime <- JSystem.currentTimeMillis()
    
    abstract pause : unit -> unit
    default this.pause() : unit =
        this.elapsedTimeAtPause <- this.getElapsedTNT()
        this.startTime <- Long.MAX_VALUE
    
    abstract resume : unit -> bool
    default this.resume() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.elapsedTimeAtPause <> Long.MIN_VALUE then
            this.startTime <- JSystem.currentTimeMillis() + this.elapsedTimeAtPause
            this.elapsedTimeAtPause <- Long.MIN_VALUE
            this.setStartTimeTNT()
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract toStringAt : currentTime: int64 -> string
    default this.toStringAt(currentTime: int64) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable elapsed : int64 = this.getElapsed(currentTime)
        if elapsed > 0L then
            let mutable commonLabels : CommonLabels = CommonLabels.getInstance()
            let mutable elapsedAsString : string = Long.toString(elapsed)
            jret <- (new StringMaker()).append(commonLabels.START).appendlong(this.startTime).append(commonLabels.CURRENT).appendlong(currentTime).append(commonLabels.ELAPSED).append(elapsedAsString).ToString()
            jflow <- 1
        else
            jret <- StringUtil.getInstance().EMPTY_STRING
            jflow <- 1
        jret
    
    override this.ToString() : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable currentTime : int64 = JSystem.currentTimeMillis()
        let mutable elapsed : int64 = this.getElapsed(currentTime)
        if elapsed > 0L then
            let mutable commonLabels : CommonLabels = CommonLabels.getInstance()
            let mutable elapsedAsString : string = Long.toString(elapsed)
            jret <- (new StringMaker()).append(commonLabels.START).appendlong(this.startTime).append(commonLabels.CURRENT).appendlong(currentTime).append(commonLabels.ELAPSED).append(elapsedAsString).ToString()
            jflow <- 1
        else
            jret <- StringUtil.getInstance().EMPTY_STRING
            jflow <- 1
        jret


