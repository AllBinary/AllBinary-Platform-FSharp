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
type ColorFillPaintableFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : ColorFillPaintableFactory
    static member instance with get() : ColorFillPaintableFactory = (ColorFillPaintableFactory.jclinit(); ColorFillPaintableFactory.jcell_instance) and set (jvalue: ColorFillPaintableFactory) = (ColorFillPaintableFactory.jclinit(); ColorFillPaintableFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ColorFillPaintableFactory.jclinitDone then
            ColorFillPaintableFactory.jclinitDone <- true
            ColorFillPaintableFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ColorFillPaintableFactory.jcell_instance <- (new ColorFillPaintableFactory())
        ()
    new () =
        {  }
    
    static member getInstance_jstatic() : ColorFillPaintableFactory =
        ColorFillPaintableFactory.instance
    
    abstract getInstance : basicColor: BasicColor * forThreedCanvas: bool -> ColorFillBasePaintable
    default this.getInstance(basicColor: BasicColor, forThreedCanvas: bool) : ColorFillBasePaintable =
        let mutable jflow = 0
        let mutable jret : ColorFillBasePaintable = Unchecked.defaultof<ColorFillBasePaintable>
        let mutable operatingSystem : GenericOperatingSystem = OperatingSystemFactory.getInstance().getOperatingSystemInstance()
        if operatingSystem.isOverScan() then
            jret <- (new OverScanColorFillPaintable(basicColor))
            jflow <- 1
        else
            jret <- (new ColorFillPaintable(basicColor))
            jflow <- 1
        jret


