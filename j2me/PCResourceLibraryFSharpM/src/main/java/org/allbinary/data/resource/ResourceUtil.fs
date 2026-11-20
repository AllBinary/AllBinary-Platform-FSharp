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
    [<DefaultValue(false)>] val mutable path : string
    [<DefaultValue(false)>] val mutable ext : string
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
        this.path <- StringUtil.getInstance().EMPTY_STRING
        this.ext <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    static member getInstance() : ResourceUtil =
        ResourceUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_ResourceUtil()
    
    abstract setLoadingPaths : path: string * ext: string -> unit
    default this.setLoadingPaths(path: string, ext: string) : unit =
        this.path <- path
        this.ext <- ext
    
    abstract setClassLoader : classLoader: ClassLoader -> unit
    default this.setClassLoader(classLoader: ClassLoader) : unit =
        ()
    
    abstract getResourceAsStream : resource: string -> InputStream
    default this.getResourceAsStream(resource: string) : InputStream =
        let mutable inputStream : InputStream = this.getResourceAsStreamAtStart(resource, 2)
        if (JR.same(inputStream, null)) then
            inputStream <- this.getResourceAsStreamAtStart(resource, 1)
            if (JR.same(inputStream, null)) then
                raise ((new JException((new StringMaker()).append("Unable to obtain: ").append(resource).ToString())))
        inputStream
    
    member this.getResourceAsStreamAtStart(resource: string, startIndex: int) : InputStream =
        let mutable jflow = 0
        let mutable jret : InputStream = Unchecked.defaultof<InputStream>
        let mutable inputStream : InputStream = (new FileInputStream((new StringMaker()).append(this.path).append(resource).append(this.ext).ToString()))
        if not (JR.same(inputStream, null)) then
            let mutable byteArray : sbyte[] = (Array.zeroCreate<sbyte> (inputStream.available()))
            ignore (StreamUtil.getInstance().getByteArray(inputStream, (new ByteArrayOutputStream()), byteArray))
            jret <- (new ByteArrayInputStream(byteArray))
            jflow <- 1
        if jflow = 0 then
            jret <- inputStream
            jflow <- 1
        jret
    
    abstract addResource : resource: string * value: Integer -> unit
    default this.addResource(resource: string, value: Integer) : unit =
        ()


