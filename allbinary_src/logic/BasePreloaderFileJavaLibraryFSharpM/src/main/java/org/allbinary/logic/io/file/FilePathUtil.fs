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
type FilePathUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FilePathUtil.jclinitDone then
            FilePathUtil.jclinitDone <- true
            FilePathUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member adjust(path: string) : string =
        let mutable path = path
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable abPathData : AbPathData = AbPathData.getInstance()
        let mutable stringValidationUtil : StringValidationUtil = StringValidationUtil.getInstance()
        let mutable filePathData : FilePathData = FilePathData.getInstance()
        if stringValidationUtil.isEmpty(path) then
            jret <- filePathData.PATH_START
            jflow <- 1
        if jflow = 0 then
            path <- JString.replace(path, abPathData.SEPARATORCHAR, filePathData.SEPARATORCHAR)
            jret <- path
            jflow <- 1
        jret


