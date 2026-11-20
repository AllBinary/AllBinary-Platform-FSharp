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
type PlayerType =
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlayerType.jclinitDone then
            PlayerType.jclinitDone <- true
            PlayerType.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_PlayerType() : unit =
        this.name <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new (name: string, value: int) as this =
        {  }
        then
            this.jfields_PlayerType()
            this.jctor1(name, value)
    member this.jctor1(name: string, value: int) : unit =
        this.name <- name
        this.id <- value
        ()
    
    abstract getId : unit -> int
    default this.getId() : int =
        this.id
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    override this.ToString() : string =
        this.getName()


