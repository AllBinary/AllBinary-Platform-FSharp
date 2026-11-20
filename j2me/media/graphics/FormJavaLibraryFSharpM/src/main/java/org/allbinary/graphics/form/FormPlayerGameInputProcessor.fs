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
type FormPlayerGameInputProcessor =
    inherit Processor
    [<DefaultValue(false)>] val mutable playerGameInputCompositeInterface : PlayerGameInputCompositeInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FormPlayerGameInputProcessor.jclinitDone then
            FormPlayerGameInputProcessor.jclinitDone <- true
            FormPlayerGameInputProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (playerGameInputCompositeInterface: PlayerGameInputCompositeInterface) as this =
        { inherit Processor() }
        then
            this.jctor1(playerGameInputCompositeInterface)
    member this.jctor1(playerGameInputCompositeInterface: PlayerGameInputCompositeInterface) : unit =
        this.playerGameInputCompositeInterface <- playerGameInputCompositeInterface
        ()
    
    override this.process_() : unit =
        this.playerGameInputCompositeInterface.getPlayerGameInput().update()


