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
type BasicPopupMenuPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable basicSetColorUtil : BasicColorSetUtil
    [<DefaultValue(false)>] val mutable drawStringUtil : DrawVerticalStringUtil
    [<DefaultValue(false)>] val mutable label : string
    [<DefaultValue(false)>] val mutable foregroundBasicColor : BasicColor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable rectangle : Rectangle
    [<DefaultValue(false)>] val mutable BORDER : int
    [<DefaultValue(false)>] val mutable heightOffset : int
    [<DefaultValue(false)>] val mutable offset : int
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    static member NAME : string = "MENU"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicPopupMenuPaintable.jclinitDone then
            BasicPopupMenuPaintable.jclinitDone <- true
            BasicPopupMenuPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicPopupMenuPaintable() : unit =
        this.basicSetColorUtil <- BasicColorSetUtil.getInstance()
        this.drawStringUtil <- DrawVerticalStringUtil.getInstance()
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        ()
    
    new (rectangle: Rectangle, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit Paintable() }
        then
            this.jfields_BasicPopupMenuPaintable()
            this.jctor1(rectangle, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(rectangle: Rectangle, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        this.foregroundBasicColor <- foregroundBasicColor
        this.label <- BasicPopupMenuPaintable.NAME
        this.rectangle <- rectangle
        if J2MEUtil.isJ2ME() || J2MEUtil.isHTML() then
            this.animationInterface <- NullAnimationFactory.getFactoryInstance().getInstance(0)
        else
            this.animationInterface <- (new RectangleFilledAnimation(this.rectangle.getWidth(), this.rectangle.getHeight(), BasicColorFactory.getInstance().TRANSPARENT_GREY))
        this.init(rectangle)
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        let mutable features : Features = Features.getInstance()
        let mutable isOpenGL : bool = features.isDefault(OpenGLFeatureFactory.getInstance().OPENGL)
        this.drawStringUtil.updateMeasurement(graphics, this.label)
        let mutable BORDER : int = 0
        if J2MEUtil.isHTML() || isOpenGL then
            BORDER <- MyFontProcessor.defaultCharWidth(font) / 2
        elif (AndroidUtil.isAndroid() || J2MEUtil.isJ2SE()) || SWTUtil.isSWT then
            BORDER <- MyFontProcessor.defaultCharWidth(font)
        else
            BORDER <- MyFontProcessor.defaultCharWidth(font) * 2
        this.BORDER <- BORDER
        this.heightOffset <- this.rectangle.getHeight() - (font.getHeight() * JString.length(BasicPopupMenuPaintable.NAME))
        if OpenGLFeatureUtil.getInstance().isAnyThreed() then
            this.heightOffset <- this.heightOffset - (font.getHeight() + 2)
            if AndroidUtil.isAndroid() then
                this.heightOffset <- font.getHeight()
            else
                this.heightOffset <- this.heightOffset - (font.getHeight() + 2)
        this.offset <- (this.heightOffset >>> 1) + ((if SWTJOGLProcessor.getInstance().isJOGL() then 4 else 0))
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract init : rectangle: Rectangle -> unit
    default this.init(rectangle: Rectangle) : unit =
        this.rectangle <- rectangle
        let mutable width : int = this.rectangle.getWidth()
        let mutable height : int = this.rectangle.getHeight()
        if J2MEUtil.isJ2ME() || J2MEUtil.isHTML() then
            ()
        else
            let mutable rectangleFilledAnimation : RectangleFilledAnimation = (box (this.animationInterface) :?> RectangleFilledAnimation)
            rectangleFilledAnimation.setWidth(width)
            rectangleFilledAnimation.setHeight(height)
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable point : GPoint = this.rectangle.getPoint()
        let mutable x : int = point.getX()
        let mutable y : int = point.getY()
        let mutable width : int = this.rectangle.getWidth()
        let mutable height : int = this.rectangle.getHeight()
        this.animationInterface.paintXY(graphics, x, y)
        this.basicSetColorUtil.setBasicColorP(graphics, this.foregroundBasicColor)
        this.drawStringUtil.paintVerticle(graphics, this.label, (x + this.BORDER), (y + this.offset), 0)
        graphics.drawRect(x, y, width, height)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


