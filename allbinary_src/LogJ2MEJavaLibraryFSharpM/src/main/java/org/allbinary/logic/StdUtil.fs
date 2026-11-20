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
type StdUtil =
    [<DefaultValue(false)>] val mutable EMPTY_VECTOR : ABVector
    [<DefaultValue(false)>] val mutable NULL_TABLE : ABHashtable
    [<DefaultValue(false)>] static val mutable private jcell_instance : StdUtil
    static member instance with get() : StdUtil = (StdUtil.jclinit(); StdUtil.jcell_instance) and set (jvalue: StdUtil) = (StdUtil.jclinit(); StdUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StdUtil.jclinitDone then
            StdUtil.jclinitDone <- true
            StdUtil.jclinitBody()
    static member private jclinitBody() : unit =
        StdUtil.jcell_instance <- (new StdUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_StdUtil()
    member this.jfields_StdUtil() : unit =
        this.EMPTY_VECTOR <- this.createVector()
        this.NULL_TABLE <- this.createHashtable()
        ()
    
    static member getInstance() : StdUtil =
        StdUtil.instance
    
    member this.createStack() : ABStack =
        (new ABStack())
    
    member this.createVector() : ABVector =
        (new ABVector())
    
    member this.createHashtable() : ABHashtable =
        (new ABHashtable())


