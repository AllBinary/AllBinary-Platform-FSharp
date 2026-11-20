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
type ScaleFactorFactory =
    [<DefaultValue(false)>] val mutable DEFAULT_SCALE_FACTOR : int
    [<DefaultValue(false)>] val mutable DEFAULT_SCALE_VALUE : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : ScaleFactorFactory
    static member instance with get() : ScaleFactorFactory = (ScaleFactorFactory.jclinit(); ScaleFactorFactory.jcell_instance) and set (jvalue: ScaleFactorFactory) = (ScaleFactorFactory.jclinit(); ScaleFactorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScaleFactorFactory.jclinitDone then
            ScaleFactorFactory.jclinitDone <- true
            ScaleFactorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ScaleFactorFactory.jcell_instance <- (new ScaleFactorFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_ScaleFactorFactory()
    member this.jfields_ScaleFactorFactory() : unit =
        this.DEFAULT_SCALE_FACTOR <- 10
        this.DEFAULT_SCALE_VALUE <- 1024
        ()
    
    static member getInstance() : ScaleFactorFactory =
        ScaleFactorFactory.instance


