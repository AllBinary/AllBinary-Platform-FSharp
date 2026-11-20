namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type GamePersistanceStrings =
    [<DefaultValue(false)>] val mutable SAVED_GAME_RECORD_ID : string
    [<DefaultValue(false)>] val mutable SAVED_GAME_CONFIGURATION_RECORD_ID : string
    [<DefaultValue(false)>] val mutable DEFAULT_INPUT_MAPPING_RECORD_ID : string
    [<DefaultValue(false)>] val mutable SAVED_INPUT_CONFIGURATION_RECORD_ID : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : GamePersistanceStrings
    static member instance with get() : GamePersistanceStrings = (GamePersistanceStrings.jclinit(); GamePersistanceStrings.jcell_instance) and set (jvalue: GamePersistanceStrings) = (GamePersistanceStrings.jclinit(); GamePersistanceStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GamePersistanceStrings.jclinitDone then
            GamePersistanceStrings.jclinitDone <- true
            GamePersistanceStrings.jclinitBody()
    static member private jclinitBody() : unit =
        GamePersistanceStrings.jcell_instance <- (new GamePersistanceStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_GamePersistanceStrings()
    member this.jfields_GamePersistanceStrings() : unit =
        this.SAVED_GAME_RECORD_ID <- "_SG"
        this.SAVED_GAME_CONFIGURATION_RECORD_ID <- "_SGC"
        this.DEFAULT_INPUT_MAPPING_RECORD_ID <- "_DIM"
        this.SAVED_INPUT_CONFIGURATION_RECORD_ID <- "_SIC"
        ()
    
    static member getInstance() : GamePersistanceStrings =
        GamePersistanceStrings.instance


