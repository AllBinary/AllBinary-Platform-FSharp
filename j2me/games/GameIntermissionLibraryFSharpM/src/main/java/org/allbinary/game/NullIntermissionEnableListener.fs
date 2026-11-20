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
type NullIntermissionEnableListener =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : IntermissionEnableListenerInterface
    static member SINGLETON with get() : IntermissionEnableListenerInterface = (NullIntermissionEnableListener.jclinit(); NullIntermissionEnableListener.jcell_SINGLETON) and set (jvalue: IntermissionEnableListenerInterface) = (NullIntermissionEnableListener.jclinit(); NullIntermissionEnableListener.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullIntermissionEnableListener.jclinitDone then
            NullIntermissionEnableListener.jclinitDone <- true
            NullIntermissionEnableListener.jclinitBody()
    static member private jclinitBody() : unit =
        NullIntermissionEnableListener.jcell_SINGLETON <- (new NullIntermissionEnableListener())
        ()
    
    static member getInstance() : IntermissionEnableListenerInterface =
        NullIntermissionEnableListener.SINGLETON
    
    new () =
        {  }
    
    abstract notifyIntermission : enable: bool -> unit
    default this.notifyIntermission(enable: bool) : unit =
        ()
    interface IntermissionEnableListenerInterface with
        member this.notifyIntermission(jp0: bool) : unit = this.notifyIntermission(jp0)


