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
type DomData =
    static member ID : string = "id"
    static member CHILD : string = "child"
    static member NAME : string = "name"
    static member VALUE : string = "value"
    static member INDEX : string = "index"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DomData.jclinitDone then
            DomData.jclinitDone <- true
            DomData.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }


