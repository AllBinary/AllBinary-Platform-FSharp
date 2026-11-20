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
type StartIntermissionPaintable =
    inherit InitUpdatePaintable
    [<DefaultValue(false)>] val mutable fontDebugFactory : FontDebugFactory
    [<DefaultValue(false)>] val mutable basicSetColorUtil : BasicColorSetUtil
    [<DefaultValue(false)>] val mutable gameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] val mutable stringArray : string[]
    [<DefaultValue(false)>] val mutable fontSize : int
    [<DefaultValue(false)>] val mutable font : Font
    [<DefaultValue(false)>] val mutable lastWidth : int[]
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable color : int
    [<DefaultValue(false)>] val mutable lineYOffsetArray : int[]
    [<DefaultValue(false)>] val mutable hasChanged : bool
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable fontHeightP : int
    [<DefaultValue(false)>] val mutable BEGIN_LEVEL : string
    [<DefaultValue(false)>] val mutable EMPTY_STRING : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StartIntermissionPaintable.jclinitDone then
            StartIntermissionPaintable.jclinitDone <- true
            StartIntermissionPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_StartIntermissionPaintable() : unit =
        this.fontDebugFactory <- FontDebugFactory.getInstance()
        this.basicSetColorUtil <- BasicColorSetUtil.getInstance()
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.basicColor <- BasicColorFactory.getInstance().BLACK
        this.lineYOffsetArray <- NullUtil.getInstance().NULL_INT_ARRAY
        this.hasChanged <- true
        this.anchor <- Anchor.TOP_LEFT
        this.BEGIN_LEVEL <- "Begin Level "
        this.EMPTY_STRING <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new (gameCanvas: AllBinaryGameCanvas, stringArray: string[], basicColor: BasicColor, font: Font) as this =
        { inherit InitUpdatePaintable() }
        then
            this.jfields_StartIntermissionPaintable()
            this.jctor1(gameCanvas, stringArray, basicColor, font)
    member this.jctor1(gameCanvas: AllBinaryGameCanvas, stringArray: string[], basicColor: BasicColor, font: Font) : unit =
        this.gameCanvas <- gameCanvas
        this.stringArray <- stringArray
        this.lastWidth <- (Array.zeroCreate<int> (this.stringArray.Length))
        this.setBasicColorP(basicColor)
        this.color <- basicColor.intValue()
        this.fontSize <- font.getSize()
        this.font <- font
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.fontHeightP <- font.getHeight()
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable existingFont : Font = graphics.getFont()
        this.fontDebugFactory.setFont(this.font, graphics)
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        this.basicSetColorUtil.setBasicColorP3(graphics, this.basicColor, this.color)
        let mutable beginWidth : int = 0
        let mutable index : int = this.lineYOffsetArray.Length - 1
        while index >= 0 do
            if this.hasChanged then
                this.lastWidth.[index] <- (graphics.getFont().stringWidth(this.stringArray.[index]) >>> 1)
            beginWidth <- this.lastWidth.[index]
            graphics.drawString(this.stringArray.[index], (displayInfo.getLastHalfWidth() - beginWidth), (displayInfo.getLastHalfHeight() - this.lineYOffsetArray.[index]), this.anchor)
            index <- index - 1
        this.hasChanged <- false
        this.fontDebugFactory.setFont(existingFont, graphics)
    
    override this.update() : unit =
        let mutable level : int = this.gameCanvas.getLayerManager().getGameInfo().getCurrentLevel()
        this.stringArray.[0] <- (new StringMaker()).append(this.BEGIN_LEVEL).appendint(level).ToString()
        let mutable index : int = this.stringArray.Length - 1
        while index >= 1 do
            this.stringArray.[index] <- this.EMPTY_STRING
            index <- index - 1
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
    
    abstract getBasicColorP : unit -> BasicColor
    default this.getBasicColorP() : BasicColor =
        this.basicColor
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


