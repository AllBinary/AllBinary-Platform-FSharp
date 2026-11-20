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
type CollidableBaseBehaviorFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableBaseBehaviorFactory.jclinitDone then
            CollidableBaseBehaviorFactory.jclinitDone <- true
            CollidableBaseBehaviorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract createBehavior : unit -> CollidableBaseBehavior
    default this.createBehavior() : CollidableBaseBehavior =
        raise ((new JRuntimeException()))
    interface CollidableBaseBehaviorFactoryInterface with
        member this.createBehavior() : CollidableBaseBehavior = this.createBehavior()


