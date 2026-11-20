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
type MidletIcon =
    [<DefaultValue(false)>] static val mutable private jcell_RESOURCE : string
    static member RESOURCE with get() : string = (MidletIcon.jclinit(); MidletIcon.jcell_RESOURCE) and set (jvalue: string) = (MidletIcon.jclinit(); MidletIcon.jcell_RESOURCE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MidletIcon.jclinitDone then
            MidletIcon.jclinitDone <- true
            MidletIcon.jclinitBody()
    static member private jclinitBody() : unit =
        MidletIcon.jcell_RESOURCE <- "icon"
        ()
    new () =
        {  }


