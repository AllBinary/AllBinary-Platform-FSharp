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
type ScoreHudWidget =
    inherit NumberStringHud
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScoreHudWidget.jclinitDone then
            ScoreHudWidget.jclinitDone <- true
            ScoreHudWidget.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member getInstance(maxscore: int, location: int, direction: int) : ScoreHudWidget =
        (new ScoreHudWidget(maxscore, location, direction, 2, BasicColorFactory.getInstance().GREY))
    
    new (maxscore: int, location: int, direction: int, bufferZone: int, basicColor: BasicColor) as this =
        { inherit NumberStringHud("Pts ", maxscore, location, direction, bufferZone, basicColor) }
        then
            this.jctor1(maxscore, location, direction, bufferZone, basicColor)
    member this.jctor1(maxscore: int, location: int, direction: int, bufferZone: int, basicColor: BasicColor) : unit =
        ()
        this.updateMaxHeight <- 14
        ()
    
    override this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.updateMaxWidth <- font.getSize() * 5
        base.updateMeasurement(graphics)


