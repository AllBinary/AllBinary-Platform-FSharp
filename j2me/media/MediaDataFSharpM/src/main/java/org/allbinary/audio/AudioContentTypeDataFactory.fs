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
type AudioContentTypeDataFactory =
    [<DefaultValue(false)>] val mutable MIME_AUDIO_TONE : AudioContentTypeData
    [<DefaultValue(false)>] val mutable MIME_AUDIO_AMR : AudioContentTypeData
    [<DefaultValue(false)>] val mutable MIME_AUDIO_AMR_WB : AudioContentTypeData
    [<DefaultValue(false)>] val mutable MIME_AUDIO_WAV : AudioContentTypeData
    [<DefaultValue(false)>] val mutable MIME_AUDIO_MIDI : AudioContentTypeData
    [<DefaultValue(false)>] val mutable MIME_AUDIO_SP_MIDI : AudioContentTypeData
    [<DefaultValue(false)>] static val mutable private jcell_instance : AudioContentTypeDataFactory
    static member instance with get() : AudioContentTypeDataFactory = (AudioContentTypeDataFactory.jclinit(); AudioContentTypeDataFactory.jcell_instance) and set (jvalue: AudioContentTypeDataFactory) = (AudioContentTypeDataFactory.jclinit(); AudioContentTypeDataFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AudioContentTypeDataFactory.jclinitDone then
            AudioContentTypeDataFactory.jclinitDone <- true
            AudioContentTypeDataFactory.jclinitBody()
    static member private jclinitBody() : unit =
        AudioContentTypeDataFactory.jcell_instance <- (new AudioContentTypeDataFactory())
        ()
    member this.jfields_AudioContentTypeDataFactory() : unit =
        this.MIME_AUDIO_TONE <- (new AudioContentTypeData("audio/x-tone-seq"))
        this.MIME_AUDIO_AMR <- (new AudioContentTypeData("audio/amr"))
        this.MIME_AUDIO_AMR_WB <- (new AudioContentTypeData("audio/amr-wb"))
        this.MIME_AUDIO_WAV <- (new AudioContentTypeData("audio/x-wav"))
        this.MIME_AUDIO_MIDI <- (new AudioContentTypeData("audio/midi"))
        this.MIME_AUDIO_SP_MIDI <- (new AudioContentTypeData("audio/sp-midi"))
        ()
    
    static member getInstance() : AudioContentTypeDataFactory =
        AudioContentTypeDataFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_AudioContentTypeDataFactory()


