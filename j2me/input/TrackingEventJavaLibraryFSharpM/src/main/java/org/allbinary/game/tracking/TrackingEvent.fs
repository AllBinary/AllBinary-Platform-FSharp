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
type TrackingEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable layerInterface : AllBinaryLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TrackingEvent.jclinitDone then
            TrackingEvent.jclinitDone <- true
            TrackingEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_TrackingEvent() : unit =
        this.layerInterface <- AllBinaryLayer.NULL_ALLBINARY_LAYER
        ()
    
    new (allBinaryLayerInterface: obj) as this =
        { inherit AllBinaryEventObject(allBinaryLayerInterface) }
        then
            this.jfields_TrackingEvent()
            this.jctor1(allBinaryLayerInterface)
    member this.jctor1(allBinaryLayerInterface: obj) : unit =
        ()
        if not (JR.same(allBinaryLayerInterface, TrackingEventHandler.getInstance())) then
            this.setLayerInterface((box (allBinaryLayerInterface) :?> AllBinaryLayer))
        ()
    
    abstract init : anyType: obj -> unit
    default this.init(anyType: obj) : unit =
        this.setSource(anyType)
    
    abstract getLayerInterface : unit -> AllBinaryLayer
    default this.getLayerInterface() : AllBinaryLayer =
        this.layerInterface
    
    member this.setLayerInterface(layerInterface: AllBinaryLayer) : unit =
        this.layerInterface <- layerInterface
    
    abstract setLayerInterfaceForCircularStaticPool : layerInterface: AllBinaryLayer -> unit
    default this.setLayerInterfaceForCircularStaticPool(layerInterface: AllBinaryLayer) : unit =
        this.layerInterface <- layerInterface
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("TrackingEvent: \n"))
        ignore (stringBuffer.append("LayerInterface: "))
        ignore (stringBuffer.append(this.layerInterface.ToString()))
        stringBuffer.ToString()


