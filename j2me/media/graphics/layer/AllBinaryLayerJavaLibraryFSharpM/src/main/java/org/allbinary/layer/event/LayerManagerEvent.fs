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
type LayerManagerEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable layerInterface : AllBinaryLayer
    [<DefaultValue(false)>] val mutable crud : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerManagerEvent.jclinitDone then
            LayerManagerEvent.jclinitDone <- true
            LayerManagerEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LayerManagerEvent() : unit =
        this.layerInterface <- AllBinaryLayer.NULL_ALLBINARY_LAYER
        ()
    
    new (layerManager: LayerManager, crud: string) as this =
        { inherit AllBinaryEventObject(layerManager) }
        then
            this.jfields_LayerManagerEvent()
            this.jctor1(layerManager, crud)
    member this.jctor1(layerManager: LayerManager, crud: string) : unit =
        ()
        this.crud <- crud
        ()
    
    abstract getLayerInterface : unit -> AllBinaryLayer
    default this.getLayerInterface() : AllBinaryLayer =
        this.layerInterface
    
    abstract setLayerInterface : layerInterface: AllBinaryLayer -> unit
    default this.setLayerInterface(layerInterface: AllBinaryLayer) : unit =
        this.layerInterface <- layerInterface
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("LayerManagerEvent: \n"))
        ignore (stringBuffer.append("LayerInterface: "))
        ignore (stringBuffer.append(this.getLayerInterface().ToString()))
        ignore (stringBuffer.append("\nCRUD: "))
        ignore (stringBuffer.append(this.crud))
        stringBuffer.ToString()


