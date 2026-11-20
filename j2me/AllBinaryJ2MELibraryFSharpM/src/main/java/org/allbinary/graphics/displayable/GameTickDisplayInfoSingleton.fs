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
type GameTickDisplayInfoSingleton =
    [<DefaultValue(false)>] val mutable displayInfoSingleton : DisplayInfoSingleton
    [<DefaultValue(false)>] val mutable lastWidth : int
    [<DefaultValue(false)>] val mutable lastHeight : int
    [<DefaultValue(false)>] val mutable lastHalfWidth : int
    [<DefaultValue(false)>] val mutable lastHalfHeight : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : GameTickDisplayInfoSingleton
    static member instance with get() : GameTickDisplayInfoSingleton = (GameTickDisplayInfoSingleton.jclinit(); GameTickDisplayInfoSingleton.jcell_instance) and set (jvalue: GameTickDisplayInfoSingleton) = (GameTickDisplayInfoSingleton.jclinit(); GameTickDisplayInfoSingleton.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameTickDisplayInfoSingleton.jclinitDone then
            GameTickDisplayInfoSingleton.jclinitDone <- true
            GameTickDisplayInfoSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        GameTickDisplayInfoSingleton.jcell_instance <- (new GameTickDisplayInfoSingleton())
        ()
    new () as this =
        {  }
        then
            this.jfields_GameTickDisplayInfoSingleton()
    member this.jfields_GameTickDisplayInfoSingleton() : unit =
        this.displayInfoSingleton <- DisplayInfoSingleton.getInstance()
        this.lastWidth <- this.displayInfoSingleton.getLastWidth()
        this.lastHeight <- this.displayInfoSingleton.getLastHeight()
        this.lastHalfWidth <- this.displayInfoSingleton.getLastHalfWidth()
        this.lastHalfHeight <- this.displayInfoSingleton.getLastHalfHeight()
        ()
    
    static member getInstance() : GameTickDisplayInfoSingleton =
        GameTickDisplayInfoSingleton.instance
    
    abstract update : unit -> unit
    default this.update() : unit =
        this.lastWidth <- this.displayInfoSingleton.getLastWidth()
        this.lastHeight <- this.displayInfoSingleton.getLastHeight()
        this.lastHalfWidth <- this.displayInfoSingleton.getLastHalfWidth()
        this.lastHalfHeight <- this.displayInfoSingleton.getLastHalfHeight()
    
    abstract getLastWidth : unit -> int
    default this.getLastWidth() : int =
        this.lastWidth
    
    abstract getLastHeight : unit -> int
    default this.getLastHeight() : int =
        this.lastHeight
    
    abstract getLastHalfWidth : unit -> int
    default this.getLastHalfWidth() : int =
        this.lastHalfWidth
    
    abstract getLastHalfHeight : unit -> int
    default this.getLastHalfHeight() : int =
        this.lastHalfHeight


