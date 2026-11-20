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
type CharArrayFactory =
    [<DefaultValue(false)>] val mutable zeroCharArray : char[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : CharArrayFactory
    static member instance with get() : CharArrayFactory = (CharArrayFactory.jclinit(); CharArrayFactory.jcell_instance) and set (jvalue: CharArrayFactory) = (CharArrayFactory.jclinit(); CharArrayFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CharArrayFactory.jclinitDone then
            CharArrayFactory.jclinitDone <- true
            CharArrayFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CharArrayFactory.jcell_instance <- (new CharArrayFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_CharArrayFactory()
    member this.jfields_CharArrayFactory() : unit =
        this.zeroCharArray <- (Array.zeroCreate<char> (0))
        ()
    
    static member getInstance() : CharArrayFactory =
        CharArrayFactory.instance
    
    abstract getZeroCharArray : unit -> char[]
    default this.getZeroCharArray() : char[] =
        this.zeroCharArray


