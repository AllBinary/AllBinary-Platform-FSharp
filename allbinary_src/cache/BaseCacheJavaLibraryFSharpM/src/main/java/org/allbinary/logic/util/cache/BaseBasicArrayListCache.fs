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
type BaseBasicArrayListCache =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseBasicArrayListCache.jclinitDone then
            BaseBasicArrayListCache.jclinitDone <- true
            BaseBasicArrayListCache.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_BaseBasicArrayListCache()
    member this.jfields_BaseBasicArrayListCache() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    abstract log : unit -> string
    default this.log() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("S: "))
        ignore (stringBuffer.appendint(this.list.size()))
        stringBuffer.ToString()


