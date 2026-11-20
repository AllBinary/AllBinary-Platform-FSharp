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
type RectangleFilledAnimation =
    inherit Animation
    [<DefaultValue(false)>] val mutable widthP : int
    [<DefaultValue(false)>] val mutable heightP : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RectangleFilledAnimation.jclinitDone then
            RectangleFilledAnimation.jclinitDone <- true
            RectangleFilledAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (width: int, height: int, basicColor: BasicColor) as this =
        { inherit Animation() }
        then
            this.jctor1(width, height, basicColor)
    member this.jctor1(width: int, height: int, basicColor: BasicColor) : unit =
        this.widthP <- width
        this.heightP <- height
        this.setBasicColorP(basicColor)
        ()
    
    override this.nextFrame() : unit =
        ()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.basicSetColorUtil.setBasicColorP3(graphics, this.getBasicColorP(), this.getColor())
        graphics.fillRect(x, y, this.widthP, this.heightP)
    
    abstract setWidth : width: int -> unit
    default this.setWidth(width: int) : unit =
        this.widthP <- width
    
    abstract setHeight : height: int -> unit
    default this.setHeight(height: int) : unit =
        this.heightP <- height
    
    override this.getBasicColorP() : BasicColor =
        base.getBasicColorP()
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        base.setBasicColorP(basicColor)
    interface ColorCompositeInterface with
        member this.getBasicColorP() : BasicColor = this.getBasicColorP()
    interface BasicColorCompositeSetterInterface with
        member this.setBasicColorP(jp0: BasicColor) : unit = this.setBasicColorP(jp0)


