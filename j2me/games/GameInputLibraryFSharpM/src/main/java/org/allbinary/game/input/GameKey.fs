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
type GameKey =
    inherit Input
    [<DefaultValue(false)>] static val mutable private jcell_NULL_GAME_KEY : GameKey
    static member NULL_GAME_KEY with get() : GameKey = (GameKey.jclinit(); GameKey.jcell_NULL_GAME_KEY) and set (jvalue: GameKey) = (GameKey.jclinit(); GameKey.jcell_NULL_GAME_KEY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameKey.jclinitDone then
            GameKey.jclinitDone <- true
            GameKey.jclinitBody()
    static member private jclinitBody() : unit =
        GameKey.jcell_NULL_GAME_KEY <- (new GameKey(-1, StringUtil.getInstance().NULL_STRING))
        ()
    
    new (key: int, name: string) =
        { inherit Input(key, name) }
    
    override this.ToString() : string =
        (new StringMaker()).append("GameKey ").append(base.ToString()).ToString()


