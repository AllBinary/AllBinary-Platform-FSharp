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
type AnimationCompositePaintable =
    inherit InitUpdatePaintable
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnimationCompositePaintable.jclinitDone then
            AnimationCompositePaintable.jclinitDone <- true
            AnimationCompositePaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (animationInterface: Animation) as this =
        { inherit InitUpdatePaintable() }
        then
            this.jctor1(animationInterface)
    member this.jctor1(animationInterface: Animation) : unit =
        this.animationInterface <- animationInterface
        ()
    
    override this.paint(graphics: Graphics) : unit =
        this.animationInterface.paintXY(graphics, 0, 0)
    
    override this.paintThreed(graphics: Graphics) : unit =
        this.animationInterface.paintThreedXYZ(graphics, 0, 0, 0)


