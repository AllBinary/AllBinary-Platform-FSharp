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
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : BasicTouchButtonsBuilder
    static member SINGLETON with get() : BasicTouchButtonsBuilder = (BasicTouchButtonsBuilder.jclinit(); BasicTouchButtonsBuilder.jcell_SINGLETON) and set (jvalue: BasicTouchButtonsBuilder) = (BasicTouchButtonsBuilder.jclinit(); BasicTouchButtonsBuilder.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicTouchButtonsBuilder.jclinitDone then
            BasicTouchButtonsBuilder.jclinitDone <- true
            BasicTouchButtonsBuilder.jclinitBody()
    static member private jclinitBody() : unit =
        BasicTouchButtonsBuilder.jcell_SINGLETON <- (new BasicTouchButtonsBuilder())
        ()
    new () as this =
        { inherit BaseTouchInput() }
        then
            this.jfields_BasicTouchButtonsBuilder()
    member this.jfields_BasicTouchButtonsBuilder() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : BaseTouchInput =
        BasicTouchButtonsBuilder.SINGLETON
    
    override this.getList() : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        try
            this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.GET_LIST)
            let mutable list_ : BasicArrayList = (new BasicArrayListD())
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


