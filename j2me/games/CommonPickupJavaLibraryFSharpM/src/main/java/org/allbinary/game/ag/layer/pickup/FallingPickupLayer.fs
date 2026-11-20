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
type FallingPickupLayer =
    inherit PickupLayer
    static member NAME : string = "FallingPickupLayer"
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FallingPickupLayer.jclinitDone then
            FallingPickupLayer.jclinitDone <- true
            FallingPickupLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (remoteInfo: RemoteInfo) =
        { inherit PickupLayer(FallingPickupLayer.NAME, remoteInfo, 0, CountedPickedUpLayerInterfaceFactory.NULL_COUNTED_PICKUP_LAYER_FACTORY, NullAnimationFactory.getFactoryInstance().getInstance(0), (new Rectangle(PointFactory.getInstance().ZERO_ZERO, 0, 0)), ViewPosition.getInstanceD()) }
    
    override this.processTick(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        this.setPosition(this.x, (this.y + 1), this.z)
    
    override this.implmentsTickableInterface() : bool =
        true
    interface TickableInterface with
        member this.processTick(jp0: AllBinaryLayerManager) : unit = this.processTick(jp0)
    interface NamedInterface with
        member this.getName() : string = this.getName()


