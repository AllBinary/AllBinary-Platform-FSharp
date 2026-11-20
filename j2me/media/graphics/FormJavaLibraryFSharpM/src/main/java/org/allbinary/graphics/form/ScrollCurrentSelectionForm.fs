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
type ScrollCurrentSelectionForm =
    inherit ScrollSelectionForm
    [<DefaultValue(false)>] val mutable moveForSmallScreen : bool
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable processor : Processor
    [<DefaultValue(false)>] val mutable preItemIndexDx : ItemIndexDx
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] val mutable maxWidth : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScrollCurrentSelectionForm.jclinitDone then
            ScrollCurrentSelectionForm.jclinitDone <- true
            ScrollCurrentSelectionForm.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ScrollCurrentSelectionForm() : unit =
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.processor <- Processor.getInstance()
        this.preItemIndexDx <- ItemIndexDx.getInstance()
        this.maxWidth <- 0
        ()
    
    new (title: string, items: ABCustomItem[], formPaintableFactory: ItemPaintableFactory, border: int, adjustedExtraBorder: int, moveForSmallScreen: bool, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit ScrollSelectionForm(title, items, formPaintableFactory, border, adjustedExtraBorder, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jfields_ScrollCurrentSelectionForm()
            this.jctor1(title, items, formPaintableFactory, border, adjustedExtraBorder, moveForSmallScreen, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(title: string, items: ABCustomItem[], formPaintableFactory: ItemPaintableFactory, border: int, adjustedExtraBorder: int, moveForSmallScreen: bool, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.moveForSmallScreen <- moveForSmallScreen
        ()
    
    override this.init(rectangle: Rectangle, formType: FormType) : unit =
        base.init(rectangle, formType)
        let mutable formTypeFactory : FormTypeFactory = FormTypeFactory.getInstance()
        if (JR.same(formType, formTypeFactory.TEMP_HORIZONTAL_FORM)) then
            this.processor <- (new TempHorizontalFormProcessor(this))
            this.preItemIndexDx <- (new TempHorizontalItemIndexDx(this))
        elif (JR.same(formType, formTypeFactory.HORIZONTAL_FORM)) then
            this.processor <- (new HorizontalFormProcessor(this))
            this.preItemIndexDx <- (new HorizontalItemIndexDx(this))
        elif (JR.same(formType, formTypeFactory.VERTICAL_CENTER_FORM)) then
            this.processor <- (new VerticalFormProcessor(this))
            this.preItemIndexDx <- (new VerticalItemIndexDx(this))
        elif (JR.same(formType, formTypeFactory.NULL_FORM_TYPE)) then
            ()
        else
            this.logUtil.putF(formTypeFactory.UNK, this, this.commonStrings.INIT)
        this.myFontProcessor <- this.updateMyFontProcessor
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract processTempHorizontalForm : unit -> unit
    default this.processTempHorizontalForm() : unit =
        this.dx <- (this.x - 30) + (this.rectangle.getWidth() >>> 1)
        this.dy <- this.y
    
    abstract processHorizontalForm : unit -> unit
    default this.processHorizontalForm() : unit =
        let mutable size : int = this.size()
        let mutable totalWidth : int = 0
        let mutable item : ABCustomItem = null
        let mutable index : int = 0
        while index < size do
            item <- this.get(index)
            totalWidth <- totalWidth + (item.getMinimumWidth() + this.border)
            index <- index + 1
        this.dx <- (this.x + (this.rectangle.getWidth() >>> 1)) - (totalWidth >>> 1)
        this.dy <- this.y + (this.rectangle.getHeight() >>> 1)
        if this.moveForSmallScreen then
            let mutable maxTitleHeight : int = 175
            if this.dy < maxTitleHeight then
                this.dy <- maxTitleHeight
    
    abstract processVerticalForm : unit -> unit
    default this.processVerticalForm() : unit =
        let mutable totalHeight : int = 0
        let mutable size : int = this.size()
        let mutable item2 : ABCustomItem = null
        let mutable index : int = 0
        while index < size do
            item2 <- this.get(index)
            if this.maxWidth < item2.getMinimumWidth() then
                this.maxWidth <- item2.getMinimumWidth()
            totalHeight <- totalHeight + (item2.getMinimumHeight() + this.border)
            index <- index + 1
        this.dx <- ((this.rectangle.getWidth() - this.maxWidth) / 2)
        if this.size() > 0 then
            this.dy <- this.y + ((this.rectangle.getHeight() - totalHeight) / 2)
            if this.moveForSmallScreen then
                let mutable maxTitleHeight : int = 175
                if this.dy < maxTitleHeight then
                    this.dy <- maxTitleHeight
        else
            this.dy <- this.y
    
    abstract getXTempHorizontalForm : index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.getXTempHorizontalForm(index: int, item: ABCustomItem, dx: int, dy: int) : int =
        this.getDiffX(item)
    
    abstract getXHorizontalForm : index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.getXHorizontalForm(index: int, item: ABCustomItem, dx: int, dy: int) : int =
        0
    
    abstract getXVerticalForm : index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.getXVerticalForm(index: int, item: ABCustomItem, dx: int, dy: int) : int =
        this.getDiffX(item) + this.halfBorder
    
    override this.getDiffX(item: ABCustomItem) : int =
        ((this.maxWidth - item.getMinimumWidth()) >>> 1)
    
    override this.getDx() : int =
        this.dx
    
    override this.getDy() : int =
        this.dy
    
    override this.paint(graphics: Graphics) : unit =
        try
            this.processor.process_()
            let mutable delta : int = 0
            let mutable deltaX : int = this.getDx()
            let mutable deltaY : int = this.getDy()
            let mutable size : int = this.size()
            let mutable formTypeFactory : FormTypeFactory = FormTypeFactory.getInstance()
            let mutable item : ABCustomItem = null
            let mutable index : int = 0
            while index < size do
                item <- this.get(index)
                let mutable diffX : int = this.preItemIndexDx.getDx(index, item, this.dx, this.dy)
                if index = this.getSelectedIndex() then
                    delta <- this.paintItem(graphics, index, item, (deltaX + diffX), deltaY)
                    this.paintable.paint(graphics, index, (deltaX + diffX), deltaY)
                else
                    delta <- this.paintUnselectedItem(graphics, index, item, (deltaX + diffX), deltaY)
                    this.paintable.paint(graphics, index, (deltaX + diffX), deltaY)
                if (JR.same(this.formType, formTypeFactory.TEMP_HORIZONTAL_FORM)) then
                    ()
                elif (JR.same(this.formType, formTypeFactory.HORIZONTAL_FORM)) then
                    deltaX <- delta
                elif (JR.same(this.formType, formTypeFactory.VERTICAL_CENTER_FORM)) then
                    deltaY <- delta
                else
                    raise ((new JException(formTypeFactory.UNK)))
                index <- index + 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.canvasStrings.PAINT, e)
            | _ -> reraise ()
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


