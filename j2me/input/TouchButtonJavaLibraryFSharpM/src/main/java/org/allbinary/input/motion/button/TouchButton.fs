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
type TouchButton =
    inherit Paintable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable touchButtonInput : TouchButtonInput
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] val mutable hintAnimationInterface : Animation
    [<DefaultValue(false)>] val mutable rawRectangle : Rectangle
    [<DefaultValue(false)>] val mutable xBorder : int
    [<DefaultValue(false)>] val mutable yBorder : int
    [<DefaultValue(false)>] val mutable rectangleP : Rectangle
    [<DefaultValue(false)>] val mutable cellPositionP : CellPosition
    [<DefaultValue(false)>] val mutable animationX : int
    [<DefaultValue(false)>] val mutable animationY : int
    [<DefaultValue(false)>] val mutable hintAnimationY : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButton.jclinitDone then
            TouchButton.jclinitDone <- true
            TouchButton.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TouchButton() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.rectangleP <- RectangleFactory.SINGLETON
        ()
    
    static member createButton(touchButtonInput: TouchButtonInput, touchButtonResource: TouchButtonResource, rawRectangle: Rectangle, cellPosition: CellPosition, xBorder: int, yBorder: int) : TouchButton =
        (new TouchButton(touchButtonInput, FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(touchButtonResource.RESOURCE).getInstance(0), FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(touchButtonResource.HINT).getInstance(0), rawRectangle, cellPosition, xBorder, yBorder))
    
    new (touchButtonInput: TouchButtonInput, animationInterface: Animation, hintAnimationInterface: Animation, rawRectangle: Rectangle, cellPosition: CellPosition, xBorder: int, yBorder: int) as this =
        { inherit Paintable() }
        then
            this.jfields_TouchButton()
            this.jctor1(touchButtonInput, animationInterface, hintAnimationInterface, rawRectangle, cellPosition, xBorder, yBorder)
    member this.jctor1(touchButtonInput: TouchButtonInput, animationInterface: Animation, hintAnimationInterface: Animation, rawRectangle: Rectangle, cellPosition: CellPosition, xBorder: int, yBorder: int) : unit =
        this.touchButtonInput <- touchButtonInput
        this.animationInterface <- animationInterface
        this.hintAnimationInterface <- hintAnimationInterface
        this.rawRectangle <- rawRectangle
        this.cellPositionP <- cellPosition
        this.xBorder <- xBorder
        this.yBorder <- yBorder
        this.updateRectangle()
        this.logUtil.putF((new StringMaker()).append("Created: ").append(this.ToString()).ToString(), this, this.commonStrings.CONSTRUCTOR)
        ()
    
    abstract paintHint : graphics: Graphics -> unit
    default this.paintHint(graphics: Graphics) : unit =
        this.hintAnimationInterface.paintXY(graphics, this.animationX, this.hintAnimationY)
    
    override this.paint(graphics: Graphics) : unit =
        this.animationInterface.paintXY(graphics, this.animationX, this.animationY)
    
    abstract updateRectangle : unit -> unit
    default this.updateRectangle() : unit =
        try
            let mutable pointFactory : PointFactory = PointFactory.getInstance()
            let mutable x : int = this.rawRectangle.getWidth() * this.cellPositionP.getColumn()
            let mutable y : int = this.rawRectangle.getHeight() * this.cellPositionP.getRow()
            this.rectangleP <- (new Rectangle(pointFactory.createXY((x + this.xBorder), (y + this.yBorder)), this.rawRectangle.getWidth(), this.rawRectangle.getHeight()))
            let mutable point : GPoint = this.rectangleP.getPoint()
            this.animationX <- point.getX()
            this.animationY <- point.getY()
            this.hintAnimationY <- this.animationY - 32
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, "updateRectangle", e)
            | _ -> reraise ()
    
    abstract getCellPosition : unit -> CellPosition
    default this.getCellPosition() : CellPosition =
        this.cellPositionP
    
    abstract getRectangle : unit -> Rectangle
    default this.getRectangle() : Rectangle =
        this.rectangleP
    
    abstract getTouchButtonInput : unit -> TouchButtonInput
    default this.getTouchButtonInput() : TouchButtonInput =
        this.touchButtonInput
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable stringUtil : StringUtil = StringUtil.getInstance()
        ignore (stringBuffer.append("TouchButton: "))
        ignore (stringBuffer.append(stringUtil.toString(this.getRectangle())))
        ignore (stringBuffer.append(" CellPosition: "))
        ignore (stringBuffer.append(stringUtil.toString(this.cellPositionP)))
        ignore (stringBuffer.append(" xBorder: "))
        ignore (stringBuffer.appendint(this.xBorder))
        ignore (stringBuffer.append(" yBorder: "))
        ignore (stringBuffer.appendint(this.yBorder))
        stringBuffer.ToString()


