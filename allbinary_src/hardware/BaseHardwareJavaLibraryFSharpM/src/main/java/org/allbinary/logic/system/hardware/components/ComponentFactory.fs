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
type ComponentFactory =
    [<DefaultValue(false)>] val mutable VGA : Component
    [<DefaultValue(false)>] val mutable IDE : Component
    [<DefaultValue(false)>] val mutable SCSI : Component
    [<DefaultValue(false)>] val mutable BRIDGE : Component
    [<DefaultValue(false)>] val mutable ETHERNET : Component
    [<DefaultValue(false)>] val mutable USB : Component
    [<DefaultValue(false)>] val mutable MULTIMEDIA : Component
    [<DefaultValue(false)>] val mutable PCI : Component
    [<DefaultValue(false)>] val mutable RAID : Component
    [<DefaultValue(false)>] val mutable SMBUS : Component
    [<DefaultValue(false)>] val mutable PIC : Component
    [<DefaultValue(false)>] val mutable Class : Component
    [<DefaultValue(false)>] val mutable UNKNOWN : Component
    [<DefaultValue(false)>] static val mutable private jcell_instance : ComponentFactory
    static member instance with get() : ComponentFactory = (ComponentFactory.jclinit(); ComponentFactory.jcell_instance) and set (jvalue: ComponentFactory) = (ComponentFactory.jclinit(); ComponentFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ComponentFactory.jclinitDone then
            ComponentFactory.jclinitDone <- true
            ComponentFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ComponentFactory.jcell_instance <- (new ComponentFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_ComponentFactory()
    member this.jfields_ComponentFactory() : unit =
        this.VGA <- (new Component("VGA"))
        this.IDE <- (new Component("IDE"))
        this.SCSI <- (new Component("SCSI"))
        this.BRIDGE <- (new Component("bridge"))
        this.ETHERNET <- (new Component("Ethernet"))
        this.USB <- (new Component("USB"))
        this.MULTIMEDIA <- (new Component("Multimedia"))
        this.PCI <- (new Component("PCI"))
        this.RAID <- (new Component("RAID"))
        this.SMBUS <- (new Component("SMBus"))
        this.PIC <- (new Component("PIC"))
        this.Class <- (new Component("Class"))
        this.UNKNOWN <- (new Component(CommonStrings.getInstance().UNKNOWN))
        ()
    
    static member getInstance() : ComponentFactory =
        ComponentFactory.instance


