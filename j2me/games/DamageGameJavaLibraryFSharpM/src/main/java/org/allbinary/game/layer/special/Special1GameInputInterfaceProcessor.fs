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
type Special1GameInputInterfaceProcessor =
    inherit SpecialGameInputInterfaceProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Special1GameInputInterfaceProcessor.jclinitDone then
            Special1GameInputInterfaceProcessor.jclinitDone <- true
            Special1GameInputInterfaceProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (collidableDestroyableDamageableLayer: SpecialGameInputInterface) =
        { inherit SpecialGameInputInterfaceProcessor(collidableDestroyableDamageableLayer) }
    
    override this.processEvent(allbinaryLayerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        this.specialGameInputInterface.special1(allbinaryLayerManager, gameKeyEvent)


