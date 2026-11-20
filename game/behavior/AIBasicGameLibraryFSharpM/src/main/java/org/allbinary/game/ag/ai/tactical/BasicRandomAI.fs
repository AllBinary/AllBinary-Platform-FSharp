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
type BasicRandomAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable i_random : int
    [<DefaultValue(false)>] val mutable inputProbability : InputProbability
    [<DefaultValue(false)>] val mutable visitor : Visitor
    [<DefaultValue(false)>] val mutable keyArray : int[]
    [<DefaultValue(false)>] val mutable myRandomFactory : MyRandomFactory
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicRandomAI.jclinitDone then
            BasicRandomAI.jclinitDone <- true
            BasicRandomAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicRandomAI() : unit =
        this.i_random <- 0
        this.keyArray <- ([| Canvas.UP; Canvas.DOWN; Canvas.LEFT; Canvas.RIGHT; Canvas.KEY_NUM1; Canvas.KEY_NUM7; Canvas.KEY_NUM9 |] : int[])
        this.myRandomFactory <- MyRandomFactory.getInstance()
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput, inputProbability: InputProbability, visitor: Visitor) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_BasicRandomAI()
            this.jctor1(ownerLayerInterface, gameInput, inputProbability, visitor)
    member this.jctor1(ownerLayerInterface: AllBinaryLayer, gameInput: GameInput, inputProbability: InputProbability, visitor: Visitor) : unit =
        ()
        this.inputProbability <- inputProbability
        this.visitor <- visitor
        ()
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        let mutable jflow = 0
        if this.inputProbability.getTimeDelayHelper().isTime(GameTickTimeDelayHelperFactory.getInstance().startTime) then
            this.i_random <- this.myRandomFactory.getAbsoluteNextInt(this.inputProbability.getMax())
            let mutable repeat : bool = false
            let mutable repeatLikelyhoodIntegerArray : Integer[] = this.inputProbability.getRepeatLikelyhoodIntegerArray()
            if (this.getLastKey() <> (-1)) && (repeatLikelyhoodIntegerArray.[this.getLastKey()].intValue() >= this.i_random) then
                repeat <- true
            if not (repeat) then
                let mutable likelyhoodIntegerArray : Integer[][] = this.inputProbability.getLikelyhoodIntegerArray()
                this.i_random <- this.myRandomFactory.getAbsoluteNextInt(this.inputProbability.getMax())
                let mutable size : int = this.keyArray.Length
                let mutable likelyhoodIntegerKeyArray : Integer[] = null
                let mutable index : int = 0
                while jflow = 0 && (index < size) do
                    let mutable key : int = this.keyArray.[index]
                    likelyhoodIntegerKeyArray <- likelyhoodIntegerArray.[key]
                    if (likelyhoodIntegerArray.Length >= key) && (not (JR.same(likelyhoodIntegerKeyArray.[0], null))) then
                        if (this.i_random >= likelyhoodIntegerKeyArray.[0].intValue()) && (this.i_random < likelyhoodIntegerKeyArray.[1].intValue()) then
                            this.setLastKey(key)
                            jflow <- 100001
                    if jflow = 200001 then jflow <- 0
                    if jflow = 0 then index <- index + 1
                if jflow = 100001 then jflow <- 0
            if jflow = 0 then
                ignore (this.visitor.visit(this))


