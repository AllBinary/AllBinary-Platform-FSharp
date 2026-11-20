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
type NumberStringHud =
    inherit BasicHud
    [<DefaultValue(false)>] val mutable primitiveLongUtil : PrimitiveLongUtil
    [<DefaultValue(false)>] val mutable prependString : string
    [<DefaultValue(false)>] val mutable PREPEND_STRING : char[]
    [<DefaultValue(false)>] val mutable value : int
    [<DefaultValue(false)>] val mutable max : int
    [<DefaultValue(false)>] val mutable offset : int
    [<DefaultValue(false)>] val mutable valueString : char[]
    [<DefaultValue(false)>] val mutable valueTotalDigits : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NumberStringHud.jclinitDone then
            NumberStringHud.jclinitDone <- true
            NumberStringHud.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (prependString: string, max_: int, location: int, direction: int, bufferZone: int, basicColor: BasicColor) as this =
        { inherit BasicHud(location, direction, bufferZone, basicColor) }
        then
            this.jctor1(prependString, max_, location, direction, bufferZone, basicColor)
    member this.jctor1(prependString: string, max_: int, location: int, direction: int, bufferZone: int, basicColor: BasicColor) : unit =
        ()
        this.prependString <- prependString
        this.PREPEND_STRING <- JString.toCharArray(prependString)
        this.valueString <- PrimitiveLongSingleton.getInstance().NUMBER_CHAR_ARRAYS.[0]
        this.primitiveLongUtil <- PrimitiveLongUtil.createPowerOfTen((max_ + 1))
        this.max <- max_
        this.value <- 0
        if direction = 0 then
            raise ((new JRuntimeException(BasicHudFactory.getInstance().DIRECTION_EXCEPTION)))
        ()
    
    override this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.offset <- font.stringWidth(this.prependString) + MyFontProcessor.defaultCharWidth(font)
        base.updateMeasurement(graphics)
    
    abstract get : unit -> int
    default this.get() : int =
        this.value
    
    abstract add : value: int -> unit
    default this.add(value: int) : unit =
        this.set((this.value + value))
    
    abstract set : value: int -> unit
    default this.set(value: int) : unit =
        this.value <- value
        if this.value > this.max then
            this.value <- 0
        this.valueString <- this.primitiveLongUtil.getCharArray(this.value)
        this.valueTotalDigits <- this.primitiveLongUtil.getCurrentTotalDigits()
    
    abstract reduce : value: int -> unit
    default this.reduce(value: int) : unit =
        this.set((this.value - value))
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        base.paintDX(graphics, this.PREPEND_STRING, 0, this.PREPEND_STRING.Length, this.valueString, 0, this.valueTotalDigits, this.offset)
    
    abstract paintXY : graphics: Graphics * x: int * y: int -> unit
    default this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable charArray : char[] = this.PREPEND_STRING
        let mutable len : int = this.PREPEND_STRING.Length
        let mutable charArray2 : char[] = this.valueString
        let mutable len2 : int = this.valueTotalDigits
        this.basicSetColorUtil.setBasicColorP(graphics, this.getBasicColorP())
        graphics.drawChars(charArray, 0, len, x, y, 0)
        graphics.drawChars(charArray2, 0, len2, (x - this.offset), y, 0)
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)


