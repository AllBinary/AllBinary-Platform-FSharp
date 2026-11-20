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
type ThreadPoolStrings =
    [<DefaultValue(false)>] val mutable ADD_TASK : string
    [<DefaultValue(false)>] val mutable START_TASK : string
    [<DefaultValue(false)>] val mutable COMPLETE_TASK : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : ThreadPoolStrings
    static member instance with get() : ThreadPoolStrings = (ThreadPoolStrings.jclinit(); ThreadPoolStrings.jcell_instance) and set (jvalue: ThreadPoolStrings) = (ThreadPoolStrings.jclinit(); ThreadPoolStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThreadPoolStrings.jclinitDone then
            ThreadPoolStrings.jclinitDone <- true
            ThreadPoolStrings.jclinitBody()
    static member private jclinitBody() : unit =
        ThreadPoolStrings.jcell_instance <- (new ThreadPoolStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_ThreadPoolStrings()
    member this.jfields_ThreadPoolStrings() : unit =
        this.ADD_TASK <- "addTask"
        this.START_TASK <- "Started Task: "
        this.COMPLETE_TASK <- "Completed Task: "
        ()
    
    static member getInstance() : ThreadPoolStrings =
        ThreadPoolStrings.instance


