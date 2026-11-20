namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type SWTUtil =
    [<DefaultValue(false)>] static val mutable private jcell_isSWT : bool
    static member isSWT with get() : bool = (SWTUtil.jclinit(); SWTUtil.jcell_isSWT) and set (jvalue: bool) = (SWTUtil.jclinit(); SWTUtil.jcell_isSWT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_SWT : string
    static member SWT with get() : string = (SWTUtil.jclinit(); SWTUtil.jcell_SWT) and set (jvalue: string) = (SWTUtil.jclinit(); SWTUtil.jcell_SWT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SWTUtil.jclinitDone then
            SWTUtil.jclinitDone <- true
            SWTUtil.jclinitBody()
    static member private jclinitBody() : unit =
        SWTUtil.jcell_isSWT <- true
        SWTUtil.jcell_SWT <- "SWT"
        ()
    new () =
        {  }


