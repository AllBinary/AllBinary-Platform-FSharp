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
type ColorTemperatureUtil =
    [<DefaultValue(false)>] val mutable basicColorFactory : BasicColorFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : ColorTemperatureUtil
    static member instance with get() : ColorTemperatureUtil = (ColorTemperatureUtil.jclinit(); ColorTemperatureUtil.jcell_instance) and set (jvalue: ColorTemperatureUtil) = (ColorTemperatureUtil.jclinit(); ColorTemperatureUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ColorTemperatureUtil.jclinitDone then
            ColorTemperatureUtil.jclinitDone <- true
            ColorTemperatureUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ColorTemperatureUtil.jcell_instance <- (new ColorTemperatureUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_ColorTemperatureUtil()
    member this.jfields_ColorTemperatureUtil() : unit =
        this.basicColorFactory <- BasicColorFactory.getInstance()
        ()
    
    static member getInstance() : ColorTemperatureUtil =
        ColorTemperatureUtil.instance
    
    abstract getBasicColor : thirdTemp: int -> BasicColor
    default this.getBasicColor(thirdTemp: int) : BasicColor =
        let mutable basicColor : BasicColor = this.basicColorFactory.RED
        if thirdTemp > 3700 then
            basicColor <- this.basicColorFactory.PURPLE
        elif thirdTemp > 3200 then
            basicColor <- this.basicColorFactory.BLUE
        elif thirdTemp > 2700 then
            basicColor <- this.basicColorFactory.PUCE
        elif thirdTemp > 2200 then
            basicColor <- this.basicColorFactory.WHITE
        elif thirdTemp > 1700 then
            basicColor <- this.basicColorFactory.GREEN
        elif thirdTemp > 1200 then
            basicColor <- this.basicColorFactory.YELLOW
        elif thirdTemp > 700 then
            basicColor <- this.basicColorFactory.ORANGE
        basicColor


