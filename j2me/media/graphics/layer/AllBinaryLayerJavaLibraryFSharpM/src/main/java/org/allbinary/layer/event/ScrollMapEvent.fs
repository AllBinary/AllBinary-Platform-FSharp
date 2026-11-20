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
type ScrollMapEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScrollMapEvent.jclinitDone then
            ScrollMapEvent.jclinitDone <- true
            ScrollMapEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (anyType: obj) =
        { inherit AllBinaryEventObject(anyType) }
    
    abstract setDx : dx: int -> unit
    default this.setDx(dx: int) : unit =
        this.dx <- dx
    
    abstract getDx : unit -> int
    default this.getDx() : int =
        this.dx
    
    abstract setDy : dy: int -> unit
    default this.setDy(dy: int) : unit =
        this.dy <- dy
    
    abstract getDy : unit -> int
    default this.getDy() : int =
        this.dy
    
    abstract setDxDy : dx: int * dy: int -> unit
    default this.setDxDy(dx: int, dy: int) : unit =
        this.dx <- dx
        this.dy <- dy


