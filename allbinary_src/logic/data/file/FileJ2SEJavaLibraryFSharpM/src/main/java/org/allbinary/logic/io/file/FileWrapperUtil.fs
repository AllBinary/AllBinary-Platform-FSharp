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
type FileWrapperUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FileWrapperUtil.jclinitDone then
            FileWrapperUtil.jclinitDone <- true
            FileWrapperUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member wrapFiles(files: obj[]) : AbFile[] =
        let mutable jflow = 0
        let mutable jret : AbFile[] = Unchecked.defaultof<AbFile[]>
        try
            let mutable abFileArray : AbFile[] = (Array.zeroCreate<AbFile> (files.Length))
            let mutable index : int = files.Length - 1
            while index >= 0 do
                abFileArray.[index] <- (new AbFile((box (files.[index]) :?> File)))
                index <- index - 1
            jret <- abFileArray
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putSE("Exception Wrapping Files", "FileWrapperUtil", "wrapFiles", e)
                jret <- (Array.zeroCreate<AbFile> (0))
                jflow <- 1
            | _ -> reraise ()
        jret
    
    static member wrapFile(file: File) : AbFile =
        let mutable jflow = 0
        let mutable jret : AbFile = Unchecked.defaultof<AbFile>
        try
            jret <- (new AbFile(file))
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.putSE("Exception Wrapping File", "FileWrapperUtil", "wrapFile", e)
                jret <- AbFile.NULL_FILE
                jflow <- 1
            | _ -> reraise ()
        jret


