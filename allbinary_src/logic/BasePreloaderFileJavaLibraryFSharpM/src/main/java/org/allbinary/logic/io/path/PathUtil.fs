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
type PathUtil =
    [<DefaultValue(false)>] val mutable abPathData : AbPathData
    [<DefaultValue(false)>] val mutable filePathData : FilePathData
    [<DefaultValue(false)>] static val mutable private jcell_instance : PathUtil
    static member instance with get() : PathUtil = (PathUtil.jclinit(); PathUtil.jcell_instance) and set (jvalue: PathUtil) = (PathUtil.jclinit(); PathUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PathUtil.jclinitDone then
            PathUtil.jclinitDone <- true
            PathUtil.jclinitBody()
    static member private jclinitBody() : unit =
        PathUtil.jcell_instance <- (new PathUtil())
        ()
    member this.jfields_PathUtil() : unit =
        this.abPathData <- AbPathData.getInstance()
        this.filePathData <- FilePathData.getInstance()
        ()
    
    static member getInstance() : PathUtil =
        PathUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_PathUtil()
    
    abstract getExtensionWithAbFilePath : abFilePath: AbFilePath -> string
    default this.getExtensionWithAbFilePath(abFilePath: AbFilePath) : string =
        this.abPathData.getExtension(abFilePath.ToString())
    
    abstract getExtensionWithAbPath : abPath: AbPath -> string
    default this.getExtensionWithAbPath(abPath: AbPath) : string =
        this.abPathData.getExtension(abPath.ToString())
    
    abstract getWithoutExtensionWithAbFilePath : abFilePath: AbFilePath -> string
    default this.getWithoutExtensionWithAbFilePath(abFilePath: AbFilePath) : string =
        this.getWithoutExtension(abFilePath.ToString())
    
    abstract getWithoutExtensionWithAbPath : abPath: AbPath -> string
    default this.getWithoutExtensionWithAbPath(abPath: AbPath) : string =
        this.getWithoutExtension(abPath.ToString())
    
    abstract getWithoutExtension : filePath: string -> string
    default this.getWithoutExtension(filePath: string) : string =
        let mutable indexOfFileExtensionDelmiter : int = this.abPathData.getExtensionIndex(filePath)
        let mutable pathWithoutExtension : string = filePath
        if indexOfFileExtensionDelmiter >= 0 then
            pathWithoutExtension <- JString.substring(filePath, 0, indexOfFileExtensionDelmiter)
        pathWithoutExtension
    
    abstract isValid : path: string -> bool
    default this.isValid(path: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.isValidStart(path) then
            if this.isValidEnd(path) then
                jret <- true
                jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    member this.isValidStart(path: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JString.charAt(path, 0) = this.abPathData.SEPARATORCHAR) || (JString.charAt(path, 0) = '.') then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    member this.isValidEnd(path: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
        if stringValidationUtil.isEmpty(path) then
            jret <- false
            jflow <- 1
        if jflow = 0 then
            if JString.charAt(path, (JString.length(path) - 1)) = this.abPathData.SEPARATORCHAR then
                jret <- true
                jflow <- 1
            else
                jret <- false
                jflow <- 1
        jret
    
    abstract adjustStart : path: string -> string
    default this.adjustStart(path: string) : string =
        let mutable path = path
        if not (this.isValidStart(path)) then
            path <- JR.nn(this.abPathData.SEPARATOR) + JR.nn(path)
        path
    
    abstract adjustEnd : path: string -> string
    default this.adjustEnd(path: string) : string =
        let mutable path = path
        if not (this.isValidEnd(path)) then
            path <- JR.nn(path) + JR.nn(this.abPathData.SEPARATOR)
        path
    
    abstract adjust : path: string -> string
    default this.adjust(path: string) : string =
        let mutable path = path
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
        if stringValidationUtil.isEmpty(path) then
            jret <- this.abPathData.SEPARATOR
            jflow <- 1
        if jflow = 0 then
            if JString.indexOf(path, "\\") >= 0 then
                path <- JString.replace(path, '\\', this.abPathData.SEPARATORCHAR)
            jret <- path
            jflow <- 1
        jret
    
    abstract removeNameFromPath : path: string -> AbPath
    default this.removeNameFromPath(path: string) : AbPath =
        let mutable jflow = 0
        let mutable jret : AbPath = Unchecked.defaultof<AbPath>
        let mutable endIndex : int = JString.lastIndexOf(path, this.abPathData.SEPARATOR)
        if endIndex < 0 then
            endIndex <- JString.lastIndexOf(path, this.filePathData.SEPARATORCHAR)
        if endIndex < 0 then
            jret <- AbPath.createAbPath()
            jflow <- 1
        if jflow = 0 then
            if JString.length(path) = (endIndex + 1) then
                jret <- this.removeNameFromPath(JString.substring(path, 0, (endIndex - 1)))
                jflow <- 1
            else
                let mutable pathWithoutName : string = JString.substring(path, 0, endIndex)
                jret <- (new AbPath(pathWithoutName, StringUtil.getInstance().EMPTY_STRING))
                jflow <- 1
        jret


