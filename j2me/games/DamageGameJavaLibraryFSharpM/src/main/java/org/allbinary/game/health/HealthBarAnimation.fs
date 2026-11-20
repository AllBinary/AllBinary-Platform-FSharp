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
type HealthBarAnimation =
    inherit Animation
    [<DefaultValue(false)>] val mutable basicColorFactory : BasicColorFactory
    [<DefaultValue(false)>] val mutable x2 : int
    [<DefaultValue(false)>] val mutable thickness : int
    [<DefaultValue(false)>] val mutable location : int
    [<DefaultValue(false)>] val mutable allbinaryLayer : AllBinaryLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HealthBarAnimation.jclinitDone then
            HealthBarAnimation.jclinitDone <- true
            HealthBarAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HealthBarAnimation() : unit =
        this.basicColorFactory <- BasicColorFactory.getInstance()
        ()
    
    new (layerInterface: AllBinaryLayer, location: int) as this =
        { inherit Animation() }
        then
            this.jfields_HealthBarAnimation()
            this.jctor1(layerInterface, location)
    member this.jctor1(layerInterface: AllBinaryLayer, location: int) : unit =
        this.allbinaryLayer <- layerInterface
        this.location <- location
        let mutable basicHudFactory : BasicHudFactory = BasicHudFactory.getInstance()
        if (this.location <> basicHudFactory.TOPLEFT) && (this.location <> basicHudFactory.BOTTOMLEFT) then
            raise ((new JException("Location Not Valid")))
        if layerInterface.getWidth() > 40 then
            this.thickness <- 3
        elif layerInterface.getWidth() > 20 then
            this.thickness <- 2
        else
            this.thickness <- 1
        ()
    
    abstract onHealthChange : newX2: int -> unit
    default this.onHealthChange(newX2: int) : unit =
        this.x2 <- newX2
        let mutable quarter : int = (this.allbinaryLayer.getWidth() >>> 2)
        if this.x2 > (quarter * 3) then
            this.basicColor <- this.basicColorFactory.GREEN
            this.colorP <- this.basicColor.intValue()
        elif this.x2 > (quarter * 2) then
            this.basicColor <- this.basicColorFactory.YELLOW
            this.colorP <- this.basicColor.intValue()
        elif this.x2 > quarter then
            this.basicColor <- this.basicColorFactory.ORANGE
            this.colorP <- this.basicColor.intValue()
        else
            this.basicColor <- this.basicColorFactory.RED
            this.colorP <- this.basicColor.intValue()
    
    abstract getY : unit -> int
    default this.getY() : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        let mutable basicHudFactory : BasicHudFactory = BasicHudFactory.getInstance()
        if this.location = basicHudFactory.TOPLEFT then
            jret <- this.allbinaryLayer.getViewPosition().getY() - 4
            jflow <- 1
        elif this.location = basicHudFactory.BOTTOMLEFT then
            jret <- this.allbinaryLayer.getViewPosition().getY2() + 4
            jflow <- 1
        if jflow = 0 then
            jret <- -1
            jflow <- 1
        jret


