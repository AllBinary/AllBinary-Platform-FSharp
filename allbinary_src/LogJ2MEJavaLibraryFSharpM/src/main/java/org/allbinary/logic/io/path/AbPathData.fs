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
type AbPathData =
    [<DefaultValue(false)>] val mutable EXTENSION_SEP : string
    [<DefaultValue(false)>] val mutable SEPARATORCHAR : char
    [<DefaultValue(false)>] val mutable SEPARATOR : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : AbPathData
    static member instance with get() : AbPathData = (AbPathData.jclinit(); AbPathData.jcell_instance) and set (jvalue: AbPathData) = (AbPathData.jclinit(); AbPathData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbPathData.jclinitDone then
            AbPathData.jclinitDone <- true
            AbPathData.jclinitBody()
    static member private jclinitBody() : unit =
        AbPathData.jcell_instance <- (new AbPathData())
        ()
    member this.jfields_AbPathData() : unit =
        this.EXTENSION_SEP <- CommonSeps.getInstance().PERIOD
        this.SEPARATORCHAR <- '/'
        this.SEPARATOR <- CommonSeps.getInstance().FORWARD_SLASH
        ()
    
    static member getInstance() : AbPathData =
        AbPathData.instance
    
    new () as this =
        {  }
        then
            this.jfields_AbPathData()


