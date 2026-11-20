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
type DestroyEventFactory =
    [<DefaultValue(false)>] val mutable combatGameCanvas : AllBinaryGameCanvas
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DestroyEventFactory.jclinitDone then
            DestroyEventFactory.jclinitDone <- true
            DestroyEventFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (combatGameCanvas: AllBinaryGameCanvas) as this =
        {  }
        then
            this.jctor1(combatGameCanvas)
    member this.jctor1(combatGameCanvas: AllBinaryGameCanvas) : unit =
        this.combatGameCanvas <- combatGameCanvas
        ()
    
    abstract getInstance : unit -> AllBinaryEventObject
    default this.getInstance() : AllBinaryEventObject =
        (new DestroyedEvent(this.combatGameCanvas))
    interface AllBinaryEventObjectFactoryInterface with
        member this.getInstance() : AllBinaryEventObject = this.getInstance()


