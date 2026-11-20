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
type GameCanvasPaintHelper =
    inherit ProcessPaintable
    [<DefaultValue(false)>] val mutable gameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameCanvasPaintHelper.jclinitDone then
            GameCanvasPaintHelper.jclinitDone <- true
            GameCanvasPaintHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (gameCanvas: AllBinaryGameCanvas) as this =
        { inherit ProcessPaintable() }
        then
            this.jctor1(gameCanvas)
    member this.jctor1(gameCanvas: AllBinaryGameCanvas) : unit =
        this.gameCanvas <- gameCanvas
        ()
    
    override this.process_() : unit =
        ()
    
    override this.paint(graphics: Graphics) : unit =
        this.gameCanvas.draw(graphics)


