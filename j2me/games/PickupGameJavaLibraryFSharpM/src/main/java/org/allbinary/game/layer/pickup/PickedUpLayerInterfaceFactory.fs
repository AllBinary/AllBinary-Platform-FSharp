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
type PickedUpLayerInterfaceFactory =
    inherit PickedUpLayerInterfaceFactoryBase
    [<DefaultValue(false)>] val mutable pickedUpLayerType : PickedUpLayerType
    [<DefaultValue(false)>] val mutable iconLayer : IconLayer
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PickedUpLayerInterfaceFactory.jclinitDone then
            PickedUpLayerInterfaceFactory.jclinitDone <- true
            PickedUpLayerInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (pickeUpLayerType: PickedUpLayerType, iconLayer: IconLayer, animationInterface: Animation) as this =
        { inherit PickedUpLayerInterfaceFactoryBase() }
        then
            this.jctor1(pickeUpLayerType, iconLayer, animationInterface)
    member this.jctor1(pickeUpLayerType: PickedUpLayerType, iconLayer: IconLayer, animationInterface: Animation) : unit =
        this.pickedUpLayerType <- pickeUpLayerType
        this.animationInterface <- animationInterface
        this.iconLayer <- iconLayer
        ()
    
    override this.getIconLayer() : AllBinaryLayer =
        this.iconLayer
    
    override this.getAnimationInterface() : Animation =
        this.animationInterface
    
    override this.getPickedUpLayerType() : PickedUpLayerType =
        this.pickedUpLayerType


