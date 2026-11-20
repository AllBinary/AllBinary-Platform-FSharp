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
type NoHardwareComponent =
    [<DefaultValue(false)>] static val mutable private jcell_instance : NoHardwareComponent
    static member instance with get() : NoHardwareComponent = (NoHardwareComponent.jclinit(); NoHardwareComponent.jcell_instance) and set (jvalue: NoHardwareComponent) = (NoHardwareComponent.jclinit(); NoHardwareComponent.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NoHardwareComponent.jclinitDone then
            NoHardwareComponent.jclinitDone <- true
            NoHardwareComponent.jclinitBody()
    static member private jclinitBody() : unit =
        NoHardwareComponent.jcell_instance <- (new NoHardwareComponent())
        ()
    new () =
        {  }
    
    static member getInstance() : NoHardwareComponent =
        NoHardwareComponent.instance
    
    abstract compareTo : componentInterface: HardwareComponentInterface -> bool
    default this.compareTo(componentInterface: HardwareComponentInterface) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(this, componentInterface)) then
            jret <- true
            jflow <- 1
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    override this.ToString() : string =
        StringUtil.getInstance().NULL_STRING
    interface HardwareComponentInterface with
        member this.compareTo(jp0: HardwareComponentInterface) : bool = this.compareTo(jp0)


