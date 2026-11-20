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
type BufferedLineReader =
    [<DefaultValue(false)>] val mutable tmpIn : BufferedReader
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BufferedLineReader.jclinitDone then
            BufferedLineReader.jclinitDone <- true
            BufferedLineReader.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (file: AbFile) as this =
        {  }
        then
            this.jctor1(file)
    member this.jctor1(file: AbFile) : unit =
        this.tmpIn <- (new BufferedReader((new FileReader(AbFileNativeUtil.get(file)))))
        ()
    
    abstract readUpToLines : readAheadIndex: int64 -> unit
    default this.readUpToLines(readAheadIndex: int64) : unit =
        ()
    
    abstract readLine : unit -> string
    default this.readLine() : string =
        this.tmpIn.readLine()
    
    abstract ready : unit -> bool
    default this.ready() : bool =
        this.tmpIn.ready()
    
    abstract getSize : unit -> int64
    default this.getSize() : int64 =
        0L
    
    abstract getCurrent : unit -> int
    default this.getCurrent() : int =
        0


