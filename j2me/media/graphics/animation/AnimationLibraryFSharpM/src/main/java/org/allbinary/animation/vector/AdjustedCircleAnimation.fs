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
type AdjustedCircleAnimation =
    inherit CircleAnimation
    [<DefaultValue(false)>] val mutable xAdjustment : int
    [<DefaultValue(false)>] val mutable yAdjustment : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AdjustedCircleAnimation.jclinitDone then
            AdjustedCircleAnimation.jclinitDone <- true
            AdjustedCircleAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createAnimation(width: int, height: int, xAdjustment: int, yAdjustment: int, basicColor: BasicColor) : AdjustedCircleAnimation =
        let mutable adjustedCircleAnimation : AdjustedCircleAnimation = (new AdjustedCircleAnimation(width, height, basicColor))
        adjustedCircleAnimation.initXY(xAdjustment, yAdjustment)
        adjustedCircleAnimation
    
    static member createW(width: int, height: int, innerWidth: int, basicColor: BasicColor) : AdjustedCircleAnimation =
        let mutable adjustedCircleAnimation : AdjustedCircleAnimation = (new AdjustedCircleAnimation(width, height, basicColor))
        adjustedCircleAnimation.init(innerWidth)
        adjustedCircleAnimation
    
    new (width: int, height: int, basicColor: BasicColor) =
        { inherit CircleAnimation(width, height, basicColor) }
    
    member this.initXY(xAdjustment: int, yAdjustment: int) : unit =
        this.xAdjustment <- xAdjustment
        this.yAdjustment <- yAdjustment
    
    member this.init(innerWidth: int) : unit =
        if AndroidUtil.isAndroid() then
            let mutable widthPortion : int = (((innerWidth / 3) * 10) / 7)
            this.xAdjustment <- -(((this.width >>> 1) - widthPortion))
            this.yAdjustment <- this.xAdjustment
        else
            this.xAdjustment <- -(((this.width >>> 1) - innerWidth))
            this.yAdjustment <- this.xAdjustment
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.basicSetColorUtil.setBasicColorP3(graphics, this.getBasicColorP(), this.getColor())
        graphics.drawArc((x + this.xAdjustment), (y + this.yAdjustment), this.width, this.height, 0, this.TOTAL_ANGLE)


