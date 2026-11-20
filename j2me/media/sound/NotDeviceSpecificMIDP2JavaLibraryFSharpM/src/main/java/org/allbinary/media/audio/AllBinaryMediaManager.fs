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
type AllBinaryMediaManager =
    static member THIS : string = "AllBinaryMediaManagerNoMIPD2"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryMediaManager.jclinitDone then
            AllBinaryMediaManager.jclinitDone <- true
            AllBinaryMediaManager.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member isMuted() : bool =
        false
    
    static member setMuted(aMuted: bool) : unit =
        ()
    
    static member update() : bool =
        true
    
    static member init(soundsFactoryInterface: SoundsFactoryInterface) : unit =
        let mutable logUtil : LogUtil = LogUtil.getInstance()
        let mutable commonString : CommonStrings = CommonStrings.getInstance()
        logUtil.putF(commonString.START, AllBinaryMediaManager.THIS, commonString.INIT)
        ProgressCanvasFactory.getInstance().addNormalPortion(50, "Media Manager")
        (new Sounds(soundsFactoryInterface)).init()
    
    static member shutdown(soundsFactoryInterface: SoundsFactoryInterface) : unit =
        (new Sounds(soundsFactoryInterface)).stopAll()
        (new Sounds(soundsFactoryInterface)).closeAll()
        TsUtil.getInstance().gc()
    
    static member createPlayer(resource: string) : Player =
        let mutable jflow = 0
        let mutable jret : Player = Unchecked.defaultof<Player>
        if Features.getInstance().isFeature(GameFeatureFactory.getInstance().SOUND) then
            if TsUtil.getInstance().compareTo(resource, Manager.TONE_DEVICE_LOCATOR) = 0 then
                jret <- Manager.createPlayer(resource)
                jflow <- 1
            else
                let mutable inputStream : InputStream = ResourceUtil.getInstance().getResourceAsStream(resource)
                jret <- MIDPUtil.getInstance().createPlayerFromInputStream(inputStream, AudioContentTypeDataFactory.getInstance().MIME_AUDIO_WAV.getName())
                jflow <- 1
        else
            jret <- NoPlayer.NO_PLAYER
            jflow <- 1
        jret
    
    static member playTone(frequency: int, time: int, volume: int) : unit =
        if Features.getInstance().isFeature(GameFeatureFactory.getInstance().SOUND) then
            Manager.playTone(frequency, time, volume)


