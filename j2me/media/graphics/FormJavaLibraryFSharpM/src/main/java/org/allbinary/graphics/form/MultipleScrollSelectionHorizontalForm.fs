namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type MultipleScrollSelectionHorizontalForm =
    inherit ScrollSelectionForm
    [<DefaultValue(false)>] val mutable rectPaintable : Paintable
    [<DefaultValue(false)>] val mutable multipleScrollSelectionHorizontalFormTypeItemIndexPaintable : ItemIndexPaintable
    [<DefaultValue(false)>] val mutable backgroundColor : int
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable logged : bool
    [<DefaultValue(false)>] val mutable fontHeight : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MultipleScrollSelectionHorizontalForm.jclinitDone then
            MultipleScrollSelectionHorizontalForm.jclinitDone <- true
            MultipleScrollSelectionHorizontalForm.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_MultipleScrollSelectionHorizontalForm() : unit =
        this.rectPaintable <- NullPaintable.getInstance()
        this.multipleScrollSelectionHorizontalFormTypeItemIndexPaintable <- ItemIndexPaintable.getInstance()
        this.backgroundColor <- BasicColorFactory.getInstance().TRANSPARENT_GREY.intValue()
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        this.logged <- false
        this.fontHeight <- 0
        ()
    
    static member createForm(title: string, items: ABCustomItem[], rectangle: Rectangle, formType: FormType, border: int, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : ScrollSelectionForm =
        let mutable scrollSelectionForm : ScrollSelectionForm = (new MultipleScrollSelectionHorizontalForm(title, items, ItemPaintableFactory.getInstance(), border, backgroundBasicColor, foregroundBasicColor))
        scrollSelectionForm.init(rectangle, formType)
        scrollSelectionForm
    
    new (title: string, items: ABCustomItem[], formPaintableFactory: ItemPaintableFactory, border: int, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit ScrollSelectionForm(title, items, formPaintableFactory, border, 3, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jfields_MultipleScrollSelectionHorizontalForm()
            this.jctor1(title, items, formPaintableFactory, border, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(title: string, items: ABCustomItem[], formPaintableFactory: ItemPaintableFactory, border: int, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        if J2MEUtil.isJ2ME() || J2MEUtil.isHTML() then
            ()
        else
            this.rectPaintable <- (new MultipleScrollSelectionFormRectPaintable(this))
        ()
    
    abstract fillRect : graphics: Graphics -> unit
    default this.fillRect(graphics: Graphics) : unit =
        graphics.setColor(this.backgroundColor)
        graphics.fillRect(this.x, this.y, this.rectangle.getWidth(), this.rectangle.getHeight())
    
    override this.init(rectangle: Rectangle, formType: FormType) : unit =
        base.init(rectangle, formType)
        let mutable formTypeFactory : FormTypeFactory = FormTypeFactory.getInstance()
        if (JR.same(formType, formTypeFactory.HORIZONTAL_FORM)) then
            this.multipleScrollSelectionHorizontalFormTypeItemIndexPaintable <- (new MultipleScrollSelectionFormHorizontalPaintable(this))
        elif (JR.same(formType, formTypeFactory.VERTICAL_CENTER_FORM)) then
            this.multipleScrollSelectionHorizontalFormTypeItemIndexPaintable <- (new MultipleScrollSelectionFormVerticalPaintable(this))
        elif (JR.same(formType, formTypeFactory.NULL_FORM_TYPE)) then
            ()
        else
            raise ((new JException(formTypeFactory.UNK)))
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.fontHeight <- font.getHeight()
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract paintHorizontal : graphics: Graphics * index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.paintHorizontal(graphics: Graphics, index: int, item: ABCustomItem, dx: int, dy: int) : int =
        let mutable dx = dx
        let mutable dx2 : int = this.paintItem(graphics, index, item, dx, dy) + this.border
        this.paintable.paint(graphics, index, dx, dy)
        dx <- dx2
        dx
    
    abstract paintVertical : graphics: Graphics * index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.paintVertical(graphics: Graphics, index: int, item: ABCustomItem, dx: int, dy: int) : int =
        ignore (this.paintItem(graphics, index, item, dx, dy))
        this.paintable.paint(graphics, index, dx, dy)
        dx
    
    override this.getStartIndex() : int =
        this.getSelectedIndex()
    
    override this.paint(graphics: Graphics) : unit =
        try
            this.myFontProcessor.process_(graphics)
            let mutable start : int = this.getStartIndex()
            let mutable size : int = this.size()
            let mutable dx : int = this.x
            let mutable dy : int = this.y
            this.rectPaintable.paint(graphics)
            graphics.drawString(this.getTitle(), this.x, (this.y - this.fontHeight), 0)
            let mutable item : ABCustomItem = null
            let mutable index : int = start
            while index < size do
                item <- this.get(index)
                if dx >= this.rectangle.getMaxX() then
                    if this.logged then
                        ()
                    else
                        this.logged <- true
                        PreLogUtil.put((new StringMaker()).append("painting beyond maxx: ").appendint(this.rectangle.getMaxX()).ToString(), this, this.canvasStrings.PAINT)
                dx <- this.multipleScrollSelectionHorizontalFormTypeItemIndexPaintable.paint(graphics, index, item, dx, dy)
                index <- index + 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.put(this.commonStrings.EXCEPTION, this, this.canvasStrings.PAINT)
            | _ -> reraise ()
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


