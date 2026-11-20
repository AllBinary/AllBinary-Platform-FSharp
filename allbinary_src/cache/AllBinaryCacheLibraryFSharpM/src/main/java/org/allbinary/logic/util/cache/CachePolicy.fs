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
type CachePolicy =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable maxTime : int64
    [<DefaultValue(false)>] val mutable maxSize : int64
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CachePolicy.jclinitDone then
            CachePolicy.jclinitDone <- true
            CachePolicy.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string, maxTime: int64, maxSize: int64) as this =
        {  }
        then
            this.jctor1(name, maxTime, maxSize)
    member this.jctor1(name: string, maxTime: int64, maxSize: int64) : unit =
        this.name <- name
        this.setMaxTime(maxTime)
        this.setMaxSize(maxSize)
        ()
    
    abstract getMaxTime : unit -> int64
    default this.getMaxTime() : int64 =
        this.maxTime
    
    abstract setMaxTime : maxTime: int64 -> unit
    default this.setMaxTime(maxTime: int64) : unit =
        this.maxTime <- maxTime
    
    abstract getMaxSize : unit -> int64
    default this.getMaxSize() : int64 =
        this.maxSize
    
    abstract setMaxSize : maxSize: int64 -> unit
    default this.setMaxSize(maxSize: int64) : unit =
        this.maxSize <- maxSize
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name


