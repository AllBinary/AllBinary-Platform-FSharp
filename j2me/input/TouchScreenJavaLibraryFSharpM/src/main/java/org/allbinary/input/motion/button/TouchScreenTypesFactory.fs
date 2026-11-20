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
type TouchScreenTypesFactory =
    [<DefaultValue(false)>] val mutable FINGER : TouchScreenType
    [<DefaultValue(false)>] val mutable NOTOUCH : TouchScreenType
    [<DefaultValue(false)>] val mutable STYLUS : TouchScreenType
    [<DefaultValue(false)>] val mutable UNDEFINED : TouchScreenType
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchScreenTypesFactory
    static member instance with get() : TouchScreenTypesFactory = (TouchScreenTypesFactory.jclinit(); TouchScreenTypesFactory.jcell_instance) and set (jvalue: TouchScreenTypesFactory) = (TouchScreenTypesFactory.jclinit(); TouchScreenTypesFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchScreenTypesFactory.jclinitDone then
            TouchScreenTypesFactory.jclinitDone <- true
            TouchScreenTypesFactory.jclinitBody()
    static member private jclinitBody() : unit =
        TouchScreenTypesFactory.jcell_instance <- (new TouchScreenTypesFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_TouchScreenTypesFactory()
    member this.jfields_TouchScreenTypesFactory() : unit =
        this.FINGER <- (new TouchScreenType("Finger"))
        this.NOTOUCH <- (new TouchScreenType("No Touch"))
        this.STYLUS <- (new TouchScreenType("Stylus"))
        this.UNDEFINED <- (new TouchScreenType("Undefined"))
        ()
    
    static member getInstance() : TouchScreenTypesFactory =
        TouchScreenTypesFactory.instance


