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
type BufferedWriterUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable commonLabels : CommonLabels
    [<DefaultValue(false)>] val mutable REMOVING_OLD : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : BufferedWriterUtil
    static member instance with get() : BufferedWriterUtil = (BufferedWriterUtil.jclinit(); BufferedWriterUtil.jcell_instance) and set (jvalue: BufferedWriterUtil) = (BufferedWriterUtil.jclinit(); BufferedWriterUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BufferedWriterUtil.jclinitDone then
            BufferedWriterUtil.jclinitDone <- true
            BufferedWriterUtil.jclinitBody()
    static member private jclinitBody() : unit =
        BufferedWriterUtil.jcell_instance <- (new BufferedWriterUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_BufferedWriterUtil()
    member this.jfields_BufferedWriterUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.commonLabels <- CommonLabels.getInstance()
        this.REMOVING_OLD <- "Remove old for overwriting: "
        ()
    
    static member getInstance() : BufferedWriterUtil =
        BufferedWriterUtil.instance
    
    abstract overwrite : path: string * data: string -> unit
    default this.overwrite(path: string, data: string) : unit =
        let mutable abFile : AbFile = AbFile.createAbFile(path)
        if abFile.exists() then
            this.logUtil.putF((JR.nn(this.REMOVING_OLD) + JR.nn(path)), this, this.commonStrings.CREATE)
            ignore (abFile.delete())
        else
            let mutable name : string = AbPathData.getInstance().removeNameFromPath(path)
            let mutable abFileDirectory : AbFile = AbFile.createAbFile(name)
            if abFileDirectory.exists() then
                ()
            else
                let mutable stringBuilder : StringMaker = (new StringMaker())
                this.logUtil.putF(stringBuilder.append(this.commonStrings.CREATE).append(this.commonLabels.COLON_SEP).append(name).ToString(), this, this.commonStrings.CREATE)
                let mutable result : bool = abFileDirectory.mkdirs()
                ignore (stringBuilder.delete(0, stringBuilder.length()))
                this.logUtil.putF(stringBuilder.append(this.commonLabels.RESULT_).appendboolean(result).ToString(), this, this.commonStrings.CREATE)
        this.write(abFile, data)
    
    abstract overwrite : abFile: AbFile * data: string -> unit
    default this.overwrite(abFile: AbFile, data: string) : unit =
        if abFile.exists() then
            this.logUtil.putF((JR.nn(this.REMOVING_OLD) + JR.nn(abFile.getPath())), this, this.commonStrings.CREATE)
            ignore (abFile.delete())
        else
            let mutable name : string = AbPathData.getInstance().removeNameFromPath(abFile.getAbsolutePath())
            let mutable abFileDirectory : AbFile = AbFile.createAbFile(name)
            if abFileDirectory.exists() then
                ()
            else
                let mutable stringBuilder : StringMaker = (new StringMaker())
                this.logUtil.putF(stringBuilder.append(this.commonStrings.CREATE).append(this.commonLabels.COLON_SEP).append(name).ToString(), this, this.commonStrings.CREATE)
                let mutable result : bool = abFileDirectory.mkdirs()
                ignore (stringBuilder.delete(0, stringBuilder.length()))
                this.logUtil.putF(stringBuilder.append(this.commonLabels.RESULT_).appendboolean(result).ToString(), this, this.commonStrings.CREATE)
        this.write(abFile, data)
    
    abstract write : abFile: AbFile * data: string -> unit
    default this.write(abFile: AbFile, data: string) : unit =
        let mutable fileOut : BufferedWriter = (new BufferedWriter((new FileWriter(AbFileNativeUtil.get(abFile)))))
        ignore (fileOut.write(data, 0, JString.length(data)))
        ignore (fileOut.newLine())
        ignore (fileOut.flush())


