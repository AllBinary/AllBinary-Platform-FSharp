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
type GamePersistanceSingleton =
    inherit KeyValuePersistance
    [<DefaultValue(false)>] static val mutable private jcell_GAME_PERSISTANCE : GamePersistanceSingleton
    static member GAME_PERSISTANCE with get() : GamePersistanceSingleton = (GamePersistanceSingleton.jclinit(); GamePersistanceSingleton.jcell_GAME_PERSISTANCE) and set (jvalue: GamePersistanceSingleton) = (GamePersistanceSingleton.jclinit(); GamePersistanceSingleton.jcell_GAME_PERSISTANCE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GamePersistanceSingleton.jclinitDone then
            GamePersistanceSingleton.jclinitDone <- true
            GamePersistanceSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        GamePersistanceSingleton.jcell_GAME_PERSISTANCE <- (new GamePersistanceSingleton())
        ()
    
    static member getInstance() : GamePersistanceSingleton =
        GamePersistanceSingleton.GAME_PERSISTANCE
    
    new () =
        { inherit KeyValuePersistance(GamePersistanceStrings.getInstance().SAVED_GAME_RECORD_ID) }


