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
type IconLayer =
    inherit AllBinaryLayer
    [<DefaultValue(false)>] val mutable animationInterface : Animation
    [<DefaultValue(false)>] static val mutable private jcell_NULL_ICON_LAYER : IconLayer
    static member NULL_ICON_LAYER with get() : IconLayer = (IconLayer.jclinit(); IconLayer.jcell_NULL_ICON_LAYER) and set (jvalue: IconLayer) = (IconLayer.jclinit(); IconLayer.jcell_NULL_ICON_LAYER <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not IconLayer.jclinitDone then
            IconLayer.jclinitDone <- true
            IconLayer.jclinitBody()
    static member private jclinitBody() : unit =
        IconLayer.jcell_NULL_ICON_LAYER <- (new IconLayer(NullAnimationFactory.getFactoryInstance().getInstance(0), 0, 0))
        ()
    
    new (animationInterface: Animation, width: int, height: int) as this =
        { inherit AllBinaryLayer(StringUtil.getInstance().EMPTY_STRING, (new Rectangle(PointFactory.getInstance().ZERO_ZERO, width, height)), ViewPosition.getInstanceD()) }
        then
            this.jctor1(animationInterface, width, height)
    member this.jctor1(animationInterface: Animation, width: int, height: int) : unit =
        ()
        this.animationInterface <- animationInterface
        ()
    
    override this.paint(graphics: Graphics) : unit =
        this.animationInterface.paintXY(graphics, this.x, this.y)
    
    override this.paintThreed(graphics: Graphics) : unit =
        this.animationInterface.paintThreedXYZ(graphics, this.x, this.y, this.z)
    
    abstract getAnimationInterface : unit -> Animation
    default this.getAnimationInterface() : Animation =
        this.animationInterface


