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
type TouchScreenTypeFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : TouchScreenTypeFactory
    static member instance with get() : TouchScreenTypeFactory = (TouchScreenTypeFactory.jclinit(); TouchScreenTypeFactory.jcell_instance) and set (jvalue: TouchScreenTypeFactory) = (TouchScreenTypeFactory.jclinit(); TouchScreenTypeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchScreenTypeFactory.jclinitDone then
            TouchScreenTypeFactory.jclinitDone <- true
            TouchScreenTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        TouchScreenTypeFactory.jcell_instance <- (new TouchScreenTypeFactory())
        ()
    
    static member getInstance() : TouchScreenTypeFactory =
        TouchScreenTypeFactory.instance
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable touchScreenFactory : TouchScreenFactory = TouchScreenFactory.getInstance()
        touchScreenFactory.setTouch(false)
        ()


