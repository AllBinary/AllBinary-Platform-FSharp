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
type Special5GameInputInterfaceProcessor =
    inherit SpecialGameInputInterfaceProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Special5GameInputInterfaceProcessor.jclinitDone then
            Special5GameInputInterfaceProcessor.jclinitDone <- true
            Special5GameInputInterfaceProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (collidableDestroyableDamageableLayer: SpecialGameInputInterface) =
        { inherit SpecialGameInputInterfaceProcessor(collidableDestroyableDamageableLayer) }
    
    override this.processEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        this.specialGameInputInterface.special5(allbinaryLayerManager, gameKeyEvent)


