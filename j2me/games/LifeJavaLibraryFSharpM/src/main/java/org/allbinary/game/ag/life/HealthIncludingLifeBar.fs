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
type HealthIncludingLifeBar =
    inherit Paintable
    [<DefaultValue(false)>] val mutable animationInterface : HealthBarAnimation
    [<DefaultValue(false)>] val mutable life : Life
    [<DefaultValue(false)>] val mutable healthInterface : HealthInterface
    [<DefaultValue(false)>] val mutable allbinaryLayer : AllBinaryLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HealthIncludingLifeBar.jclinitDone then
            HealthIncludingLifeBar.jclinitDone <- true
            HealthIncludingLifeBar.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    static member createHealthIncludingLifeBar(layerInterface: AllBinaryLayer, life: Life, healthInterface: Health, location: int, direction: int) : HealthIncludingLifeBar =
        (new HealthIncludingLifeBar(layerInterface, life, healthInterface, (new HealthBarTwodAnimation(layerInterface, location)), direction))
    
    new (layerInterface: AllBinaryLayer, life: Life, healthInterface: Health, animationInterface: HealthBarAnimation, direction: int) as this =
        { inherit Paintable() }
        then
            this.jctor1(layerInterface, life, healthInterface, animationInterface, direction)
    member this.jctor1(layerInterface: AllBinaryLayer, life: Life, healthInterface: Health, animationInterface: HealthBarAnimation, direction: int) : unit =
        this.allbinaryLayer <- layerInterface
        this.animationInterface <- animationInterface
        this.life <- life
        this.healthInterface <- healthInterface
        this.healthInterface.addListener(this)
        this.onHealthChange()
        ()
    
    abstract onHealthChange : unit -> unit
    default this.onHealthChange() : unit =
        this.animationInterface.onHealthChange((((this.healthInterface.getHealth() + (this.healthInterface.getMaxHealth() * int (int (this.life.get())))) * this.allbinaryLayer.getWidth()) / (this.healthInterface.getMaxHealth() + (this.healthInterface.getMaxHealth() * int (int (this.life.getStartLives()))))))
    
    override this.paint(graphics: Graphics) : unit =
        this.animationInterface.paintXY(graphics, 0, 0)
    
    override this.paintThreed(graphics: Graphics) : unit =
        this.animationInterface.paintThreedXYZ(graphics, 0, 0, 0)
    interface HealthListenerInterface with
        member this.onHealthChange() : unit = this.onHealthChange()


