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
type FullTouchButton =
    inherit TouchButton
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FullTouchButton.jclinitDone then
            FullTouchButton.jclinitDone <- true
            FullTouchButton.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createButton(touchButtonInput: TouchButtonInput, touchButtonResource: TouchButtonResource, rawRectangle: Rectangle, cellPosition: CellPosition, xBorder: int, yBorder: int) : FullTouchButton =
        (new FullTouchButton(touchButtonInput, FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(touchButtonResource.RESOURCE).getInstance(0), FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(touchButtonResource.HINT).getInstance(0), rawRectangle, cellPosition, xBorder, yBorder))
    
    new (touchButtonInput: TouchButtonInput, animationInterface: Animation, hintAnimationInterface: Animation, rawRectangle: Rectangle, cellPosition: CellPosition, xBorder: int, yBorder: int) =
        { inherit TouchButton(touchButtonInput, animationInterface, hintAnimationInterface, rawRectangle, cellPosition, xBorder, yBorder) }
    
    override this.updateRectangle() : unit =
        try
            let mutable pointFactory : PointFactory = PointFactory.getInstance()
            let mutable x : int = this.rawRectangle.getWidth() * this.cellPositionP.getColumn()
            let mutable y : int = this.rawRectangle.getHeight() * this.cellPositionP.getRow()
            this.rectangleP <- (new Rectangle(pointFactory.createXY(x, y), (this.rawRectangle.getWidth() + (2 * this.xBorder)), (this.rawRectangle.getHeight() + (2 * this.yBorder))))
            let mutable point : GPoint = this.rectangleP.getPoint()
            this.animationX <- point.getX() + this.xBorder
            this.animationY <- point.getY() + this.yBorder
            this.hintAnimationY <- (this.animationY - this.rectangleP.getHeight()) >>> 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "updateRectangle", e)
            | _ -> reraise ()


