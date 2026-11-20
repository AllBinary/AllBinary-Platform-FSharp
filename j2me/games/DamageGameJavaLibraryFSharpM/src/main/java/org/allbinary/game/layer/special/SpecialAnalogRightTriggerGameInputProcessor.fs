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
type SpecialAnalogRightTriggerGameInputProcessor =
    inherit SpecialGameInputProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpecialAnalogRightTriggerGameInputProcessor.jclinitDone then
            SpecialAnalogRightTriggerGameInputProcessor.jclinitDone <- true
            SpecialAnalogRightTriggerGameInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer) =
        { inherit SpecialGameInputProcessor(collidableDestroyableDamageableLayer) }
    
    override this.processAnalog(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent, yAnalogValue: int) : unit =
        this.collidableDestroyableDamageableLayer.rightTrigger(allbinaryLayerManager, gameKeyEvent, yAnalogValue)


