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
type BasicNeededTouchButtonsBuilder =
    inherit BaseTouchInput
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicNeededTouchButtonsBuilder.jclinitDone then
            BasicNeededTouchButtonsBuilder.jclinitDone <- true
            BasicNeededTouchButtonsBuilder.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit BaseTouchInput() }
        then
            this.jfields_BasicNeededTouchButtonsBuilder()
    member this.jfields_BasicNeededTouchButtonsBuilder() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    override this.getList() : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        try
            this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
            let mutable list_ : BasicArrayList = (new BasicArrayListD())
            let mutable touchButtonLocationHelper : TouchButtonLocationHelper = (new TouchButtonLocationHelper())
            let mutable basicTouchButtonCellPositionFactory : BasicTouchButtonCellPositionFactory = (new BasicTouchButtonCellPositionFactory())
            let mutable commonButtons : CommonButtons = CommonButtons.getInstance()
            let mutable animationInterface : Animation = NullAnimationFactory.getFactoryInstance().getInstance(0)
            let mutable UP : TouchButton = (new TouchButton(BasicTouchInputFactory.getInstance().UP, animationInterface, animationInterface, commonButtons.NORMAL_BUTTON, basicTouchButtonCellPositionFactory.SECOND_FROM_BOTTOM_LEFT, touchButtonLocationHelper.getColumnsRemainderHalf(), touchButtonLocationHelper.getRowsRemainderHalf()))
            let mutable DOWN : TouchButton = (new TouchButton(BasicTouchInputFactory.getInstance().DOWN, animationInterface, animationInterface, commonButtons.NORMAL_BUTTON, basicTouchButtonCellPositionFactory.BOTTOM_LEFT, touchButtonLocationHelper.getColumnsRemainderHalf(), touchButtonLocationHelper.getRowsRemainderHalf()))
            let mutable LEFT : TouchButton = (new TouchButton(BasicTouchInputFactory.getInstance().LEFT, animationInterface, animationInterface, commonButtons.NORMAL_BUTTON, basicTouchButtonCellPositionFactory.BOTTOM_SECOND_FROM_RIGHT, touchButtonLocationHelper.getColumnsRemainderHalf(), touchButtonLocationHelper.getRowsRemainderHalf()))
            let mutable RIGHT : TouchButton = (new TouchButton(BasicTouchInputFactory.getInstance().RIGHT, animationInterface, animationInterface, commonButtons.NORMAL_BUTTON, basicTouchButtonCellPositionFactory.BOTTOM_RIGHT, touchButtonLocationHelper.getColumnsRemainderHalf(), touchButtonLocationHelper.getRowsRemainderHalf()))
            ignore (list_.add(UP))
            ignore (list_.add(DOWN))
            ignore (list_.add(LEFT))
            ignore (list_.add(RIGHT))
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


