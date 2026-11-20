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
type GameAdStateBase =
    [<DefaultValue(false)>] val mutable adConfigurationP : AdConfiguration
    [<DefaultValue(false)>] val mutable advertisementsP : Advertisements
    [<DefaultValue(false)>] val mutable okayToShowAdsP : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameAdStateBase.jclinitDone then
            GameAdStateBase.jclinitDone <- true
            GameAdStateBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameAdStateBase() : unit =
        this.advertisementsP <- (new Advertisements())
        ()
    
    new (adConfiguration: AdConfiguration) as this =
        {  }
        then
            this.jfields_GameAdStateBase()
            this.jctor1(adConfiguration)
    member this.jctor1(adConfiguration: AdConfiguration) : unit =
        this.adConfigurationP <- adConfiguration
        ()
    
    abstract initViewArray : viewArray: obj[] -> unit
    default this.initViewArray(viewArray: obj[]) : unit =
        ()
    
    abstract onStart : anyType: obj -> unit
    default this.onStart(anyType: obj) : unit =
        this.init()
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract isShowingAtLocation : location: int -> bool
    default this.isShowingAtLocation(location: int) : bool =
        false
    
    abstract isShowingAt : unit -> bool
    default this.isShowingAt() : bool =
        false
    
    abstract show : unit -> unit
    default this.show() : unit =
        ()
    
    abstract hide : unit -> unit
    default this.hide() : unit =
        ()
    
    abstract onEvent : eventObject: AllBinaryEventObject -> unit
    default this.onEvent(eventObject: AllBinaryEventObject) : unit =
        ForcedLogUtil.log(EventStrings.getInstance().PERFORMANCE_MESSAGE, this)
    
    abstract processAdState : gameState: GameState * gameType: GameType -> unit
    default this.processAdState(gameState: GameState, gameType: GameType) : unit =
        ()
    
    abstract processPageAdState : unit -> unit
    default this.processPageAdState() : unit =
        ()
    
    abstract playingAdState : unit -> unit
    default this.playingAdState() : unit =
        ()
    
    abstract playingAdStateWH : width: int * height: int -> unit
    default this.playingAdStateWH(width: int, height: int) : unit =
        ()
    
    abstract notPlayingAdState : unit -> unit
    default this.notPlayingAdState() : unit =
        ()
    
    abstract setGameIsReady : gameIsReady: bool -> unit
    default this.setGameIsReady(gameIsReady: bool) : unit =
        ()
    
    abstract isGameIsReady : unit -> bool
    default this.isGameIsReady() : bool =
        false
    
    abstract getAdvertisements : unit -> Advertisements
    default this.getAdvertisements() : Advertisements =
        this.advertisementsP
    
    abstract getAdConfiguration : unit -> AdConfiguration
    default this.getAdConfiguration() : AdConfiguration =
        this.adConfigurationP
    
    abstract isOkayToShowPageAd : unit -> bool
    default this.isOkayToShowPageAd() : bool =
        false
    
    abstract setOkayToShowAds : okayToShowAds: bool -> unit
    default this.setOkayToShowAds(okayToShowAds: bool) : unit =
        this.okayToShowAdsP <- okayToShowAds
    
    abstract isOkayToShowAds : unit -> bool
    default this.isOkayToShowAds() : bool =
        this.okayToShowAdsP
    
    abstract isEnabled : unit -> bool
    default this.isEnabled() : bool =
        false


