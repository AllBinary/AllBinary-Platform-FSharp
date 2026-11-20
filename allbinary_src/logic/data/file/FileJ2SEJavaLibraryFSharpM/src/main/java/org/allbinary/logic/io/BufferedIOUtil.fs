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
type BufferedIOUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BufferedIOUtil.jclinitDone then
            BufferedIOUtil.jclinitDone <- true
            BufferedIOUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member copy(backupFile: AbFile, backupFileBak: AbFile) : unit =
        let mutable line : string = StringUtil.getInstance().EMPTY_STRING
        let mutable tmpOut : BufferedWriter = (new BufferedWriter((new FileWriter(AbFileNativeUtil.get(backupFileBak)))))
        let mutable tmpIn : BufferedReader = (new BufferedReader((new FileReader(AbFileNativeUtil.get(backupFile)))))
        while tmpIn.ready() do
            line <- tmpIn.readLine()
            ignore (tmpOut.write(line, 0, JString.length(line)))
            ignore (tmpOut.newLine())
        ignore (tmpOut.flush())


