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
type OwnershipPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable displayInfo : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable COPYRIGHT : string
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable color : int
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable COPYRIGHT_Y : int
    [<DefaultValue(false)>] val mutable beginWidth : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OwnershipPaintable.jclinitDone then
            OwnershipPaintable.jclinitDone <- true
            OwnershipPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_OwnershipPaintable() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.displayInfo <- DisplayInfoSingleton.getInstance()
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.COPYRIGHT <- "AllBinary Copyright (c) 2011"
        this.basicColor <- BasicColorFactory.getInstance().WHITE
        this.color <- this.basicColor.intValue()
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    static member getInstance() : OwnershipPaintable =
        (new OwnershipPaintable())
    
    new () as this =
        { inherit Paintable() }
        then
            this.jfields_OwnershipPaintable()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.COPYRIGHT_Y <- 2 * font.getHeight()
        this.beginWidth <- (font.stringWidth(this.COPYRIGHT) >>> 1)
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
        this.color <- basicColor.intValue()
    
    abstract getBasicColorP : unit -> BasicColor
    default this.getBasicColorP() : BasicColor =
        this.basicColor
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        graphics.setColor(this.color)
        let mutable halfWidth : int = this.displayInfo.getLastHalfWidth()
        let mutable height : int = this.displayInfo.getLastHeight()
        graphics.drawString(this.COPYRIGHT, (halfWidth - this.beginWidth), (height - this.COPYRIGHT_Y), this.anchor)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


