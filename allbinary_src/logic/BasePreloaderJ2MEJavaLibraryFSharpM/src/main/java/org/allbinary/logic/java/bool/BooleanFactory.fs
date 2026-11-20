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
type BooleanFactory =
    [<DefaultValue(false)>] val mutable TRUE : Boolean
    [<DefaultValue(false)>] val mutable FALSE : Boolean
    [<DefaultValue(false)>] val mutable TRUE_STRING : string
    [<DefaultValue(false)>] val mutable FALSE_STRING : string
    [<DefaultValue(false)>] val mutable YES : string
    [<DefaultValue(false)>] val mutable NO : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : BooleanFactory
    static member instance with get() : BooleanFactory = (BooleanFactory.jclinit(); BooleanFactory.jcell_instance) and set (jvalue: BooleanFactory) = (BooleanFactory.jclinit(); BooleanFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BooleanFactory.jclinitDone then
            BooleanFactory.jclinitDone <- true
            BooleanFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BooleanFactory.jcell_instance <- (new BooleanFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_BooleanFactory()
    member this.jfields_BooleanFactory() : unit =
        this.TRUE <- (new Boolean(true))
        this.FALSE <- (new Boolean(false))
        this.TRUE_STRING <- this.TRUE.ToString()
        this.FALSE_STRING <- this.FALSE.ToString()
        this.YES <- "yes"
        this.NO <- "no"
        ()
    
    static member getInstance() : BooleanFactory =
        BooleanFactory.instance
    
    abstract toStringb : bool: bool -> string
    default this.toStringb(bool: bool) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        if bool then
            jret <- this.TRUE_STRING
            jflow <- 1
        else
            jret <- this.FALSE_STRING
            jflow <- 1
        jret


