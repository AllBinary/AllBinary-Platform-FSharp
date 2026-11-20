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
type InitUpdatePaintable =
    inherit Paintable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InitUpdatePaintable.jclinitDone then
            InitUpdatePaintable.jclinitDone <- true
            InitUpdatePaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit Paintable() }
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract update : unit -> unit
    default this.update() : unit =
        ()
    interface InitUpdatePaintableInterface
    interface InitInterface with
        member this.init() : unit = this.init()
    interface UpdateInterface with
        member this.update() : unit = this.update()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)


