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
type FireworksSound =
    inherit CompositeSound
    [<DefaultValue(false)>] static val mutable private jcell_soundInterface : Sound
    static member soundInterface with get() : Sound = (FireworksSound.jclinit(); FireworksSound.jcell_soundInterface) and set (jvalue: Sound) = (FireworksSound.jclinit(); FireworksSound.jcell_soundInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FireworksSound.jclinitDone then
            FireworksSound.jclinitDone <- true
            FireworksSound.jclinitBody()
    static member private jclinitBody() : unit =
        FireworksSound.jcell_soundInterface <- (new FireworksSound())
        ()
    
    new () =
        { inherit CompositeSound("resource:/wav/fireworks.wav") }
    
    static member getInstance() : Sound =
        FireworksSound.soundInterface


