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
type BasicLayerProcessor =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_NULL_LAYER_PROCESSOR : BasicLayerProcessor
    static member NULL_LAYER_PROCESSOR with get() : BasicLayerProcessor = (BasicLayerProcessor.jclinit(); BasicLayerProcessor.jcell_NULL_LAYER_PROCESSOR) and set (jvalue: BasicLayerProcessor) = (BasicLayerProcessor.jclinit(); BasicLayerProcessor.jcell_NULL_LAYER_PROCESSOR <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicLayerProcessor.jclinitDone then
            BasicLayerProcessor.jclinitDone <- true
            BasicLayerProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        BasicLayerProcessor.jcell_NULL_LAYER_PROCESSOR <- (new BasicLayerProcessor())
        ()
    member this.jfields_BasicLayerProcessor() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.list <- (new BasicArrayListD())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_BasicLayerProcessor()
    
    abstract add : layerInterface: AllBinaryLayer -> unit
    default this.add(layerInterface: AllBinaryLayer) : unit =
        if not (this.list.contains(layerInterface)) then
            ignore (this.list.add(layerInterface))
    
    abstract process_ : allBinaryLayerManager: AllBinaryLayerManager -> unit
    default this.process_(allBinaryLayerManager: AllBinaryLayerManager) : unit =
        raise ((new JException(CommonStrings.getInstance().NOT_IMPLEMENTED)))
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.list


