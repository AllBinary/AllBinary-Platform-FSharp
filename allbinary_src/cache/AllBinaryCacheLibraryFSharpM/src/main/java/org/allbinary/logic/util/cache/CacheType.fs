namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2007 AllBinary 
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
type CacheType =
    [<DefaultValue(false)>] val mutable vendor : string
    [<DefaultValue(false)>] val mutable type_ : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CacheType.jclinitDone then
            CacheType.jclinitDone <- true
            CacheType.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (vendor: string, type_: string) as this =
        {  }
        then
            this.jctor1(vendor, type_)
    member this.jctor1(vendor: string, type_: string) : unit =
        this.vendor <- vendor
        this.type_ <- type_
        ()
    
    abstract getVendor : unit -> string
    default this.getVendor() : string =
        this.vendor
    
    abstract getType : unit -> string
    default this.getType() : string =
        this.type_
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("CacheType: Vendor: "))
        ignore (stringBuffer.append(this.getVendor()))
        ignore (stringBuffer.append(" Type: "))
        ignore (stringBuffer.append(this.getType()))
        stringBuffer.ToString()


