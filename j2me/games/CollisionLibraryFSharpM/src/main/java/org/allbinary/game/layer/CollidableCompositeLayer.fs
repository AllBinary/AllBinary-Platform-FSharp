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
type CollidableCompositeLayer =
    inherit AllBinaryGameLayer
    [<DefaultValue(false)>] val mutable collidableInferface : CollidableBaseBehavior
    [<DefaultValue(false)>] static val mutable private jcell_NULL_COLLIDABLE_COMPOSITE_LAYER : obj
    static member NULL_COLLIDABLE_COMPOSITE_LAYER with get() : obj = (CollidableCompositeLayer.jclinit(); CollidableCompositeLayer.jcell_NULL_COLLIDABLE_COMPOSITE_LAYER) and set (jvalue: obj) = (CollidableCompositeLayer.jclinit(); CollidableCompositeLayer.jcell_NULL_COLLIDABLE_COMPOSITE_LAYER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CollidableCompositeLayer.jclinitDone then
            CollidableCompositeLayer.jclinitDone <- true
            CollidableCompositeLayer.jclinitBody()
    static member private jclinitBody() : unit =
        CollidableCompositeLayer.jcell_NULL_COLLIDABLE_COMPOSITE_LAYER <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_CollidableCompositeLayer() : unit =
        this.collidableInferface <- CollidableNeverCollideBehaviorFactory.getInstance().createBehavior()
        ()
    
    static member getNullInstance() : CollidableCompositeLayer =
        if (JR.same(CollidableCompositeLayer.NULL_COLLIDABLE_COMPOSITE_LAYER, NullUtil.getInstance().NULL_OBJECT)) then
            CollidableCompositeLayer.NULL_COLLIDABLE_COMPOSITE_LAYER <- (new CollidableCompositeLayer(StringUtil.getInstance().EMPTY_STRING, RectangleFactory.SINGLETON, ViewPositionBase.NULL_VIEW_POSITION, CollidableNeverCollideBehaviorFactory.getInstance()))
        (box (CollidableCompositeLayer.NULL_COLLIDABLE_COMPOSITE_LAYER) :?> CollidableCompositeLayer)
    
    new (name: string, layerInfo: Rectangle, viewPosition: ViewPositionBase, collidableBaseBehaviorFactory: CollidableBaseBehaviorFactory) as this =
        { inherit AllBinaryGameLayer(name, layerInfo, viewPosition) }
        then
            this.jfields_CollidableCompositeLayer()
            this.jctor1(name, layerInfo, viewPosition, collidableBaseBehaviorFactory)
    member this.jctor1(name: string, layerInfo: Rectangle, viewPosition: ViewPositionBase, collidableBaseBehaviorFactory: CollidableBaseBehaviorFactory) : unit =
        ()
        if not (JR.same(collidableBaseBehaviorFactory, CollidableNeverCollideBehaviorFactory.getInstance())) then
            this.setCollidableInferface(collidableBaseBehaviorFactory.createBehavior())
        ()
    
    abstract getArtificialIntelligenceInterface : unit -> ArtificialIntelligenceInterface
    default this.getArtificialIntelligenceInterface() : ArtificialIntelligenceInterface =
        ForcedLogUtil.log(this.commonStrings.NOT_IMPLEMENTED, this)
        ArtificialIntelligence.getInstance()
    
    abstract getCollidableInferface : unit -> CollidableBaseBehavior
    default this.getCollidableInferface() : CollidableBaseBehavior =
        this.collidableInferface
    
    abstract setCollidableInferface : collidableInferface: CollidableBaseBehavior -> unit
    default this.setCollidableInferface(collidableInferface: CollidableBaseBehavior) : unit =
        this.collidableInferface <- collidableInferface
    
    override this.implmentsCollidableInterface() : bool =
        true
    
    override this.toStringAppend(stringBuffer: StringMaker) : unit =
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        base.toStringAppend(stringBuffer)
        ignore (stringBuffer.append(commonSeps.NEW_LINE))
        ignore (stringBuffer.append(this.getCollidableInferface().ToString()))
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        this.toStringAppend(stringBuffer)
        stringBuffer.ToString()
    interface CollidableInterfaceCompositeInterface with
        member this.getCollidableInferface() : CollidableBaseBehavior = this.getCollidableInferface()


