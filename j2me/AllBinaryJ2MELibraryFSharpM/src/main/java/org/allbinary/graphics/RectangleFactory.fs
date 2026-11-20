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
type RectangleFactory =
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : Rectangle
    static member SINGLETON with get() : Rectangle = (RectangleFactory.jclinit(); RectangleFactory.jcell_SINGLETON) and set (jvalue: Rectangle) = (RectangleFactory.jclinit(); RectangleFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_ARRAY_OF_ARRAYS : Rectangle[][]
    static member ARRAY_OF_ARRAYS with get() : Rectangle[][] = (RectangleFactory.jclinit(); RectangleFactory.jcell_ARRAY_OF_ARRAYS) and set (jvalue: Rectangle[][]) = (RectangleFactory.jclinit(); RectangleFactory.jcell_ARRAY_OF_ARRAYS <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RectangleFactory.jclinitDone then
            RectangleFactory.jclinitDone <- true
            RectangleFactory.jclinitBody()
    static member private jclinitBody() : unit =
        RectangleFactory.jcell_SINGLETON <- (new Rectangle(PointFactory.getInstance().ZERO_ZERO, 0, 0))
        RectangleFactory.jcell_ARRAY_OF_ARRAYS <- (JR.newArray2<Rectangle>(0, 0))
        ()
    new () =
        {  }


