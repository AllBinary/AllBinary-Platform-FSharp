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
type BasicTouchButtonsBuilder =
    inherit BaseTouchInput
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicTouchButtonsBuilder.jclinitDone then
            BasicTouchButtonsBuilder.jclinitDone <- true
            BasicTouchButtonsBuilder.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit BaseTouchInput() }
        then
            this.jfields_BasicTouchButtonsBuilder()
    member this.jfields_BasicTouchButtonsBuilder() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    override this.getList() : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        try
            this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
            let mutable list_ : BasicArrayList = (new BasicArrayListD())
            let mutable commonButtons : CommonButtons = CommonButtons.getInstance()
            let mutable touchButtonLocationHelper : TouchButtonLocationHelper = (new TouchButtonLocationHelper())
            let mutable basicTouchButtonCellPositionFactory : BasicTouchButtonCellPositionFactory = (new BasicTouchButtonCellPositionFactory())
            let mutable UP : TouchButton = TouchButton.createButton(BasicTouchInputFactory.getInstance().UP, TouchButtonUpResource.getInstance(), commonButtons.NORMAL_BUTTON, basicTouchButtonCellPositionFactory.SECOND_FROM_BOTTOM_LEFT, touchButtonLocationHelper.getColumnsRemainderHalf(), touchButtonLocationHelper.getRowsRemainderHalf())
            let mutable DOWN : TouchButton = TouchButton.createButton(BasicTouchInputFactory.getInstance().DOWN, TouchButtonDownResource.getInstance(), commonButtons.NORMAL_BUTTON, basicTouchButtonCellPositionFactory.BOTTOM_LEFT, touchButtonLocationHelper.getColumnsRemainderHalf(), touchButtonLocationHelper.getRowsRemainderHalf())
            let mutable LEFT : TouchButton = TouchButton.createButton(BasicTouchInputFactory.getInstance().SPECIAL_BUTTON_FOUR, TouchButtonTurnLeftResource.getInstance(), commonButtons.NORMAL_BUTTON, basicTouchButtonCellPositionFactory.BOTTOM_SECOND_FROM_RIGHT, touchButtonLocationHelper.getColumnsRemainderHalf(), touchButtonLocationHelper.getRowsRemainderHalf())
            let mutable RIGHT : TouchButton = TouchButton.createButton(BasicTouchInputFactory.getInstance().SPECIAL_BUTTON_THREE, TouchButtonTurnRightResource.getInstance(), commonButtons.NORMAL_BUTTON, basicTouchButtonCellPositionFactory.BOTTOM_RIGHT, touchButtonLocationHelper.getColumnsRemainderHalf(), touchButtonLocationHelper.getRowsRemainderHalf())
            ignore (list_.add(UP))
            ignore (list_.add(LEFT))
            ignore (list_.add(RIGHT))
            ignore (list_.add(DOWN))
            jret <- list_
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.GET_LIST, e)
                jret <- BasicArrayListUtil.getInstance().getImmutableInstance()
                jflow <- 1
            | _ -> reraise ()
        jret


