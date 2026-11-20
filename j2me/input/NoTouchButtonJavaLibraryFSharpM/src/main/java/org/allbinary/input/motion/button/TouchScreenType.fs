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
type TouchScreenType =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchScreenType.jclinitDone then
            TouchScreenType.jclinitDone <- true
            TouchScreenType.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string) as this =
        {  }
        then
            this.jctor1(name)
    member this.jctor1(name: string) : unit =
        this.name <- name
        ()
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    override this.ToString() : string =
        this.getName()


