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
type PickedUpLayerInterfaceFactoryBase =
    [<DefaultValue(false)>] static val mutable private jcell_NULL_PICKED_UP_LAYER_FACTORY_BASE : PickedUpLayerInterfaceFactoryBase
    static member NULL_PICKED_UP_LAYER_FACTORY_BASE with get() : PickedUpLayerInterfaceFactoryBase = (PickedUpLayerInterfaceFactoryBase.jclinit(); PickedUpLayerInterfaceFactoryBase.jcell_NULL_PICKED_UP_LAYER_FACTORY_BASE) and set (jvalue: PickedUpLayerInterfaceFactoryBase) = (PickedUpLayerInterfaceFactoryBase.jclinit(); PickedUpLayerInterfaceFactoryBase.jcell_NULL_PICKED_UP_LAYER_FACTORY_BASE <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PickedUpLayerInterfaceFactoryBase.jclinitDone then
            PickedUpLayerInterfaceFactoryBase.jclinitDone <- true
            PickedUpLayerInterfaceFactoryBase.jclinitBody()
    static member private jclinitBody() : unit =
        PickedUpLayerInterfaceFactoryBase.jcell_NULL_PICKED_UP_LAYER_FACTORY_BASE <- (new PickedUpLayerInterfaceFactoryBase())
        ()
    new () =
        {  }
    
    abstract getIconLayer : unit -> AllBinaryLayer
    default this.getIconLayer() : AllBinaryLayer =
        raise ((new JRuntimeException()))
    
    abstract getAnimationInterface : unit -> Animation
    default this.getAnimationInterface() : Animation =
        raise ((new JRuntimeException()))
    
    abstract getPickedUpLayerType : unit -> PickedUpLayerType
    default this.getPickedUpLayerType() : PickedUpLayerType =
        raise ((new JRuntimeException()))
    interface PickedUpLayerInterfaceFactoryInterface with
        member this.getPickedUpLayerType() : PickedUpLayerType = this.getPickedUpLayerType()
        member this.getIconLayer() : AllBinaryLayer = this.getIconLayer()
        member this.getAnimationInterface() : Animation = this.getAnimationInterface()


