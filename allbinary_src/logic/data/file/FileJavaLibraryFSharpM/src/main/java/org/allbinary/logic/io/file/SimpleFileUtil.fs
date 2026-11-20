namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type SimpleFileUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable NULL_WRITER : Writer
    [<DefaultValue(false)>] val mutable NULL_READER : Reader
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable nullUtil : NullUtil
    [<DefaultValue(false)>] val mutable streamUtil : StreamUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : SimpleFileUtil
    static member instance with get() : SimpleFileUtil = (SimpleFileUtil.jclinit(); SimpleFileUtil.jcell_instance) and set (jvalue: SimpleFileUtil) = (SimpleFileUtil.jclinit(); SimpleFileUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimpleFileUtil.jclinitDone then
            SimpleFileUtil.jclinitDone <- true
            SimpleFileUtil.jclinitBody()
    static member private jclinitBody() : unit =
        SimpleFileUtil.jcell_instance <- (new SimpleFileUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_SimpleFileUtil()
    member this.jfields_SimpleFileUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.NULL_WRITER <- SimpleFileUtil.nullWriter()
        this.NULL_READER <- SimpleFileUtil.nullReader()
        this.commonStrings <- CommonStrings.getInstance()
        this.nullUtil <- NullUtil.getInstance()
        this.streamUtil <- StreamUtil.getInstance()
        ()
    
    static member getInstance() : SimpleFileUtil =
        SimpleFileUtil.instance
    
    static member nullOutputStream() : OutputStream =
        NullOutputStream.NULL_OUTPUT_STREAM
    
    static member nullWriter() : Writer =
        NullWriter.NULL_WRITER
    
    static member nullReader() : Reader =
        NullReader.NULL_READER
    
    abstract loadFileAsList : inputStream: InputStream * max_: int * byteArray1: sbyte[] -> BasicArrayList
    default this.loadFileAsList(inputStream: InputStream, max_: int, byteArray1: sbyte[]) : BasicArrayList =
        this.loadFileAsListReturnLine(inputStream, max_, byteArray1, 0)
    
    abstract loadFileAsListReturnLine : inputStream: InputStream * max_: int * byteArray1: sbyte[] * includeReturnLine: int -> BasicArrayList
    default this.loadFileAsListReturnLine(inputStream: InputStream, max_: int, byteArray1: sbyte[], includeReturnLine: int) : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        let mutable stringList : BasicArrayList = (new BasicArrayListD())
        if (JR.same(inputStream, null)) then
            jret <- stringList
            jflow <- 1
        if jflow = 0 then
            let mutable byteArray : sbyte[] = this.nullUtil.NULL_BYTE_ARRAY
            try
                let mutable outputStream2 : ByteArrayOutputStream = (new ByteArrayOutputStream(max_))
                byteArray <- this.streamUtil.getByteArray(inputStream, outputStream2, byteArray1)
                ignore (this.streamUtil.close(inputStream))
            with jex ->
                match JR.throwable(jex) with
                | :? JException as e ->
                    ignore (this.streamUtil.close(inputStream))
                    this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.ADD, e)
                | _ -> reraise ()
            if (JR.same(byteArray, null)) then
                jret <- stringList
                jflow <- 1
            if jflow = 0 then
                let mutable size : int = byteArray.Length
                let mutable index : int = 0
                let mutable startIndex : int = 0
                let mutable returnLine : int = 0
                while index < size do
                    startIndex <- index
                    while (index < (size - 1)) && (byteArray.[index] <> sbyte ('\n')) do
                        index <- index + 1
                    if includeReturnLine = 0 then
                        if (index > 0) && (byteArray.[index - 1] = sbyte ('\r')) then
                            returnLine <- 1
                        else
                            returnLine <- 0
                    let mutable s : string = JString.newString(byteArray, startIndex, (((index + includeReturnLine) - returnLine) - startIndex))
                    ignore (stringList.add(s))
                    index <- index + 1
                jret <- stringList
                jflow <- 1
        jret
    
    abstract createStringFromArrayOfStrings : stringArray: string[] -> string
    default this.createStringFromArrayOfStrings(stringArray: string[]) : string =
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable size : int = stringArray.Length
        let mutable index : int = 0
        while index < size do
            ignore (stringMaker.append(stringArray.[index]))
            index <- index + 1
        stringMaker.ToString()


