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
type SelectSound =
    inherit CompositeSound
    [<DefaultValue(false)>] static val mutable private jcell_soundInterface : Sound
    static member soundInterface with get() : Sound = (SelectSound.jclinit(); SelectSound.jcell_soundInterface) and set (jvalue: Sound) = (SelectSound.jclinit(); SelectSound.jcell_soundInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SelectSound.jclinitDone then
            SelectSound.jclinitDone <- true
            SelectSound.jclinitBody()
    static member private jclinitBody() : unit =
        SelectSound.jcell_soundInterface <- (new SelectSound())
        ()
    
    new () =
        { inherit CompositeSound("resource:/wav/select.wav") }
    
    static member getInstance() : Sound =
        SelectSound.soundInterface


