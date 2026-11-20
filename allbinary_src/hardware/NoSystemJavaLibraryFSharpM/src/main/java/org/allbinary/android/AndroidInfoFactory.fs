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
type AndroidInfoFactory =
    [<DefaultValue(false)>] val mutable version : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : AndroidInfoFactory
    static member instance with get() : AndroidInfoFactory = (AndroidInfoFactory.jclinit(); AndroidInfoFactory.jcell_instance) and set (jvalue: AndroidInfoFactory) = (AndroidInfoFactory.jclinit(); AndroidInfoFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AndroidInfoFactory.jclinitDone then
            AndroidInfoFactory.jclinitDone <- true
            AndroidInfoFactory.jclinitBody()
    static member private jclinitBody() : unit =
        AndroidInfoFactory.jcell_instance <- (new AndroidInfoFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_AndroidInfoFactory()
    member this.jfields_AndroidInfoFactory() : unit =
        this.version <- 8
        ()
    
    static member getInstance() : AndroidInfoFactory =
        AndroidInfoFactory.instance
    
    abstract getVersion : unit -> int
    default this.getVersion() : int =
        this.version


