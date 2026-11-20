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
type SoftwareInformation =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable shortName : string
    [<DefaultValue(false)>] val mutable version : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SoftwareInformation.jclinitDone then
            SoftwareInformation.jclinitDone <- true
            SoftwareInformation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string, version: string, shortName: string) as this =
        {  }
        then
            this.jctor1(name, version, shortName)
    member this.jctor1(name: string, version: string, shortName: string) : unit =
        this.name <- name
        this.version <- version
        this.shortName <- (new StringMaker()).append(shortName).append(KotlinUtil.getShortName()).ToString()
        ()
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract getVersion : unit -> string
    default this.getVersion() : string =
        this.version
    
    abstract toShortString : unit -> string
    default this.toShortString() : string =
        this.shortName
    
    override this.ToString() : string =
        let mutable NAME : string = "Name: "
        let mutable VERSION : string = "Version: "
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(NAME))
        ignore (stringBuffer.append(this.getName()))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(VERSION))
        ignore (stringBuffer.append(this.getVersion()))
        stringBuffer.ToString()


