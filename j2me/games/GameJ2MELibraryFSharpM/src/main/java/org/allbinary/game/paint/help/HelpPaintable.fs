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
type HelpPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable displayInfo : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable title : string
    [<DefaultValue(false)>] val mutable inputInfo : string[]
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable titleBeginWidth : int
    [<DefaultValue(false)>] val mutable beginWidthArray : int[]
    [<DefaultValue(false)>] val mutable charHeight : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HelpPaintable.jclinitDone then
            HelpPaintable.jclinitDone <- true
            HelpPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HelpPaintable() : unit =
        this.displayInfo <- DisplayInfoSingleton.getInstance()
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.anchor <- Anchor.TOP_LEFT
        this.inputInfo <- StringUtil.getInstance().getArrayInstance()
        this.beginWidthArray <- NullUtil.getInstance().NULL_INT_ARRAY
        ()
    
    new (title: string, backgroundBasicColor: BasicColor, basicColor: BasicColor) as this =
        { inherit Paintable() }
        then
            this.jfields_HelpPaintable()
            this.jctor1(title, backgroundBasicColor, basicColor)
    member this.jctor1(title: string, backgroundBasicColor: BasicColor, basicColor: BasicColor) : unit =
        this.title <- title
        this.basicColor <- basicColor
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.titleBeginWidth <- (font.stringWidth(this.title) >>> 1)
        this.charHeight <- font.getHeight()
        let mutable size : int = this.inputInfo.Length
        let mutable index : int = 0
        while index < size do
            this.beginWidthArray.[index] <- (font.stringWidth(this.inputInfo.[index]) >>> 1)
            index <- index + 1
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract setInputInfoP : inputInfo: string[] -> unit
    default this.setInputInfoP(inputInfo: string[]) : unit =
        this.inputInfo <- inputInfo
        this.beginWidthArray <- (Array.zeroCreate<int> (this.inputInfo.Length))
        this.myFontProcessor <- this.updateMyFontProcessor
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable halfWidth : int = this.displayInfo.getLastHalfWidth()
        graphics.setColor(this.basicColor.intValue())
        graphics.drawString(this.title, (halfWidth - this.titleBeginWidth), this.charHeight, this.anchor)
        let mutable size : int = this.inputInfo.Length
        let mutable index : int = 0
        while index < size do
            graphics.drawString(this.inputInfo.[index], (halfWidth - this.beginWidthArray.[index]), ((index + 3) * this.charHeight), this.anchor)
            index <- index + 1
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


