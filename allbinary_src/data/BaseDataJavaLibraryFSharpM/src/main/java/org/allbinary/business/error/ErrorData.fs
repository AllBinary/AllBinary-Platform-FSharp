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
type ErrorData =
    [<DefaultValue(false)>] val mutable NAME : string
    [<DefaultValue(false)>] val mutable TEXT : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : ErrorData
    static member instance with get() : ErrorData = (ErrorData.jclinit(); ErrorData.jcell_instance) and set (jvalue: ErrorData) = (ErrorData.jclinit(); ErrorData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ErrorData.jclinitDone then
            ErrorData.jclinitDone <- true
            ErrorData.jclinitBody()
    static member private jclinitBody() : unit =
        ErrorData.jcell_instance <- (new ErrorData())
        ()
    member this.jfields_ErrorData() : unit =
        this.NAME <- "ERROR_NAME"
        this.TEXT <- "ERROR_TEXT"
        ()
    
    static member getInstance() : ErrorData =
        ErrorData.instance
    
    new () as this =
        {  }
        then
            this.jfields_ErrorData()


