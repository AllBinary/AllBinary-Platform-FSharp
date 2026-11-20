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
type AbPath =
    [<DefaultValue(false)>] val mutable commonSeps : CommonSeps
    [<DefaultValue(false)>] val mutable abPathData : AbPathData
    [<DefaultValue(false)>] val mutable abPathUtil : PathUtil
    [<DefaultValue(false)>] val mutable EMPTY_STRING : string
    [<DefaultValue(false)>] val mutable schema : string
    [<DefaultValue(false)>] val mutable path : string
    [<DefaultValue(false)>] val mutable nameP : string
    [<DefaultValue(false)>] val mutable hasSchemaP : bool
    [<DefaultValue(false)>] val mutable numberOfSeps : int
    static member NETWORK_SEP : string = ":/"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbPath.jclinitDone then
            AbPath.jclinitDone <- true
            AbPath.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AbPath() : unit =
        this.commonSeps <- CommonSeps.getInstance()
        this.abPathData <- AbPathData.getInstance()
        this.abPathUtil <- PathUtil.getInstance()
        this.EMPTY_STRING <- StringUtil.getInstance().EMPTY_STRING
        this.schema <- this.EMPTY_STRING
        this.path <- this.EMPTY_STRING
        this.nameP <- this.EMPTY_STRING
        this.hasSchemaP <- false
        this.numberOfSeps <- 0
        ()
    
    static member createAbPath() : AbPath =
        let mutable jflow = 0
        let mutable jret : AbPath = Unchecked.defaultof<AbPath>
        try
            let mutable EMPTY_STRING : string = StringUtil.getInstance().EMPTY_STRING
            jret <- (new AbPath(EMPTY_STRING, EMPTY_STRING))
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as ex ->
                raise ((new JRuntimeException()))
            | _ -> reraise ()
        jret
    
    new (aPath: string, name: string) as this =
        {  }
        then
            this.jfields_AbPath()
            this.jctor1(aPath, name)
    member this.jctor1(aPath: string, name: string) : unit =
        let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
        if not (stringValidationUtil.isEmpty(aPath)) then
            this.schema <- this.getSchema(aPath)
            this.nameP <- name
            this.path <- this.abPathUtil.adjustEnd(this.abPathUtil.adjust(this.getPathFromPath(aPath)))
        else
            this.init()
            if not (stringValidationUtil.isEmpty(name)) then
                this.nameP <- name
        ()
    
    member this.init() : unit =
        this.schema <- this.EMPTY_STRING
        this.setPath(this.abPathData.SEPARATOR)
        this.nameP <- this.EMPTY_STRING
    
    abstract getSchema : aPath: string -> string
    default this.getSchema(aPath: string) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable beginIndex : int = JString.indexOf(aPath, this.commonSeps.COLON)
        if beginIndex >= 0 then
            this.hasSchemaP <- true
            jret <- JString.substring(aPath, 0, beginIndex)
            jflow <- 1
        if jflow = 0 then
            this.hasSchemaP <- false
            jret <- this.EMPTY_STRING
            jflow <- 1
        jret
    
    abstract hasSchema : unit -> bool
    default this.hasSchema() : bool =
        this.hasSchemaP
    
    abstract getPathFromPath : aPath: string -> string
    default this.getPathFromPath(aPath: string) : string =
        let mutable filePathData : FilePathData = FilePathData.getInstance()
        let mutable tempPath : string = aPath
        if not (this.hasSchema()) then
            tempPath <- this.abPathUtil.adjustStart(tempPath)
        else
            let mutable beginIndex : int = JString.indexOf(tempPath, this.commonSeps.COLON)
            if beginIndex >= 0 then
                beginIndex <- beginIndex + 1
                while (JString.charAt(tempPath, beginIndex) = this.abPathData.SEPARATORCHAR) || (JString.charAt(tempPath, beginIndex) = filePathData.SEPARATORCHAR) do
                    beginIndex <- beginIndex + 1
                    this.numberOfSeps <- this.numberOfSeps + 1
                    if this.numberOfSeps > 2 then
                        raise ((new JException("Should Not Have More Than Two Seps")))
                tempPath <- JString.substring(tempPath, beginIndex, JString.length(tempPath))
        tempPath
    
    abstract setName : name: string -> unit
    default this.setName(name: string) : unit =
        this.nameP <- name
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.nameP
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        if this.hasSchema() then
            ignore (stringBuffer.append(this.schema))
            ignore (stringBuffer.append(AbPath.NETWORK_SEP))
        ignore (stringBuffer.append(this.getPath()))
        ignore (stringBuffer.append(this.nameP))
        stringBuffer.ToString()
    
    abstract toFileSystemString : unit -> string
    default this.toFileSystemString() : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        if this.hasSchema() then
            let mutable filePathData : FilePathData = FilePathData.getInstance()
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append(this.schema))
            ignore (stringBuffer.append(this.commonSeps.COLON))
            ignore (stringBuffer.append(filePathData.PATH_START))
            ignore (stringBuffer.append(FilePathUtil.adjust(this.getPath())))
            ignore (stringBuffer.append(this.nameP))
            jret <- stringBuffer.ToString()
            jflow <- 1
        else
            jret <- JR.nn(FilePathUtil.adjust(this.getPath())) + JR.nn(this.nameP)
            jflow <- 1
        jret
    
    abstract getPath : unit -> string
    default this.getPath() : string =
        this.path
    
    abstract setPath : path: string -> unit
    default this.setPath(path: string) : unit =
        this.path <- path


