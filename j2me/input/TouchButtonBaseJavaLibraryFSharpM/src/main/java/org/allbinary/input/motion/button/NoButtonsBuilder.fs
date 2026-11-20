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
type NoButtonsBuilder =
    inherit BaseTouchInput
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoButtonsBuilder.jclinitDone then
            NoButtonsBuilder.jclinitDone <- true
            NoButtonsBuilder.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit BaseTouchInput() }
        then
            this.jfields_NoButtonsBuilder()
    member this.jfields_NoButtonsBuilder() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    override this.getList() : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        try
            this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
            let mutable list_ : BasicArrayList = BasicArrayListUtil.getInstance().getImmutableInstance()
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


