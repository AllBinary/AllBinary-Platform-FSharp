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
type NoScoreable =
    inherit Scoreable
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : NoScoreable
    static member SINGLETON with get() : NoScoreable = (NoScoreable.jclinit(); NoScoreable.jcell_SINGLETON) and set (jvalue: NoScoreable) = (NoScoreable.jclinit(); NoScoreable.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoScoreable.jclinitDone then
            NoScoreable.jclinitDone <- true
            NoScoreable.jclinitBody()
    static member private jclinitBody() : unit =
        NoScoreable.jcell_SINGLETON <- (new NoScoreable())
        ()
    
    static member getInstance() : NoScoreable =
        NoScoreable.SINGLETON
    
    new () =
        { inherit Scoreable(0) }
    
    override this.addPoints(points: int) : unit =
        ()
    
    override this.removePoints(points: int) : unit =
        ()


