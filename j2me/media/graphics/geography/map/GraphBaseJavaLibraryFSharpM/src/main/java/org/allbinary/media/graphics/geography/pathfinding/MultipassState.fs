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
type MultipassState =
    [<DefaultValue(false)>] val mutable step : int
    [<DefaultValue(false)>] val mutable iteration : int
    [<DefaultValue(false)>] val mutable iteration2 : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MultipassState.jclinitDone then
            MultipassState.jclinitDone <- true
            MultipassState.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }


