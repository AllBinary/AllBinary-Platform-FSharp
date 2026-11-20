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
type AdjustedSpriteIndexedAnimation =
    inherit SpriteIndexedAnimation
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AdjustedSpriteIndexedAnimation.jclinitDone then
            AdjustedSpriteIndexedAnimation.jclinitDone <- true
            AdjustedSpriteIndexedAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (sprite: Sprite, image: Image, basicColorArray: BasicColor[], dx: int, dy: int, animationBehavior: AnimationBehavior) as this =
        { inherit SpriteIndexedAnimation(sprite, image, basicColorArray, animationBehavior) }
        then
            this.jctor1(sprite, image, basicColorArray, dx, dy, animationBehavior)
    member this.jctor1(sprite: Sprite, image: Image, basicColorArray: BasicColor[], dx: int, dy: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.dx <- dx
        this.dy <- dy
        ()
    
    override this.paintFrame(graphics: Graphics, frame: int, x: int, y: int) : unit =
        this.setFrame(frame)
        this.sprite.setPosition((x + this.dx), (y + this.dy))
        base.paint(graphics)
    
    override this.paintXY(g: Graphics, x: int, y: int) : unit =
        this.sprite.setPosition((x + this.dx), (y + this.dy))
        base.paint(g)
    
    override this.paint(g: Graphics) : unit =
        this.sprite.setPosition(this.dx, this.dy)
        base.paint(g)


