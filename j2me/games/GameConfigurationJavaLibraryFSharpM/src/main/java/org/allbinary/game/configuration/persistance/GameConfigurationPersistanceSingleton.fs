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
type GameConfigurationPersistanceSingleton =
    inherit KeyValuePersistance
    [<DefaultValue(false)>] static val mutable private jcell_GAME_PERSISTANCE : GameConfigurationPersistanceSingleton
    static member GAME_PERSISTANCE with get() : GameConfigurationPersistanceSingleton = (GameConfigurationPersistanceSingleton.jclinit(); GameConfigurationPersistanceSingleton.jcell_GAME_PERSISTANCE) and set (jvalue: GameConfigurationPersistanceSingleton) = (GameConfigurationPersistanceSingleton.jclinit(); GameConfigurationPersistanceSingleton.jcell_GAME_PERSISTANCE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameConfigurationPersistanceSingleton.jclinitDone then
            GameConfigurationPersistanceSingleton.jclinitDone <- true
            GameConfigurationPersistanceSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        GameConfigurationPersistanceSingleton.jcell_GAME_PERSISTANCE <- (new GameConfigurationPersistanceSingleton())
        ()
    
    static member getInstance() : GameConfigurationPersistanceSingleton =
        GameConfigurationPersistanceSingleton.GAME_PERSISTANCE
    
    new () =
        { inherit KeyValuePersistance(GamePersistanceStrings.getInstance().SAVED_GAME_CONFIGURATION_RECORD_ID) }


