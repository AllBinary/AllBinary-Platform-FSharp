namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NullReader =
    inherit Reader
    [<DefaultValue(false)>] static val mutable private jcell_NULL_READER : NullReader
    static member NULL_READER with get() : NullReader = (NullReader.jclinit(); NullReader.jcell_NULL_READER) and set (jvalue: NullReader) = (NullReader.jclinit(); NullReader.jcell_NULL_READER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullReader.jclinitDone then
            NullReader.jclinitDone <- true
            NullReader.jclinitBody()
    static member private jclinitBody() : unit =
        NullReader.jcell_NULL_READER <- (new NullReader())
        ()
    new () =
        { inherit Reader() }
    
    override this.read() : int =
        -1
    
    override this.read(cbuf: char[], off: int, len: int) : int =
        -1
    
    override this.ready() : bool =
        false
    
    override this.skip(n: int64) : int64 =
        0L
    
    override this.close() : unit =
        ()


