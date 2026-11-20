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
type CountedLayerInterfaceFactoryPart =
    [<DefaultValue(false)>] val mutable updateMyFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable myFontProcessor : MyFontProcessor
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] val mutable total : int
    [<DefaultValue(false)>] val mutable totalString : char[]
    [<DefaultValue(false)>] val mutable xOffset : int
    [<DefaultValue(false)>] val mutable countedPickedUpLayerInterfaceFactory : CountedPickedUpLayerInterfaceFactory
    [<DefaultValue(false)>] val mutable primitiveLongUtil : PrimitiveLongUtil
    [<DefaultValue(false)>] static val mutable private jcell_NULL_COUNTED_LAYER_INTERFACE_FACTORY : CountedLayerInterfaceFactoryPart
    static member NULL_COUNTED_LAYER_INTERFACE_FACTORY with get() : CountedLayerInterfaceFactoryPart = (CountedLayerInterfaceFactoryPart.jclinit(); CountedLayerInterfaceFactoryPart.jcell_NULL_COUNTED_LAYER_INTERFACE_FACTORY) and set (jvalue: CountedLayerInterfaceFactoryPart) = (CountedLayerInterfaceFactoryPart.jclinit(); CountedLayerInterfaceFactoryPart.jcell_NULL_COUNTED_LAYER_INTERFACE_FACTORY <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CountedLayerInterfaceFactoryPart.jclinitDone then
            CountedLayerInterfaceFactoryPart.jclinitDone <- true
            CountedLayerInterfaceFactoryPart.jclinitBody()
    static member private jclinitBody() : unit =
        CountedLayerInterfaceFactoryPart.jcell_NULL_COUNTED_LAYER_INTERFACE_FACTORY <- (new CountedLayerInterfaceFactoryPart(0, CountedPickedUpLayerInterfaceFactory.NULL_COUNTED_PICKUP_LAYER_FACTORY))
        ()
    member this.jfields_CountedLayerInterfaceFactoryPart() : unit =
        this.updateMyFontProcessor <- (new UpdateMyFontProcessor(this))
        this.myFontProcessor <- this.updateMyFontProcessor
        this.animationInterface <- NullAnimationFactory.getFactoryInstance().getInstance(0)
        this.totalString <- NullUtil.getInstance().NULL_CHAR_ARRAY
        this.countedPickedUpLayerInterfaceFactory <- CountedPickedUpLayerInterfaceFactory.NULL_COUNTED_PICKUP_LAYER_FACTORY
        ()
    
    new (total: int, countedPickedUpLayerInterfaceFactory: CountedPickedUpLayerInterfaceFactory) as this =
        {  }
        then
            this.jfields_CountedLayerInterfaceFactoryPart()
            this.jctor1(total, countedPickedUpLayerInterfaceFactory)
    member this.jctor1(total: int, countedPickedUpLayerInterfaceFactory: CountedPickedUpLayerInterfaceFactory) : unit =
        this.primitiveLongUtil <- PrimitiveLongUtil.createPowerOfTen(1000)
        this.init(total, countedPickedUpLayerInterfaceFactory)
        ()
    
    abstract updateMeasurement : graphics: Graphics -> unit
    default this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        this.setXOffset((font.charsWidth(this.totalString, 0, this.primitiveLongUtil.getCurrentTotalDigits()) + (font.getSize() >>> 1)))
        this.myFontProcessor <- MyFontProcessor.getInstance()
    
    member this.init(total: int, countedPickedUpLayerInterfaceFactory: CountedPickedUpLayerInterfaceFactory) : unit =
        this.setCountedPickedUpLayerInterfaceFactory(countedPickedUpLayerInterfaceFactory)
        this.total <- total
    
    abstract getInstance : hashtable: ABHashtable * x: int * y: int * z: int -> AllBinaryLayer
    default this.getInstance(hashtable: ABHashtable, x: int, y: int, z: int) : AllBinaryLayer =
        let mutable jflow = 0
        let mutable jret : AllBinaryLayer = Unchecked.defaultof<AllBinaryLayer>
        if this.total > 0 then
            this.setTotal((this.total - 1))
            jret <- this.getCountedPickedUpLayerInterfaceFactory().getNextInstance(hashtable, x, y, z)
            jflow <- 1
        else
            raise ((new JException("No more left. Could use a listener to automatically remove")))
        jret
    
    abstract getTotal : unit -> int
    default this.getTotal() : int =
        this.total
    
    abstract setTotal : total: int -> unit
    default this.setTotal(total: int) : unit =
        this.total <- total
        this.totalString <- this.primitiveLongUtil.getCharArray(total)
        this.myFontProcessor <- this.updateMyFontProcessor
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    
    abstract getAnimationInterface : unit -> Animation
    default this.getAnimationInterface() : Animation =
        this.animationInterface
    
    abstract setAnimationInterface : animationInterface: Animation -> unit
    default this.setAnimationInterface(animationInterface: Animation) : unit =
        this.animationInterface <- animationInterface
    
    abstract getXOffset : unit -> int
    default this.getXOffset() : int =
        this.xOffset
    
    member this.setXOffset(totalStringWidth: int) : unit =
        this.xOffset <- totalStringWidth
    
    abstract getTotalString : unit -> char[]
    default this.getTotalString() : char[] =
        this.totalString
    
    abstract getCountedPickedUpLayerInterfaceFactory : unit -> CountedPickedUpLayerInterfaceFactory
    default this.getCountedPickedUpLayerInterfaceFactory() : CountedPickedUpLayerInterfaceFactory =
        this.countedPickedUpLayerInterfaceFactory
    
    abstract setCountedPickedUpLayerInterfaceFactory : countedPickedUpLayerInterfaceFactory: CountedPickedUpLayerInterfaceFactory -> unit
    default this.setCountedPickedUpLayerInterfaceFactory(countedPickedUpLayerInterfaceFactory: CountedPickedUpLayerInterfaceFactory) : unit =
        this.countedPickedUpLayerInterfaceFactory <- countedPickedUpLayerInterfaceFactory
    interface PartInterface
    interface UpdateMyFontInterface with
        member this.updateMeasurement(jp0: Graphics) : unit = this.updateMeasurement(jp0)
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)
    interface AnimationInterfaceCompositeInterface with
        member this.getAnimationInterface() : Animation = this.getAnimationInterface()


