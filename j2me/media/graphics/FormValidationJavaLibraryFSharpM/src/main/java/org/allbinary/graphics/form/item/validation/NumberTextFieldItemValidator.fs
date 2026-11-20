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
type NumberTextFieldItemValidator =
    inherit ValidatorBase
    [<DefaultValue(false)>] val mutable textFieldItem : ABTextFieldItem
    [<DefaultValue(false)>] val mutable min : int
    [<DefaultValue(false)>] val mutable max : int
    [<DefaultValue(false)>] val mutable maxChars : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NumberTextFieldItemValidator.jclinitDone then
            NumberTextFieldItemValidator.jclinitDone <- true
            NumberTextFieldItemValidator.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (textFieldItem: ABTextFieldItem, maxChars: int, min_: int, max_: int) as this =
        { inherit ValidatorBase() }
        then
            this.jctor1(textFieldItem, maxChars, min_, max_)
    member this.jctor1(textFieldItem: ABTextFieldItem, maxChars: int, min_: int, max_: int) : unit =
        this.textFieldItem <- textFieldItem
        this.min <- min_
        this.max <- max_
        this.maxChars <- maxChars
        ()
    
    abstract isNumberValid : value: Integer -> Boolean
    default this.isNumberValid(value: Integer) : Boolean =
        BooleanFactory.getInstance().TRUE
    
    abstract toNumberVector : value: Integer -> BasicArrayList
    default this.toNumberVector(value: Integer) : BasicArrayList =
        (new BasicArrayListD())
    
    override this.isValid() : Boolean =
        let mutable result : Boolean = BooleanFactory.getInstance().TRUE
        let mutable string_ : string = this.textFieldItem.getString()
        let mutable textLength : int = JString.length(string_)
        if (textLength > 0) && (textLength < this.maxChars) then
            try
                ignore (Integer.parseInt(this.textFieldItem.getString()))
            with jex ->
                match JR.throwable(jex) with
                | :? JNumberFormatException as e ->
                    result <- BooleanFactory.getInstance().FALSE
                | _ -> reraise ()
        else
            if textLength < 1 then
                result <- BooleanFactory.getInstance().FALSE
            elif textLength > this.maxChars then
                result <- BooleanFactory.getInstance().FALSE
        result
    
    override this.toList() : BasicArrayList =
        let mutable list_ : BasicArrayList = (new BasicArrayListD())
        let mutable string_ : string = this.textFieldItem.getString()
        let mutable textLength : int = JString.length(string_)
        let mutable label : string = this.textFieldItem.getLabel()
        let mutable name : string = JString.substring(label, 0, (JString.length(label) - 2))
        let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
        let mutable stringMaker : StringMaker = (new StringMaker())
        if (textLength > 0) && (textLength < this.maxChars) then
            try
                let mutable number : Integer = smallIntegerSingletonFactory.createInstance(Integer.parseInt(this.textFieldItem.getString()))
                if number.intValue() > this.min then
                    ignore (stringMaker.delete(0, stringMaker.length()))
                    ignore (list_.add(stringMaker.append(name).append(" is to small").ToString()))
                elif number.intValue() > this.max then
                    ignore (stringMaker.delete(0, stringMaker.length()))
                    ignore (list_.add(stringMaker.append(name).append(" is to large").ToString()))
            with jex ->
                match JR.throwable(jex) with
                | :? JNumberFormatException as e ->
                    ignore (stringMaker.delete(0, stringMaker.length()))
                    ignore (list_.add(stringMaker.append(name).append(" is not a number").ToString()))
                | _ -> reraise ()
        else
            if textLength < 1 then
                ignore (stringMaker.delete(0, stringMaker.length()))
                ignore (list_.add(stringMaker.append(name).append(" is to short").ToString()))
            elif textLength > this.maxChars then
                ignore (stringMaker.delete(0, stringMaker.length()))
                ignore (list_.add(stringMaker.append(name).append(" is to long").ToString()))
        list_


