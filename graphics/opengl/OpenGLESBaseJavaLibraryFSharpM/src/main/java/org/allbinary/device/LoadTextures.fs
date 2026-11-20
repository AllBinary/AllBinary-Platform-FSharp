namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type LoadTextures =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LoadTextures.jclinitDone then
            LoadTextures.jclinitDone <- true
            LoadTextures.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract load : gl: GL10 -> unit
    default this.load(gl: GL10) : unit =
        ()


