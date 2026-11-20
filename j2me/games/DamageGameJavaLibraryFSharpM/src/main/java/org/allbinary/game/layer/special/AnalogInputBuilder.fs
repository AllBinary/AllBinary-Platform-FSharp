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
type AnalogInputBuilder =
    [<DefaultValue(false)>] static val mutable private jcell_instance : AnalogInputBuilder
    static member instance with get() : AnalogInputBuilder = (AnalogInputBuilder.jclinit(); AnalogInputBuilder.jcell_instance) and set (jvalue: AnalogInputBuilder) = (AnalogInputBuilder.jclinit(); AnalogInputBuilder.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AnalogInputBuilder.jclinitDone then
            AnalogInputBuilder.jclinitDone <- true
            AnalogInputBuilder.jclinitBody()
    static member private jclinitBody() : unit =
        AnalogInputBuilder.jcell_instance <- (new AnalogInputBuilder())
        ()
    new () =
        {  }
    
    static member getInstance() : AnalogInputBuilder =
        AnalogInputBuilder.instance
    
    abstract disable : inputProcessorArray: GameInputProcessor[] * collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer -> unit
    default this.disable(inputProcessorArray: GameInputProcessor[], collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer) : unit =
        inputProcessorArray.[Canvas.UP] <- (new SpecialUpGameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.DOWN] <- (new SpecialDownGameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.RIGHT] <- (new SpecialRightGameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.LEFT] <- (new SpecialLeftGameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.KEY_NUM0] <- (new Special1GameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.KEY_NUM5] <- (new Special3GameInputProcessor(collidableDestroyableDamageableLayer))
    
    abstract enable : inputProcessorArray: GameInputProcessor[] * collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer -> unit
    default this.enable(inputProcessorArray: GameInputProcessor[], collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer) : unit =
        inputProcessorArray.[Canvas.UP] <- (new SpecialAnalogUpGameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.DOWN] <- (new SpecialAnalogDownGameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.RIGHT] <- (new SpecialAnalogRightGameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.LEFT] <- (new SpecialAnalogLeftGameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.KEY_NUM0] <- (new SpecialAnalogLeftTriggerGameInputProcessor(collidableDestroyableDamageableLayer))
        inputProcessorArray.[Canvas.KEY_NUM5] <- (new SpecialAnalogRightTriggerGameInputProcessor(collidableDestroyableDamageableLayer))


