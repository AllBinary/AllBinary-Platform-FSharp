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
type AboutPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable displayInfoSingleton : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable ABOUT : string
    [<DefaultValue(false)>] val mutable info : string[]
    [<DefaultValue(false)>] val mutable developers : string[]
    [<DefaultValue(false)>] val mutable paintableArray : Paintable[]
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable charHeight : int
    [<DefaultValue(false)>] val mutable aboutBeginWidth : int
    [<DefaultValue(false)>] val mutable infoBeginWidth : int[]
    [<DefaultValue(false)>] val mutable developersBeginWidth : int[]
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AboutPaintable.jclinitDone then
            AboutPaintable.jclinitDone <- true
            AboutPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AboutPaintable() : unit =
        this.displayInfoSingleton <- DisplayInfoSingleton.getInstance()
        this.ABOUT <- CanvasStrings.getInstance().ABOUT
        this.paintableArray <- ([| this |] : Paintable[])
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    static member getInstance(info: string[], developers: string[]) : AboutPaintable =
        (new AboutPaintable(info, developers))
    
    new (info: string[], developers: string[]) as this =
        { inherit Paintable() }
        then
            this.jfields_AboutPaintable()
            this.jctor1(info, developers)
    member this.jctor1(info: string[], developers: string[]) : unit =
        this.info <- info
        this.infoBeginWidth <- (Array.zeroCreate<int> (this.info.Length))
        this.developers <- developers
        this.developersBeginWidth <- (Array.zeroCreate<int> (this.developers.Length))
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.charHeight <- font.getHeight()
        this.aboutBeginWidth <- (font.stringWidth(this.ABOUT) >>> 1)
        let mutable infoSize : int = this.info.Length
        let mutable index : int = 0
        while index < infoSize do
            this.infoBeginWidth.[index] <- (font.stringWidth(this.info.[index]) >>> 1)
            index <- index + 1
        let mutable size : int = this.developers.Length
        let mutable index : int = 0
        while index < size do
            this.developersBeginWidth.[index] <- (font.stringWidth(this.developers.[index]) >>> 1)
            index <- index + 1
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract getPaintableArrayInstance : unit -> Paintable[]
    default this.getPaintableArrayInstance() : Paintable[] =
        this.paintableArray
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable halfWidth : int = this.displayInfoSingleton.getLastHalfWidth()
        graphics.drawString(this.ABOUT, (halfWidth - this.aboutBeginWidth), (2 * this.charHeight), this.anchor)
        let mutable infoSize : int = this.info.Length
        let mutable index : int = 0
        while index < infoSize do
            graphics.drawString(this.info.[index], (halfWidth - this.infoBeginWidth.[index]), ((4 + index) * this.charHeight), this.anchor)
            index <- index + 1
        let mutable size : int = this.developers.Length
        let mutable index : int = 0
        while index < size do
            graphics.drawString(this.developers.[index], (halfWidth - this.developersBeginWidth.[index]), (((5 + infoSize) + index) * this.charHeight), this.anchor)
            index <- index + 1
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


