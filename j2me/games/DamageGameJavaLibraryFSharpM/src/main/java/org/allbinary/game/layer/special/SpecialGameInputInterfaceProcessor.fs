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
type SpecialGameInputInterfaceProcessor =
    inherit GameInputProcessor
    [<DefaultValue(false)>] val mutable specialGameInputInterface : SpecialGameInputInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpecialGameInputInterfaceProcessor.jclinitDone then
            SpecialGameInputInterfaceProcessor.jclinitDone <- true
            SpecialGameInputInterfaceProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (collidableDestroyableDamageableLayer: SpecialGameInputInterface) as this =
        { inherit GameInputProcessor() }
        then
            this.jctor1(collidableDestroyableDamageableLayer)
    member this.jctor1(collidableDestroyableDamageableLayer: SpecialGameInputInterface) : unit =
        this.specialGameInputInterface <- collidableDestroyableDamageableLayer
        ()


