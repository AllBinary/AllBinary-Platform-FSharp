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
type SoundThreadPool =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ThreadPool
    static member instance with get() : ThreadPool = (SoundThreadPool.jclinit(); SoundThreadPool.jcell_instance) and set (jvalue: ThreadPool) = (SoundThreadPool.jclinit(); SoundThreadPool.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SoundThreadPool.jclinitDone then
            SoundThreadPool.jclinitDone <- true
            SoundThreadPool.jclinitBody()
    static member private jclinitBody() : unit =
        SoundThreadPool.jcell_instance <- (new ThreadPool("Sound", 1, ThreadPool.NORMAL_PRIORITY))
        ()
    new () =
        {  }
    
    static member getInstance() : ThreadPool =
        SoundThreadPool.instance


