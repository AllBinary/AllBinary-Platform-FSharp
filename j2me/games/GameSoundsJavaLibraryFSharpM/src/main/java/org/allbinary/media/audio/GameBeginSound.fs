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
type GameBeginSound =
    inherit CompositeSound
    [<DefaultValue(false)>] static val mutable private jcell_soundInterface : Sound
    static member soundInterface with get() : Sound = (GameBeginSound.jclinit(); GameBeginSound.jcell_soundInterface) and set (jvalue: Sound) = (GameBeginSound.jclinit(); GameBeginSound.jcell_soundInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameBeginSound.jclinitDone then
            GameBeginSound.jclinitDone <- true
            GameBeginSound.jclinitBody()
    static member private jclinitBody() : unit =
        GameBeginSound.jcell_soundInterface <- (new GameBeginSound())
        ()
    
    new () =
        { inherit CompositeSound("resource:/wav/begin.wav") }
    
    static member getInstance() : Sound =
        GameBeginSound.soundInterface


