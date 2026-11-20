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
type LifeLayer =
    inherit AllBinaryLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LifeLayer.jclinitDone then
            LifeLayer.jclinitDone <- true
            LifeLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        { inherit AllBinaryLayer(StringUtil.getInstance().EMPTY_STRING, (new Rectangle(PointFactory.getInstance().ZERO_ZERO, 0, 0)), ViewPosition.getInstanceD()) }
    
    override this.paint(graphics: Graphics) : unit =
        ()
    
    abstract visit : lifeInterface: Life -> unit
    default this.visit(lifeInterface: Life) : unit =
        lifeInterface.add(int16 (1))
    interface LifeVisitorInterface with
        member this.visit(jp0: Life) : unit = this.visit(jp0)


