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
type ResourceLoadingLevel =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable level : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ResourceLoadingLevel.jclinitDone then
            ResourceLoadingLevel.jclinitDone <- true
            ResourceLoadingLevel.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string, level: int) as this =
        {  }
        then
            this.jctor1(name, level)
    member this.jctor1(name: string, level: int) : unit =
        this.name <- name
        this.level <- level
        ()
    
    abstract getLevel : unit -> int
    default this.getLevel() : int =
        this.level
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name


