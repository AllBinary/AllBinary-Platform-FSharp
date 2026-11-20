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
type FrictionProperties =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FrictionProperties.jclinitDone then
            FrictionProperties.jclinitDone <- true
            FrictionProperties.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    abstract friction : velocityProperties: VelocityProperties * nominator: int -> unit
    default this.friction(velocityProperties: VelocityProperties, nominator: int) : unit =
        DragVelocityBehavior.instance.reduce(velocityProperties, nominator, FrictionData.getFrictionDenominator())


