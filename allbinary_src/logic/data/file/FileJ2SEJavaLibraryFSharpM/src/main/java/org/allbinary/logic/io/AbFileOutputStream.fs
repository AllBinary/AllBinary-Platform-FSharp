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
type AbFileOutputStream =
    inherit FileOutputStream
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbFileOutputStream.jclinitDone then
            AbFileOutputStream.jclinitDone <- true
            AbFileOutputStream.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createFromAbFile(file: AbFile) : AbFileOutputStream =
        (new AbFileOutputStream(file.getPath(), false))
    
    static member createFromAbFileAppend(file: AbFile, append: bool) : AbFileOutputStream =
        (new AbFileOutputStream(file.getPath(), append))
    
    static member createFromFilePath(name: string) : AbFileOutputStream =
        (new AbFileOutputStream(name, false))
    
    static member createFromFilePathAppend(name: string, append: bool) : AbFileOutputStream =
        (new AbFileOutputStream(name, append))
    
    new (name: string, append: bool) =
        { inherit FileOutputStream(name, append) }


