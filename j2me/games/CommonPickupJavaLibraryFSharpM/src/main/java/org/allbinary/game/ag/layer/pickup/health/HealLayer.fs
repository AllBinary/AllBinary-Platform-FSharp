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
type HealLayer =
    inherit AllBinaryLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HealLayer.jclinitDone then
            HealLayer.jclinitDone <- true
            HealLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit AllBinaryLayer(StringUtil.getInstance().EMPTY_STRING, (new Rectangle(PointFactory.getInstance().ZERO_ZERO, 0, 0)), ViewPosition.getInstanceD()) }
    
    override this.paint(graphics: Graphics) : unit =
        ()
    
    abstract visit : healthInterface: HealthInterface -> unit
    default this.visit(healthInterface: HealthInterface) : unit =
        if healthInterface.isAlive() then
            healthInterface.healMax()
        else
            this.logUtil.putF("Heal attempt on dead: Does not currently occur", this, "visit")
    interface HealthVisitorInterface with
        member this.visit(jp0: HealthInterface) : unit = this.visit(jp0)


