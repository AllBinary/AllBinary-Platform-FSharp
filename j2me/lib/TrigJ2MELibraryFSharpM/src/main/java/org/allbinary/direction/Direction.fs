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
type Direction =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable otherName : string
    [<DefaultValue(false)>] val mutable value : int
    [<DefaultValue(false)>] val mutable frameFactor : int
    [<DefaultValue(false)>] static val mutable private jcell_directionArray : Direction[]
    static member directionArray with get() : Direction[] = (Direction.jclinit(); Direction.jcell_directionArray) and set (jvalue: Direction[]) = (Direction.jclinit(); Direction.jcell_directionArray <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Direction.jclinitDone then
            Direction.jclinitDone <- true
            Direction.jclinitBody()
    static member private jclinitBody() : unit =
        Direction.jcell_directionArray <- (Array.zeroCreate<Direction> (13))
        ()
    
    new (name: string, otherName: string, value: int, frameFactor: int) as this =
        {  }
        then
            this.jctor1(name, otherName, value, frameFactor)
    member this.jctor1(name: string, otherName: string, value: int, frameFactor: int) : unit =
        this.name <- name
        this.otherName <- otherName
        this.value <- value
        this.frameFactor <- frameFactor
        Direction.directionArray.[value] <- this
        ()
    
    static member getInstance(direction: int) : Direction =
        Direction.directionArray.[direction]
    
    abstract getValue : unit -> int
    default this.getValue() : int =
        this.value
    
    abstract getFrameFactor : unit -> int
    default this.getFrameFactor() : int =
        this.frameFactor
    
    abstract getOtherName : unit -> string
    default this.getOtherName() : string =
        this.otherName
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Direction: "))
        ignore (stringBuffer.append(this.getName()))
        ignore (stringBuffer.append(" Or: "))
        ignore (stringBuffer.append(this.getOtherName()))
        ignore (stringBuffer.append(" Value: "))
        ignore (stringBuffer.appendint(this.value))
        stringBuffer.ToString()


