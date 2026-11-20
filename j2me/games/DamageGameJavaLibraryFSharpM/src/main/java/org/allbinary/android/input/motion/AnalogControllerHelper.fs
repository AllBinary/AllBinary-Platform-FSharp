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
type AnalogControllerHelper =
    [<DefaultValue(false)>] val mutable reduceTimeFactor : int
    [<DefaultValue(false)>] val mutable SCALE_VALUE : int
    [<DefaultValue(false)>] val mutable rightTimeElapsedHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable leftTimeElapsedHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable downTimeElapsedHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable upTimeElapsedHelper : TimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnalogControllerHelper.jclinitDone then
            AnalogControllerHelper.jclinitDone <- true
            AnalogControllerHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AnalogControllerHelper() : unit =
        this.SCALE_VALUE <- AnalogControllerConfigurationFactory.getInstance().SCALE_VALUE
        this.rightTimeElapsedHelper <- (new TimeDelayHelper(0))
        this.leftTimeElapsedHelper <- (new TimeDelayHelper(0))
        this.downTimeElapsedHelper <- (new TimeDelayHelper(0))
        this.upTimeElapsedHelper <- (new TimeDelayHelper(0))
        ()
    
    new (reduceTimeFactor: int) as this =
        {  }
        then
            this.jfields_AnalogControllerHelper()
            this.jctor1(reduceTimeFactor)
    member this.jctor1(reduceTimeFactor: int) : unit =
        this.reduceTimeFactor <- reduceTimeFactor
        ()
    
    abstract right : collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer * xAnalogValue: int -> unit
    default this.right(collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer, xAnalogValue: int) : unit =
        this.rightTimeElapsedHelper.delay <- ((this.SCALE_VALUE - xAnalogValue) >>> this.reduceTimeFactor)
        if this.rightTimeElapsedHelper.isTimeTNT() then
            collidableDestroyableDamageableLayer.right()
    
    abstract left : collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer * xAnalogValue: int -> unit
    default this.left(collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer, xAnalogValue: int) : unit =
        this.leftTimeElapsedHelper.delay <- ((this.SCALE_VALUE + xAnalogValue) >>> this.reduceTimeFactor)
        if this.leftTimeElapsedHelper.isTimeTNT() then
            collidableDestroyableDamageableLayer.left()
    
    abstract up : collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer * xAnalogValue: int -> unit
    default this.up(collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer, xAnalogValue: int) : unit =
        this.upTimeElapsedHelper.delay <- ((this.SCALE_VALUE - xAnalogValue) >>> this.reduceTimeFactor)
        if this.upTimeElapsedHelper.isTimeTNT() then
            collidableDestroyableDamageableLayer.up()
    
    abstract down : collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer * xAnalogValue: int -> unit
    default this.down(collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer, xAnalogValue: int) : unit =
        this.downTimeElapsedHelper.delay <- ((this.SCALE_VALUE + xAnalogValue) >>> this.reduceTimeFactor)
        if this.downTimeElapsedHelper.isTimeTNT() then
            collidableDestroyableDamageableLayer.down()


