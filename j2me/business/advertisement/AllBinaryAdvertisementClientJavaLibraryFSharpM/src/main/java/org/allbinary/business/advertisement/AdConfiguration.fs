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
type AdConfiguration =
    [<DefaultValue(false)>] val mutable INNERACTIVE : string
    [<DefaultValue(false)>] val mutable LEADBOLT : string
    [<DefaultValue(false)>] val mutable ADMOB : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AdConfiguration.jclinitDone then
            AdConfiguration.jclinitDone <- true
            AdConfiguration.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (advertIdArray: obj[]) as this =
        {  }
        then
            this.jctor1(advertIdArray)
    member this.jctor1(advertIdArray: obj[]) : unit =
        this.INNERACTIVE <- (box (advertIdArray.[0]) :?> string)
        this.ADMOB <- (box (advertIdArray.[1]) :?> string)
        this.LEADBOLT <- (box (advertIdArray.[2]) :?> string)
        ()
    
    abstract getValidAdSpots : unit -> Direction[]
    default this.getValidAdSpots() : Direction[] =
        (Array.zeroCreate<Direction> (0))
    
    abstract process_ : gameState: GameState -> unit
    default this.process_(gameState: GameState) : unit =
        ()
    
    abstract processDemo : state: int -> unit
    default this.processDemo(state: int) : unit =
        ()
    
    abstract setShowAds : unit -> unit
    default this.setShowAds() : unit =
        ()
    
    abstract setToggleAds : showAds: bool -> unit
    default this.setToggleAds(showAds: bool) : unit =
        ()
    
    abstract isShowAds : unit -> bool
    default this.isShowAds() : bool =
        true


