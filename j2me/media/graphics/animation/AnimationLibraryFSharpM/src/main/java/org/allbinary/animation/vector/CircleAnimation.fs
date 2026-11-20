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
type CircleAnimation =
    inherit Animation
    [<DefaultValue(false)>] val mutable TOTAL_ANGLE : int
    [<DefaultValue(false)>] val mutable width : int
    [<DefaultValue(false)>] val mutable height : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CircleAnimation.jclinitDone then
            CircleAnimation.jclinitDone <- true
            CircleAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CircleAnimation() : unit =
        this.TOTAL_ANGLE <- int (AngleFactory.getInstance().TOTAL_ANGLE)
        ()
    
    new (width: int, height: int, basicColor: BasicColor) as this =
        { inherit Animation() }
        then
            this.jfields_CircleAnimation()
            this.jctor1(width, height, basicColor)
    member this.jctor1(width: int, height: int, basicColor: BasicColor) : unit =
        this.width <- width
        this.height <- height
        this.setBasicColorP(basicColor)
        ()
    
    override this.nextFrame() : unit =
        ()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.basicSetColorUtil.setBasicColorP3(graphics, this.getBasicColorP(), this.getColor())
        graphics.drawArc(x, y, this.width, this.height, 0, this.TOTAL_ANGLE)
    
    override this.getBasicColorP() : BasicColor =
        base.getBasicColorP()
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        base.setBasicColorP(basicColor)
    interface ColorCompositeInterface with
        member this.getBasicColorP() : BasicColor = this.getBasicColorP()
    interface BasicColorCompositeSetterInterface with
        member this.setBasicColorP(jp0: BasicColor) : unit = this.setBasicColorP(jp0)


