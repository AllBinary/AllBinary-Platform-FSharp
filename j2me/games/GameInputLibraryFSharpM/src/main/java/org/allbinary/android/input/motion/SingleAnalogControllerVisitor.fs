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
type SingleAnalogControllerVisitor =
    inherit AnalogControllerVisitor
    [<DefaultValue(false)>] val mutable playerInputId : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SingleAnalogControllerVisitor.jclinitDone then
            SingleAnalogControllerVisitor.jclinitDone <- true
            SingleAnalogControllerVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (playerInputId: int) as this =
        { inherit AnalogControllerVisitor() }
        then
            this.jctor1(playerInputId)
    member this.jctor1(playerInputId: int) : unit =
        this.playerInputId <- playerInputId
        ()
    
    override this.process_(allbinaryLayerManager: AllBinaryLayerManager, analogLocationInputProcessor: AnalogLocationInputProcessor) : unit =
        let mutable analogLocationInput : AnalogLocationInput = AnalogLocationInputFactory.getInstance().getInstanceForPlayer(this.playerInputId)
        analogLocationInputProcessor.process_(allbinaryLayerManager, analogLocationInput)


