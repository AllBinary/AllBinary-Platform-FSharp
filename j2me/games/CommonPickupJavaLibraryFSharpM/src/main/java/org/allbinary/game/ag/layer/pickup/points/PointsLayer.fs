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
type PointsLayer =
    inherit AllBinaryLayer
    [<DefaultValue(false)>] val mutable points : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PointsLayer.jclinitDone then
            PointsLayer.jclinitDone <- true
            PointsLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (points: int) as this =
        { inherit AllBinaryLayer(StringUtil.getInstance().EMPTY_STRING, (new Rectangle(PointFactory.getInstance().ZERO_ZERO, 0, 0)), ViewPosition.getInstanceD()) }
        then
            this.jctor1(points)
    member this.jctor1(points: int) : unit =
        ()
        this.points <- points
        ()
    
    override this.paint(graphics: Graphics) : unit =
        ()
    
    abstract visit : scoreableInterface: ScoreableInterface -> unit
    default this.visit(scoreableInterface: ScoreableInterface) : unit =
        scoreableInterface.addPoints(this.points)


