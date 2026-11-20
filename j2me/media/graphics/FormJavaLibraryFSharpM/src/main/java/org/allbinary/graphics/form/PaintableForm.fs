namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type PaintableForm =
    inherit ABCustomForm
    [<DefaultValue(false)>] val mutable canvasStrings : CanvasStrings
    [<DefaultValue(false)>] val mutable rectangle : Rectangle
    [<DefaultValue(false)>] val mutable x : int
    [<DefaultValue(false)>] val mutable y : int
    [<DefaultValue(false)>] val mutable formType : FormType
    [<DefaultValue(false)>] static val mutable private jcell_NULL_PAINTABLE_FORM : obj
    static member NULL_PAINTABLE_FORM with get() : obj = (PaintableForm.jclinit(); PaintableForm.jcell_NULL_PAINTABLE_FORM) and set (jvalue: obj) = (PaintableForm.jclinit(); PaintableForm.jcell_NULL_PAINTABLE_FORM <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PaintableForm.jclinitDone then
            PaintableForm.jclinitDone <- true
            PaintableForm.jclinitBody()
    static member private jclinitBody() : unit =
        PaintableForm.jcell_NULL_PAINTABLE_FORM <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_PaintableForm() : unit =
        this.canvasStrings <- CanvasStrings.getInstance()
        this.rectangle <- RectangleFactory.SINGLETON
        this.formType <- FormTypeFactory.getInstance().NULL_FORM_TYPE
        ()
    
    static member getNullPaintableForm() : PaintableForm =
        if (JR.same(PaintableForm.NULL_PAINTABLE_FORM, NullUtil.getInstance().NULL_OBJECT)) then
            PaintableForm.NULL_PAINTABLE_FORM <- (new PaintableForm(StringUtil.getInstance().EMPTY_STRING, (Array.zeroCreate<ABCustomItem> (0)), BasicColorFactory.getInstance().BLACK, BasicColorFactory.getInstance().WHITE))
        (box (PaintableForm.NULL_PAINTABLE_FORM) :?> PaintableForm)
    
    new (title: string, items: ABCustomItem[], backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit ABCustomForm(title, items, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jfields_PaintableForm()
            this.jctor1(title, items, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(title: string, items: ABCustomItem[], backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.setSelectedIndex(0)
        ()
    
    abstract init : rectangle: Rectangle * formType: FormType -> unit
    default this.init(rectangle: Rectangle, formType: FormType) : unit =
        this.rectangle <- rectangle
        let mutable point : GPoint = this.rectangle.getPoint()
        this.x <- point.getX()
        this.y <- point.getY()
        this.formType <- formType
    
    override this.getWidth() : int =
        this.rectangle.getWidth()


