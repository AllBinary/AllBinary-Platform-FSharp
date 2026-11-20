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
type ReverseVelocityBoundsVisitor =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable velocityInterface : VelocityInterface
    [<DefaultValue(false)>] val mutable layerInterface : LayerInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ReverseVelocityBoundsVisitor.jclinitDone then
            ReverseVelocityBoundsVisitor.jclinitDone <- true
            ReverseVelocityBoundsVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ReverseVelocityBoundsVisitor() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    new (layerInterface: LayerInterface) as this =
        {  }
        then
            this.jfields_ReverseVelocityBoundsVisitor()
            this.jctor1(layerInterface)
    member this.jctor1(layerInterface: LayerInterface) : unit =
        this.layerInterface <- layerInterface
        let mutable velocityInterfaceCompositeInterface : VelocityInterfaceCompositeInterface = (box (layerInterface) :?> VelocityInterfaceCompositeInterface)
        this.velocityInterface <- (box (velocityInterfaceCompositeInterface.getVelocityProperties()) :?> VelocityInterface)
        ()
    
    abstract getX : unit -> int
    default this.getX() : int =
        this.layerInterface.getXP()
    
    abstract getY : unit -> int
    default this.getY() : int =
        this.layerInterface.getYP()
    
    abstract minX : unit -> unit
    default this.minX() : unit =
        if this.velocityInterface.getVelocityXBasicDecimalP().getUnscaled() < 0L then
            this.velocityInterface.getVelocityXBasicDecimalP().multiplyint(-1)
    
    abstract maxX : unit -> unit
    default this.maxX() : unit =
        if this.velocityInterface.getVelocityXBasicDecimalP().getUnscaled() > 0L then
            this.velocityInterface.getVelocityXBasicDecimalP().multiplyint(-1)
    
    abstract minY : unit -> unit
    default this.minY() : unit =
        if this.velocityInterface.getVelocityYBasicDecimalP().getUnscaled() < 0L then
            this.velocityInterface.getVelocityYBasicDecimalP().multiplyint(-1)
    
    abstract maxY : unit -> unit
    default this.maxY() : unit =
        if this.velocityInterface.getVelocityYBasicDecimalP().getUnscaled() > 0L then
            this.velocityInterface.getVelocityYBasicDecimalP().multiplyint(-1)
    interface BoundsVisitorInterface with
        member this.getX() : int = this.getX()
        member this.getY() : int = this.getY()
        member this.maxX() : unit = this.maxX()
        member this.maxY() : unit = this.maxY()
        member this.minX() : unit = this.minX()
        member this.minY() : unit = this.minY()


