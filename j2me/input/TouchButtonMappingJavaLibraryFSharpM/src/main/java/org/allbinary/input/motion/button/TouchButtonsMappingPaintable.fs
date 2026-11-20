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
type TouchButtonsMappingPaintable =
    inherit Paintable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable foregroundColor : int
    [<DefaultValue(false)>] val mutable paintableTable : Paintable[][]
    [<DefaultValue(false)>] val mutable touchButtonLocationHelper : TouchButtonLocationHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonsMappingPaintable.jclinitDone then
            TouchButtonsMappingPaintable.jclinitDone <- true
            TouchButtonsMappingPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TouchButtonsMappingPaintable() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.paintableTable <- (JR.newArray2<Paintable>(0, 0))
        this.touchButtonLocationHelper <- (new TouchButtonLocationHelper())
        ()
    
    new (basicColor: BasicColor) as this =
        { inherit Paintable() }
        then
            this.jfields_TouchButtonsMappingPaintable()
            this.jctor1(basicColor)
    member this.jctor1(basicColor: BasicColor) : unit =
        this.foregroundColor <- basicColor.intValue()
        this.init()
        ()
    
    member this.init() : unit =
        try
            this.paintableTable <- this.createPaintableTable()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, "updateRectangle", e)
            | _ -> reraise ()
    
    member this.createPaintableTable() : Paintable[][] =
        let mutable totalColumns : int = this.touchButtonLocationHelper.getTotalColumns()
        let mutable totalRows : int = this.touchButtonLocationHelper.getTotalRows()
        let mutable paintableTable : Paintable[][] = (JR.newArray2<Paintable>(totalColumns, totalRows))
        let mutable cellPositionFactory : CellPositionFactory = CellPositionFactory.getInstance()
        let mutable commonButtons : CommonButtons = CommonButtons.getInstance()
        let mutable index : int = totalColumns - 1
        while index >= 0 do
            let mutable rowIndex : int = totalRows - 1
            while rowIndex >= 0 do
                this.paintableTable.[index].[rowIndex] <- TouchButton.createButton(BasicTouchInputFactory.getInstance().NONE, TouchButtonBlankResource.getInstance(), commonButtons.NORMAL_BUTTON, cellPositionFactory.getInstanceColRow(index, rowIndex), this.touchButtonLocationHelper.getColumnsRemainderHalf(), this.touchButtonLocationHelper.getRowsRemainderHalf())
                rowIndex <- rowIndex - 1
            index <- index - 1
        paintableTable
    
    override this.paint(graphics: Graphics) : unit =
        let mutable totalColumns : int = this.touchButtonLocationHelper.getTotalColumns()
        let mutable totalRows : int = this.touchButtonLocationHelper.getTotalRows()
        let mutable index : int = totalColumns - 1
        while index >= 0 do
            let mutable rowIndex : int = totalRows - 1
            while rowIndex >= 0 do
                this.paintableTable.[index].[rowIndex].paint(graphics)
                rowIndex <- rowIndex - 1
            index <- index - 1


