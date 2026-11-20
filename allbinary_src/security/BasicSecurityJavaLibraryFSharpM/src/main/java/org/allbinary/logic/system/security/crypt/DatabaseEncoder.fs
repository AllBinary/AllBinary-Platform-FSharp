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
type DatabaseEncoder =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DatabaseEncoder.jclinitDone then
            DatabaseEncoder.jclinitDone <- true
            DatabaseEncoder.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member encode(value: sbyte[]) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        try
            let mutable array_ : sbyte[] = value
            let mutable stringBuffer : StringMaker = (new StringMaker())
            let mutable index : int = 0
            while index < array_.Length do
                ignore (stringBuffer.append((new Byte(array_.[index])).ToString()))
                if index < (array_.Length - 1) then
                    ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
                index <- index + 1
            jret <- stringBuffer.ToString()
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                PreLogUtil.putOE(commonStrings.EXCEPTION, "DatabaseEncoder", "decode", e)
                jret <- StringUtil.getInstance().EMPTY_STRING
                jflow <- 1
            | _ -> reraise ()
        jret
    
    static member decode(value: string) : sbyte[] =
        let mutable jflow = 0
        let mutable jret : sbyte[] = Unchecked.defaultof<sbyte[]>
        try
            let mutable tokenizer : Tokenizer = (new Tokenizer(CommonSeps.getInstance().SPACE))
            let mutable vector : BasicArrayList = tokenizer.getTokensFromString(value, (new BasicArrayListD()))
            let mutable size : int = vector.size()
            let mutable decode : sbyte[] = (Array.zeroCreate<sbyte> (size))
            let mutable byteOfData : string = null
            let mutable index : int = 0
            while index < size do
                byteOfData <- (box (vector.objectArray.[index]) :?> string)
                decode.[index] <- Byte.parseByte(byteOfData)
                index <- index + 1
            jret <- decode
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                PreLogUtil.putSE(commonStrings.EXCEPTION, "DatabaseEncoder", "decode", e)
                jret <- NullUtil.getInstance().NULL_BYTE_ARRAY
                jflow <- 1
            | _ -> reraise ()
        jret


