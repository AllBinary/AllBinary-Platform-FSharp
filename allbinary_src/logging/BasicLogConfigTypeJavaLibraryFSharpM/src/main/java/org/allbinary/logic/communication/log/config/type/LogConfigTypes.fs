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
type LogConfigTypes =
    [<DefaultValue(false)>] static val mutable private jcell_LOGGING : BasicArrayList
    static member LOGGING with get() : BasicArrayList = (LogConfigTypes.jclinit(); LogConfigTypes.jcell_LOGGING) and set (jvalue: BasicArrayList) = (LogConfigTypes.jclinit(); LogConfigTypes.jcell_LOGGING <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LogConfigTypes.jclinitDone then
            LogConfigTypes.jclinitDone <- true
            LogConfigTypes.jclinitBody()
    static member private jclinitBody() : unit =
        LogConfigTypes.jcell_LOGGING <- (new BasicArrayListD())
        ()
    
    new () =
        {  }


