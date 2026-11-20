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
type ViewPosition =
    inherit ViewPositionBase
    [<DefaultValue(false)>] val mutable allbinaryLayer : AllBinaryLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ViewPosition.jclinitDone then
            ViewPosition.jclinitDone <- true
            ViewPosition.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ViewPosition() : unit =
        this.allbinaryLayer <- AllBinaryLayer.NULL_ALLBINARY_LAYER
        ()
    
    static member getInstanceD() : ViewPosition =
        (new ViewPosition(0, 0, 0))
    
    new (x: int, y: int, z: int) as this =
        { inherit ViewPositionBase(x, y, z) }
        then
            this.jfields_ViewPosition()
    
    override this.getX() : int =
        this.allbinaryLayer.getXP()
    
    override this.getY() : int =
        this.allbinaryLayer.getYP()
    
    override this.getZ() : int =
        this.allbinaryLayer.getZP()
    
    override this.getX2() : int =
        this.getX() + this.allbinaryLayer.getWidth()
    
    override this.getY2() : int =
        this.getY() + this.allbinaryLayer.getHeight()
    
    override this.getZ2() : int =
        int ((int64 (this.getZ()) + this.allbinaryLayer.getDepth()))
    
    override this.setAllbinaryLayer(allbinaryLayer: obj) : unit =
        this.allbinaryLayer <- (box (allbinaryLayer) :?> AllBinaryLayer)


