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
type HudTimer =
    [<DefaultValue(false)>] val mutable startTime : int64
    [<DefaultValue(false)>] val mutable hundredthTime : int64
    [<DefaultValue(false)>] val mutable maxTime : int64
    [<DefaultValue(false)>] val mutable modifier : int64
    [<DefaultValue(false)>] val mutable hundrethsString : char[]
    [<DefaultValue(false)>] val mutable totalDigits : int
    [<DefaultValue(false)>] val mutable primitiveLongUtil : PrimitiveLongUtil
    [<DefaultValue(false)>] val mutable MAX : char[]
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HudTimer.jclinitDone then
            HudTimer.jclinitDone <- true
            HudTimer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HudTimer() : unit =
        this.startTime <- int64 (-1)
        this.hundrethsString <- PrimitiveLongSingleton.getInstance().ZERO
        this.totalDigits <- 1
        this.MAX <- ([| 'L'; 'O'; 'L' |] : char[])
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        ()
    
    new (maxTime: int) as this =
        {  }
        then
            this.jfields_HudTimer()
            this.jctor1(maxTime)
    member this.jctor1(maxTime: int) : unit =
        this.primitiveLongUtil <- PrimitiveLongUtil.createPowerOfTen(maxTime)
        this.maxTime <- int64 (maxTime)
        ()
    
    abstract start : unit -> unit
    default this.start() : unit =
        this.hundredthTime <- 0L
        this.startTime <- this.gameTickTimeDelayHelper.startTime
    
    abstract get : unit -> int64
    default this.get() : int64 =
        this.hundredthTime
    
    abstract update : unit -> unit
    default this.update() : unit =
        let mutable lastLowerTime : int64 = this.hundredthTime
        let mutable currentTime : int64 = (int64 ((this.modifier + int64 (this.gameTickTimeDelayHelper.startTime))) - this.startTime)
        if currentTime < 0L then
            currentTime <- 0L
        this.hundredthTime <- currentTime / 100L
        if this.hundredthTime >= this.maxTime then
            if this.startTime > 0L then
                this.hundrethsString <- this.MAX
        elif lastLowerTime <> this.hundredthTime then
            this.hundrethsString <- this.primitiveLongUtil.getCharArray(int (this.hundredthTime))
            this.totalDigits <- this.primitiveLongUtil.getCurrentTotalDigits()
    
    abstract reduce : value: int -> unit
    default this.reduce(value: int) : unit =
        this.modifier <- this.modifier - int64 (value)
    
    abstract add : value: int -> unit
    default this.add(value: int) : unit =
        this.modifier <- this.modifier + int64 (value)
    
    abstract getTimeChars : unit -> char[]
    default this.getTimeChars() : char[] =
        this.hundrethsString
    
    abstract getCurrentTotalDigits : unit -> int
    default this.getCurrentTotalDigits() : int =
        this.totalDigits


