namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type AdjustCustomTextAnimation =
    inherit CustomTextAnimation
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AdjustCustomTextAnimation.jclinitDone then
            AdjustCustomTextAnimation.jclinitDone <- true
            AdjustCustomTextAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (text: string, fontSize: int, dx: int, dy: int, animationBehavior: AnimationBehavior) as this =
        { inherit CustomTextAnimation(text, fontSize, animationBehavior) }
        then
            this.jctor1(text, fontSize, dx, dy, animationBehavior)
    member this.jctor1(text: string, fontSize: int, dx: int, dy: int, animationBehavior: AnimationBehavior) : unit =
        ()
        this.dx <- dx
        this.dy <- dy
        ()
    
    override this.getDx() : int =
        this.dx
    
    override this.setDx(dx: int) : unit =
        this.dx <- dx
    
    override this.getDy() : int =
        this.dy
    
    override this.setDy(dy: int) : unit =
        this.dy <- dy
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        base.paintXY(graphics, (x + this.dx), (y + this.dy))


