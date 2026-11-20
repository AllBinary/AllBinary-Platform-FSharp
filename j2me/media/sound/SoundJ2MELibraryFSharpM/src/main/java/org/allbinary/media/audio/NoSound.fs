namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type NoSound =
    inherit Sound
    [<DefaultValue(false)>] static val mutable private jcell_instance : NoSound
    static member instance with get() : NoSound = (NoSound.jclinit(); NoSound.jcell_instance) and set (jvalue: NoSound) = (NoSound.jclinit(); NoSound.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoSound.jclinitDone then
            NoSound.jclinitDone <- true
            NoSound.jclinitBody()
    static member private jclinitBody() : unit =
        NoSound.jcell_instance <- (new NoSound())
        ()
    
    static member getInstance() : NoSound =
        NoSound.instance
    
    new () as this =
        { inherit Sound(StringUtil.getInstance().EMPTY_STRING) }
        then
            this.jctor1()
    member this.jctor1() : unit =
        ()
        this.setPlayerP(NoPlayer.NO_PLAYER)
        ()


