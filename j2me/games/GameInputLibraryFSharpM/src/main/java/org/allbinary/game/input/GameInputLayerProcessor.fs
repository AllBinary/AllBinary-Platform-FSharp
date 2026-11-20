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
type GameInputLayerProcessor =
    inherit LayerProcessor
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameInputLayerProcessor.jclinitDone then
            GameInputLayerProcessor.jclinitDone <- true
            GameInputLayerProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit LayerProcessor((new GameInputLayerManager())) }
    
    override this.processAt(allBinaryLayerManager: AllBinaryLayerManager, layerInterface: AllBinaryLayer, index: int) : unit =
        let mutable gameInputInterface : GameInputInterface = (box (layerInterface) :?> GameInputInterface)
        gameInputInterface.processInput(allBinaryLayerManager)
    
    override this.isProcessorLayer(layerInterface: AllBinaryLayer) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if layerInterface.implmentsGameInputInterface() then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


