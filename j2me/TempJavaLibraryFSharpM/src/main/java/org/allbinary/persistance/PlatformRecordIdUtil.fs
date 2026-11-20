namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type PlatformRecordIdUtil =
    [<DefaultValue(false)>] val mutable PLATFORM_SHORT_NAME : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : PlatformRecordIdUtil
    static member instance with get() : PlatformRecordIdUtil = (PlatformRecordIdUtil.jclinit(); PlatformRecordIdUtil.jcell_instance) and set (jvalue: PlatformRecordIdUtil) = (PlatformRecordIdUtil.jclinit(); PlatformRecordIdUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlatformRecordIdUtil.jclinitDone then
            PlatformRecordIdUtil.jclinitDone <- true
            PlatformRecordIdUtil.jclinitBody()
    static member private jclinitBody() : unit =
        PlatformRecordIdUtil.jcell_instance <- (new PlatformRecordIdUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_PlatformRecordIdUtil()
    member this.jfields_PlatformRecordIdUtil() : unit =
        this.PLATFORM_SHORT_NAME <- "AVN"
        ()
    
    static member getInstance() : PlatformRecordIdUtil =
        PlatformRecordIdUtil.instance
    
    abstract getRecordId : abeClientInformation: AbeClientInformationInterface * baseRecordId: string -> string
    default this.getRecordId(abeClientInformation: AbeClientInformationInterface, baseRecordId: string) : string =
        (new StringMaker()).append(abeClientInformation.toShortString()).append(CommonSeps.getInstance().UNDERSCORE).append(this.PLATFORM_SHORT_NAME).append(baseRecordId).ToString()


