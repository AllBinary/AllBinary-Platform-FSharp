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
type PlayerTypesFactory =
    [<DefaultValue(false)>] val mutable PLAYER_TYPE_ONE : PlayerType
    [<DefaultValue(false)>] val mutable PLAYER_TYPE_TWO : PlayerType
    [<DefaultValue(false)>] val mutable PLAYER_TYPE_THREE : PlayerType
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : PlayerTypesFactory
    static member SINGLETON with get() : PlayerTypesFactory = (PlayerTypesFactory.jclinit(); PlayerTypesFactory.jcell_SINGLETON) and set (jvalue: PlayerTypesFactory) = (PlayerTypesFactory.jclinit(); PlayerTypesFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlayerTypesFactory.jclinitDone then
            PlayerTypesFactory.jclinitDone <- true
            PlayerTypesFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PlayerTypesFactory.jcell_SINGLETON <- (new PlayerTypesFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_PlayerTypesFactory()
    member this.jfields_PlayerTypesFactory() : unit =
        this.PLAYER_TYPE_ONE <- (new PlayerType("Player Type One", 0))
        this.PLAYER_TYPE_TWO <- (new PlayerType("Player Type Two", 1))
        this.PLAYER_TYPE_THREE <- (new PlayerType("Player Type Three", 2))
        ()
    
    static member getInstance() : PlayerTypesFactory =
        PlayerTypesFactory.SINGLETON


