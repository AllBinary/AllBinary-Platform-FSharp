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
type PlayerStateUtil =
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable UNREALIZED : string
    [<DefaultValue(false)>] val mutable REALIZED : string
    [<DefaultValue(false)>] val mutable PREFETCHED : string
    [<DefaultValue(false)>] val mutable STARTED : string
    [<DefaultValue(false)>] val mutable CLOSED : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : PlayerStateUtil
    static member instance with get() : PlayerStateUtil = (PlayerStateUtil.jclinit(); PlayerStateUtil.jcell_instance) and set (jvalue: PlayerStateUtil) = (PlayerStateUtil.jclinit(); PlayerStateUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlayerStateUtil.jclinitDone then
            PlayerStateUtil.jclinitDone <- true
            PlayerStateUtil.jclinitBody()
    static member private jclinitBody() : unit =
        PlayerStateUtil.jcell_instance <- (new PlayerStateUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_PlayerStateUtil()
    member this.jfields_PlayerStateUtil() : unit =
        this.commonStrings <- CommonStrings.getInstance()
        this.UNREALIZED <- "UNREALIZED"
        this.REALIZED <- "REALIZED"
        this.PREFETCHED <- "PREFETCHED"
        this.STARTED <- "STARTED"
        this.CLOSED <- "CLOSED"
        ()
    
    static member getInstance() : PlayerStateUtil =
        PlayerStateUtil.instance
    
    abstract convert : state: int -> string
    default this.convert(state: int) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        if state = Player.UNREALIZED then
            jret <- this.UNREALIZED
            jflow <- 1
        elif state = Player.REALIZED then
            jret <- this.REALIZED
            jflow <- 1
        elif state = Player.PREFETCHED then
            jret <- this.PREFETCHED
            jflow <- 1
        elif state = Player.STARTED then
            jret <- this.STARTED
            jflow <- 1
        elif state = Player.CLOSED then
            jret <- this.CLOSED
            jflow <- 1
        if jflow = 0 then
            jret <- this.commonStrings.UNKNOWN
            jflow <- 1
        jret


