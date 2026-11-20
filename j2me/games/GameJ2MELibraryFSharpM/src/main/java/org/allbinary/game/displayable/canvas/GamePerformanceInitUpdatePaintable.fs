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
type GamePerformanceInitUpdatePaintable =
    inherit InitUpdatePaintable
    [<DefaultValue(false)>] val mutable halfHeight : int
    [<DefaultValue(false)>] val mutable yArray : int[]
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable baseRefreshHelperCharArray : char[][]
    [<DefaultValue(false)>] val mutable defaultStringWidth : int
    [<DefaultValue(false)>] val mutable RED : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GamePerformanceInitUpdatePaintable.jclinitDone then
            GamePerformanceInitUpdatePaintable.jclinitDone <- true
            GamePerformanceInitUpdatePaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit InitUpdatePaintable() }
        then
            this.jfields_GamePerformanceInitUpdatePaintable()
    member this.jfields_GamePerformanceInitUpdatePaintable() : unit =
        this.halfHeight <- DisplayInfoSingleton.getInstance().getLastHalfHeight()
        this.yArray <- ([| this.halfHeight + 30; this.halfHeight + 30; (this.halfHeight + 30) + 15; (this.halfHeight + 30) + 15; (this.halfHeight + 30) + 30; (this.halfHeight + 30) + 30; (this.halfHeight + 30) + 45; (this.halfHeight + 30) + 45 |] : int[])
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.baseRefreshHelperCharArray <- (JR.newArray2<char>(0, 0))
        this.RED <- BasicColorFactory.getInstance().RED.intValue()
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.defaultStringWidth <- MyFontProcessor.defaultStringWidth(font, 2)
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    override this.init() : unit =
        ()
    
    override this.update() : unit =
        this.baseRefreshHelperCharArray <- GameStatisticsFactory.getInstance().to2DCharArray()
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        graphics.setColor(this.RED)
        let mutable charArray : char[] = null
        let mutable charArray2 : char[] = null
        let mutable size2 : int = 0
        let mutable size3 : int = 0
        let mutable size : int = this.baseRefreshHelperCharArray.Length - 2
        let mutable index : int = size
        while index >= 0 do
            charArray <- this.baseRefreshHelperCharArray.[index]
            charArray2 <- this.baseRefreshHelperCharArray.[index + 1]
            size2 <- charArray.Length
            size3 <- charArray2.Length
            graphics.drawChars(charArray, 0, size2, 0, this.yArray.[index], 0)
            graphics.drawChars(charArray2, 0, size3, (size2 * this.defaultStringWidth), this.yArray.[index + 1], 0)
            index <- index - 2
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


