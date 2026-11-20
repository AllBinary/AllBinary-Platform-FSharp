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
type LocationPaintable =
    [<DefaultValue(false)>] static val mutable private jcell_instance : LocationPaintable
    static member instance with get() : LocationPaintable = (LocationPaintable.jclinit(); LocationPaintable.jcell_instance) and set (jvalue: LocationPaintable) = (LocationPaintable.jclinit(); LocationPaintable.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LocationPaintable.jclinitDone then
            LocationPaintable.jclinitDone <- true
            LocationPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        LocationPaintable.jcell_instance <- (new LocationPaintable())
        ()
    new () =
        {  }
    
    static member getInstance() : LocationPaintable =
        LocationPaintable.instance
    
    abstract paintXY : graphics: Graphics * x: int * y: int -> unit
    default this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        ()
    interface LocationPaintableInterface with
        member this.paintXY(jp0: Graphics, jp1: int, jp2: int) : unit = this.paintXY(jp0, jp1, jp2)


