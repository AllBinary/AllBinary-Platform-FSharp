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
type NullOutputStream =
    inherit OutputStream
    [<DefaultValue(false)>] static val mutable private jcell_NULL_OUTPUT_STREAM : NullOutputStream
    static member NULL_OUTPUT_STREAM with get() : NullOutputStream = (NullOutputStream.jclinit(); NullOutputStream.jcell_NULL_OUTPUT_STREAM) and set (jvalue: NullOutputStream) = (NullOutputStream.jclinit(); NullOutputStream.jcell_NULL_OUTPUT_STREAM <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullOutputStream.jclinitDone then
            NullOutputStream.jclinitDone <- true
            NullOutputStream.jclinitBody()
    static member private jclinitBody() : unit =
        NullOutputStream.jcell_NULL_OUTPUT_STREAM <- (new NullOutputStream())
        ()
    new () =
        { inherit OutputStream() }
    
    override this.write(b: int) : unit =
        ()
    
    override this.write(b: sbyte[], off: int, len: int) : unit =
        ()
    
    override this.close() : unit =
        ()


