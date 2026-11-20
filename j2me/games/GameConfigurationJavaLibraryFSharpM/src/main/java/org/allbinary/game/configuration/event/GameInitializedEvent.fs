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
type GameInitializedEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable resourceLoadingLevel : ResourceLoadingLevel
    [<DefaultValue(false)>] val mutable level : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInitializedEvent.jclinitDone then
            GameInitializedEvent.jclinitDone <- true
            GameInitializedEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_GameInitializedEvent() : unit =
        this.resourceLoadingLevel <- ResourceLoadingLevelFactory.getInstance().LEVEL
        ()
    
    new (anyType: obj) as this =
        { inherit AllBinaryEventObject(anyType) }
        then
            this.jfields_GameInitializedEvent()
    
    abstract setLevel : level: int -> unit
    default this.setLevel(level: int) : unit =
        this.level <- level
        this.resourceLoadingLevel <- ResourceLoadingLevelFactory.getInstance().LEVEL
    
    abstract getLevel : unit -> int
    default this.getLevel() : int =
        this.level
    
    abstract setResourceLoadingLevel : resourceLoadingLevel: ResourceLoadingLevel -> unit
    default this.setResourceLoadingLevel(resourceLoadingLevel: ResourceLoadingLevel) : unit =
        this.resourceLoadingLevel <- resourceLoadingLevel
        this.level <- this.resourceLoadingLevel.getLevel()
    
    abstract getResourceLoadingLevel : unit -> ResourceLoadingLevel
    default this.getResourceLoadingLevel() : ResourceLoadingLevel =
        this.resourceLoadingLevel


