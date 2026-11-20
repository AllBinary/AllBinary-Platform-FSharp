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
type LayerManagerLogging =
    inherit LayerManagerLoggingBase
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable stringBuilder : StringMaker
    [<DefaultValue(false)>] val mutable APPEND : string
    [<DefaultValue(false)>] val mutable APPEND_ : string
    [<DefaultValue(false)>] val mutable _AT_ : string
    [<DefaultValue(false)>] val mutable ATTEMPT_REMOVE_ : string
    [<DefaultValue(false)>] val mutable REMOVE_ : string
    [<DefaultValue(false)>] val mutable REMOVE : string
    [<DefaultValue(false)>] val mutable DID_NOT_REMOVE : string
    [<DefaultValue(false)>] val mutable CLEAR : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : LayerManagerLogging
    static member instance with get() : LayerManagerLogging = (LayerManagerLogging.jclinit(); LayerManagerLogging.jcell_instance) and set (jvalue: LayerManagerLogging) = (LayerManagerLogging.jclinit(); LayerManagerLogging.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_removeFailed : bool
    static member removeFailed with get() : bool = (LayerManagerLogging.jclinit(); LayerManagerLogging.jcell_removeFailed) and set (jvalue: bool) = (LayerManagerLogging.jclinit(); LayerManagerLogging.jcell_removeFailed <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerManagerLogging.jclinitDone then
            LayerManagerLogging.jclinitDone <- true
            LayerManagerLogging.jclinitBody()
    static member private jclinitBody() : unit =
        LayerManagerLogging.jcell_instance <- (new LayerManagerLogging())
        LayerManagerLogging.jcell_removeFailed <- false
        ()
    new () as this =
        { inherit LayerManagerLoggingBase() }
        then
            this.jfields_LayerManagerLogging()
    member this.jfields_LayerManagerLogging() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.stringBuilder <- (new StringMaker())
        this.APPEND <- "append"
        this.APPEND_ <- " append: "
        this._AT_ <- " at: "
        this.ATTEMPT_REMOVE_ <- " Remove Attempt: "
        this.REMOVE_ <- " Remove: "
        this.REMOVE <- "remove"
        this.DID_NOT_REMOVE <- " Did not remove: "
        this.CLEAR <- " Clear List"
        ()
    
    static member getInstance() : LayerManagerLogging =
        LayerManagerLogging.instance
    
    override this.append(layerInterface: AllBinaryLayer) : unit =
        ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
        this.logUtil.putF(this.stringBuilder.appendint(TsUtil.getInstance().hashCode(this)).append(this.APPEND_).append(layerInterface.getName()).ToString(), this, this.APPEND)
    
    override this.appendAt(layerInterface: AllBinaryLayer, index: int) : unit =
        ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
        this.logUtil.putF(this.stringBuilder.appendint(TsUtil.getInstance().hashCode(this)).append(this.APPEND_).append(layerInterface.getName()).append(this._AT_).appendint(index).ToString(), this, this.APPEND)
    
    override this.remove(layerInterface: AllBinaryLayer) : unit =
        if (JR.same(layerInterface, null)) then
            ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
            this.logUtil.putF(this.stringBuilder.appendint(TsUtil.getInstance().hashCode(this)).append(this.ATTEMPT_REMOVE_).append(StringUtil.getInstance().toString(layerInterface)).ToString(), this, this.REMOVE)
        else
            ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
            this.logUtil.putF(this.stringBuilder.appendint(TsUtil.getInstance().hashCode(this)).append(this.ATTEMPT_REMOVE_).append(layerInterface.getName()).ToString(), this, this.REMOVE)
    
    override this.removeResult(layerManager: LayerManager, layerInterface: AllBinaryLayer, result: bool) : unit =
        if (JR.same(layerInterface, null)) then
            ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
            this.logUtil.putF(this.stringBuilder.appendint(TsUtil.getInstance().hashCode(this)).append(this.REMOVE_).append(StringUtil.getInstance().toString(layerInterface)).ToString(), this, this.REMOVE)
        elif result then
            if LayerManagerLogging.removeFailed then
                ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
                this.logUtil.putF(this.stringBuilder.appendint(TsUtil.getInstance().hashCode(this)).append(this.REMOVE_).append(layerInterface.getName()).ToString(), this, this.REMOVE)
        else
            ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
            this.logUtil.putF(this.stringBuilder.appendint(TsUtil.getInstance().hashCode(this)).append(this.DID_NOT_REMOVE).append(layerInterface.getName()).ToString(), this, this.REMOVE)
            LayerManagerLogging.removeFailed <- true
    
    member this.log(layerManager: LayerManager) : unit =
        ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
        let mutable size : int = layerManager.getSize()
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        ignore (this.stringBuilder.append(Integer.toHexString(TsUtil.getInstance().hashCode(layerManager))).append(commonSeps.COLON_SEP))
        ignore (this.stringBuilder.appendint(size).append(commonSeps.COLON_SEP))
        let mutable allBinaryLayer : AllBinaryLayer = null
        let mutable index : int = 0
        while index < size do
            allBinaryLayer <- ((box (layerManager.getLayerAt(index)) :?> AllBinaryLayer))
            ignore (this.stringBuilder.append(allBinaryLayer.getName()).append(commonSeps.COMMA))
            index <- index + 1
        this.logUtil.putF(this.stringBuilder.ToString(), this, this.REMOVE)
    
    override this.clear() : unit =
        ignore (this.stringBuilder.delete(0, this.stringBuilder.length()))
        this.logUtil.putF(this.stringBuilder.appendint(TsUtil.getInstance().hashCode(this)).append(this.CLEAR).ToString(), this, this.CLEAR)


