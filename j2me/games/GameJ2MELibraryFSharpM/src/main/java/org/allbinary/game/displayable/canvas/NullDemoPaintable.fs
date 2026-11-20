namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type NullDemoPaintable =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_DEMO_PAINTABLE : NullDemoPaintable
    static member NULL_DEMO_PAINTABLE with get() : NullDemoPaintable = (NullDemoPaintable.jclinit(); NullDemoPaintable.jcell_NULL_DEMO_PAINTABLE) and set (jvalue: NullDemoPaintable) = (NullDemoPaintable.jclinit(); NullDemoPaintable.jcell_NULL_DEMO_PAINTABLE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullDemoPaintable.jclinitDone then
            NullDemoPaintable.jclinitDone <- true
            NullDemoPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        NullDemoPaintable.jcell_NULL_DEMO_PAINTABLE <- (new NullDemoPaintable())
        ()
    new () =
        {  }
    
    abstract showGamePaintable : unit -> unit
    default this.showGamePaintable() : unit =
        ()
    interface DemoPaintableInterface with
        member this.showGamePaintable() : unit = this.showGamePaintable()


