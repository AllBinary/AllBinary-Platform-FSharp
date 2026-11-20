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
type AllBinaryAdjustedSpriteRotationAnimation =
    inherit AllBinarySpriteRotationAnimation
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryAdjustedSpriteRotationAnimation.jclinitDone then
            AllBinaryAdjustedSpriteRotationAnimation.jclinitDone <- true
            AllBinaryAdjustedSpriteRotationAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (sprite: Sprite, image: Image, dx: int, dy: int, animationBehavior: AnimationBehavior) as this =
        { inherit AllBinarySpriteRotationAnimation(sprite, image, animationBehavior) }
        then
            this.jctor1(sprite, image, dx, dy, animationBehavior)
    member this.jctor1(sprite: Sprite, image: Image, dx: int, dy: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.dx <- dx
        this.dy <- dy
        ()
    
    override this.paintXY(g: Graphics, x: int, y: int) : unit =
        this.sprite.setPosition((x + this.dx), (y + this.dy))
        this.paint(g)


