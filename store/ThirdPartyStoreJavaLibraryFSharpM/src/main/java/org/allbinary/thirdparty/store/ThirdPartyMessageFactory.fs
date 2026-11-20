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
type ThirdPartyMessageFactory =
    [<DefaultValue(false)>] val mutable AUTHORIZED : string
    [<DefaultValue(false)>] val mutable NOT_AUTHORIZED : string
    [<DefaultValue(false)>] val mutable LINKAGE_ERROR : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : ThirdPartyMessageFactory
    static member instance with get() : ThirdPartyMessageFactory = (ThirdPartyMessageFactory.jclinit(); ThirdPartyMessageFactory.jcell_instance) and set (jvalue: ThirdPartyMessageFactory) = (ThirdPartyMessageFactory.jclinit(); ThirdPartyMessageFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThirdPartyMessageFactory.jclinitDone then
            ThirdPartyMessageFactory.jclinitDone <- true
            ThirdPartyMessageFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ThirdPartyMessageFactory.jcell_instance <- (new ThirdPartyMessageFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_ThirdPartyMessageFactory()
    member this.jfields_ThirdPartyMessageFactory() : unit =
        this.AUTHORIZED <- "Authorized"
        this.NOT_AUTHORIZED <- "Not Authorized"
        this.LINKAGE_ERROR <- "Linkage Error"
        ()
    
    static member getInstance() : ThirdPartyMessageFactory =
        ThirdPartyMessageFactory.instance


