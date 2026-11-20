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
type Component =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Component.jclinitDone then
            Component.jclinitDone <- true
            Component.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (componentName: string) as this =
        {  }
        then
            this.jctor1(componentName)
    member this.jctor1(componentName: string) : unit =
        this.name <- componentName
        ()
    
    override this.ToString() : string =
        this.name


