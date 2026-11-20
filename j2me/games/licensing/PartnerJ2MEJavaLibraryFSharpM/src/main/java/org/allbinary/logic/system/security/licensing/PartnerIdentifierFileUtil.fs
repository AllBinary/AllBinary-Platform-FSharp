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
type PartnerIdentifierFileUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable FILE_NAME : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : PartnerIdentifierFileUtil
    static member instance with get() : PartnerIdentifierFileUtil = (PartnerIdentifierFileUtil.jclinit(); PartnerIdentifierFileUtil.jcell_instance) and set (jvalue: PartnerIdentifierFileUtil) = (PartnerIdentifierFileUtil.jclinit(); PartnerIdentifierFileUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PartnerIdentifierFileUtil.jclinitDone then
            PartnerIdentifierFileUtil.jclinitDone <- true
            PartnerIdentifierFileUtil.jclinitBody()
    static member private jclinitBody() : unit =
        PartnerIdentifierFileUtil.jcell_instance <- (new PartnerIdentifierFileUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_PartnerIdentifierFileUtil()
    member this.jfields_PartnerIdentifierFileUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.FILE_NAME <- "partner.txt"
        ()
    
    static member getInstance() : PartnerIdentifierFileUtil =
        PartnerIdentifierFileUtil.instance
    
    abstract get : unit -> string
    default this.get() : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        try
            let mutable resourceUtil : ResourceUtil = ResourceUtil.getInstance()
            let mutable inputStream : InputStream = resourceUtil.getResourceAsStream(this.FILE_NAME)
            let mutable inputStreamReader : InputStreamReader = (new InputStreamReader(inputStream))
            let mutable chars : char[] = (Array.zeroCreate<char> (30))
            let mutable size : int = inputStreamReader.read(chars)
            let mutable partnerString : string = StringUtil.getInstance().EMPTY_STRING
            if size > 0 then
                partnerString <- JString.newString(chars, 0, size)
            ignore (inputStreamReader.close())
            jret <- partnerString
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.GET, e)
                jret <- StringUtil.getInstance().NULL_STRING
                jflow <- 1
            | _ -> reraise ()
        jret


