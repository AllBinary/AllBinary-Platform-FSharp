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
type Paintable =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Paintable.jclinitDone then
            Paintable.jclinitDone <- true
            Paintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract setBasicColorP : basicColor: BasicColor -> unit
    default this.setBasicColorP(basicColor: BasicColor) : unit =
        ()
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        ()
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)


