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
type AdjustedVectorAnimation =
    inherit VectorAnimation
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AdjustedVectorAnimation.jclinitDone then
            AdjustedVectorAnimation.jclinitDone <- true
            AdjustedVectorAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (currentPoints: int[][][], basicColor: BasicColor, dx: int, dy: int, animationBehavior: AnimationBehavior) as this =
        { inherit VectorAnimation(currentPoints, basicColor, animationBehavior) }
        then
            this.jctor1(currentPoints, basicColor, dx, dy, animationBehavior)
    member this.jctor1(currentPoints: int[][][], basicColor: BasicColor, dx: int, dy: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.dx <- dx
        this.dy <- dy
        ()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        base.paintXY(graphics, (x + this.dx), (y + this.dy))


