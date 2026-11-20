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
type ResizableEmptyListener =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ResizableEmptyListener.jclinitDone then
            ResizableEmptyListener.jclinitDone <- true
            ResizableEmptyListener.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract onResizable : isResizable: bool -> unit
    default this.onResizable(isResizable: bool) : unit =
        ()
    interface ResizableListenerInterface with
        member this.onResizable(jp0: bool) : unit = this.onResizable(jp0)


