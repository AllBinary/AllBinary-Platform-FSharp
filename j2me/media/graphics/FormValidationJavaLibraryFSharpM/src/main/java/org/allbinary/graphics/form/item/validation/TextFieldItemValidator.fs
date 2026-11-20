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
type TextFieldItemValidator =
    inherit ValidatorBase
    [<DefaultValue(false)>] val mutable textFieldItem : ABTextFieldItem
    [<DefaultValue(false)>] val mutable min : int
    [<DefaultValue(false)>] val mutable max : int
    [<DefaultValue(false)>] val mutable allowOnEmpty : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TextFieldItemValidator.jclinitDone then
            TextFieldItemValidator.jclinitDone <- true
            TextFieldItemValidator.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (textFieldItem: ABTextFieldItem, min_: int, max_: int, allowOnEmpty: bool) as this =
        { inherit ValidatorBase() }
        then
            this.jctor1(textFieldItem, min_, max_, allowOnEmpty)
    member this.jctor1(textFieldItem: ABTextFieldItem, min_: int, max_: int, allowOnEmpty: bool) : unit =
        this.textFieldItem <- textFieldItem
        this.min <- min_
        this.max <- max_
        this.allowOnEmpty <- allowOnEmpty
        ()
    
    override this.isValid() : Boolean =
        let mutable booleanFactory : BooleanFactory = BooleanFactory.getInstance()
        let mutable result : Boolean = booleanFactory.TRUE
        let mutable string_ : string = this.textFieldItem.getString()
        let mutable textLength : int = JString.length(string_)
        if ((textLength = 0) && this.allowOnEmpty) || ((textLength > this.min) && (textLength < this.max)) then
            ()
        else
            if textLength < this.min then
                result <- booleanFactory.FALSE
            elif textLength > this.max then
                result <- booleanFactory.FALSE
        result
    
    override this.toList() : BasicArrayList =
        let mutable list_ : BasicArrayList = (new BasicArrayListD())
        let mutable string_ : string = this.textFieldItem.getString()
        let mutable textLength : int = JString.length(string_)
        if (textLength > this.min) && (textLength < this.max) then
            ()
        else
            let mutable label : string = this.textFieldItem.getLabel()
            let mutable name : string = JString.substring(label, 0, (JString.length(label) - 2))
            if textLength < this.min then
                ignore (list_.add((new StringMaker()).append(name).append(" is to short").ToString()))
            elif textLength > this.max then
                ignore (list_.add((new StringMaker()).append(name).append(" is to long").ToString()))
        list_


