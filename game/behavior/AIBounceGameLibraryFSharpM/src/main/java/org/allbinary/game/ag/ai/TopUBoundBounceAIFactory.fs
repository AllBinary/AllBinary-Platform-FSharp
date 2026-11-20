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
type TopUBoundBounceAIFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TopUBoundBounceAIFactory.jclinitDone then
            TopUBoundBounceAIFactory.jclinitDone <- true
            TopUBoundBounceAIFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : hashtable: ABHashtable * ownerLayerInterface: AllBinaryLayer * gameInput: GameInput -> ArtificialIntelligenceInterface
    default this.getInstance(hashtable: ABHashtable, ownerLayerInterface: AllBinaryLayer, gameInput: GameInput) : ArtificialIntelligenceInterface =
        let mutable velocityInterfaceCompositeInterface : VelocityInterfaceCompositeInterface = (box (ownerLayerInterface) :?> VelocityInterfaceCompositeInterface)
        let mutable velocityInterface : VelocityInterface = (box (velocityInterfaceCompositeInterface.getVelocityProperties()) :?> VelocityInterface)
        let mutable maxDistancePerTick : int = (velocityInterface.getMaxForwardVelocity() >>> velocityInterface.getVelocityXBasicDecimalP().getScaledFactor())
        let mutable halfWidth : int = ((ownerLayerInterface.getWidth() * 2) + maxDistancePerTick) + 1
        let mutable halfHeight : int = ((ownerLayerInterface.getHeight() * 2) + maxDistancePerTick) + 1
        let mutable point : GPoint = PointFactory.getInstance().createXY(halfWidth, (halfHeight + 60))
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable rectangle : Rectangle = (new Rectangle(point, ((displayInfo.getLastWidth() - halfWidth) - point.getX()), ((displayInfo.getLastHeight() - halfHeight) - point.getY())))
        (new BoundBounceAI(ownerLayerInterface, gameInput, (new TopULayerBounds(rectangle)), (new ReverseVelocityBoundsVisitor(ownerLayerInterface))))
    interface ArtificialIntelligenceInterfaceFactoryInterface with
        member this.getInstance(jp0: ABHashtable, jp1: AllBinaryLayer, jp2: GameInput) : ArtificialIntelligenceInterface = this.getInstance(jp0, jp1, jp2)


