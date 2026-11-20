namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type SoundStrings =
    [<DefaultValue(false)>] val mutable STOP_ALL : string
    [<DefaultValue(false)>] val mutable CLOSE_ALL : string
    [<DefaultValue(false)>] val mutable SOUND : string
    [<DefaultValue(false)>] val mutable INIT_SOUND : string
    [<DefaultValue(false)>] val mutable STOPPING_SOUND : string
    [<DefaultValue(false)>] val mutable CLOSING_SOUND : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : SoundStrings
    static member instance with get() : SoundStrings = (SoundStrings.jclinit(); SoundStrings.jcell_instance) and set (jvalue: SoundStrings) = (SoundStrings.jclinit(); SoundStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SoundStrings.jclinitDone then
            SoundStrings.jclinitDone <- true
            SoundStrings.jclinitBody()
    static member private jclinitBody() : unit =
        SoundStrings.jcell_instance <- (new SoundStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_SoundStrings()
    member this.jfields_SoundStrings() : unit =
        this.STOP_ALL <- "stopAll"
        this.CLOSE_ALL <- "closeAll"
        this.SOUND <- " Sound: "
        this.INIT_SOUND <- "Initializing Sound: "
        this.STOPPING_SOUND <- "Stopping Sound: "
        this.CLOSING_SOUND <- "Closing Sound: "
        ()
    
    static member getInstance() : SoundStrings =
        SoundStrings.instance


