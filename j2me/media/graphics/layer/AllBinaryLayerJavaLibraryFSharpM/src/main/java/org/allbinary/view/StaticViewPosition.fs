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
type StaticViewPosition =
    inherit ViewPosition
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not StaticViewPosition.jclinitDone then
            StaticViewPosition.jclinitDone <- true
            StaticViewPosition.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (x: int, y: int, z: int) =
        { inherit ViewPosition(x, y, z) }
    
    override this.getX() : int =
        this.getRawX()
    
    override this.getY() : int =
        this.getRawY()
    
    override this.getZ() : int =
        this.getRawZ()


