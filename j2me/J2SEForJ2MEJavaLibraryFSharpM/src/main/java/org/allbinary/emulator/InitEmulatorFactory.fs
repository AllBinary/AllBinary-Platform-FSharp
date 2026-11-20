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
type InitEmulatorFactory =
    [<DefaultValue(false)>] val mutable initEmulator : bool
    [<DefaultValue(false)>] static val mutable private jcell_instance : InitEmulatorFactory
    static member instance with get() : InitEmulatorFactory = (InitEmulatorFactory.jclinit(); InitEmulatorFactory.jcell_instance) and set (jvalue: InitEmulatorFactory) = (InitEmulatorFactory.jclinit(); InitEmulatorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InitEmulatorFactory.jclinitDone then
            InitEmulatorFactory.jclinitDone <- true
            InitEmulatorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        InitEmulatorFactory.jcell_instance <- (new InitEmulatorFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_InitEmulatorFactory()
    member this.jfields_InitEmulatorFactory() : unit =
        this.initEmulator <- false
        ()
    
    static member getInstance() : InitEmulatorFactory =
        InitEmulatorFactory.instance
    
    abstract setInitEmulator : initEmulator: bool -> unit
    default this.setInitEmulator(initEmulator: bool) : unit =
        this.initEmulator <- initEmulator
    
    abstract isInitEmulator : unit -> bool
    default this.isInitEmulator() : bool =
        this.initEmulator


