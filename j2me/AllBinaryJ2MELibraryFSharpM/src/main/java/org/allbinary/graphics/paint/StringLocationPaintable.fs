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
type StringLocationPaintable =
    inherit LocationPaintable
    [<DefaultValue(false)>] val mutable value : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StringLocationPaintable.jclinitDone then
            StringLocationPaintable.jclinitDone <- true
            StringLocationPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (value: string) as this =
        { inherit LocationPaintable() }
        then
            this.jctor1(value)
    member this.jctor1(value: string) : unit =
        this.value <- value
        ()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        graphics.drawString(this.value, x, y, 0)


