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
type ViewPositionBase =
    inherit GPoint
    [<DefaultValue(false)>] static val mutable private jcell_NULL_VIEW_POSITION : ViewPositionBase
    static member NULL_VIEW_POSITION with get() : ViewPositionBase = (ViewPositionBase.jclinit(); ViewPositionBase.jcell_NULL_VIEW_POSITION) and set (jvalue: ViewPositionBase) = (ViewPositionBase.jclinit(); ViewPositionBase.jcell_NULL_VIEW_POSITION <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ViewPositionBase.jclinitDone then
            ViewPositionBase.jclinitDone <- true
            ViewPositionBase.jclinitBody()
    static member private jclinitBody() : unit =
        ViewPositionBase.jcell_NULL_VIEW_POSITION <- (new ViewPositionBase(0, 0, 0))
        ()
    
    new (x: int, y: int, z: int) =
        { inherit GPoint(x, y, z) }
    
    abstract getX2 : unit -> int
    default this.getX2() : int =
        this.getX()
    
    abstract getY2 : unit -> int
    default this.getY2() : int =
        this.getY()
    
    abstract getZ2 : unit -> int
    default this.getZ2() : int =
        this.getZ()
    
    abstract setAllbinaryLayer : allbinaryLayer: obj -> unit
    default this.setAllbinaryLayer(allbinaryLayer: obj) : unit =
        ()


