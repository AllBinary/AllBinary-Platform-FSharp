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
type LicenseLoadingTypeFactory =
    [<DefaultValue(false)>] val mutable INITIAL_LOADING : LicenseLoadingType
    [<DefaultValue(false)>] val mutable GAME_START : LicenseLoadingType
    [<DefaultValue(false)>] val mutable LOGIN : LicenseLoadingType
    [<DefaultValue(false)>] val mutable OTHER : LicenseLoadingType
    [<DefaultValue(false)>] static val mutable private jcell_instance : LicenseLoadingTypeFactory
    static member instance with get() : LicenseLoadingTypeFactory = (LicenseLoadingTypeFactory.jclinit(); LicenseLoadingTypeFactory.jcell_instance) and set (jvalue: LicenseLoadingTypeFactory) = (LicenseLoadingTypeFactory.jclinit(); LicenseLoadingTypeFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LicenseLoadingTypeFactory.jclinitDone then
            LicenseLoadingTypeFactory.jclinitDone <- true
            LicenseLoadingTypeFactory.jclinitBody()
    static member private jclinitBody() : unit =
        LicenseLoadingTypeFactory.jcell_instance <- (new LicenseLoadingTypeFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_LicenseLoadingTypeFactory()
    member this.jfields_LicenseLoadingTypeFactory() : unit =
        this.INITIAL_LOADING <- (new LicenseLoadingType("Initial Loading"))
        this.GAME_START <- (new LicenseLoadingType("Game Start"))
        this.LOGIN <- (new LicenseLoadingType("Login"))
        this.OTHER <- (new LicenseLoadingType("Other/Usually The First Non Demo Level"))
        ()
    
    static member getIntance() : LicenseLoadingTypeFactory =
        LicenseLoadingTypeFactory.instance


