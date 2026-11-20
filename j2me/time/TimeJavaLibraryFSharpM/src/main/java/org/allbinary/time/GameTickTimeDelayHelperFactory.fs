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
type GameTickTimeDelayHelperFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameTickTimeDelayHelper
    static member instance with get() : GameTickTimeDelayHelper = (GameTickTimeDelayHelperFactory.jclinit(); GameTickTimeDelayHelperFactory.jcell_instance) and set (jvalue: GameTickTimeDelayHelper) = (GameTickTimeDelayHelperFactory.jclinit(); GameTickTimeDelayHelperFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameTickTimeDelayHelperFactory.jclinitDone then
            GameTickTimeDelayHelperFactory.jclinitDone <- true
            GameTickTimeDelayHelperFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GameTickTimeDelayHelperFactory.jcell_instance <- (new GameTickTimeDelayHelper(int64 (-1)))
        ()
    
    static member getInstance() : GameTickTimeDelayHelper =
        GameTickTimeDelayHelperFactory.instance
    
    new () =
        {  }


