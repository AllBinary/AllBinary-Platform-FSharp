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
type SolarisOS =
    inherit GenericOperatingSystem
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SolarisOS.jclinitDone then
            SolarisOS.jclinitDone <- true
            SolarisOS.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () as this =
        { inherit GenericOperatingSystem() }
        then
            this.jctor1()
    member this.jctor1() : unit =
        this.scalable <- true
        ()
    
    override this.isAutoHide() : bool =
        true


