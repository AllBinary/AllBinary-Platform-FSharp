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
type TimeHudWidget =
    inherit BasicHud
    [<DefaultValue(false)>] val mutable TIME_STRING : string
    [<DefaultValue(false)>] val mutable TIME_CHAR_ARRAY : char[]
    [<DefaultValue(false)>] val mutable offset : int
    [<DefaultValue(false)>] val mutable string : char[]
    [<DefaultValue(false)>] val mutable totalDigits : int
    [<DefaultValue(false)>] val mutable timer : HudTimer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TimeHudWidget.jclinitDone then
            TimeHudWidget.jclinitDone <- true
            TimeHudWidget.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TimeHudWidget() : unit =
        this.TIME_STRING <- "Time "
        this.TIME_CHAR_ARRAY <- ([| 'T'; 'i'; 'm'; 'e'; ' ' |] : char[])
        this.string <- PrimitiveLongSingleton.getInstance().ZERO
        this.totalDigits <- 1
        ()
    
    static member getInstance(location: int, direction: int, basicColor: BasicColor, timer: HudTimer) : TimeHudWidget =
        (new TimeHudWidget(location, direction, 2, basicColor, timer))
    
    new (location: int, direction: int, bufferZone: int, basicColor: BasicColor, timer: HudTimer) as this =
        { inherit BasicHud(location, direction, bufferZone, basicColor) }
        then
            this.jfields_TimeHudWidget()
            this.jctor1(location, direction, bufferZone, basicColor, timer)
    member this.jctor1(location: int, direction: int, bufferZone: int, basicColor: BasicColor, timer: HudTimer) : unit =
        ()
        this.timer <- timer
        this.set()
        this.updateMaxHeight <- 14
        ()
    
    override this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.updateMaxWidth <- font.getSize() * 5
        this.offset <- font.stringWidth(this.TIME_STRING) + MyFontProcessor.defaultStringWidth(font, 3)
        base.updateMeasurement(graphics)
    
    abstract update : unit -> unit
    default this.update() : unit =
        this.timer.update()
        this.set()
    
    member this.set() : unit =
        this.string <- this.timer.getTimeChars()
        this.totalDigits <- this.timer.getCurrentTotalDigits()
    
    abstract getTimer : unit -> HudTimer
    default this.getTimer() : HudTimer =
        this.timer
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        base.paintDX(graphics, this.TIME_CHAR_ARRAY, 0, this.TIME_CHAR_ARRAY.Length, this.string, 0, this.totalDigits, this.offset)


