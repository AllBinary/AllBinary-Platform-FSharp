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
type FileExtensionData =
    [<DefaultValue(false)>] val mutable DOT_JAVA_SOURCE : string
    [<DefaultValue(false)>] val mutable JAVA_SOURCE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : FileExtensionData
    static member instance with get() : FileExtensionData = (FileExtensionData.jclinit(); FileExtensionData.jcell_instance) and set (jvalue: FileExtensionData) = (FileExtensionData.jclinit(); FileExtensionData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FileExtensionData.jclinitDone then
            FileExtensionData.jclinitDone <- true
            FileExtensionData.jclinitBody()
    static member private jclinitBody() : unit =
        FileExtensionData.jcell_instance <- (new FileExtensionData())
        ()
    member this.jfields_FileExtensionData() : unit =
        this.DOT_JAVA_SOURCE <- ".java"
        this.JAVA_SOURCE <- "java"
        ()
    
    static member getInstance() : FileExtensionData =
        FileExtensionData.instance
    
    new () as this =
        {  }
        then
            this.jfields_FileExtensionData()


