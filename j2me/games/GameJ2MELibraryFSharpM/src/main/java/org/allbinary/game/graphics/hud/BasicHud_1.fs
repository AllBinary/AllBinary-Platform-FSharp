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
type BasicHud_1 =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable canvasStrings : CanvasStrings
    [<DefaultValue(false)>] val mutable basicSetColorUtil : BasicColorSetUtil
    [<DefaultValue(false)>] val mutable displayInfo : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable location : int
    [<DefaultValue(false)>] val mutable direction : int
    [<DefaultValue(false)>] val mutable bufferZone : int
    [<DefaultValue(false)>] val mutable hudGraphicsPosition : HudGraphicsPosition
    [<DefaultValue(false)>] val mutable x : int
    [<DefaultValue(false)>] val mutable y : int
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable color : int
    [<DefaultValue(false)>] val mutable updateMaxWidth : int
    [<DefaultValue(false)>] val mutable updateMaxHeight : int
    [<DefaultValue(false)>] val mutable offsetY : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicHud_1.jclinitDone then
            BasicHud_1.jclinitDone <- true
            BasicHud_1.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicHud_1() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.canvasStrings <- CanvasStrings.getInstance()
        this.basicSetColorUtil <- BasicColorSetUtil.getInstance()
        this.displayInfo <- DisplayInfoSingleton.getInstance()
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.hudGraphicsPosition <- HudGraphicsPosition.NULL_HUD_GRAPHICS_POSITION
        this.basicColor <- BasicColorFactory.getInstance().BLACK
        ()
    
    new (location: int, direction: int, bufferZone: int, basicColor: BasicColor) as this =
        {  }
        then
            this.jfields_BasicHud_1()
            this.jctor1(location, direction, bufferZone, basicColor)
    member this.jctor1(location: int, direction: int, bufferZone: int, basicColor: BasicColor) : unit =
        this.setLocation(location)
        this.setDirection(direction)
        this.setBufferZone(bufferZone)
        this.onDisplayChangeEvent(DisplayInfoSingleton.getInstance().displayChangeEvent)
        this.setBasicColorP(basicColor)
        this.color <- basicColor.intValue()
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        try
            this.hudGraphicsPosition <- this.getHudGraphicsPositionWH(this.displayInfo.getLastWidth(), this.displayInfo.getLastHeight(), this.updateMaxWidth, this.updateMaxHeight)
            this.x <- this.hudGraphicsPosition.getPoint().getX()
            this.setY(this.hudGraphicsPosition.getPoint().getY())
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, this.canvasStrings.ON_DISPLAY_CHANGE_EVENT, e)
            | _ -> reraise ()
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract getLocation : unit -> int
    default this.getLocation() : int =
        this.location
    
    abstract getDirection : unit -> int
    default this.getDirection() : int =
        this.direction
    
    abstract getHudGraphicsPositionWH : width: int * height: int * maxWidth: int * maxHeight: int -> HudGraphicsPosition
    default this.getHudGraphicsPositionWH(width: int, height: int, maxWidth: int, maxHeight: int) : HudGraphicsPosition =
        let mutable x : int = 0
        let mutable y : int = 0
        let mutable anchor : int = 0
        let mutable basicHudFactory : BasicHudFactory = BasicHudFactory.getInstance()
        if basicHudFactory.BOTTOMLEFT = this.getLocation() then
            x <- this.bufferZone + 2
            y <- (height - maxHeight) - this.bufferZone
            anchor <- Graphics.BOTTOM &&& Graphics.LEFT
        elif basicHudFactory.BOTTOMRIGHT = this.getLocation() then
            x <- width - maxWidth
            y <- (height - maxHeight) - this.bufferZone
            anchor <- Graphics.BOTTOM &&& Graphics.RIGHT
        elif basicHudFactory.TOPLEFT = this.getLocation() then
            x <- this.bufferZone + 2
            y <- this.bufferZone + 5
            anchor <- Anchor.TOP_LEFT
        elif basicHudFactory.TOPRIGHT = this.getLocation() then
            x <- width - maxWidth
            y <- this.bufferZone + 5
            anchor <- Graphics.TOP &&& Graphics.RIGHT
        elif basicHudFactory.TOPCENTER = this.getLocation() then
            x <- ((width - maxWidth) / 2)
            y <- this.bufferZone + 5
            anchor <- Graphics.TOP &&& Graphics.HCENTER
        elif basicHudFactory.BOTTOMCENTER = this.getLocation() then
            x <- ((width - maxWidth) / 2)
            y <- (height - maxHeight) - this.bufferZone
            anchor <- Graphics.BOTTOM &&& Graphics.HCENTER
        elif basicHudFactory.ABSOLUTE = this.getLocation() then
            x <- maxHeight
            y <- maxWidth
            anchor <- 0
        (new HudGraphicsPosition(this.getPoint(x, y), anchor))
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract onDisplayChangeEvent : displayChangeEvent: DisplayChangeEvent -> unit
    default this.onDisplayChangeEvent(displayChangeEvent: DisplayChangeEvent) : unit =
        this.myFontProcessor <- this.updateMyFontProcessor
    
    abstract getPoint : x: int * y: int -> GPoint
    default this.getPoint(x: int, y: int) : GPoint =
        PointFactory.getInstance().createXY(x, y)
    
    abstract getBufferZone : unit -> int
    default this.getBufferZone() : int =
        this.bufferZone
    
    abstract setBufferZone : bufferZone: int -> unit
    default this.setBufferZone(bufferZone: int) : unit =
        this.bufferZone <- bufferZone
    
    abstract setLocation : location: int -> unit
    default this.setLocation(location: int) : unit =
        this.location <- location
    
    abstract setDirection : direction: int -> unit
    default this.setDirection(direction: int) : unit =
        this.direction <- direction
    
    abstract getHudGraphicsPosition : unit -> HudGraphicsPosition
    default this.getHudGraphicsPosition() : HudGraphicsPosition =
        this.hudGraphicsPosition
    
    abstract getColor : unit -> int
    default this.getColor() : int =
        this.color
    
    abstract getX : unit -> int
    default this.getX() : int =
        this.x
    
    abstract setX : x: int -> unit
    default this.setX(x: int) : unit =
        this.x <- x
    
    abstract setBasicColorP : basicColor: BasicColor -> unit
    default this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
    
    abstract getBasicColorP : unit -> BasicColor
    default this.getBasicColorP() : BasicColor =
        this.basicColor
    
    abstract setY : y: int -> unit
    default this.setY(y: int) : unit =
        this.y <- y
    
    abstract getY : unit -> int
    default this.getY() : int =
        this.y
    
    abstract paintSSO : graphics: Graphics * string_: string * string2: string * offset: int -> unit
    default this.paintSSO(graphics: Graphics, string_: string, string2: string, offset: int) : unit =
        this.myFontProcessor.process_(graphics)
        this.basicSetColorUtil.setBasicColorP(graphics, this.getBasicColorP())
        graphics.drawString(string_, this.x, this.getY(), this.hudGraphicsPosition.getAnchor())
        graphics.drawString(string2, (this.x + offset), this.getY(), this.hudGraphicsPosition.getAnchor())
    
    abstract paintSSOO : graphics: Graphics * string_: string * string2: string * offset: int * offset2: int -> unit
    default this.paintSSOO(graphics: Graphics, string_: string, string2: string, offset: int, offset2: int) : unit =
        this.myFontProcessor.process_(graphics)
        graphics.setColor(this.getColor())
        graphics.drawString(string_, (this.x + offset), this.getY(), this.hudGraphicsPosition.getAnchor())
        graphics.drawString(string2, (this.x + offset2), this.getY(), this.hudGraphicsPosition.getAnchor())
    
    abstract paintDXY : graphics: Graphics * charArray: char[] * offset: int * len: int * charArray2: char[] * offset2: int * len2: int * xOffset: int * xOffset2: int -> unit
    default this.paintDXY(graphics: Graphics, charArray: char[], offset: int, len: int, charArray2: char[], offset2: int, len2: int, xOffset: int, xOffset2: int) : unit =
        this.myFontProcessor.process_(graphics)
        this.basicSetColorUtil.setBasicColorP(graphics, this.getBasicColorP())
        let mutable y : int = this.getY()
        graphics.drawChars(charArray, offset, len, (this.x + xOffset), y, this.hudGraphicsPosition.getAnchor())
        graphics.drawChars(charArray2, offset2, len2, (this.x + xOffset2), y, this.hudGraphicsPosition.getAnchor())
    
    abstract paintDX : graphics: Graphics * charArray: char[] * offset: int * len: int * charArray2: char[] * offset2: int * len2: int * xOffset: int -> unit
    default this.paintDX(graphics: Graphics, charArray: char[], offset: int, len: int, charArray2: char[], offset2: int, len2: int, xOffset: int) : unit =
        this.myFontProcessor.process_(graphics)
        this.basicSetColorUtil.setBasicColorP(graphics, this.getBasicColorP())
        let mutable y : int = this.getY()
        graphics.drawChars(charArray, offset, len, this.x, y, this.hudGraphicsPosition.getAnchor())
        graphics.drawChars(charArray2, offset2, len2, (this.x + xOffset), y, this.hudGraphicsPosition.getAnchor())
    
    abstract paintOffsetAndLength : graphics: Graphics * charArray: char[] * offset: int * len: int -> unit
    default this.paintOffsetAndLength(graphics: Graphics, charArray: char[], offset: int, len: int) : unit =
        this.myFontProcessor.process_(graphics)
        this.basicSetColorUtil.setBasicColorP(graphics, this.getBasicColorP())
        let mutable y : int = this.getY()
        graphics.drawChars(charArray, offset, len, this.x, y, this.hudGraphicsPosition.getAnchor())
    
    abstract paintString : graphics: Graphics * string_: string -> unit
    default this.paintString(graphics: Graphics, string_: string) : unit =
        this.myFontProcessor.process_(graphics)
        this.basicSetColorUtil.setBasicColorP(graphics, this.getBasicColorP())
        let mutable y : int = this.getY() + this.offsetY
        graphics.drawString(string_, this.x, y, this.hudGraphicsPosition.getAnchor())
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


