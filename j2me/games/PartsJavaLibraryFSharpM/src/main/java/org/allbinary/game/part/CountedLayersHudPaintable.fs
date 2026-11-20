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
type CountedLayersHudPaintable =
    [<DefaultValue(false)>] val mutable displayInfoSingleton : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable partInterfaceArray : PartInterface[]
    [<DefaultValue(false)>] val mutable countedTotalStringColor : int
    [<DefaultValue(false)>] val mutable countedPartsBorder : int
    [<DefaultValue(false)>] val mutable startIndex : int
    [<DefaultValue(false)>] val mutable dropSize : int
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable height : int
    [<DefaultValue(false)>] static val mutable private jcell_XXStringWidth : int
    static member XXStringWidth with get() : int = (CountedLayersHudPaintable.jclinit(); CountedLayersHudPaintable.jcell_XXStringWidth) and set (jvalue: int) = (CountedLayersHudPaintable.jclinit(); CountedLayersHudPaintable.jcell_XXStringWidth <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CountedLayersHudPaintable.jclinitDone then
            CountedLayersHudPaintable.jclinitDone <- true
            CountedLayersHudPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        CountedLayersHudPaintable.jcell_XXStringWidth <- 0
        ()
    member this.jfields_CountedLayersHudPaintable() : unit =
        this.displayInfoSingleton <- DisplayInfoSingleton.getInstance()
        this.myFontProcessor <- (new UpdateMyFontProcessor(this))
        ()
    
    new (partInterfaceArray: PartInterface[], dropSize: int, startIndex: int, countedTotalStringColor: int, countedPartsBorder: int) as this =
        {  }
        then
            this.jfields_CountedLayersHudPaintable()
            this.jctor1(partInterfaceArray, dropSize, startIndex, countedTotalStringColor, countedPartsBorder)
    member this.jctor1(partInterfaceArray: PartInterface[], dropSize: int, startIndex: int, countedTotalStringColor: int, countedPartsBorder: int) : unit =
        this.partInterfaceArray <- partInterfaceArray
        this.startIndex <- startIndex
        this.countedTotalStringColor <- countedTotalStringColor
        this.countedPartsBorder <- countedPartsBorder
        this.dropSize <- dropSize
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.height <- font.getHeight()
        if this.dropSize > font.getHeight() then
            this.height <- this.dropSize
        if CountedLayersHudPaintable.XXStringWidth = 0 then
            let mutable XXString : string = "XX"
            CountedLayersHudPaintable.XXStringWidth <- font.stringWidth(XXString)
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable lastWidth : int = this.displayInfoSingleton.getLastWidth()
        let mutable widthEdge : int = lastWidth - this.dropSize
        let mutable size : int = this.partInterfaceArray.Length
        let mutable count : int = 0
        let mutable y : int = 0
        let mutable countedLayerInterfaceFactory : CountedLayerInterfaceFactoryPart = null
        let mutable pickedUpLayerInterfaceFactoryInterface : PickedUpLayerInterfaceFactoryInterface = null
        let mutable layerInterface : AllBinaryLayer = null
        let mutable charArray : char[] = null
        let mutable index : int = this.startIndex
        while index < size do
            countedLayerInterfaceFactory <- (box (this.partInterfaceArray.[index]) :?> CountedLayerInterfaceFactoryPart)
            if countedLayerInterfaceFactory.getTotal() > 0 then
                pickedUpLayerInterfaceFactoryInterface <- countedLayerInterfaceFactory.getCountedPickedUpLayerInterfaceFactory()
                layerInterface <- pickedUpLayerInterfaceFactoryInterface.getIconLayer()
                y <- 40 + (count * this.height)
                layerInterface.setPosition(widthEdge, y, layerInterface.getZP())
                layerInterface.paint(graphics)
                graphics.setColor(this.countedTotalStringColor)
                countedLayerInterfaceFactory.paint(graphics)
                charArray <- countedLayerInterfaceFactory.getTotalString()
                graphics.drawChars(charArray, 0, charArray.Length, (widthEdge - countedLayerInterfaceFactory.getXOffset()), y, 0)
                count <- count + 1
            index <- index + 1
        if count > 0 then
            graphics.setColor(this.countedPartsBorder)
            graphics.drawRect((lastWidth - (CountedLayersHudPaintable.XXStringWidth + this.dropSize)), 40, (CountedLayersHudPaintable.XXStringWidth + this.dropSize), ((count * this.height) + 3))
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)


