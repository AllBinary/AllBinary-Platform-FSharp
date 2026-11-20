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
type LayerPlacementType =
    [<DefaultValue(false)>] val mutable type_ : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerPlacementType.jclinitDone then
            LayerPlacementType.jclinitDone <- true
            LayerPlacementType.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (type_: int) as this =
        {  }
        then
            this.jctor1(type_)
    member this.jctor1(type_: int) : unit =
        this.type_ <- type_
        ()
    
    abstract getType : unit -> int
    default this.getType() : int =
        this.type_
    
    abstract setType : type_: int -> unit
    default this.setType(type_: int) : unit =
        this.type_ <- type_


