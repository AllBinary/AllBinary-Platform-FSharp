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
type BufferedGameCanvasPaintHelper =
    inherit ProcessPaintable
    [<DefaultValue(false)>] val mutable gameCanvas : Canvas
    [<DefaultValue(false)>] val mutable offScreenImage : Image[]
    [<DefaultValue(false)>] val mutable previousImage : Image
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable drawCircularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable anchor : int
    static member MAX_IMAGES : int = 4
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BufferedGameCanvasPaintHelper.jclinitDone then
            BufferedGameCanvasPaintHelper.jclinitDone <- true
            BufferedGameCanvasPaintHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BufferedGameCanvasPaintHelper() : unit =
        this.gameCanvas <- NullCanvas.NULL_CANVAS
        this.offScreenImage <- (Array.zeroCreate<Image> (BufferedGameCanvasPaintHelper.MAX_IMAGES))
        this.previousImage <- NullImage.NULL_IMAGE
        this.circularIndexUtil <- CircularIndexUtil.createInstance(BufferedGameCanvasPaintHelper.MAX_IMAGES)
        this.drawCircularIndexUtil <- CircularIndexUtil.createInstanceAt((BufferedGameCanvasPaintHelper.MAX_IMAGES - 1), BufferedGameCanvasPaintHelper.MAX_IMAGES)
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (gameCanvas: AllBinaryGameCanvas) as this =
        { inherit ProcessPaintable() }
        then
            this.jfields_BufferedGameCanvasPaintHelper()
            this.jctor1(gameCanvas)
    member this.jctor1(gameCanvas: AllBinaryGameCanvas) : unit =
        raise ((new JException("No Longer Used")))
        ()
    
    override this.process_() : unit =
        let mutable myCanvas : MyCanvas = ((box (this.gameCanvas) :?> MyCanvas))
        myCanvas.draw(this.offScreenImage.[this.circularIndexUtil.getIndex()].getGraphics())
        ignore (this.circularIndexUtil.next())
        ignore (this.drawCircularIndexUtil.next())
    
    override this.paint(graphics: Graphics) : unit =
        this.previousImage <- this.offScreenImage.[this.drawCircularIndexUtil.getIndex()]
        graphics.drawImage(this.previousImage, 0, 0, this.anchor)


