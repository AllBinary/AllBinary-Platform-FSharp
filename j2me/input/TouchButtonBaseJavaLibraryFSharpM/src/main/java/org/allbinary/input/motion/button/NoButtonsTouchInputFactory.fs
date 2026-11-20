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
type NoButtonsTouchInputFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : BaseTouchInput
    static member instance with get() : BaseTouchInput = (NoButtonsTouchInputFactory.jclinit(); NoButtonsTouchInputFactory.jcell_instance) and set (jvalue: BaseTouchInput) = (NoButtonsTouchInputFactory.jclinit(); NoButtonsTouchInputFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoButtonsTouchInputFactory.jclinitDone then
            NoButtonsTouchInputFactory.jclinitDone <- true
            NoButtonsTouchInputFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NoButtonsTouchInputFactory.jcell_instance <- (new BaseTouchInput())
        ()
    new () =
        {  }
    
    static member getInstance() : BaseTouchInput =
        NoButtonsTouchInputFactory.instance


