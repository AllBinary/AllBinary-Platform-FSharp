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
type GenericOperatingSystem =
    [<DefaultValue(false)>] val mutable osName : string
    [<DefaultValue(false)>] val mutable osArch : string
    [<DefaultValue(false)>] val mutable osVersion : string
    [<DefaultValue(false)>] val mutable characterSet : CharacterSet
    [<DefaultValue(false)>] val mutable scalable : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GenericOperatingSystem.jclinitDone then
            GenericOperatingSystem.jclinitDone <- true
            GenericOperatingSystem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GenericOperatingSystem() : unit =
        this.characterSet <- (new CharacterSet())
        this.scalable <- false
        ()
    
    new () as this =
        {  }
        then
            this.jfields_GenericOperatingSystem()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable systemProperties : SystemProperties = SystemProperties.getInstance()
        let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
        let mutable EMPTY_STRING : string = StringUtil.getInstance().EMPTY_STRING
        if stringValidationUtil.isEmpty(systemProperties.getName()) then
            this.osName <- EMPTY_STRING
        else
            this.osName <- systemProperties.getName()
        if stringValidationUtil.isEmpty(systemProperties.getArch()) then
            this.osArch <- EMPTY_STRING
        else
            this.osArch <- systemProperties.getArch()
        if stringValidationUtil.isEmpty(systemProperties.getVersion()) then
            this.osVersion <- EMPTY_STRING
        else
            this.osVersion <- systemProperties.getVersion()
        ()
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.osName
    
    abstract getVersion : unit -> string
    default this.getVersion() : string =
        this.osVersion
    
    abstract getArch : unit -> string
    default this.getArch() : string =
        this.osArch
    
    abstract getCharacterSet : unit -> CharacterSet
    default this.getCharacterSet() : CharacterSet =
        this.characterSet
    
    abstract isOverScan : unit -> bool
    default this.isOverScan() : bool =
        false
    
    abstract getOverScanXPercent : unit -> int
    default this.getOverScanXPercent() : int =
        100
    
    abstract getOverScanYPercent : unit -> int
    default this.getOverScanYPercent() : int =
        100
    
    abstract isScalable : unit -> bool
    default this.isScalable() : bool =
        this.scalable
    
    abstract isAutoHide : unit -> bool
    default this.isAutoHide() : bool =
        false
    
    override this.ToString() : string =
        let mutable NEW_LINE : string = CommonSeps.getInstance().NEW_LINE
        let mutable osBuffer : StringMaker = (new StringMaker())
        ignore (osBuffer.append("Operating System Info: \n"))
        ignore (osBuffer.append(this.getName()))
        ignore (osBuffer.append(NEW_LINE))
        ignore (osBuffer.append(this.getArch()))
        ignore (osBuffer.append(NEW_LINE))
        ignore (osBuffer.append(this.getVersion()))
        ignore (osBuffer.append(NEW_LINE))
        ignore (osBuffer.append(StringUtil.getInstance().toString(this.getCharacterSet())))
        ignore (osBuffer.append(NEW_LINE))
        osBuffer.ToString()
    interface OperatingSystemInterface with
        member this.getName() : string = this.getName()
        member this.getVersion() : string = this.getVersion()
        member this.getArch() : string = this.getArch()
        member this.getCharacterSet() : CharacterSet = this.getCharacterSet()
        member this.isOverScan() : bool = this.isOverScan()
        member this.getOverScanXPercent() : int = this.getOverScanXPercent()
        member this.getOverScanYPercent() : int = this.getOverScanYPercent()
        member this.isScalable() : bool = this.isScalable()
        member this.isAutoHide() : bool = this.isAutoHide()


