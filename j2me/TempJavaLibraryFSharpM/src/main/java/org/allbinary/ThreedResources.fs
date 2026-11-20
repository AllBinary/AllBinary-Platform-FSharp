namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type ThreedResources =
    [<DefaultValue(false)>] static val mutable private jcell_threedResources : ThreedResources
    static member threedResources with get() : ThreedResources = (ThreedResources.jclinit(); ThreedResources.jcell_threedResources) and set (jvalue: ThreedResources) = (ThreedResources.jclinit(); ThreedResources.jcell_threedResources <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ThreedResources.jclinitDone then
            ThreedResources.jclinitDone <- true
            ThreedResources.jclinitBody()
    static member private jclinitBody() : unit =
        ThreedResources.jcell_threedResources <- (new ThreedResources())
        ()
    new () =
        {  }
    
    static member getThreedResources() : ThreedResources =
        ThreedResources.threedResources
    
    abstract add : unit -> unit
    default this.add() : unit =
        ()


