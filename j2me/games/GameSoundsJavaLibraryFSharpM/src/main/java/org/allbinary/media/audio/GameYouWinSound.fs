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
type GameYouWinSound =
    inherit CompositeSound
    [<DefaultValue(false)>] static val mutable private jcell_soundInterface : Sound
    static member soundInterface with get() : Sound = (GameYouWinSound.jclinit(); GameYouWinSound.jcell_soundInterface) and set (jvalue: Sound) = (GameYouWinSound.jclinit(); GameYouWinSound.jcell_soundInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameYouWinSound.jclinitDone then
            GameYouWinSound.jclinitDone <- true
            GameYouWinSound.jclinitBody()
    static member private jclinitBody() : unit =
        GameYouWinSound.jcell_soundInterface <- (new GameYouWinSound())
        ()
    
    new () =
        { inherit CompositeSound("resource:/wav/youwin.wav") }
    
    static member getInstance() : Sound =
        GameYouWinSound.soundInterface


