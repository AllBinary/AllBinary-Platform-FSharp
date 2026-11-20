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
type MidletStrings =
    [<DefaultValue(false)>] val mutable COMMAND_ACTION : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : MidletStrings
    static member instance with get() : MidletStrings = (MidletStrings.jclinit(); MidletStrings.jcell_instance) and set (jvalue: MidletStrings) = (MidletStrings.jclinit(); MidletStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MidletStrings.jclinitDone then
            MidletStrings.jclinitDone <- true
            MidletStrings.jclinitBody()
    static member private jclinitBody() : unit =
        MidletStrings.jcell_instance <- (new MidletStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_MidletStrings()
    member this.jfields_MidletStrings() : unit =
        this.COMMAND_ACTION <- "commandAction"
        ()
    
    static member getInstance() : MidletStrings =
        MidletStrings.instance


