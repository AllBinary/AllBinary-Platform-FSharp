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
type HealthBarTwodAnimation =
    inherit HealthBarAnimation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HealthBarTwodAnimation.jclinitDone then
            HealthBarTwodAnimation.jclinitDone <- true
            HealthBarTwodAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (layerInterface: AllBinaryLayer, location: int) =
        { inherit HealthBarAnimation(layerInterface, location) }
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        let mutable ax : int = this.allbinaryLayer.getViewPosition().getX()
        this.basicSetColorUtil.setBasicColorP3(graphics, this.basicColor, this.colorP)
        graphics.fillRect(ax, (this.getY() - 1), this.x2, this.thickness)


