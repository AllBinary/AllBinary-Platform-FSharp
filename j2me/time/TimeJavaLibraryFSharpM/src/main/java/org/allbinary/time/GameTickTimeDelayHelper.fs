namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type GameTickTimeDelayHelper =
    [<DefaultValue(false)>] val mutable timeDelta : int64
    [<DefaultValue(false)>] val mutable startTime : int64
    [<DefaultValue(false)>] val mutable lastStartTime : int64
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameTickTimeDelayHelper.jclinitDone then
            GameTickTimeDelayHelper.jclinitDone <- true
            GameTickTimeDelayHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (startTime: int64) as this =
        {  }
        then
            this.jctor1(startTime)
    member this.jctor1(startTime: int64) : unit =
        this.startTime <- startTime
        this.lastStartTime <- 0L
        ()
    
    abstract setStartTime : unit -> int64
    default this.setStartTime() : int64 =
        this.startTime <- JSystem.currentTimeMillis()
        this.startTime
    
    abstract loop : unit -> unit
    default this.loop() : unit =
        if this.lastStartTime = Long.MIN_VALUE then
            this.timeDelta <- 0L
        else
            this.timeDelta <- JSystem.currentTimeMillis() - this.lastStartTime
    
    abstract getTimeFromStart : unit -> int64
    default this.getTimeFromStart() : int64 =
        this.startTime - this.lastStartTime


