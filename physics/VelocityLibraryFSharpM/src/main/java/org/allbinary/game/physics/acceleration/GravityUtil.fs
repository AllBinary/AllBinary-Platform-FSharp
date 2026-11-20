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
type GravityUtil =
    [<DefaultValue(false)>] val mutable GAME_GRAVITY_VELOCITY : int
    [<DefaultValue(false)>] val mutable MAX_GAME_VELOCITY : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : GravityUtil
    static member instance with get() : GravityUtil = (GravityUtil.jclinit(); GravityUtil.jcell_instance) and set (jvalue: GravityUtil) = (GravityUtil.jclinit(); GravityUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GravityUtil.jclinitDone then
            GravityUtil.jclinitDone <- true
            GravityUtil.jclinitBody()
    static member private jclinitBody() : unit =
        GravityUtil.jcell_instance <- (new GravityUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_GravityUtil()
    member this.jfields_GravityUtil() : unit =
        this.GAME_GRAVITY_VELOCITY <- 1800
        this.MAX_GAME_VELOCITY <- 18000
        ()
    
    static member getInstance() : GravityUtil =
        GravityUtil.instance
    
    member this.process_(velocityProperties: BasicVelocityProperties, customGravity: int) : unit =
        velocityProperties.getVelocityYBasicDecimalP().addint(customGravity)


