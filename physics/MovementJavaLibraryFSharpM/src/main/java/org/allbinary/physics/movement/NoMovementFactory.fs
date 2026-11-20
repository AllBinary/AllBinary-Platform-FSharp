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
type NoMovementFactory =
    [<DefaultValue(false)>] val mutable movement : Movement
    [<DefaultValue(false)>] static val mutable private jcell_instance : NoMovementFactory
    static member instance with get() : NoMovementFactory = (NoMovementFactory.jclinit(); NoMovementFactory.jcell_instance) and set (jvalue: NoMovementFactory) = (NoMovementFactory.jclinit(); NoMovementFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoMovementFactory.jclinitDone then
            NoMovementFactory.jclinitDone <- true
            NoMovementFactory.jclinitBody()
    static member private jclinitBody() : unit =
        NoMovementFactory.jcell_instance <- (new NoMovementFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_NoMovementFactory()
    member this.jfields_NoMovementFactory() : unit =
        this.movement <- (new Movement())
        ()
    
    static member getInstance() : NoMovementFactory =
        NoMovementFactory.instance
    
    member this.getMovmentInstance() : Movement =
        this.movement


