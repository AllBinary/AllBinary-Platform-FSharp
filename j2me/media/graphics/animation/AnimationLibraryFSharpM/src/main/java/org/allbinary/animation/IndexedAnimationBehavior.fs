namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type IndexedAnimationBehavior =
    inherit AnimationBehavior
    [<DefaultValue(false)>] val mutable frameDelayTime : int64
    [<DefaultValue(false)>] val mutable loopTotal : int
    [<DefaultValue(false)>] val mutable elapsedTime : int64
    [<DefaultValue(false)>] val mutable loopIndex : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not IndexedAnimationBehavior.jclinitDone then
            IndexedAnimationBehavior.jclinitDone <- true
            IndexedAnimationBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (loopTotal: int, frameDelayTime: int64) as this =
        { inherit AnimationBehavior() }
        then
            this.jctor1(loopTotal, frameDelayTime)
    member this.jctor1(loopTotal: int, frameDelayTime: int64) : unit =
        this.loopTotal <- loopTotal
        this.frameDelayTime <- frameDelayTime
        ()
    
    override this.reset() : unit =
        this.loopIndex <- 0


