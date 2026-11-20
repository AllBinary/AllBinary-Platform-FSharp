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
type NoPlayerGameInput =
    inherit PlayerGameInput
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : NoPlayerGameInput
    static member SINGLETON with get() : NoPlayerGameInput = (NoPlayerGameInput.jclinit(); NoPlayerGameInput.jcell_SINGLETON) and set (jvalue: NoPlayerGameInput) = (NoPlayerGameInput.jclinit(); NoPlayerGameInput.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoPlayerGameInput.jclinitDone then
            NoPlayerGameInput.jclinitDone <- true
            NoPlayerGameInput.jclinitBody()
    static member private jclinitBody() : unit =
        NoPlayerGameInput.jcell_SINGLETON <- (new NoPlayerGameInput())
        ()
    
    static member getInstance() : NoPlayerGameInput =
        NoPlayerGameInput.SINGLETON
    
    new () =
        { inherit PlayerGameInput((new BasicArrayListD()), (new BasicArrayListD()), -1) }
    
    override this.onDownGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    override this.onUpGameKeyEvent(gameKeyEvent: GameKeyEvent) : unit =
        ()


