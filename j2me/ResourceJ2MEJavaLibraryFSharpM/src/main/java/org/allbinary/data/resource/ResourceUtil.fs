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
type ResourceUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : ResourceUtil
    static member instance with get() : ResourceUtil = (ResourceUtil.jclinit(); ResourceUtil.jcell_instance) and set (jvalue: ResourceUtil) = (ResourceUtil.jclinit(); ResourceUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ResourceUtil.jclinitDone then
            ResourceUtil.jclinitDone <- true
            ResourceUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ResourceUtil.jcell_instance <- (new ResourceUtil())
        ()
    member this.jfields_ResourceUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : ResourceUtil =
        ResourceUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_ResourceUtil()
    
    abstract setLoadingPaths : path: string * ext: string -> unit
    default this.setLoadingPaths(path: string, ext: string) : unit =
        this.logUtil.putF(CommonStrings.getInstance().NOT_IMPLEMENTED, this, "setLoadingPaths")
    
    abstract getResourceAsStream : resource: string -> InputStream
    default this.getResourceAsStream(resource: string) : InputStream =
        let mutable inputStream : InputStream = JR.getResourceAsStream(resource)
        if (JR.same(inputStream, null)) then
            inputStream <- this.getResourceAsStreamAtStart(resource, 2)
            if (JR.same(inputStream, null)) then
                inputStream <- this.getResourceAsStreamAtStart(resource, 1)
                if (JR.same(inputStream, null)) then
                    let mutable stringMaker : StringMaker = (new StringMaker())
                    let mutable index : int = JString.lastIndexOf(resource, '/')
                    let mutable resourcePath : string = JString.substring(resource, (index + 1))
                    inputStream <- JR.getResourceAsStream(resourcePath)
                    if (JR.same(inputStream, null)) then
                        resourcePath <- JString.substring(resource, index)
                        inputStream <- JR.getResourceAsStream(resourcePath)
                        if (JR.same(inputStream, null)) then
                            let mutable RES : string = "res"
                            resourcePath <- stringMaker.append(RES).append(JString.substring(resource, index)).ToString()
                            inputStream <- JR.getResourceAsStream(resourcePath)
                            if (JR.same(inputStream, null)) then
                                ignore (stringMaker.delete(0, stringMaker.length()))
                                resourcePath <- stringMaker.append("/").append(RES).append(JString.substring(resource, index)).ToString()
                                inputStream <- JR.getResourceAsStream(resourcePath)
                                let mutable COLON : string = CommonSeps.getInstance().COLON
                                if (JR.same(inputStream, null)) then
                                    ignore (stringMaker.delete(0, stringMaker.length()))
                                    resourcePath <- stringMaker.append(RES).append(COLON).append(JString.substring(resource, index)).ToString()
                                    inputStream <- JR.getResourceAsStream(resourcePath)
                                    if (JR.same(inputStream, null)) then
                                        ignore (stringMaker.delete(0, stringMaker.length()))
                                        resourcePath <- stringMaker.append(RES).append(COLON).append(JString.substring(resource, (index + 1))).ToString()
                                        inputStream <- JR.getResourceAsStream(resourcePath)
                                        if (JR.same(inputStream, null)) then
                                            let mutable RESOURCE_STRING : string = "resource"
                                            ignore (stringMaker.delete(0, stringMaker.length()))
                                            resourcePath <- stringMaker.append(RESOURCE_STRING).append(COLON).append(JString.substring(resource, index)).ToString()
                                            inputStream <- JR.getResourceAsStream(resourcePath)
                                            if (JR.same(inputStream, null)) then
                                                ignore (stringMaker.delete(0, stringMaker.length()))
                                                resourcePath <- stringMaker.append(RESOURCE_STRING).append(COLON).append(JString.substring(resource, (index + 1))).ToString()
                                                inputStream <- JR.getResourceAsStream(resourcePath)
                                                if (JR.same(inputStream, null)) then
                                                    ignore (stringMaker.delete(0, stringMaker.length()))
                                                    raise ((new JException(stringMaker.append("Unable to obtain: ").append(resource).ToString())))
        inputStream
    
    member this.getResourceAsStreamAtStart(resource: string, startIndex: int) : InputStream =
        let mutable jflow = 0
        let mutable jret : InputStream = Unchecked.defaultof<InputStream>
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable index : int = JString.indexOf(resource, CommonSeps.getInstance().COLON)
        let mutable resourcePath : string = JString.substring(resource, (index + startIndex))
        let mutable inputStream : InputStream = JR.getResourceAsStream(resourcePath)
        if not (JR.same(inputStream, null)) then
            jret <- inputStream
            jflow <- 1
        if jflow = 0 then
            jret <- inputStream
            jflow <- 1
        jret
    
    abstract addResource : resource: string * value: Integer -> unit
    default this.addResource(resource: string, value: Integer) : unit =
        ()


