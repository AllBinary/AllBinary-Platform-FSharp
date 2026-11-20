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
type ItemColorFactory =
    [<DefaultValue(false)>] val mutable INVERT_PAINT : int
    [<DefaultValue(false)>] val mutable PAINT : int
    [<DefaultValue(false)>] val mutable TEXT_FIELD_NO_FOCUS : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : ItemColorFactory
    static member instance with get() : ItemColorFactory = (ItemColorFactory.jclinit(); ItemColorFactory.jcell_instance) and set (jvalue: ItemColorFactory) = (ItemColorFactory.jclinit(); ItemColorFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ItemColorFactory.jclinitDone then
            ItemColorFactory.jclinitDone <- true
            ItemColorFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ItemColorFactory.jcell_instance <- (new ItemColorFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_ItemColorFactory()
    member this.jfields_ItemColorFactory() : unit =
        this.INVERT_PAINT <- 0xFF000000
        this.PAINT <- 0xFFe07718
        this.TEXT_FIELD_NO_FOCUS <- 0x7F7F7F
        ()
    
    static member getInstance() : ItemColorFactory =
        ItemColorFactory.instance


