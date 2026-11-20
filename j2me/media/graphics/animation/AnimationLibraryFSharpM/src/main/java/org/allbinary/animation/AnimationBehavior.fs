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
type AnimationBehavior =
    [<DefaultValue(false)>] static val mutable private jcell_instance : AnimationBehavior
    static member instance with get() : AnimationBehavior = (AnimationBehavior.jclinit(); AnimationBehavior.jcell_instance) and set (jvalue: AnimationBehavior) = (AnimationBehavior.jclinit(); AnimationBehavior.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnimationBehavior.jclinitDone then
            AnimationBehavior.jclinitDone <- true
            AnimationBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        AnimationBehavior.jcell_instance <- (new AnimationBehavior())
        ()
    new () =
        {  }
    
    static member getInstance() : AnimationBehavior =
        AnimationBehavior.instance
    
    abstract reset : unit -> unit
    default this.reset() : unit =
        ()


