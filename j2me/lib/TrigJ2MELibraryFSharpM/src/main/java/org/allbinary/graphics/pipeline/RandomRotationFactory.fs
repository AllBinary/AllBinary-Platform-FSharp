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
type RandomRotationFactory =
    [<DefaultValue(false)>] val mutable myRandomFactory : MyRandomFactory
    [<DefaultValue(false)>] val mutable angleFactory : AngleFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : RandomRotationFactory
    static member instance with get() : RandomRotationFactory = (RandomRotationFactory.jclinit(); RandomRotationFactory.jcell_instance) and set (jvalue: RandomRotationFactory) = (RandomRotationFactory.jclinit(); RandomRotationFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RandomRotationFactory.jclinitDone then
            RandomRotationFactory.jclinitDone <- true
            RandomRotationFactory.jclinitBody()
    static member private jclinitBody() : unit =
        RandomRotationFactory.jcell_instance <- (new RandomRotationFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_RandomRotationFactory()
    member this.jfields_RandomRotationFactory() : unit =
        this.myRandomFactory <- MyRandomFactory.getInstance()
        this.angleFactory <- AngleFactory.getInstance()
        ()
    
    static member getInstance() : RandomRotationFactory =
        RandomRotationFactory.instance
    
    abstract getInstanceList : vector: BasicArrayList * howMuch: int -> BasicArrayList
    default this.getInstanceList(vector: BasicArrayList, howMuch: int) : BasicArrayList =
        let mutable graphicsPipe : BasicGraphicsPipeline = (new BasicGraphicsPipeline(vector))
        graphicsPipe.createMatrix()
        graphicsPipe.rotateToAngle(this.angleFactory.getAt(this.getNextRandomAngle(howMuch)))
        graphicsPipe.getMatrix()
    
    abstract getNextRandomAngle : howMuch: int -> int
    default this.getNextRandomAngle(howMuch: int) : int =
        this.myRandomFactory.getNextInt((howMuch * 10))


