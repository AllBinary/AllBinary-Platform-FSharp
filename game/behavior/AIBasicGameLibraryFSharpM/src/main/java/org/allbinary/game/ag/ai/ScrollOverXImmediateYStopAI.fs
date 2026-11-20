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
type ScrollOverXImmediateYStopAI =
    inherit BasicAI
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScrollOverXImmediateYStopAI.jclinitDone then
            ScrollOverXImmediateYStopAI.jclinitDone <- true
            ScrollOverXImmediateYStopAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable x : int = ownerLayerInterface.getXP()
        let mutable y : int = ownerLayerInterface.getYP()
        let mutable x2 : int = ownerLayerInterface.getX2()
        let mutable y2 : int = ownerLayerInterface.getY2()
        let mutable width : int = ownerLayerInterface.getWidth()
        let mutable height : int = ownerLayerInterface.getHeight()
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        if x2 > displayInfo.getLastWidth() then
            ownerLayerInterface.setPosition(0, y, ownerLayerInterface.getZP())
        if y2 > displayInfo.getLastHeight() then
            ownerLayerInterface.setPosition(x, (displayInfo.getLastHeight() - height), ownerLayerInterface.getZP())
        if x < 0 then
            ownerLayerInterface.setPosition((displayInfo.getLastWidth() - width), y, ownerLayerInterface.getZP())
        if y < 0 then
            ownerLayerInterface.setPosition(x, 0, ownerLayerInterface.getZP())


