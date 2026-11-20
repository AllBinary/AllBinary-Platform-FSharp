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
type SpecialGameInputProcessor =
    inherit GameInputProcessor
    [<DefaultValue(false)>] val mutable collidableDestroyableDamageableLayer : CollidableDestroyableDamageableLayer
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpecialGameInputProcessor.jclinitDone then
            SpecialGameInputProcessor.jclinitDone <- true
            SpecialGameInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer) as this =
        { inherit GameInputProcessor() }
        then
            this.jctor1(collidableDestroyableDamageableLayer)
    member this.jctor1(collidableDestroyableDamageableLayer: CollidableDestroyableDamageableLayer) : unit =
        this.collidableDestroyableDamageableLayer <- collidableDestroyableDamageableLayer
        ()


