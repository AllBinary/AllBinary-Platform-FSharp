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
    static member THIS : string = "AllBinaryMediaManagerNoMediaMIDP1"
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
    
    static member createPlayerFromInputStream(stream: InputStream, type_: string) : Player =
        let mutable logUtil : LogUtil = LogUtil.getInstance()
        let mutable commonString : CommonStrings = CommonStrings.getInstance()
        logUtil.putF(commonString.START, AllBinaryMediaManager.THIS, "creatPlayer(InputStream)")
        (box (NoPlayer.NO_PLAYER) :?> Player)
    
    static member createPlayer(locator: string) : Player =
        let mutable logUtil : LogUtil = LogUtil.getInstance()
        let mutable commonString : CommonStrings = CommonStrings.getInstance()
        logUtil.putF(commonString.START, AllBinaryMediaManager.THIS, "creatPlayer(locator)")
        (box (NoPlayer.NO_PLAYER) :?> Player)
    
    static member playTone(frequency: int, time: int, volume: int) : unit =
        ()
    
    static member getSupportedContentTypes(protocol: string) : string[] =
        StringUtil.getInstance().getArrayInstance()
    
    static member getSupportedProtocols(content_type: string) : string[] =
        StringUtil.getInstance().getArrayInstance()


