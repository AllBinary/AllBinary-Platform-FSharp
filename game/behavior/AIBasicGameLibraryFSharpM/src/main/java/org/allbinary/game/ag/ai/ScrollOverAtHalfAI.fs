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
type ScrollOverAtHalfAI =
    inherit BasicAI
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScrollOverAtHalfAI.jclinitDone then
            ScrollOverAtHalfAI.jclinitDone <- true
            ScrollOverAtHalfAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable x : int = ownerLayerInterface.getXP()
        let mutable y : int = ownerLayerInterface.getYP()
        let mutable halfWidth : int = ownerLayerInterface.getHalfWidth()
        let mutable halfHeight : int = ownerLayerInterface.getHalfHeight()
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        if x > (displayInfo.getLastWidth() - halfWidth) then
            ownerLayerInterface.setPosition((halfWidth + 1), y, ownerLayerInterface.getZP())
        if y > (displayInfo.getLastHeight() - halfHeight) then
            ownerLayerInterface.setPosition(x, (halfHeight + 1), ownerLayerInterface.getZP())
        if x < (-(halfWidth)) then
            ownerLayerInterface.setPosition((displayInfo.getLastWidth() - halfWidth), y, ownerLayerInterface.getZP())
        if y < (-(halfHeight)) then
            ownerLayerInterface.setPosition(x, (displayInfo.getLastHeight() - halfHeight), ownerLayerInterface.getZP())


