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
type DestroyableBaseBehavior =
    [<DefaultValue(false)>] static val mutable private jcell_instance : DestroyableBaseBehavior
    static member instance with get() : DestroyableBaseBehavior = (DestroyableBaseBehavior.jclinit(); DestroyableBaseBehavior.jcell_instance) and set (jvalue: DestroyableBaseBehavior) = (DestroyableBaseBehavior.jclinit(); DestroyableBaseBehavior.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DestroyableBaseBehavior.jclinitDone then
            DestroyableBaseBehavior.jclinitDone <- true
            DestroyableBaseBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        DestroyableBaseBehavior.jcell_instance <- (new DestroyableBaseBehavior())
        ()
    new () =
        {  }
    
    static member getInstance() : DestroyableBaseBehavior =
        DestroyableBaseBehavior.instance
    
    abstract getName : unit -> string
    default this.getName() : string =
        JR.getClass(this)
    
    abstract isDestroyed : unit -> bool
    default this.isDestroyed() : bool =
        raise ((new JException(CommonStrings.getInstance().NOT_IMPLEMENTED)))
    
    abstract setDestroyed : destroyed: bool -> unit
    default this.setDestroyed(destroyed: bool) : unit =
        ()
    interface DestroyableInterface with
        member this.isDestroyed() : bool = this.isDestroyed()
    interface NamedInterface with
        member this.getName() : string = this.getName()


