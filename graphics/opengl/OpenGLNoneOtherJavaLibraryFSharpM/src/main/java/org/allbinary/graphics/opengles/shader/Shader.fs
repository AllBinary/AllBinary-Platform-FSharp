namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type Shader =
    [<DefaultValue(false)>] val mutable shaderName : string
    [<DefaultValue(false)>] val mutable shaderStringList : BasicArrayList
    [<DefaultValue(false)>] val mutable shaderAsString : string
    [<DefaultValue(false)>] val mutable shaderHandle : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Shader.jclinitDone then
            Shader.jclinitDone <- true
            Shader.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_Shader()
    member this.jfields_Shader() : unit =
        this.shaderName <- StringUtil.getInstance().EMPTY_STRING
        this.shaderStringList <- BasicArrayListUtil.getInstance().getImmutableInstance()
        this.shaderAsString <- StringUtil.getInstance().EMPTY_STRING
        ()


