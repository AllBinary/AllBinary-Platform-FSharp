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
type BaseSoundsFactory =
    [<DefaultValue(false)>] val mutable initialized : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseSoundsFactory.jclinitDone then
            BaseSoundsFactory.jclinitDone <- true
            BaseSoundsFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract init : unit -> unit
    default this.init() : unit =
        ()
    
    abstract getSoundInterfaceArray : unit -> Sound[]
    default this.getSoundInterfaceArray() : Sound[] =
        (Array.zeroCreate<Sound> (0))
    
    abstract setInitialized : initialized: bool -> unit
    default this.setInitialized(initialized: bool) : unit =
        this.initialized <- initialized
    
    abstract isInitialized : unit -> bool
    default this.isInitialized() : bool =
        this.initialized
    interface SoundsFactoryInterface with
        member this.init() : unit = this.init()
        member this.getSoundInterfaceArray() : Sound[] = this.getSoundInterfaceArray()
        member this.setInitialized(jp0: bool) : unit = this.setInitialized(jp0)
        member this.isInitialized() : bool = this.isInitialized()


