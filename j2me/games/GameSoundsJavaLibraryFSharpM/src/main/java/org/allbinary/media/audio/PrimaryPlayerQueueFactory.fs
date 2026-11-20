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
type PrimaryPlayerQueueFactory =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : PlayerQueue
    static member SINGLETON with get() : PlayerQueue = (PrimaryPlayerQueueFactory.jclinit(); PrimaryPlayerQueueFactory.jcell_SINGLETON) and set (jvalue: PlayerQueue) = (PrimaryPlayerQueueFactory.jclinit(); PrimaryPlayerQueueFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PrimaryPlayerQueueFactory.jclinitDone then
            PrimaryPlayerQueueFactory.jclinitDone <- true
            PrimaryPlayerQueueFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PrimaryPlayerQueueFactory.jcell_SINGLETON <- (new PlayerQueue(4))
        ()
    new () =
        {  }
    
    static member getInstance() : PlayerQueue =
        PrimaryPlayerQueueFactory.SINGLETON


