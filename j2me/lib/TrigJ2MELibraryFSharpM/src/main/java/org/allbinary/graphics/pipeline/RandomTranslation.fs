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
type RandomTranslation =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RandomTranslation.jclinitDone then
            RandomTranslation.jclinitDone <- true
            RandomTranslation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member getInstance(vector: BasicArrayList, howMuch: int) : BasicArrayList =
        let mutable myRandomFactory : MyRandomFactory = MyRandomFactory.getInstance()
        let mutable x : int = -(myRandomFactory.getNextInt(howMuch))
        let mutable y : int = myRandomFactory.getNextInt(howMuch)
        let mutable graphicsPipe : BasicGraphicsPipeline = (new BasicGraphicsPipeline(vector))
        graphicsPipe.createMatrix()
        graphicsPipe.translate(x, y)
        graphicsPipe.getMatrix()


