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
type Tokenizer =
    [<DefaultValue(false)>] val mutable sep : string
    [<DefaultValue(false)>] val mutable endSep : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Tokenizer.jclinitDone then
            Tokenizer.jclinitDone <- true
            Tokenizer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_Tokenizer() : unit =
        this.endSep <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new (sep: string) as this =
        {  }
        then
            this.jfields_Tokenizer()
            this.jctor1(sep)
    member this.jctor1(sep: string) : unit =
        if TsUtil.getInstance().compareTo(sep, StringUtil.getInstance().EMPTY_STRING) = 0 then
            raise ((new JException("Sep provided is not valid")))
        this.sep <- sep
        ()
    
    abstract setSep : sep: string -> unit
    default this.setSep(sep: string) : unit =
        this.sep <- sep
    
    abstract setEndSep : endSep: string -> unit
    default this.setEndSep(endSep: string) : unit =
        this.endSep <- endSep
    
    abstract getInsideSep : string_: string -> BasicArrayList
    default this.getInsideSep(string_: string) : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        let mutable tokenList : BasicArrayList = (new BasicArrayListD())
        let mutable index : int = 0
        let mutable size : int = JString.length(string_)
        while jflow = 0 && (index < size) do
            index <- JString.indexOf(string_, this.sep, index)
            if index <> (-1) then
                let mutable end_ : int = JString.indexOf(string_, this.endSep, (index + JString.length(this.sep)))
                if end_ <> (-1) then
                    ignore (tokenList.add(JString.substring(string_, (index + JString.length(this.sep)), (end_ - (JString.length(this.endSep) - 1)))))
                    index <- end_ + JString.length(this.endSep)
                else
                    ()
            else
                jflow <- 100001
            if jflow = 200001 then jflow <- 0
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- tokenList
            jflow <- 1
        jret
    
    abstract getTokensFromString : string_: string * tokenVector: BasicArrayList -> BasicArrayList
    default this.getTokensFromString(string_: string, tokenVector: BasicArrayList) : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        let mutable index : int = 0
        let mutable end_ : int = 0
        while jflow = 0 && (index < JString.length(string_)) do
            end_ <- JString.indexOf(string_, this.sep, index)
            if end_ <> (-1) then
                ignore (tokenVector.add(JString.substring(string_, index, end_)))
                index <- end_ + JString.length(this.sep)
            else
                ignore (tokenVector.add(JString.substring(string_, index, JString.length(string_))))
                jflow <- 100002
            if jflow = 200002 then jflow <- 0
        if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            jret <- tokenVector
            jflow <- 1
        jret
    
    abstract getTokens : stringVector: BasicArrayList -> ABHashtable
    default this.getTokens(stringVector: BasicArrayList) : ABHashtable =
        let mutable tokenHashtable : ABHashtable = StdUtil.getInstance().createHashtable()
        let mutable string_ : string = StringUtil.getInstance().EMPTY_STRING
        let mutable end_ : int = 0
        let mutable size : int = stringVector.size()
        let mutable index : int = 0
        while index < size do
            string_ <- (box (stringVector.objectArray.[index]) :?> string)
            end_ <- JString.indexOf(string_, this.sep)
            if end_ >= 0 then
                ignore (tokenHashtable.put(JString.substring(string_, 0, end_), JString.substring(string_, (end_ + 1), JString.length(string_))))
            index <- index + 1
        tokenHashtable


