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
type BasicCryptUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable tsUtil : TsUtil
    [<DefaultValue(false)>] val mutable XML_START : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : BasicCryptUtil
    static member instance with get() : BasicCryptUtil = (BasicCryptUtil.jclinit(); BasicCryptUtil.jcell_instance) and set (jvalue: BasicCryptUtil) = (BasicCryptUtil.jclinit(); BasicCryptUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicCryptUtil.jclinitDone then
            BasicCryptUtil.jclinitDone <- true
            BasicCryptUtil.jclinitBody()
    static member private jclinitBody() : unit =
        BasicCryptUtil.jcell_instance <- (new BasicCryptUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicCryptUtil()
    member this.jfields_BasicCryptUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.tsUtil <- TsUtil.getInstance()
        this.XML_START <- "<?xml"
        ()
    
    static member getInstance() : BasicCryptUtil =
        BasicCryptUtil.instance
    
    abstract getDecryptedInputStream : inputStream: InputStream * cryptInterface: CryptInterface -> InputStream
    default this.getDecryptedInputStream(inputStream: InputStream, cryptInterface: CryptInterface) : InputStream =
        let mutable jflow = 0
        let mutable jret : InputStream = Unchecked.defaultof<InputStream>
        let mutable buffer : ByteArrayOutputStream = (new ByteArrayOutputStream())
        let mutable ch : int = 0
        while jflow = 0 && (true) do
            ch <- inputStream.read()
            if ch = (-1) then
                jflow <- 100001
            if jflow = 0 then
                ignore (buffer.write(ch))
            if jflow = 200001 then jflow <- 0
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            let mutable decrypted : sbyte[] = cryptInterface.decrypt(buffer.toByteArray())
            let mutable decryptedString : string = JString.newString(decrypted)
            let mutable index : int = JString.indexOf(decryptedString, this.XML_START)
            if index > 0 then
                decryptedString <- JString.substring(decryptedString, index)
            jret <- (new ByteArrayInputStream(this.tsUtil.getByteArray(decryptedString)))
            jflow <- 1
        jret


