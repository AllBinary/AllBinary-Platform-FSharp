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
type ScrollOverAllowOutsideAtEndAI =
    inherit BasicAI
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ScrollOverAllowOutsideAtEndAI.jclinitDone then
            ScrollOverAllowOutsideAtEndAI.jclinitDone <- true
            ScrollOverAllowOutsideAtEndAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable ownerLayerInterface : AllBinaryLayer = this.getOwnerLayerInterface()
        let mutable x : int = ownerLayerInterface.getXP()
        let mutable y : int = ownerLayerInterface.getYP()
        let mutable width : int = ownerLayerInterface.getWidth()
        let mutable height : int = ownerLayerInterface.getHeight()
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        if x > displayInfo.getLastWidth() then
            ownerLayerInterface.setPosition(-(width), y, ownerLayerInterface.getZP())
        if y > displayInfo.getLastHeight() then
            ownerLayerInterface.setPosition(x, -(height), ownerLayerInterface.getZP())
        if x < (-(width)) then
            ownerLayerInterface.setPosition((displayInfo.getLastWidth() + width), y, ownerLayerInterface.getZP())
        if y < (-(height)) then
            ownerLayerInterface.setPosition(x, (displayInfo.getLastHeight() + height), ownerLayerInterface.getZP())


