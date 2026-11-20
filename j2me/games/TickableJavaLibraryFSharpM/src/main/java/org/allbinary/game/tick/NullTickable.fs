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
type NullTickable =
    [<DefaultValue(false)>] val mutable NAME : string
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : NullTickable
    static member SINGLETON with get() : NullTickable = (NullTickable.jclinit(); NullTickable.jcell_SINGLETON) and set (jvalue: NullTickable) = (NullTickable.jclinit(); NullTickable.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NullTickable.jclinitDone then
            NullTickable.jclinitDone <- true
            NullTickable.jclinitBody()
    static member private jclinitBody() : unit =
        NullTickable.jcell_SINGLETON <- (new NullTickable())
        ()
    new () as this =
        {  }
        then
            this.jfields_NullTickable()
    member this.jfields_NullTickable() : unit =
        this.NAME <- "NulLTickable"
        ()
    
    static member getInstance() : NullTickable =
        NullTickable.SINGLETON
    
    abstract processTick : allBinaryLayerManager: AllBinaryLayerManager -> unit
    default this.processTick(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        ()
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.NAME
    interface TickableInterface with
        member this.processTick(jp0: AllBinaryLayerManager) : unit = this.processTick(jp0)
    interface NamedInterface with
        member this.getName() : string = this.getName()


