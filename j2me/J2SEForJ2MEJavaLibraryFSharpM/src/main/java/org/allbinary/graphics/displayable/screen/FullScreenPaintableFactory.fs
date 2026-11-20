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
type FullScreenPaintableFactory =
    [<DefaultValue(false)>] val mutable paintable : Paintable
    [<DefaultValue(false)>] static val mutable private jcell_instance : FullScreenPaintableFactory
    static member instance with get() : FullScreenPaintableFactory = (FullScreenPaintableFactory.jclinit(); FullScreenPaintableFactory.jcell_instance) and set (jvalue: FullScreenPaintableFactory) = (FullScreenPaintableFactory.jclinit(); FullScreenPaintableFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FullScreenPaintableFactory.jclinitDone then
            FullScreenPaintableFactory.jclinitDone <- true
            FullScreenPaintableFactory.jclinitBody()
    static member private jclinitBody() : unit =
        FullScreenPaintableFactory.jcell_instance <- (new FullScreenPaintableFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_FullScreenPaintableFactory()
    member this.jfields_FullScreenPaintableFactory() : unit =
        this.paintable <- NullPaintable.getInstance()
        ()
    
    static member getInstance() : FullScreenPaintableFactory =
        FullScreenPaintableFactory.instance


