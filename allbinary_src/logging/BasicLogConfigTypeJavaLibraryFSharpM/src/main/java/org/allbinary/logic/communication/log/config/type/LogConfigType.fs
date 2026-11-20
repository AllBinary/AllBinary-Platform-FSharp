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
type LogConfigType =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable description : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LogConfigType.jclinitDone then
            LogConfigType.jclinitDone <- true
            LogConfigType.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string, description: string) as this =
        {  }
        then
            this.jctor1(name, description)
    member this.jctor1(name: string, description: string) : unit =
        this.name <- name
        this.description <- description
        ()
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract getDescription : unit -> string
    default this.getDescription() : string =
        this.description
    
    abstract setName : value: string -> unit
    default this.setName(value: string) : unit =
        this.name <- value
    
    abstract setDescription : value: string -> unit
    default this.setDescription(value: string) : unit =
        this.description <- value


