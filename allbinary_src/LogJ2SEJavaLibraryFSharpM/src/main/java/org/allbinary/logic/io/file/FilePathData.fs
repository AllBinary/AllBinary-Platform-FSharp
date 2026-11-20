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
type FilePathData =
    [<DefaultValue(false)>] val mutable SEPARATORCHAR : char
    [<DefaultValue(false)>] val mutable PATH_START : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : FilePathData
    static member instance with get() : FilePathData = (FilePathData.jclinit(); FilePathData.jcell_instance) and set (jvalue: FilePathData) = (FilePathData.jclinit(); FilePathData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FilePathData.jclinitDone then
            FilePathData.jclinitDone <- true
            FilePathData.jclinitBody()
    static member private jclinitBody() : unit =
        FilePathData.jcell_instance <- (new FilePathData())
        ()
    member this.jfields_FilePathData() : unit =
        this.SEPARATORCHAR <- File.separatorChar
        this.PATH_START <- File.separator
        ()
    
    static member getInstance() : FilePathData =
        FilePathData.instance
    
    new () as this =
        {  }
        then
            this.jfields_FilePathData()
            this.jctor1()
    member this.jctor1() : unit =
        if File.separatorChar = '\\' then
            this.PATH_START <- JR.nn(File.separator) + JR.nn(File.separator)
        ()


