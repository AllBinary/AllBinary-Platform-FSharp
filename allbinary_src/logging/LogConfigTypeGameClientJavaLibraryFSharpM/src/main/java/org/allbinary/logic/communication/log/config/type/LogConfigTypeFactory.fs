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
type LogConfigTypeFactory =
    [<DefaultValue(false)>] val mutable NO_DESCRIPTION : string
    [<DefaultValue(false)>] val mutable OS : LogConfigType
    [<DefaultValue(false)>] val mutable FACTORYERROR : LogConfigType
    [<DefaultValue(false)>] static val mutable private jcell_instance : LogConfigTypeFactory
    static member instance with get() : LogConfigTypeFactory = (LogConfigTypeFactory.jclinit(); LogConfigTypeFactory.jcell_instance) and set (jvalue: LogConfigTypeFactory) = (LogConfigTypeFactory.jclinit(); LogConfigTypeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LogConfigTypeFactory.jclinitDone then
            LogConfigTypeFactory.jclinitDone <- true
            LogConfigTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LogConfigTypeFactory.jcell_instance <- (new LogConfigTypeFactory())
        ()
    member this.jfields_LogConfigTypeFactory() : unit =
        this.NO_DESCRIPTION <- "No Description"
        this.OS <- (new LogConfigType("Operating System", this.NO_DESCRIPTION))
        this.FACTORYERROR <- (new LogConfigType("Factory Error", this.NO_DESCRIPTION))
        ()
    
    static member getInstance() : LogConfigTypeFactory =
        LogConfigTypeFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_LogConfigTypeFactory()
            this.jctor1()
    member this.jctor1() : unit =
        ignore (LogConfigTypes.LOGGING.add(this.OS))
        ignore (LogConfigTypes.LOGGING.add(this.FACTORYERROR))
        ()


