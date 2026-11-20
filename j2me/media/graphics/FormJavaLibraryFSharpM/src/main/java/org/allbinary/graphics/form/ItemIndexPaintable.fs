namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type ItemIndexPaintable =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ItemIndexPaintable
    static member instance with get() : ItemIndexPaintable = (ItemIndexPaintable.jclinit(); ItemIndexPaintable.jcell_instance) and set (jvalue: ItemIndexPaintable) = (ItemIndexPaintable.jclinit(); ItemIndexPaintable.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ItemIndexPaintable.jclinitDone then
            ItemIndexPaintable.jclinitDone <- true
            ItemIndexPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ItemIndexPaintable.jcell_instance <- (new ItemIndexPaintable())
        ()
    new () =
        {  }
    
    static member getInstance() : ItemIndexPaintable =
        ItemIndexPaintable.instance
    
    abstract paint : graphics: Graphics * index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.paint(graphics: Graphics, index: int, item: ABCustomItem, dx: int, dy: int) : int =
        0


