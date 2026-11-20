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
type NotificationUtil =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : NotificationUtil
    static member SINGLETON with get() : NotificationUtil = (NotificationUtil.jclinit(); NotificationUtil.jcell_SINGLETON) and set (jvalue: NotificationUtil) = (NotificationUtil.jclinit(); NotificationUtil.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NotificationUtil.jclinitDone then
            NotificationUtil.jclinitDone <- true
            NotificationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        NotificationUtil.jcell_SINGLETON <- (new NotificationUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : NotificationUtil =
        NotificationUtil.SINGLETON
    
    abstract notify : command: Command * resource: string * message: string -> unit
    default this.notify(command: Command, resource: string, message: string) : unit =
        ()


