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
type AllBinaryVisualDebugVibration =
    inherit AllBinaryVibrationME
    [<DefaultValue(false)>] val mutable displayInfoSingleton : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable timeDelayHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable VIBRATING : string
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable width : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryVisualDebugVibration.jclinitDone then
            AllBinaryVisualDebugVibration.jclinitDone <- true
            AllBinaryVisualDebugVibration.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit AllBinaryVibrationME() }
        then
            this.jfields_AllBinaryVisualDebugVibration()
    member this.jfields_AllBinaryVisualDebugVibration() : unit =
        this.displayInfoSingleton <- DisplayInfoSingleton.getInstance()
        this.timeDelayHelper <- (new TimeDelayHelper(Integer.MAX_VALUE))
        this.VIBRATING <- "Vibrating"
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.width <- font.stringWidth(this.VIBRATING)
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    override this.vibrate(duration: int, type_: int, volume: int) : unit =
        this.timeDelayHelper.delay <- duration
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        if this.timeDelayHelper.isTimeTNT() then
            this.timeDelayHelper.delay <- Integer.MAX_VALUE
            this.myFontProcessor.process_(graphics)
            graphics.drawString(this.VIBRATING, (this.displayInfoSingleton.getLastHalfWidth() - (this.width >>> 1)), 0, this.anchor)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


