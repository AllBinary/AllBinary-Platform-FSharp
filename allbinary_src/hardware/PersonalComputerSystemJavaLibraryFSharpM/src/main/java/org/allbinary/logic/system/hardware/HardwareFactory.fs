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
type HardwareFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : HardwareFactory
    static member instance with get() : HardwareFactory = (HardwareFactory.jclinit(); HardwareFactory.jcell_instance) and set (jvalue: HardwareFactory) = (HardwareFactory.jclinit(); HardwareFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HardwareFactory.jclinitDone then
            HardwareFactory.jclinitDone <- true
            HardwareFactory.jclinitBody()
    static member private jclinitBody() : unit =
        HardwareFactory.jcell_instance <- (new HardwareFactory())
        ()
    
    static member getInstance_jstatic() : HardwareFactory =
        HardwareFactory.instance
    
    new () =
        {  }
    
    static member getInstance_jstatic(os: GenericOperatingSystem) : HardwareInterface =
        let mutable jflow = 0
        let mutable jret : HardwareInterface = Unchecked.defaultof<HardwareInterface>
        try
            let mutable operatingSystems : OperatingSystems = OperatingSystems.getInstance()
            if JString.compareTo(os.getName(), operatingSystems.LINUX) = 0 then
                jret <- (box ((new LinuxHardware())) :?> HardwareInterface)
                jflow <- 1
            elif JString.indexOf(os.getName(), operatingSystems.WINDOWS) >= 0 then
                jret <- (box ((new WindowsHardware())) :?> HardwareInterface)
                jflow <- 1
            if jflow = 0 then
                raise ((new JException((JR.nn("No Hardware Imp for: ") + JR.nn(os.getName())))))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                raise (e)
            | _ -> reraise ()
        jret


