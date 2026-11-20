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
type LinuxHardware =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LinuxHardware.jclinitDone then
            LinuxHardware.jclinitDone <- true
            LinuxHardware.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    abstract getMultimedia : index: int -> MediaInterface
    default this.getMultimedia(index: int) : MediaInterface =
        raise ((new JRuntimeException()))
    
    abstract getBridge : index: int -> BridgeInterface
    default this.getBridge(index: int) : BridgeInterface =
        raise ((new JRuntimeException()))
    
    abstract getCpu : index: int -> CpuInterface
    default this.getCpu(index: int) : CpuInterface =
        raise ((new JRuntimeException()))
    
    abstract getEthernet : index: int -> EthernetInterface
    default this.getEthernet(index: int) : EthernetInterface =
        raise ((new JRuntimeException()))
    
    abstract getFireWire : index: int -> FireWireInterface
    default this.getFireWire(index: int) : FireWireInterface =
        raise ((new JRuntimeException()))
    
    abstract getHardDriveController : index: int -> HardDriveControllerInterface
    default this.getHardDriveController(index: int) : HardDriveControllerInterface =
        raise ((new JRuntimeException()))
    
    abstract getHardDrive : index: int -> HardDriveInterface
    default this.getHardDrive(index: int) : HardDriveInterface =
        raise ((new JRuntimeException()))
    
    abstract getMachineAccessControlAddress : index: int -> MachineAccessControlAddressInterface
    default this.getMachineAccessControlAddress(index: int) : MachineAccessControlAddressInterface =
        raise ((new JRuntimeException()))
    
    abstract getMonitor : index: int -> MonitorInterface
    default this.getMonitor(index: int) : MonitorInterface =
        raise ((new JRuntimeException()))
    
    abstract getUsb : index: int -> UsbInterface
    default this.getUsb(index: int) : UsbInterface =
        raise ((new JRuntimeException()))
    
    abstract getVideo : index: int -> VideoInterface
    default this.getVideo(index: int) : VideoInterface =
        raise ((new JRuntimeException()))
    
    abstract getComponent : index: int -> HardwareComponentInterface
    default this.getComponent(index: int) : HardwareComponentInterface =
        raise ((new JRuntimeException()))
    
    override this.ToString() : string =
        StringUtil.getInstance().EMPTY_STRING
    
    abstract compareTo : hardwareInterface: HardwareInterface -> bool
    default this.compareTo(hardwareInterface: HardwareInterface) : bool =
        true
    
    abstract difference : hardwareInterface: HardwareInterface -> ABHashtable
    default this.difference(hardwareInterface: HardwareInterface) : ABHashtable =
        StdUtil.getInstance().NULL_TABLE
    
    abstract isNextHardware : nextLine: string -> bool
    default this.isNextHardware(nextLine: string) : bool =
        false
    interface HardwareInterface with
        member this.getComponent(jp0: int) : HardwareComponentInterface = this.getComponent(jp0)
        member this.compareTo(jp0: HardwareInterface) : bool = this.compareTo(jp0)
        member this.difference(jp0: HardwareInterface) : ABHashtable = this.difference(jp0)


