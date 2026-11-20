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
type ItemPaintableFactory =
    inherit ItemPaintable
    [<DefaultValue(false)>] static val mutable private jcell_instance : ItemPaintableFactory
    static member instance with get() : ItemPaintableFactory = (ItemPaintableFactory.jclinit(); ItemPaintableFactory.jcell_instance) and set (jvalue: ItemPaintableFactory) = (ItemPaintableFactory.jclinit(); ItemPaintableFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ItemPaintableFactory.jclinitDone then
            ItemPaintableFactory.jclinitDone <- true
            ItemPaintableFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ItemPaintableFactory.jcell_instance <- (new ItemPaintableFactory())
        ()
    new () =
        { inherit ItemPaintable() }
    
    static member getInstance() : ItemPaintableFactory =
        ItemPaintableFactory.instance
    
    abstract getInstanceItemPaintable : paintableForm: PaintableForm -> ItemPaintable
    default this.getInstanceItemPaintable(paintableForm: PaintableForm) : ItemPaintable =
        ItemPaintableFactory.instance


