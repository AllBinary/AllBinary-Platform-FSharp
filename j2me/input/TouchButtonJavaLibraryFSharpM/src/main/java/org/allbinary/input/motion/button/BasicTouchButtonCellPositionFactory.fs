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
type BasicTouchButtonCellPositionFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable TOP_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable TOP_LEFT : CellPosition
    [<DefaultValue(false)>] val mutable SECOND_FROM_TOP_LEFT : CellPosition
    [<DefaultValue(false)>] val mutable SECOND_FROM_TOP_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable TOP_SECOND_FROM_LEFT : CellPosition
    [<DefaultValue(false)>] val mutable TOP_SECOND_FROM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable BOTTOM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable BOTTOM_SECOND_FROM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable SECOND_FROM_BOTTOM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable THIRD_FROM_BOTTOM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable FOURTH_FROM_BOTTOM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable SECOND_FROM_BOTTOM_SECOND_FROM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable SECOND_FROM_BOTTOM_THIRD_FROM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable SECOND_FROM_BOTTOM_FOURTH_FROM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable BOTTOM_THIRD_FROM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable BOTTOM_FOURTH_FROM_RIGHT : CellPosition
    [<DefaultValue(false)>] val mutable BOTTOM_SECOND_FROM_LEFT : CellPosition
    [<DefaultValue(false)>] val mutable SECOND_FROM_BOTTOM_LEFT : CellPosition
    [<DefaultValue(false)>] val mutable THIRD_FROM_BOTTOM_LEFT : CellPosition
    [<DefaultValue(false)>] val mutable BOTTOM_LEFT : CellPosition
    [<DefaultValue(false)>] val mutable SECOND_FROM_BOTTOM_SECOND_FROM_LEFT : CellPosition
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicTouchButtonCellPositionFactory.jclinitDone then
            BasicTouchButtonCellPositionFactory.jclinitDone <- true
            BasicTouchButtonCellPositionFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicTouchButtonCellPositionFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_BasicTouchButtonCellPositionFactory()
            this.jctor1()
    member this.jctor1() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        let mutable touchButtonLocationHelper : TouchButtonLocationHelper = (new TouchButtonLocationHelper())
        let mutable cellPositionFactory : CellPositionFactory = CellPositionFactory.getInstance()
        cellPositionFactory.init(touchButtonLocationHelper.getTotalColumns(), touchButtonLocationHelper.getTotalRows())
        this.TOP_LEFT <- cellPositionFactory.getInstanceColRow(0, 0)
        this.TOP_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 1), 0)
        this.BOTTOM_LEFT <- cellPositionFactory.getInstanceColRow(0, (touchButtonLocationHelper.getTotalRows() - 1))
        this.BOTTOM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 1), (touchButtonLocationHelper.getTotalRows() - 1))
        this.BOTTOM_SECOND_FROM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 2), (touchButtonLocationHelper.getTotalRows() - 1))
        this.SECOND_FROM_BOTTOM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 1), (touchButtonLocationHelper.getTotalRows() - 2))
        this.SECOND_FROM_BOTTOM_SECOND_FROM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 2), (touchButtonLocationHelper.getTotalRows() - 2))
        this.BOTTOM_SECOND_FROM_LEFT <- cellPositionFactory.getInstanceColRow(1, (touchButtonLocationHelper.getTotalRows() - 1))
        this.SECOND_FROM_BOTTOM_LEFT <- cellPositionFactory.getInstanceColRow(0, (touchButtonLocationHelper.getTotalRows() - 2))
        this.SECOND_FROM_BOTTOM_SECOND_FROM_LEFT <- cellPositionFactory.getInstanceColRow(1, (touchButtonLocationHelper.getTotalRows() - 2))
        if touchButtonLocationHelper.getTotalRows() > 2 then
            this.SECOND_FROM_TOP_LEFT <- cellPositionFactory.getInstanceColRow(0, 1)
            this.SECOND_FROM_TOP_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 1), 1)
        else
            this.SECOND_FROM_TOP_LEFT <- cellPositionFactory.NONE
            this.SECOND_FROM_TOP_RIGHT <- cellPositionFactory.NONE
        if touchButtonLocationHelper.getTotalRows() >= 4 then
            this.THIRD_FROM_BOTTOM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 1), (touchButtonLocationHelper.getTotalRows() - 3))
            this.FOURTH_FROM_BOTTOM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 1), (touchButtonLocationHelper.getTotalRows() - 4))
            this.THIRD_FROM_BOTTOM_LEFT <- cellPositionFactory.getInstanceColRow(0, (touchButtonLocationHelper.getTotalRows() - 3))
        else
            this.THIRD_FROM_BOTTOM_RIGHT <- cellPositionFactory.NONE
            this.FOURTH_FROM_BOTTOM_RIGHT <- cellPositionFactory.NONE
            this.THIRD_FROM_BOTTOM_LEFT <- cellPositionFactory.NONE
        if touchButtonLocationHelper.getTotalColumns() >= 4 then
            this.SECOND_FROM_BOTTOM_THIRD_FROM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 3), (touchButtonLocationHelper.getTotalRows() - 2))
            this.SECOND_FROM_BOTTOM_FOURTH_FROM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 4), (touchButtonLocationHelper.getTotalRows() - 2))
            this.BOTTOM_THIRD_FROM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 3), (touchButtonLocationHelper.getTotalRows() - 1))
            this.BOTTOM_FOURTH_FROM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 4), (touchButtonLocationHelper.getTotalRows() - 1))
            this.TOP_SECOND_FROM_LEFT <- cellPositionFactory.getInstanceColRow(1, 0)
            this.TOP_SECOND_FROM_RIGHT <- cellPositionFactory.getInstanceColRow((touchButtonLocationHelper.getTotalColumns() - 2), 0)
        else
            this.SECOND_FROM_BOTTOM_THIRD_FROM_RIGHT <- cellPositionFactory.NONE
            this.SECOND_FROM_BOTTOM_FOURTH_FROM_RIGHT <- cellPositionFactory.NONE
            this.BOTTOM_THIRD_FROM_RIGHT <- cellPositionFactory.NONE
            this.BOTTOM_FOURTH_FROM_RIGHT <- cellPositionFactory.NONE
            this.TOP_SECOND_FROM_LEFT <- cellPositionFactory.NONE
            this.TOP_SECOND_FROM_RIGHT <- cellPositionFactory.NONE
        ()


