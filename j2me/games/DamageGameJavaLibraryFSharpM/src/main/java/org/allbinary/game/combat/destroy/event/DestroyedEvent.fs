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
type DestroyedEvent =
    inherit AllBinaryEventObject
    [<DefaultValue(false)>] val mutable allBinaryGameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] val mutable allBinaryLayerInterface : AllBinaryLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DestroyedEvent.jclinitDone then
            DestroyedEvent.jclinitDone <- true
            DestroyedEvent.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_DestroyedEvent() : unit =
        this.allBinaryGameCanvas <- NullGameCanvas.getInstance()
        this.allBinaryLayerInterface <- AllBinaryLayer.NULL_ALLBINARY_LAYER
        ()
    
    new (combatGameCanvas: AllBinaryGameCanvas) as this =
        { inherit AllBinaryEventObject(DestroyedEventHandler.getInstance()) }
        then
            this.jfields_DestroyedEvent()
            this.jctor1(combatGameCanvas)
    member this.jctor1(combatGameCanvas: AllBinaryGameCanvas) : unit =
        ()
        this.setAllBinaryGameCanvas(combatGameCanvas)
        ()
    
    abstract getAllBinaryGameCanvas : unit -> AllBinaryGameCanvas
    default this.getAllBinaryGameCanvas() : AllBinaryGameCanvas =
        this.allBinaryGameCanvas
    
    abstract getLayerInterface : unit -> AllBinaryLayer
    default this.getLayerInterface() : AllBinaryLayer =
        this.allBinaryLayerInterface
    
    member this.setAllBinaryGameCanvas(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        this.allBinaryGameCanvas <- allBinaryGameCanvas
    
    abstract setLayerInterfaceForCircularStaticPool : allBinaryLayerInterface: AllBinaryLayer -> unit
    default this.setLayerInterfaceForCircularStaticPool(allBinaryLayerInterface: AllBinaryLayer) : unit =
        this.allBinaryLayerInterface <- allBinaryLayerInterface
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("DestroyedEvent: \n"))
        ignore (stringBuffer.append("AllBinaryLayerInterface: "))
        ignore (stringBuffer.append(this.allBinaryLayerInterface.ToString()))
        ignore (stringBuffer.append("\nAllBinaryGameCanvas: "))
        ignore (stringBuffer.append(StringUtil.getInstance().toString(this.getAllBinaryGameCanvas())))
        stringBuffer.ToString()


