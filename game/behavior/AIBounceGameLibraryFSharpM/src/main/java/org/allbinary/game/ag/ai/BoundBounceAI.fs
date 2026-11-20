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
type BoundBounceAI =
    inherit BasicAI
    [<DefaultValue(false)>] val mutable currentRelativeAngle : int
    [<DefaultValue(false)>] val mutable layerBounds : LayerBounds
    [<DefaultValue(false)>] val mutable boundsVisitorInterface : BoundsVisitorInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BoundBounceAI.jclinitDone then
            BoundBounceAI.jclinitDone <- true
            BoundBounceAI.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BoundBounceAI() : unit =
        this.currentRelativeAngle <- 0
        ()
    
    new (ownerLayerInterface: AllBinaryLayer, gameInput: GameInput, layerBounds: LayerBounds, boundsVisitorInterface: BoundsVisitorInterface) as this =
        { inherit BasicAI(ownerLayerInterface, gameInput) }
        then
            this.jfields_BoundBounceAI()
            this.jctor1(ownerLayerInterface, gameInput, layerBounds, boundsVisitorInterface)
    member this.jctor1(ownerLayerInterface: AllBinaryLayer, gameInput: GameInput, layerBounds: LayerBounds, boundsVisitorInterface: BoundsVisitorInterface) : unit =
        ()
        this.layerBounds <- layerBounds
        this.boundsVisitorInterface <- boundsVisitorInterface
        ()
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        let mutable rectange : Rectangle = this.layerBounds.getRectangleP()
        graphics.drawRect(rectange.getPoint().getX(), rectange.getPoint().getY(), rectange.getWidth(), rectange.getHeight())
    
    override this.processAI(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        this.layerBounds.visit(this.boundsVisitorInterface)


