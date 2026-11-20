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
type MultiKeyPressesAI =
    inherit KeyPressesAI
    [<DefaultValue(false)>] val mutable toggleTimeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable gameTickTimeDelayHelper : GameTickTimeDelayHelper
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MultiKeyPressesAI.jclinitDone then
            MultiKeyPressesAI.jclinitDone <- true
            MultiKeyPressesAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_MultiKeyPressesAI() : unit =
        this.toggleTimeHelper <- (new TimeDelayHelper(600))
        this.gameTickTimeDelayHelper <- GameTickTimeDelayHelperFactory.getInstance()
        ()
    
    new (hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit KeyPressesAI(hashtable, ownerLayerInterface, gameInput) }
        then
            this.jfields_MultiKeyPressesAI()
            this.jctor1(hashtable, ownerLayerInterface, gameInput)
    member this.jctor1(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.update()
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        ()
    
    member this.update() : unit =
        let mutable gameInput : GameInput = this.getGameInput()
        let mutable keys : Integer[] = this.keys
        let mutable size : int = keys.Length
        if this.isOn() then
            let mutable index : int = 0
            while index < size do
                let mutable key : int = keys.[index].intValue()
                if key <> (-1) then
                    ignore (gameInput.add(this.gameKeyEventFactory.getInstanceForKey(this, key)))
                index <- index + 1
        else
            let mutable index : int = 0
            while index < size do
                let mutable key : int = keys.[index].intValue()
                if key <> (-1) then
                    gameInput.addForRemoval(this.gameKeyEventFactory.getInstanceForKey(this, key))
                index <- index + 1
    
    override this.toggle() : unit =
        if this.toggleTimeHelper.isTime(this.gameTickTimeDelayHelper.startTime) then
            base.toggle()
            this.update()
    
    override this.disable() : unit =
        if this.toggleTimeHelper.isTime(this.gameTickTimeDelayHelper.startTime) then
            base.disable()
            this.update()
    
    override this.enable() : unit =
        if this.toggleTimeHelper.isTime(this.gameTickTimeDelayHelper.startTime) then
            base.enable()
            this.update()


