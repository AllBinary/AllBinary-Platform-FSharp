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
type KeyPressesAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable on : bool
    [<DefaultValue(false)>] val mutable keys : Integer[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KeyPressesAI.jclinitDone then
            KeyPressesAI.jclinitDone <- true
            KeyPressesAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_KeyPressesAI() : unit =
        this.on <- true
        ()
    
    new (hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_KeyPressesAI()
            this.jctor1(hashtable, ownerLayerInterface, gameInput)
    member this.jctor1(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.keys <- (Array.zeroCreate<Integer> (hashtable.size()))
        let mutable objectArray : obj[] = HashtableUtil.getInstance().getKeysAsArray(hashtable)
        let mutable size : int = objectArray.Length
        let mutable index : int = 0
        while index < size do
            this.keys.[index] <- (box (hashtable.get((box (objectArray.[index])))) :?> Integer)
            index <- index + 1
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        if this.on then
            let mutable index : int = 0
            while index < this.keys.Length do
                base.processKeyAI(this.keys.[index].intValue())
                index <- index + 1
    
    abstract toggle : unit -> unit
    default this.toggle() : unit =
        if this.isOn() then
            this.setOn(false)
        else
            this.setOn(true)
    
    abstract disable : unit -> unit
    default this.disable() : unit =
        this.setOn(false)
    
    abstract enable : unit -> unit
    default this.enable() : unit =
        this.setOn(true)
    
    member this.setOn(on: bool) : unit =
        this.on <- on
    
    abstract isOn : unit -> bool
    default this.isOn() : bool =
        this.on


