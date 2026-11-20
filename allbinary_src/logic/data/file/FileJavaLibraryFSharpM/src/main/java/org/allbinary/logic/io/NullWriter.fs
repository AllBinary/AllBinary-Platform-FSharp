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
type NullWriter =
    inherit Writer
    [<DefaultValue(false)>] static val mutable private jcell_NULL_WRITER : NullWriter
    static member NULL_WRITER with get() : NullWriter = (NullWriter.jclinit(); NullWriter.jcell_NULL_WRITER) and set (jvalue: NullWriter) = (NullWriter.jclinit(); NullWriter.jcell_NULL_WRITER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullWriter.jclinitDone then
            NullWriter.jclinitDone <- true
            NullWriter.jclinitBody()
    static member private jclinitBody() : unit =
        NullWriter.jcell_NULL_WRITER <- (new NullWriter())
        ()
    new () =
        { inherit Writer() }
    
    override this.write(c: int) : unit =
        ()
    
    override this.write(cbuf: char[], off: int, len: int) : unit =
        ()
    
    override this.write(str: string) : unit =
        ()
    
    override this.write(str: string, off: int, len: int) : unit =
        ()
    
    override this.flush() : unit =
        ()
    
    override this.close() : unit =
        ()


