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
type CancelTouchButtonInputFactory =
    [<DefaultValue(false)>] val mutable cancelInputArray : TouchButtonInput[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (CancelTouchButtonInputFactory.jclinit(); CancelTouchButtonInputFactory.jcell_instance) and set (jvalue: obj) = (CancelTouchButtonInputFactory.jclinit(); CancelTouchButtonInputFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CancelTouchButtonInputFactory.jclinitDone then
            CancelTouchButtonInputFactory.jclinitDone <- true
            CancelTouchButtonInputFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CancelTouchButtonInputFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_CancelTouchButtonInputFactory() : unit =
        this.cancelInputArray <- (Array.zeroCreate<TouchButtonInput> (InputFactory.getInstance().MAX))
        ()
    
    static member getInstance() : CancelTouchButtonInputFactory =
        if (JR.same(CancelTouchButtonInputFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            CancelTouchButtonInputFactory.instance <- (new CancelTouchButtonInputFactory())
        (box (CancelTouchButtonInputFactory.instance) :?> CancelTouchButtonInputFactory)
    
    new () as this =
        {  }
        then
            this.jfields_CancelTouchButtonInputFactory()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable basicTouchInputFactory : BasicTouchInputFactory = BasicTouchInputFactory.getInstance()
        let mutable index : int = this.cancelInputArray.Length - 1
        while index >= 0 do
            this.cancelInputArray.[index] <- basicTouchInputFactory.NONE
            index <- index - 1
        this.cancelInputArray.[basicTouchInputFactory.UP.getSourceId()] <- basicTouchInputFactory.DOWN
        this.cancelInputArray.[basicTouchInputFactory.DOWN.getSourceId()] <- basicTouchInputFactory.UP
        this.cancelInputArray.[basicTouchInputFactory.LEFT.getSourceId()] <- basicTouchInputFactory.RIGHT
        this.cancelInputArray.[basicTouchInputFactory.RIGHT.getSourceId()] <- basicTouchInputFactory.LEFT
        ()
    
    abstract getCancel : touchButtonInput: TouchButtonInput -> TouchButtonInput
    default this.getCancel(touchButtonInput: TouchButtonInput) : TouchButtonInput =
        this.cancelInputArray.[touchButtonInput.getSourceId()]


