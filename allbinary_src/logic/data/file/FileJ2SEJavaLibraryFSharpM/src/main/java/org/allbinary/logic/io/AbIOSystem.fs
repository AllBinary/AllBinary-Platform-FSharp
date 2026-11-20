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
type AbIOSystem =
    [<DefaultValue(false)>] val mutable type_ : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : AbIOSystem
    static member instance with get() : AbIOSystem = (AbIOSystem.jclinit(); AbIOSystem.jcell_instance) and set (jvalue: AbIOSystem) = (AbIOSystem.jclinit(); AbIOSystem.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AbIOSystem.jclinitDone then
            AbIOSystem.jclinitDone <- true
            AbIOSystem.jclinitBody()
    static member private jclinitBody() : unit =
        AbIOSystem.jcell_instance <- (new AbIOSystem())
        ()
    new () as this =
        {  }
        then
            this.jfields_AbIOSystem()
    member this.jfields_AbIOSystem() : unit =
        this.type_ <- "java.io"
        ()
    
    static member getInstance() : AbIOSystem =
        AbIOSystem.instance
    
    abstract getType : unit -> string
    default this.getType() : string =
        this.type_
    
    abstract isType : type_: string -> bool
    default this.isType(type_: string) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if JString.compareTo(this.type_, type_) = 0 then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


