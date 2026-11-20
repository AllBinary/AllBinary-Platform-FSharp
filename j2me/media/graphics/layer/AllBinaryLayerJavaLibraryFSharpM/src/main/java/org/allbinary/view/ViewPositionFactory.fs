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
type ViewPositionFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ViewPositionFactory.jclinitDone then
            ViewPositionFactory.jclinitDone <- true
            ViewPositionFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : unit -> ViewPositionBase
    default this.getInstance() : ViewPositionBase =
        ViewPosition.getInstanceD()
    interface ViewPositionFactoryInterface with
        member this.getInstance() : ViewPositionBase = this.getInstance()


