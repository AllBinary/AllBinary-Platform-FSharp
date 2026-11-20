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
type ByteUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ByteUtil
    static member instance with get() : ByteUtil = (ByteUtil.jclinit(); ByteUtil.jcell_instance) and set (jvalue: ByteUtil) = (ByteUtil.jclinit(); ByteUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ByteUtil.jclinitDone then
            ByteUtil.jclinitDone <- true
            ByteUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ByteUtil.jcell_instance <- (new ByteUtil())
        ()
    
    static member getInstance() : ByteUtil =
        ByteUtil.instance
    
    new () =
        {  }
    
    abstract xor : array_: sbyte[] * mask: sbyte -> sbyte[]
    default this.xor(array_: sbyte[], mask: sbyte) : sbyte[] =
        let mutable bytes : sbyte[] = (Array.zeroCreate<sbyte> (array_.Length))
        let mutable size : int = array_.Length
        let mutable index : int = 0
        let mutable currentByte : sbyte = 0y
        while index < size do
            currentByte <- array_.[index]
            bytes.[index] <- sbyte ((int (currentByte) ^^^ int (mask)))
            index <- index + 1
        bytes
    
    abstract not_ : array_: sbyte[] -> sbyte[]
    default this.not_(array_: sbyte[]) : sbyte[] =
        let mutable bytes : sbyte[] = (Array.zeroCreate<sbyte> (array_.Length))
        let mutable size : int = array_.Length
        let mutable index : int = 0
        while index < size do
            bytes.[index] <- sbyte (~~~(array_.[index]))
            index <- index + 1
        bytes
    
    abstract xorByte : array_: sbyte[] * index: int -> sbyte[]
    default this.xorByte(array_: sbyte[], index: int) : sbyte[] =
        let mutable mask : sbyte = (0y)
        if index = 0 then
            mask <- (1y)
        if index = 1 then
            mask <- (2y)
        if index = 2 then
            mask <- (4y)
        if index = 3 then
            mask <- (8y)
        if index = 4 then
            mask <- (16y)
        if index = 5 then
            mask <- (32y)
        if index = 6 then
            mask <- (64y)
        if index = 7 then
            mask <- (-127y)
        this.xor(array_, mask)
    
    abstract compare : newByteArray: sbyte[] * oldByteArray: sbyte[] -> bool
    default this.compare(newByteArray: sbyte[], oldByteArray: sbyte[]) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if newByteArray.Length <> oldByteArray.Length then
            jret <- false
            jflow <- 1
        else
            ()
        if jflow = 0 then
            let mutable size : int = newByteArray.Length
            let mutable index : int = 0
            while jflow = 0 && (index < size) do
                if newByteArray.[index] <> oldByteArray.[index] then
                    jret <- false
                    jflow <- 1
                if jflow = 200003 then jflow <- 0
                if jflow = 0 then index <- index + 1
            if jflow = 100003 then jflow <- 0
            if jflow = 0 then
                jret <- true
                jflow <- 1
        jret
    
    abstract compareWithStats : newByteArray: sbyte[] * newSize: int * oldByteArray: sbyte[] * stats: int[] -> bool
    default this.compareWithStats(newByteArray: sbyte[], newSize: int, oldByteArray: sbyte[], stats: int[]) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if newSize <> oldByteArray.Length then
            stats.[0] <- -1
            stats.[2] <- newSize
            stats.[3] <- oldByteArray.Length
            jret <- false
            jflow <- 1
        else
            stats.[0] <- newSize
        if jflow = 0 then
            stats.[1] <- 0
            let mutable size : int = newSize
            let mutable index : int = 0
            while jflow = 0 && (index < size) do
                if newByteArray.[index] <> oldByteArray.[index] then
                    jret <- false
                    jflow <- 1
                if jflow = 0 then
                    stats.[1] <- stats.[1] + 1
                if jflow = 200004 then jflow <- 0
                if jflow = 0 then index <- index + 1
            if jflow = 100004 then jflow <- 0
            if jflow = 0 then
                jret <- true
                jflow <- 1
        jret


