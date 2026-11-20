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
type RectangleLayerBounds =
    inherit LayerBounds
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RectangleLayerBounds.jclinitDone then
            RectangleLayerBounds.jclinitDone <- true
            RectangleLayerBounds.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (rectangle: Rectangle) =
        { inherit LayerBounds(rectangle) }
    
    override this.visit(boundsVisitorInterface: BoundsVisitorInterface) : unit =
        if boundsVisitorInterface.getX() > this.rectangle.getMaxX() then
            boundsVisitorInterface.maxX()
        if boundsVisitorInterface.getY() > this.rectangle.getMaxY() then
            boundsVisitorInterface.maxY()
        if boundsVisitorInterface.getX() < this.rectangle.getPoint().getX() then
            boundsVisitorInterface.minX()
        if boundsVisitorInterface.getY() < this.rectangle.getPoint().getY() then
            boundsVisitorInterface.minY()


