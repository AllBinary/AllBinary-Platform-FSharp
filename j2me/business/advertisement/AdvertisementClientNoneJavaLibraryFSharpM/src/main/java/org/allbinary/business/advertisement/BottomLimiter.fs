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
type BottomLimiter =
    [<DefaultValue(false)>] val mutable bottom : int
    [<DefaultValue(false)>] val mutable deltaY : int
    [<DefaultValue(false)>] val mutable lower : int
    [<DefaultValue(false)>] val mutable higher : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : BottomLimiter
    static member instance with get() : BottomLimiter = (BottomLimiter.jclinit(); BottomLimiter.jcell_instance) and set (jvalue: BottomLimiter) = (BottomLimiter.jclinit(); BottomLimiter.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BottomLimiter.jclinitDone then
            BottomLimiter.jclinitDone <- true
            BottomLimiter.jclinitBody()
    static member private jclinitBody() : unit =
        BottomLimiter.jcell_instance <- (new BottomLimiter())
        ()
    
    static member getInstance() : BottomLimiter =
        BottomLimiter.instance
    
    new () =
        {  }
    
    abstract init : lower: int * higher: int -> unit
    default this.init(lower: int, higher: int) : unit =
        this.lower <- lower
        this.higher <- higher
    
    abstract update : unit -> unit
    default this.update() : unit =
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable gameAdState : GameAdState = GameAdStateFactory.getInstance().getCurrentInstance()
        if gameAdState.isShowingAt() then
            this.deltaY <- this.higher
        else
            this.deltaY <- this.lower
        this.bottom <- displayInfo.getLastHeight() - this.deltaY
    
    abstract getDeltaY : unit -> int
    default this.getDeltaY() : int =
        this.deltaY
    
    abstract getBottom : unit -> int
    default this.getBottom() : int =
        this.bottom


