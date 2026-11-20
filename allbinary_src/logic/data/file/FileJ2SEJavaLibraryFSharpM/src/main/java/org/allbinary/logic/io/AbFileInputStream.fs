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
type AbFileInputStream =
    inherit FileInputStream
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbFileInputStream.jclinitDone then
            AbFileInputStream.jclinitDone <- true
            AbFileInputStream.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string) =
        { inherit FileInputStream(name) }
    
    static member createFromAbFile(file: AbFile) : AbFileInputStream =
        (new AbFileInputStream(AbFileNativeUtil.get(file).getPath()))
    
    static member createFromFile(file: File) : AbFileInputStream =
        (new AbFileInputStream(file.getPath()))


