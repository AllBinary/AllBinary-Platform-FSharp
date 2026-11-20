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
type TouchJ2ME =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchJ2ME.jclinitDone then
            TouchJ2ME.jclinitDone <- true
            TouchJ2ME.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    abstract pointerDragged : x: int * y: int -> unit
    default this.pointerDragged(x: int, y: int) : unit =
        ()
    
    abstract pointerPressed : x: int * y: int -> unit
    default this.pointerPressed(x: int, y: int) : unit =
        ()
    
    abstract pointerReleased : x: int * y: int -> unit
    default this.pointerReleased(x: int, y: int) : unit =
        ()


