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
type InputFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable KEY_CODE_LABEL : string
    [<DefaultValue(false)>] val mutable DEVICE_ID_LABEL : string
    [<DefaultValue(false)>] val mutable MAX : int
    [<DefaultValue(false)>] val mutable inputIntegerArray : Input[]
    [<DefaultValue(false)>] val mutable NO_INPUT : Input
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (InputFactory.jclinit(); InputFactory.jcell_instance) and set (jvalue: obj) = (InputFactory.jclinit(); InputFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputFactory.jclinitDone then
            InputFactory.jclinitDone <- true
            InputFactory.jclinitBody()
    static member private jclinitBody() : unit =
        InputFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_InputFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.KEY_CODE_LABEL <- "KeyCode: "
        this.DEVICE_ID_LABEL <- "DeviceId: "
        this.MAX <- SmallIntegerSingletonFactory.getInstance().getMin()
        this.inputIntegerArray <- (Array.zeroCreate<Input> (this.MAX))
        this.NO_INPUT <- (new Input(0, this.commonStrings.UNKNOWN))
        ()
    
    static member getInstance() : InputFactory =
        if (JR.same(InputFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            InputFactory.instance <- (new InputFactory())
        (box (InputFactory.instance) :?> InputFactory)
    
    new () as this =
        {  }
        then
            this.jfields_InputFactory()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable size : int = this.inputIntegerArray.Length
        let mutable index : int = 0
        while index < size do
            this.inputIntegerArray.[index] <- this.NO_INPUT
            index <- index + 1
        ()
    
    abstract add : id_: int * input: Input -> unit
    default this.add(id_: int, input: Input) : unit =
        this.inputIntegerArray.[id_] <- input
    
    abstract getInstanceById : id_: int -> Input
    default this.getInstanceById(id_: int) : Input =
        let mutable id_ = id_
        let mutable jflow = 0
        let mutable jret : Input = Unchecked.defaultof<Input>
        if id_ < 0 then
            id_ <- -(id_)
        if id_ > this.inputIntegerArray.Length then
            this.logUtil.putF((new StringMaker()).append("Warning id: ").appendint(id_).ToString(), this, this.commonStrings.GET_INSTANCE)
            jret <- this.NO_INPUT
            jflow <- 1
        if jflow = 0 then
            jret <- this.inputIntegerArray.[id_]
            jflow <- 1
        jret


