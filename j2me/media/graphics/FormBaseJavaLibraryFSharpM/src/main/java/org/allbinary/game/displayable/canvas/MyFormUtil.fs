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
type MyFormUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable popupMenuRectangle : Rectangle
    [<DefaultValue(false)>] static val mutable private jcell_instance : MyFormUtil
    static member instance with get() : MyFormUtil = (MyFormUtil.jclinit(); MyFormUtil.jcell_instance) and set (jvalue: MyFormUtil) = (MyFormUtil.jclinit(); MyFormUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MyFormUtil.jclinitDone then
            MyFormUtil.jclinitDone <- true
            MyFormUtil.jclinitBody()
    static member private jclinitBody() : unit =
        MyFormUtil.jcell_instance <- (new MyFormUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_MyFormUtil()
    member this.jfields_MyFormUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.popupMenuRectangle <- RectangleFactory.SINGLETON
        ()
    
    static member getInstance() : MyFormUtil =
        MyFormUtil.instance
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable features : Features = Features.getInstance()
        let mutable isOpenGL : bool = features.isDefault(OpenGLFeatureFactory.getInstance().OPENGL)
        let mutable TOTAL_CHAR_WIDTH : int = (if SWTJOGLProcessor.getInstance().isJOGL() && isOpenGL then 2 else 3)
        let mutable width : int = MyFontProcessor.defaultStringWidth(font, TOTAL_CHAR_WIDTH)
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        if displayInfo.getLastHeight() < 320 then
            this.popupMenuRectangle <- (new Rectangle(pointFactory.createXY(0, 25), width, ((font.getHeight() * 4) + 2)))
        else
            this.popupMenuRectangle <- (new Rectangle(pointFactory.createXY(0, (displayInfo.getLastHalfHeight() - 70)), width, (font.getHeight() * 5)))
    
    abstract getPopupMenuRectangle : unit -> Rectangle
    default this.getPopupMenuRectangle() : Rectangle =
        this.popupMenuRectangle


