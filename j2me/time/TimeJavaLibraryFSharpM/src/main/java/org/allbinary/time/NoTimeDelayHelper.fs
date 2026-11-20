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
type NoTimeDelayHelper =
    inherit TimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : NoTimeDelayHelper
    static member SINGLETON with get() : NoTimeDelayHelper = (NoTimeDelayHelper.jclinit(); NoTimeDelayHelper.jcell_SINGLETON) and set (jvalue: NoTimeDelayHelper) = (NoTimeDelayHelper.jclinit(); NoTimeDelayHelper.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoTimeDelayHelper.jclinitDone then
            NoTimeDelayHelper.jclinitDone <- true
            NoTimeDelayHelper.jclinitBody()
    static member private jclinitBody() : unit =
        NoTimeDelayHelper.jcell_SINGLETON <- (new NoTimeDelayHelper())
        ()
    
    new () =
        { inherit TimeDelayHelper(0) }
    
    override this.isTimeTNT() : bool =
        true
    
    override this.isTimeSinceTNT(delay: int) : bool =
        true
    
    override this.isTime(currentTime: int64) : bool =
        true
    
    override this.isTimeSince(delay: int, currentTime: int64) : bool =
        true


