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
type ScoreableAddOnlyForHud =
    inherit Scoreable
    [<DefaultValue(false)>] val mutable scoreHudWidget : ScoreHudWidget
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScoreableAddOnlyForHud.jclinitDone then
            ScoreableAddOnlyForHud.jclinitDone <- true
            ScoreableAddOnlyForHud.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (scoreVectorGraphic: ScoreHudWidget) as this =
        { inherit Scoreable(0) }
        then
            this.jctor1(scoreVectorGraphic)
    member this.jctor1(scoreVectorGraphic: ScoreHudWidget) : unit =
        ()
        this.scoreHudWidget <- scoreVectorGraphic
        this.getScoreHudWidget().set(0)
        ()
    
    override this.removePoints(points: int) : unit =
        ()
    
    override this.addPoints(points: int) : unit =
        base.addPoints(points)
        this.getScoreHudWidget().add(points)
    
    abstract getScoreHudWidget : unit -> ScoreHudWidget
    default this.getScoreHudWidget() : ScoreHudWidget =
        this.scoreHudWidget


