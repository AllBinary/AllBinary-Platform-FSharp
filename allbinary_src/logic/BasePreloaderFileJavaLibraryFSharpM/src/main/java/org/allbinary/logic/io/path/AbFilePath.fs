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
type AbFilePath =
    inherit AbPath
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbFilePath.jclinitDone then
            AbFilePath.jclinitDone <- true
            AbFilePath.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (aPath: string) as this =
        { inherit AbPath(StringUtil.getInstance().EMPTY_STRING, StringUtil.getInstance().EMPTY_STRING) }
        then
            this.jctor1(aPath)
    member this.jctor1(aPath: string) : unit =
        ()
        let mutable pathData : AbPathData = AbPathData.getInstance()
        let mutable abPathUtil : PathUtil = PathUtil.getInstance()
        this.schema <- this.getSchema(aPath)
        this.setName(pathData.getNameFromPath(aPath))
        this.setPath(abPathUtil.adjust(this.getPathFromPath(abPathUtil.removeNameFromPath(aPath).ToString())))
        ()


