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
type CanvasDrawLineString =
    [<DefaultValue(false)>] val mutable drawStringUtil : DrawStringUtil
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable x : int
    [<DefaultValue(false)>] val mutable y : int
    [<DefaultValue(false)>] val mutable fontHeight : int
    [<DefaultValue(false)>] static val mutable private jcell_NULL_CANVAS_DRAW_LINE_STRING : CanvasDrawLineString
    static member NULL_CANVAS_DRAW_LINE_STRING with get() : CanvasDrawLineString = (CanvasDrawLineString.jclinit(); CanvasDrawLineString.jcell_NULL_CANVAS_DRAW_LINE_STRING) and set (jvalue: CanvasDrawLineString) = (CanvasDrawLineString.jclinit(); CanvasDrawLineString.jcell_NULL_CANVAS_DRAW_LINE_STRING <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CanvasDrawLineString.jclinitDone then
            CanvasDrawLineString.jclinitDone <- true
            CanvasDrawLineString.jclinitBody()
    static member private jclinitBody() : unit =
        CanvasDrawLineString.jcell_NULL_CANVAS_DRAW_LINE_STRING <- (new CanvasDrawLineString(0, 0))
        ()
    member this.jfields_CanvasDrawLineString() : unit =
        this.drawStringUtil <- DrawStringUtil.getInstance()
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.fontHeight <- 0
        ()
    
    new (x: int, y: int) as this =
        {  }
        then
            this.jfields_CanvasDrawLineString()
            this.jctor1(x, y)
    member this.jctor1(x: int, y: int) : unit =
        this.x <- x
        this.y <- y
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.fontHeight <- font.getHeight()
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract paint : graphics: Graphics * string_: string * line: int -> unit
    default this.paint(graphics: Graphics, string_: string, line: int) : unit =
        this.myFontProcessor.process_(graphics)
        this.drawStringUtil.drawCenterString(graphics, string_, 0, JString.length(string_), this.x, (this.y + (line * this.fontHeight)))
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


