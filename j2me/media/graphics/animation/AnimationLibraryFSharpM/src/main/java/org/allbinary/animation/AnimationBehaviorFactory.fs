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
type AnimationBehaviorFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : AnimationBehaviorFactory
    static member instance with get() : AnimationBehaviorFactory = (AnimationBehaviorFactory.jclinit(); AnimationBehaviorFactory.jcell_instance) and set (jvalue: AnimationBehaviorFactory) = (AnimationBehaviorFactory.jclinit(); AnimationBehaviorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnimationBehaviorFactory.jclinitDone then
            AnimationBehaviorFactory.jclinitDone <- true
            AnimationBehaviorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        AnimationBehaviorFactory.jcell_instance <- (new AnimationBehaviorFactory())
        ()
    new () =
        {  }
    
    static member getInstance() : AnimationBehaviorFactory =
        AnimationBehaviorFactory.instance
    
    abstract getOrCreateInstance : unit -> AnimationBehavior
    default this.getOrCreateInstance() : AnimationBehavior =
        AnimationBehavior.getInstance()


