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
type CommandCurrentSelectionForm =
    inherit ScrollCurrentSelectionForm
    [<DefaultValue(false)>] val mutable selectedAnimationArray : Animation[]
    [<DefaultValue(false)>] val mutable unSelectedAnimationArray : Animation[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommandCurrentSelectionForm.jclinitDone then
            CommandCurrentSelectionForm.jclinitDone <- true
            CommandCurrentSelectionForm.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CommandCurrentSelectionForm() : unit =
        this.selectedAnimationArray <- (Array.zeroCreate<Animation> (16))
        this.unSelectedAnimationArray <- (Array.zeroCreate<Animation> (16))
        ()
    
    new (title: string, items: ABCustomItem[], border: int, moveForSmallScreen: bool, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit ScrollCurrentSelectionForm(title, items, ItemPaintableFactory.getInstance(), border, -3, moveForSmallScreen, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jfields_CommandCurrentSelectionForm()
            this.jctor1(title, items, border, moveForSmallScreen, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(title: string, items: ABCustomItem[], border: int, moveForSmallScreen: bool, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.initAnimations()
        this.addAll(items)
        ()
    
    override this.updateMeasurement(graphics: Graphics) : unit =
        this.updateAll(graphics, this.getAllitems())
        base.updateMeasurement(graphics)
    
    member this.initAnimations() : unit =
        let mutable nullAnimation : Animation = NullAnimationFactory.getFactoryInstance().getInstance(0)
        let mutable index : int = this.selectedAnimationArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.selectedAnimationArray.[index] <- nullAnimation
        let mutable index : int = this.unSelectedAnimationArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.unSelectedAnimationArray.[index] <- nullAnimation
    
    member this.addAll(items: ABCustomItem[]) : unit =
        let mutable index : int = items.Length
        while ((index <- index - 1; index)) >= 0 do
            this.addAt(index, items.[index])
    
    member this.addAt(index: int, item: ABCustomItem) : unit =
        let mutable basicColorFactory : BasicColorFactory = BasicColorFactory.getInstance()
        let mutable buttonColor : BasicColor = basicColorFactory.TRANSPARENT_GREY
        let mutable selectedButtonColor : BasicColor = basicColorFactory.TRANSPARENT_RED
        let mutable width : int = item.getMinimumWidth()
        let mutable height : int = item.getMinimumHeight()
        let mutable adjustedBorder : int = 3
        let mutable offset : int = -((this.halfBorder + adjustedBorder))
        let mutable rectWidth : int = (width + this.border) - adjustedBorder
        let mutable rectHeight : int = (height + this.border) - adjustedBorder
        if J2MEUtil.isJ2ME() || J2MEUtil.isHTML() then
            this.selectedAnimationArray.[index] <- (new RectangleAdjustedAnimation(rectWidth, rectHeight, offset, offset, selectedButtonColor))
        else
            this.selectedAnimationArray.[index] <- (new RectangleFilledAdjustedAnimation(rectWidth, rectHeight, offset, offset, selectedButtonColor))
        adjustedBorder <- 4
        if J2MEUtil.isJ2ME() || J2MEUtil.isHTML() then
            this.unSelectedAnimationArray.[index] <- (new RectangleAdjustedAnimation(rectWidth, rectHeight, offset, offset, buttonColor))
        else
            this.unSelectedAnimationArray.[index] <- (new RectangleFilledAdjustedAnimation(rectWidth, rectHeight, offset, offset, buttonColor))
    
    member this.updateAll(graphics: Graphics, items: ABCustomItem[]) : unit =
        let mutable index : int = items.Length
        while ((index <- index - 1; index)) >= 0 do
            items.[index].preMeasurement(graphics)
            this.updateAt(index, items.[index])
    
    member this.updateAt(index: int, item: ABCustomItem) : unit =
        let mutable basicColorFactory : BasicColorFactory = BasicColorFactory.getInstance()
        let mutable buttonColor : BasicColor = basicColorFactory.TRANSPARENT_GREY
        let mutable selectedButtonColor : BasicColor = basicColorFactory.TRANSPARENT_RED
        let mutable width : int = item.getMinimumWidth()
        let mutable height : int = item.getMinimumHeight()
        let mutable adjustedBorder : int = 3
        let mutable offset : int = -((this.halfBorder + adjustedBorder))
        let mutable rectWidth : int = (width + this.border) - adjustedBorder
        let mutable rectHeight : int = (height + this.border) - adjustedBorder
        if J2MEUtil.isJ2ME() || J2MEUtil.isHTML() then
            let mutable rectangleAdjustedAnimation : RectangleAdjustedAnimation = (box (this.selectedAnimationArray.[index]) :?> RectangleAdjustedAnimation)
            rectangleAdjustedAnimation.setWidth(rectWidth)
            rectangleAdjustedAnimation.setHeight(rectHeight)
            rectangleAdjustedAnimation.setOffsetX(offset)
            rectangleAdjustedAnimation.setOffsetY(offset)
            rectangleAdjustedAnimation.setBasicColorP(selectedButtonColor)
        else
            let mutable rectangleAdjustedAnimation : RectangleFilledAdjustedAnimation = (box (this.selectedAnimationArray.[index]) :?> RectangleFilledAdjustedAnimation)
            rectangleAdjustedAnimation.setWidth(rectWidth)
            rectangleAdjustedAnimation.setHeight(rectHeight)
            rectangleAdjustedAnimation.setOffsetX(offset)
            rectangleAdjustedAnimation.setOffsetY(offset)
            rectangleAdjustedAnimation.setBasicColorP(selectedButtonColor)
        adjustedBorder <- 4
        if J2MEUtil.isJ2ME() || J2MEUtil.isHTML() then
            let mutable rectangleAdjustedAnimation : RectangleAdjustedAnimation = (box (this.unSelectedAnimationArray.[index]) :?> RectangleAdjustedAnimation)
            rectangleAdjustedAnimation.setWidth(rectWidth)
            rectangleAdjustedAnimation.setHeight(rectHeight)
            rectangleAdjustedAnimation.setOffsetX(offset)
            rectangleAdjustedAnimation.setOffsetY(offset)
            rectangleAdjustedAnimation.setBasicColorP(buttonColor)
        else
            let mutable rectangleAdjustedAnimation : RectangleFilledAdjustedAnimation = (box (this.unSelectedAnimationArray.[index]) :?> RectangleFilledAdjustedAnimation)
            rectangleAdjustedAnimation.setWidth(rectWidth)
            rectangleAdjustedAnimation.setHeight(rectHeight)
            rectangleAdjustedAnimation.setOffsetX(offset)
            rectangleAdjustedAnimation.setOffsetY(offset)
            rectangleAdjustedAnimation.setBasicColorP(buttonColor)
    
    abstract getSelectedCommand : unit -> Command
    default this.getSelectedCommand() : Command =
        let mutable index : int = base.getSelectedIndex()
        let mutable commandTextItem : CommandTextItem = (box (this.get(index)) :?> CommandTextItem)
        commandTextItem.getCommand()
    
    override this.append(item: ABCustomItem) : int =
        let mutable result : int = base.append(item)
        this.addAt(result, item)
        result
    
    override this.delete(itemNum: int) : unit =
        base.delete(itemNum)
    
    override this.deleteAll() : unit =
        this.initAnimations()
        base.deleteAll()
    
    override this.insert(itemNum: int, item: ABCustomItem) : unit =
        base.insert(itemNum, item)
    
    override this.set(itemNum: int, item: ABCustomItem) : unit =
        base.set(itemNum, item)
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        base.paint(graphics)
    
    override this.paintItem(graphics: Graphics, index: int, item: ABCustomItem, x: int, y: int) : int =
        this.selectedAnimationArray.[index].paintXY(graphics, x, y)
        base.paintItem(graphics, index, item, x, y)
    
    override this.paintUnselectedItem(graphics: Graphics, index: int, item: ABCustomItem, x: int, y: int) : int =
        this.unSelectedAnimationArray.[index].paintXY(graphics, x, y)
        base.paintUnselectedItem(graphics, index, item, x, y)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


