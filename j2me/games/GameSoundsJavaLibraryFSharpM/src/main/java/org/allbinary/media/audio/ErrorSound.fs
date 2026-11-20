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
type ErrorSound =
    inherit CompositeSound
    [<DefaultValue(false)>] static val mutable private jcell_soundInterface : Sound
    static member soundInterface with get() : Sound = (ErrorSound.jclinit(); ErrorSound.jcell_soundInterface) and set (jvalue: Sound) = (ErrorSound.jclinit(); ErrorSound.jcell_soundInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ErrorSound.jclinitDone then
            ErrorSound.jclinitDone <- true
            ErrorSound.jclinitBody()
    static member private jclinitBody() : unit =
        ErrorSound.jcell_soundInterface <- (new ErrorSound())
        ()
    
    new () =
        { inherit CompositeSound("resource:/wav/error.wav") }
    
    static member getInstance() : Sound =
        ErrorSound.soundInterface


