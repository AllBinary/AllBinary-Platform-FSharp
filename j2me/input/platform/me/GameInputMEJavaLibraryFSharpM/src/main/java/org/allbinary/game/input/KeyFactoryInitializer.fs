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
type KeyFactoryInitializer =
    inherit Init
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KeyFactoryInitializer.jclinitDone then
            KeyFactoryInitializer.jclinitDone <- true
            KeyFactoryInitializer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        { inherit Init() }
        then
            this.jfields_KeyFactoryInitializer()
    member this.jfields_KeyFactoryInitializer() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    override this.init() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.INIT)


