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
type OverScanColorFillPaintable =
    inherit ColorFillPaintable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OverScanColorFillPaintable.jclinitDone then
            OverScanColorFillPaintable.jclinitDone <- true
            OverScanColorFillPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (basicColor: BasicColor) =
        { inherit ColorFillPaintable(basicColor) }
    
    override this.paint(graphics: Graphics) : unit =
        graphics.setColor(this.colorP)
        graphics.fillRect(-(graphics.getClipX()), -(graphics.getClipY()), (this.displayInfoSingleton.getLastWidth() + (graphics.getClipX() * 2)), (this.displayInfoSingleton.getLastHeight() + (graphics.getClipY() * 2)))


