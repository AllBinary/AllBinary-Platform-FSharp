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
type ScrollSelectionForm =
    inherit PaintableForm
    [<DefaultValue(false)>] val mutable rectangleCollisionUtil : RectangleCollisionUtil
    [<DefaultValue(false)>] val mutable border : int
    [<DefaultValue(false)>] val mutable halfBorder : int
    [<DefaultValue(false)>] val mutable buttonBasicColor : BasicColor
    [<DefaultValue(false)>] val mutable scrollSelectionFormFormTypeItemIndexPaintable : ItemIndexPaintable
    [<DefaultValue(false)>] val mutable formTypeItemIndexDx : ItemIndexDx
    [<DefaultValue(false)>] val mutable paintable : ItemPaintable
    [<DefaultValue(false)>] val mutable adjustedExtraBorder : int
    [<DefaultValue(false)>] static val mutable private jcell_NULL_SCROLL_SELECTION_FORM : obj
    static member NULL_SCROLL_SELECTION_FORM with get() : obj = (ScrollSelectionForm.jclinit(); ScrollSelectionForm.jcell_NULL_SCROLL_SELECTION_FORM) and set (jvalue: obj) = (ScrollSelectionForm.jclinit(); ScrollSelectionForm.jcell_NULL_SCROLL_SELECTION_FORM <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_NULL_SCROLL_SELECTION_HORIZONTAL_FORM : obj
    static member NULL_SCROLL_SELECTION_HORIZONTAL_FORM with get() : obj = (ScrollSelectionForm.jclinit(); ScrollSelectionForm.jcell_NULL_SCROLL_SELECTION_HORIZONTAL_FORM) and set (jvalue: obj) = (ScrollSelectionForm.jclinit(); ScrollSelectionForm.jcell_NULL_SCROLL_SELECTION_HORIZONTAL_FORM <- jvalue)
    static member INSIDE_FORM : string = " inside form"
    static member IS_IN_FORM : string = "isInForm"
    static member GET_SELECTED_INDEX : string = "getSelectedIndexForPoint"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScrollSelectionForm.jclinitDone then
            ScrollSelectionForm.jclinitDone <- true
            ScrollSelectionForm.jclinitBody()
    static member private jclinitBody() : unit =
        ScrollSelectionForm.jcell_NULL_SCROLL_SELECTION_FORM <- NullUtil.getInstance().NULL_OBJECT
        ScrollSelectionForm.jcell_NULL_SCROLL_SELECTION_HORIZONTAL_FORM <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_ScrollSelectionForm() : unit =
        this.rectangleCollisionUtil <- RectangleCollisionUtil.getInstance()
        this.scrollSelectionFormFormTypeItemIndexPaintable <- ItemIndexPaintable.getInstance()
        this.formTypeItemIndexDx <- ItemIndexDx.getInstance()
        this.paintable <- ItemPaintableFactory.getInstance()
        ()
    
    static member createForm(title: string, items: ABCustomItem[], formPaintableFactory: ItemPaintableFactory, border: int, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : PaintableForm =
        let mutable jflow = 0
        let mutable jret : PaintableForm = Unchecked.defaultof<PaintableForm>
        try
            if (JR.same(formPaintableFactory, ItemPaintableFactory.getInstance())) then
                jret <- (new ScrollSelectionForm(title, items, formPaintableFactory, border, -3, backgroundBasicColor, foregroundBasicColor))
                jflow <- 1
            else
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                let mutable logUtil : LogUtil = LogUtil.getInstance()
                logUtil.putF(commonStrings.EXCEPTION, logUtil, commonStrings.EXCEPTION)
                jret <- PaintableForm.getNullPaintableForm()
                jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                let mutable logUtil : LogUtil = LogUtil.getInstance()
                logUtil.put(commonStrings.EXCEPTION, logUtil, commonStrings.EXCEPTION, e)
                jret <- PaintableForm.getNullPaintableForm()
                jflow <- 1
            | _ -> reraise ()
        jret
    
    static member getNullScrollSelectionForm() : ScrollSelectionForm =
        if (JR.same(ScrollSelectionForm.NULL_SCROLL_SELECTION_FORM, NullUtil.getInstance().NULL_OBJECT)) then
            ScrollSelectionForm.NULL_SCROLL_SELECTION_FORM <- ScrollSelectionForm.createForm(StringUtil.getInstance().EMPTY_STRING, (Array.zeroCreate<ABCustomItem> (0)), ItemPaintableFactory.getInstance(), 0, BasicColorFactory.getInstance().BLACK, BasicColorFactory.getInstance().WHITE)
        (box (ScrollSelectionForm.NULL_SCROLL_SELECTION_FORM) :?> ScrollSelectionForm)
    
    static member getNullScrollSelectionFormHorizontal() : ScrollSelectionForm =
        if (JR.same(ScrollSelectionForm.NULL_SCROLL_SELECTION_HORIZONTAL_FORM, NullUtil.getInstance().NULL_OBJECT)) then
            ScrollSelectionForm.NULL_SCROLL_SELECTION_HORIZONTAL_FORM <- ScrollSelectionForm.createForm(StringUtil.getInstance().EMPTY_STRING, (Array.zeroCreate<ABCustomItem> (0)), ItemPaintableFactory.getInstance(), 0, BasicColorFactory.getInstance().BLACK, BasicColorFactory.getInstance().WHITE)
        (box (ScrollSelectionForm.NULL_SCROLL_SELECTION_HORIZONTAL_FORM) :?> ScrollSelectionForm)
    
    new (title: string, items: ABCustomItem[], formPaintableFactory: ItemPaintableFactory, border: int, adjustedExtraBorder: int, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit PaintableForm(title, items, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jfields_ScrollSelectionForm()
            this.jctor1(title, items, formPaintableFactory, border, adjustedExtraBorder, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(title: string, items: ABCustomItem[], formPaintableFactory: ItemPaintableFactory, border: int, adjustedExtraBorder: int, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.adjustedExtraBorder <- adjustedExtraBorder
        this.buttonBasicColor <- foregroundBasicColor
        this.border <- border
        this.halfBorder <- (border >>> 1)
        this.paintable <- formPaintableFactory.getInstanceItemPaintable(this)
        ()
    
    override this.init(rectangle: Rectangle, formType: FormType) : unit =
        base.init(rectangle, formType)
        let mutable formTypeFactory : FormTypeFactory = FormTypeFactory.getInstance()
        if (JR.same(formType, formTypeFactory.HORIZONTAL_FORM)) then
            this.scrollSelectionFormFormTypeItemIndexPaintable <- (new ScrollSelectionFormHorizontalPaintable(this))
            this.formTypeItemIndexDx <- (new ScrollSelectionFormHorizontalDx(this))
        elif (JR.same(formType, formTypeFactory.VERTICAL_CENTER_FORM)) then
            this.scrollSelectionFormFormTypeItemIndexPaintable <- (new ScrollSelectionFormVerticalPaintable(this))
            this.formTypeItemIndexDx <- (new ScrollSelectionFormVericalDx(this))
        elif (JR.same(formType, formTypeFactory.TEMP_HORIZONTAL_FORM)) then
            this.scrollSelectionFormFormTypeItemIndexPaintable <- (new ScrollSelectionFormTempHorizontalPaintable(this))
            this.formTypeItemIndexDx <- (new ScrollSelectionFormTempHorizontalDx(this))
        elif (JR.same(formType, formTypeFactory.NULL_FORM_TYPE)) then
            ()
        else
            raise ((new JException(formTypeFactory.UNK)))
    
    abstract paintItemHorizontal : graphics: Graphics * index: int * item: ABCustomItem * x: int * y: int -> int
    default this.paintItemHorizontal(graphics: Graphics, index: int, item: ABCustomItem, x: int, y: int) : int =
        let mutable width : int = item.getMinimumWidth()
        (x + width) + this.border
    
    abstract paintItemVertical : graphics: Graphics * index: int * item: ABCustomItem * x: int * y: int -> int
    default this.paintItemVertical(graphics: Graphics, index: int, item: ABCustomItem, x: int, y: int) : int =
        let mutable height : int = item.getMinimumHeight()
        (y + height) + this.border
    
    abstract paintItemTempHorizontal : graphics: Graphics * index: int * item: ABCustomItem * x: int * y: int -> int
    default this.paintItemTempHorizontal(graphics: Graphics, index: int, item: ABCustomItem, x: int, y: int) : int =
        0
    
    abstract getSelectedIndexForPointHorizontalDx : index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.getSelectedIndexForPointHorizontalDx(index: int, item: ABCustomItem, dx: int, dy: int) : int =
        dx - this.halfBorder
    
    abstract getSelectedIndexForPointVerticalDx : index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.getSelectedIndexForPointVerticalDx(index: int, item: ABCustomItem, dx: int, dy: int) : int =
        dx + this.getDiffX(item)
    
    abstract getSelectedIndexForPointTempHorizontalDx : index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.getSelectedIndexForPointTempHorizontalDx(index: int, item: ABCustomItem, dx: int, dy: int) : int =
        dx + this.getDiffX(item)
    
    override this.append(item: ABCustomItem) : int =
        base.append(item)
    
    abstract getSelectedItem : point: GPoint -> ABCustomItem
    default this.getSelectedItem(point: GPoint) : ABCustomItem =
        let mutable jflow = 0
        let mutable jret : ABCustomItem = Unchecked.defaultof<ABCustomItem>
        let mutable index : int = this.getSelectedIndexForPoint(point)
        if index <> (-1) then
            jret <- this.get(index)
            jflow <- 1
        else
            jret <- ABCustomItem.getNullInstance()
            jflow <- 1
        jret
    
    abstract getItemIndex : item: ABCustomItem -> int
    default this.getItemIndex(item: ABCustomItem) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable nextItem : ABCustomItem = null
        let mutable size : int = this.size()
        let mutable index : int = 0
        while jflow = 0 && (index < size) do
            nextItem <- (box (this.get(index)) :?> ABCustomItem)
            if (JR.same(nextItem, item)) then
                jret <- index
                jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- -1
            jflow <- 1
        jret
    
    abstract getStartIndex : unit -> int
    default this.getStartIndex() : int =
        0
    
    abstract getSelectedIndexForPoint : point: GPoint -> int
    default this.getSelectedIndexForPoint(point: GPoint) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable start : int = this.getStartIndex()
        let mutable size : int = this.size()
        let mutable dx : int = this.getDx()
        let mutable dy : int = this.getDy()
        let mutable formTypeFactory : FormTypeFactory = FormTypeFactory.getInstance()
        let mutable commonLabels : CommonLabels = CommonLabels.getInstance()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(commonLabels.START_LABEL))
        ignore (stringBuffer.appendint(start))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(commonLabels.TOTAL_LABEL))
        ignore (stringBuffer.appendint(size))
        this.logUtil.putF(stringBuffer.ToString(), this, ScrollSelectionForm.GET_SELECTED_INDEX)
        let mutable item : ABCustomItem = null
        let mutable width : int = 0
        let mutable height : int = 0
        let mutable diffX : int = 0
        let mutable index : int = start
        while jflow = 0 && (index < size) do
            item <- this.get(index)
            width <- item.getMinimumWidth()
            height <- item.getMinimumHeight()
            diffX <- this.formTypeItemIndexDx.getDx(index, item, dx, dy)
            if this.rectangleCollisionUtil.isInside(diffX, (dy - this.halfBorder), ((diffX + width) + this.border), (((dy + height) + this.halfBorder) + 1), point.getX(), point.getY()) then
                ignore (stringBuffer.delete(0, stringBuffer.length()))
                ignore (stringBuffer.append(commonLabels.ITEM_LABEL))
                ignore (stringBuffer.append(item.getLabel()))
                ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
                ignore (stringBuffer.append(commonLabels.INDEX_LABEL))
                ignore (stringBuffer.appendint(index))
                this.logUtil.putF(stringBuffer.ToString(), this, ScrollSelectionForm.GET_SELECTED_INDEX)
                jret <- index
                jflow <- 1
            if jflow = 0 then
                if (JR.same(this.formType, formTypeFactory.HORIZONTAL_FORM)) then
                    dx <- (dx + width) + this.border
                    if dx > this.rectangle.getMaxX() then
                        jflow <- 100002
                elif (JR.same(this.formType, formTypeFactory.VERTICAL_CENTER_FORM)) then
                    dy <- (dy + height) + this.border
                    if dy > this.rectangle.getMaxY() then
                        jflow <- 100002
                elif (JR.same(this.formType, formTypeFactory.NULL_FORM_TYPE)) then
                    ()
                else
                    raise ((new JException(formTypeFactory.UNK)))
            if jflow = 200002 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            jret <- -1
            jflow <- 1
        jret
    
    abstract processInputKey : gameKeyCode: int -> int
    default this.processInputKey(gameKeyCode: int) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable formTypeFactory : FormTypeFactory = FormTypeFactory.getInstance()
        if this.size() = 0 then
            jret <- -1
            jflow <- 1
        if jflow = 0 then
            let mutable index : int = this.getSelectedIndex()
            if ((JR.same(this.formType, formTypeFactory.HORIZONTAL_FORM))) || ((JR.same(this.formType, formTypeFactory.TEMP_HORIZONTAL_FORM))) then
                if gameKeyCode = Canvas.RIGHT then
                    index <- index + 1
                elif gameKeyCode = Canvas.LEFT then
                    index <- index - 1
            elif (JR.same(this.formType, formTypeFactory.VERTICAL_CENTER_FORM)) then
                if gameKeyCode = Canvas.DOWN then
                    index <- index + 1
                elif gameKeyCode = Canvas.UP then
                    index <- index - 1
            elif (JR.same(this.formType, formTypeFactory.NULL_FORM_TYPE)) then
                ()
            else
                raise ((new JException(formTypeFactory.UNK)))
            let mutable max_ : int = this.size() - 1
            if index < 0 then
                this.setSelectedIndex(0)
            elif index > max_ then
                this.setSelectedIndex(max_)
            else
                this.setSelectedIndex(index)
            jret <- -1
            jflow <- 1
        jret
    
    abstract isInForm : point: GPoint -> bool
    default this.isInForm(point: GPoint) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.rectangleCollisionUtil.isInside(this.x, (this.y - this.halfBorder), (this.rectangle.getMaxX() + this.border), (this.rectangle.getMaxY() + this.border), point.getX(), point.getY()) then
            this.logUtil.putF((new StringMaker()).append(StringUtil.getInstance().toString(point)).append(ScrollSelectionForm.INSIDE_FORM).ToString(), this, ScrollSelectionForm.IS_IN_FORM)
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract paintItem : graphics: Graphics * index: int * item: ABCustomItem * x: int * y: int -> int
    default this.paintItem(graphics: Graphics, index: int, item: ABCustomItem, x: int, y: int) : int =
        item.paintXY(graphics, x, y)
        let mutable width : int = item.getMinimumWidth()
        let mutable height : int = item.getMinimumHeight()
        graphics.setColor(this.getButtonBasicColor().intValue())
        let mutable adjustedBorder : int = 3
        graphics.drawRect(((x - this.halfBorder) - adjustedBorder), ((y - this.halfBorder) - adjustedBorder), ((width + this.border) + this.adjustedExtraBorder), ((height + this.border) + this.adjustedExtraBorder))
        this.scrollSelectionFormFormTypeItemIndexPaintable.paint(graphics, index, item, x, y)
    
    abstract paintUnselectedItem : graphics: Graphics * index: int * item: ABCustomItem * x: int * y: int -> int
    default this.paintUnselectedItem(graphics: Graphics, index: int, item: ABCustomItem, x: int, y: int) : int =
        graphics.setColor(this.getButtonBasicColor().intValue())
        item.paintUnselected(graphics, x, y)
        this.scrollSelectionFormFormTypeItemIndexPaintable.paint(graphics, index, item, x, y)
    
    abstract getDiffX : item: ABCustomItem -> int
    default this.getDiffX(item: ABCustomItem) : int =
        0
    
    abstract getDx : unit -> int
    default this.getDx() : int =
        this.x
    
    abstract getDy : unit -> int
    default this.getDy() : int =
        this.y
    
    abstract setButtonBasicColor : buttonBasicColor: BasicColor -> unit
    default this.setButtonBasicColor(buttonBasicColor: BasicColor) : unit =
        this.buttonBasicColor <- buttonBasicColor
    
    member this.getButtonBasicColor() : BasicColor =
        this.buttonBasicColor


