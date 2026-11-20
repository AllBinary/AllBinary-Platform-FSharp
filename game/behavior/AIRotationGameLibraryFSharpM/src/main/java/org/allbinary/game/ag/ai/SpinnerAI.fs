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
type SpinnerAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable isEven : bool
    [<DefaultValue(false)>] val mutable direction : int[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpinnerAI.jclinitDone then
            SpinnerAI.jclinitDone <- true
            SpinnerAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (direction: int[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jctor1(direction, ownerLayerInterface, gameInput)
    member this.jctor1(direction: int[], ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : unit =
        ()
        this.direction <- direction
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        if this.isEven then
            base.processKeyAI(this.direction.[0])
            this.isEven <- false
        else
            base.processKeyAI(Canvas.KEY_NUM1)
            this.isEven <- true


