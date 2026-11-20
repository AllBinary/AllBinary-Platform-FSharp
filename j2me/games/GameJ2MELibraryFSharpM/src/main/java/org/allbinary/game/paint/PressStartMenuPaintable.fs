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
type PressStartMenuPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable displayInfo : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable PRESS_START : string
    [<DefaultValue(false)>] val mutable KEY_START : string
    [<DefaultValue(false)>] val mutable MENU_START : string
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable startString : string
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable flash : bool
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable beginWidth : int
    [<DefaultValue(false)>] val mutable line : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PressStartMenuPaintable.jclinitDone then
            PressStartMenuPaintable.jclinitDone <- true
            PressStartMenuPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PressStartMenuPaintable() : unit =
        this.displayInfo <- DisplayInfoSingleton.getInstance()
        this.PRESS_START <- "Press Screen To Start"
        this.KEY_START <- "Press or Click F2 To Begin"
        this.MENU_START <- "Press Start From The Menu To Begin"
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.startString <- StringUtil.getInstance().EMPTY_STRING
        this.timeDelayHelper <- (new TimeDelayHelper(1100))
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new () as this =
        { inherit Paintable() }
        then
            this.jfields_PressStartMenuPaintable()
            this.jctor1()
    member this.jctor1() : unit =
        if TouchScreenFactory.getInstance().isTouch() then
            this.startString <- this.PRESS_START
        elif AppletUtil.isAppletLoader(this) then
            this.startString <- this.KEY_START
        else
            this.startString <- this.MENU_START
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.beginWidth <- (graphics.getFont().stringWidth(this.startString) >>> 1)
        this.line <- (4 * MyFontProcessor.defaultCharWidth(font)) + (font.getHeight() >>> 1)
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    override this.paint(graphics: Graphics) : unit =
        if this.timeDelayHelper.isTimeTNT() then
            if this.isFlash() then
                this.setFlash(false)
            else
                this.setFlash(true)
        if this.isFlash() then
            this.myFontProcessor.process_(graphics)
            graphics.drawString(this.startString, (this.displayInfo.getLastHalfWidth() - this.beginWidth), (this.displayInfo.getLastHeight() - this.line), this.anchor)
    
    member this.setFlash(flash: bool) : unit =
        this.flash <- flash
    
    member this.isFlash() : bool =
        this.flash
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


