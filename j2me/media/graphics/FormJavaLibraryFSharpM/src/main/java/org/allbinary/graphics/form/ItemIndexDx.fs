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
type ItemIndexDx =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ItemIndexDx
    static member instance with get() : ItemIndexDx = (ItemIndexDx.jclinit(); ItemIndexDx.jcell_instance) and set (jvalue: ItemIndexDx) = (ItemIndexDx.jclinit(); ItemIndexDx.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ItemIndexDx.jclinitDone then
            ItemIndexDx.jclinitDone <- true
            ItemIndexDx.jclinitBody()
    static member private jclinitBody() : unit =
        ItemIndexDx.jcell_instance <- (new ItemIndexDx())
        ()
    new () =
        {  }
    
    static member getInstance() : ItemIndexDx =
        ItemIndexDx.instance
    
    abstract getDx : index: int * item: ABCustomItem * dx: int * dy: int -> int
    default this.getDx(index: int, item: ABCustomItem, dx: int, dy: int) : int =
        0


