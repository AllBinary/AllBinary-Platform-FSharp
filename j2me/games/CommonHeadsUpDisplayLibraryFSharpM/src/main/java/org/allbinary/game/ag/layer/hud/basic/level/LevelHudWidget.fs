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
type LevelHudWidget =
    inherit BasicHud
    [<DefaultValue(false)>] val mutable level : int
    [<DefaultValue(false)>] val mutable maxlevel : int
    [<DefaultValue(false)>] val mutable levelString : char[]
    [<DefaultValue(false)>] val mutable levelNumberCharArray : char[]
    [<DefaultValue(false)>] val mutable levelNumberTotalDigits : int
    [<DefaultValue(false)>] val mutable offset : int
    [<DefaultValue(false)>] val mutable primitiveLongUtil : PrimitiveLongUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LevelHudWidget.jclinitDone then
            LevelHudWidget.jclinitDone <- true
            LevelHudWidget.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LevelHudWidget() : unit =
        this.levelNumberCharArray <- NullUtil.getInstance().NULL_CHAR_ARRAY
        ()
    
    static member createHud(maxlevel: int, location: int, direction: int) : LevelHudWidget =
        (new LevelHudWidget(maxlevel, location, direction))
    
    new (maxlevel: int, location: int, direction: int) as this =
        { inherit BasicHud(location, direction, 2, BasicColorFactory.getInstance().GREY) }
        then
            this.jfields_LevelHudWidget()
            this.jctor1(maxlevel, location, direction)
    member this.jctor1(maxlevel: int, location: int, direction: int) : unit =
        ()
        this.primitiveLongUtil <- PrimitiveLongUtil.createPowerOfTen(1000)
        let mutable LEVEL : string = "Lv "
        this.levelString <- JString.toCharArray(LEVEL)
        this.maxlevel <- maxlevel
        this.level <- maxlevel
        this.update()
        this.updateMaxHeight <- 14
        ()
    
    override this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.updateMaxWidth <- font.getSize() * 4
        this.offset <- font.charsWidth(this.levelString, 0, this.levelString.Length) + font.getSize()
        base.updateMeasurement(graphics)
    
    member this.update() : unit =
        this.levelNumberCharArray <- this.primitiveLongUtil.getCharArray(this.level)
        this.levelNumberTotalDigits <- this.primitiveLongUtil.getCurrentTotalDigits()
    
    abstract setLevel : level: int -> unit
    default this.setLevel(level: int) : unit =
        this.level <- level
        this.update()
    
    abstract nextLevel : unit -> unit
    default this.nextLevel() : unit =
        this.level <- this.level + 1
        this.update()
    
    abstract previousLevel : unit -> unit
    default this.previousLevel() : unit =
        this.level <- this.level - 1
        if this.level < 0 then
            this.level <- 0
        this.update()
    
    abstract isComplete : unit -> bool
    default this.isComplete() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.level <= this.maxlevel then
            jret <- false
            jflow <- 1
        else
            jret <- true
            jflow <- 1
        jret
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        base.paintDX(graphics, this.levelString, 0, this.levelString.Length, this.levelNumberCharArray, 0, this.levelNumberTotalDigits, this.offset)
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)


