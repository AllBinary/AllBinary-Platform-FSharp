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
type ValidatorBase =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ValidatorBase
    static member instance with get() : ValidatorBase = (ValidatorBase.jclinit(); ValidatorBase.jcell_instance) and set (jvalue: ValidatorBase) = (ValidatorBase.jclinit(); ValidatorBase.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ValidatorBase.jclinitDone then
            ValidatorBase.jclinitDone <- true
            ValidatorBase.jclinitBody()
    static member private jclinitBody() : unit =
        ValidatorBase.jcell_instance <- (new ValidatorBase())
        ()
    
    static member getInstance() : ValidatorBase =
        ValidatorBase.instance
    
    new () =
        {  }
    
    abstract isValid : unit -> Boolean
    default this.isValid() : Boolean =
        BooleanFactory.getInstance().TRUE
    
    abstract validationInfo : unit -> string
    default this.validationInfo() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract toHashtable : unit -> ABHashtable
    default this.toHashtable() : ABHashtable =
        StdUtil.getInstance().NULL_TABLE
    
    abstract toList : unit -> BasicArrayList
    default this.toList() : BasicArrayList =
        BasicArrayListUtil.getInstance().getImmutableInstance()
    interface ValidatorBaseInterface with
        member this.isValid() : Boolean = this.isValid()
        member this.validationInfo() : string = this.validationInfo()
        member this.toHashtable() : ABHashtable = this.toHashtable()
        member this.toList() : BasicArrayList = this.toList()


