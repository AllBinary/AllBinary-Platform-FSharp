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
type MotionGestureInput =
    inherit Input
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionGestureInput.jclinitDone then
            MotionGestureInput.jclinitDone <- true
            MotionGestureInput.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (id_: int, name: string) as this =
        { inherit Input(id_, name) }
        then
            this.jctor1(id_, name)
    member this.jctor1(id_: int, name: string) : unit =
        ()
        let mutable inputFactory : InputFactory = InputFactory.getInstance()
        inputFactory.add(this.getId(), this)
        ()


