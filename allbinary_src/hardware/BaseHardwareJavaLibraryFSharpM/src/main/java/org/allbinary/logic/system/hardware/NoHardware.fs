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
type NoHardware =
    [<DefaultValue(false)>] static val mutable private jcell_instance : HardwareInterface
    static member instance with get() : HardwareInterface = (NoHardware.jclinit(); NoHardware.jcell_instance) and set (jvalue: HardwareInterface) = (NoHardware.jclinit(); NoHardware.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoHardware.jclinitDone then
            NoHardware.jclinitDone <- true
            NoHardware.jclinitBody()
    static member private jclinitBody() : unit =
        NoHardware.jcell_instance <- (new NoHardware())
        ()
    new () =
        {  }
    
    static member getInstance() : HardwareInterface =
        NoHardware.instance
    
    abstract getComponent : index: int -> HardwareComponentInterface
    default this.getComponent(index: int) : HardwareComponentInterface =
        NoHardwareComponent.getInstance()
    
    override this.ToString() : string =
        "No Hardware"
    
    abstract compareTo : hardwareInterface: HardwareInterface -> bool
    default this.compareTo(hardwareInterface: HardwareInterface) : bool =
        true
    
    abstract difference : hardwareInterface: HardwareInterface -> ABHashtable
    default this.difference(hardwareInterface: HardwareInterface) : ABHashtable =
        StdUtil.getInstance().NULL_TABLE
    interface HardwareInterface with
        member this.getComponent(jp0: int) : HardwareComponentInterface = this.getComponent(jp0)
        member this.compareTo(jp0: HardwareInterface) : bool = this.compareTo(jp0)
        member this.difference(jp0: HardwareInterface) : ABHashtable = this.difference(jp0)


