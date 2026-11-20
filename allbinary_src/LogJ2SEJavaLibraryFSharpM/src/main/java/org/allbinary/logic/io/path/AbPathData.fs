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
type AbPathData =
    [<DefaultValue(false)>] val mutable EXTENSION_SEP : string
    [<DefaultValue(false)>] val mutable SEPARATORCHAR : char
    [<DefaultValue(false)>] val mutable SEPARATOR : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : AbPathData
    static member instance with get() : AbPathData = (AbPathData.jclinit(); AbPathData.jcell_instance) and set (jvalue: AbPathData) = (AbPathData.jclinit(); AbPathData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbPathData.jclinitDone then
            AbPathData.jclinitDone <- true
            AbPathData.jclinitBody()
    static member private jclinitBody() : unit =
        AbPathData.jcell_instance <- (new AbPathData())
        ()
    member this.jfields_AbPathData() : unit =
        this.EXTENSION_SEP <- CommonSeps.getInstance().PERIOD
        this.SEPARATORCHAR <- '/'
        this.SEPARATOR <- CommonSeps.getInstance().FORWARD_SLASH
        ()
    
    static member getInstance() : AbPathData =
        AbPathData.instance
    
    new () as this =
        {  }
        then
            this.jfields_AbPathData()
    
    abstract getExtensionIndex : filePath: string -> int
    default this.getExtensionIndex(filePath: string) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable indexOfFileExtensionDelmiter : int = JString.lastIndexOf(filePath, this.EXTENSION_SEP)
        let mutable indexOfLatDelimiter : int = JString.lastIndexOf(filePath, this.SEPARATORCHAR)
        if indexOfFileExtensionDelmiter < 0 then
            jret <- -1
            jflow <- 1
        if jflow = 0 then
            if indexOfFileExtensionDelmiter < indexOfLatDelimiter then
                jret <- -1
                jflow <- 1
            if jflow = 0 then
                jret <- indexOfFileExtensionDelmiter
                jflow <- 1
        jret
    
    abstract getExtensionWithDot : filePath: string -> string
    default this.getExtensionWithDot(filePath: string) : string =
        let mutable indexOfFileExtensionDelmiter : int = this.getExtensionIndex(filePath)
        let mutable extension : string = StringUtil.getInstance().EMPTY_STRING
        if indexOfFileExtensionDelmiter >= 0 then
            extension <- JString.substring(filePath, indexOfFileExtensionDelmiter)
        extension
    
    abstract getExtension : filePath: string -> string
    default this.getExtension(filePath: string) : string =
        let mutable indexOfFileExtensionDelmiter : int = this.getExtensionIndex(filePath)
        let mutable extension : string = StringUtil.getInstance().EMPTY_STRING
        if indexOfFileExtensionDelmiter >= 0 then
            extension <- JString.substring(filePath, (indexOfFileExtensionDelmiter + 1))
        extension
    
    abstract getNameFromPath : path: string -> string
    default this.getNameFromPath(path: string) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable endIndex : int = JString.lastIndexOf(path, this.SEPARATORCHAR)
        if endIndex < 0 then
            endIndex <- JString.lastIndexOf(path, FilePathData.getInstance().SEPARATORCHAR)
        if endIndex < 0 then
            jret <- path
            jflow <- 1
        if jflow = 0 then
            if JString.length(path) = (endIndex + 1) then
                let mutable categoryName : string = JString.substring(path, 0, endIndex)
                jret <- this.getNameFromPath(categoryName)
                jflow <- 1
            else
                let mutable categoryName : string = JString.substring(path, (endIndex + 1))
                jret <- categoryName
                jflow <- 1
        jret
    
    abstract removeNameFromPath : path: string -> string
    default this.removeNameFromPath(path: string) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable endIndex : int = JString.lastIndexOf(path, this.SEPARATORCHAR)
        if endIndex < 0 then
            endIndex <- JString.lastIndexOf(path, FilePathData.getInstance().SEPARATORCHAR)
        if endIndex < 0 then
            jret <- StringUtil.getInstance().EMPTY_STRING
            jflow <- 1
        if jflow = 0 then
            if JString.length(path) = (endIndex + 1) then
                jret <- this.removeNameFromPath(JString.substring(path, 0, (endIndex - 1)))
                jflow <- 1
            else
                let mutable pathWithoutName : string = JString.substring(path, 0, endIndex)
                jret <- pathWithoutName
                jflow <- 1
        jret


