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
type ExplosionBasicSound =
    inherit CompositeSound
    [<DefaultValue(false)>] static val mutable private jcell_soundInterface : Sound
    static member soundInterface with get() : Sound = (ExplosionBasicSound.jclinit(); ExplosionBasicSound.jcell_soundInterface) and set (jvalue: Sound) = (ExplosionBasicSound.jclinit(); ExplosionBasicSound.jcell_soundInterface <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ExplosionBasicSound.jclinitDone then
            ExplosionBasicSound.jclinitDone <- true
            ExplosionBasicSound.jclinitBody()
    static member private jclinitBody() : unit =
        ExplosionBasicSound.jcell_soundInterface <- (new ExplosionBasicSound())
        ()
    
    new () =
        { inherit CompositeSound("resource:/wav/explosion.wav") }
    
    static member getInstance() : Sound =
        ExplosionBasicSound.soundInterface


