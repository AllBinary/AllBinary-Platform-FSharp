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
type PlayerGameInputGameLayer =
    inherit AllBinaryGameLayer
    [<DefaultValue(false)>] val mutable playerGameInput : PlayerGameInput
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlayerGameInputGameLayer.jclinitDone then
            PlayerGameInputGameLayer.jclinitDone <- true
            PlayerGameInputGameLayer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (playerInputId: int) as this =
        { inherit AllBinaryGameLayer(StringUtil.getInstance().EMPTY_STRING, (new Rectangle(PointFactory.getInstance().ZERO_ZERO, 0, 0)), (new StaticViewPosition(0, 0, 0))) }
        then
            this.jctor1(playerInputId)
    member this.jctor1(playerInputId: int) : unit =
        ()
        this.playerGameInput <- (new PlayerGameInput(this.getGameKeyEventList(), (new BasicArrayListD()), playerInputId))
        let mutable canvasStrings : CanvasStrings = CanvasStrings.getInstance()
        this.logUtil.putF("Danger Danger Danger: Should Not Be Called Except For Testing Input", this, canvasStrings.PAINT)
        ()
    
    abstract getPlayerGameInput : unit -> PlayerGameInput
    default this.getPlayerGameInput() : PlayerGameInput =
        this.playerGameInput
    
    abstract initInputProcessors : unit -> unit
    default this.initInputProcessors() : unit =
        ()
    
    override this.processInput(myManager: AllBinaryLayerManager) : unit =
        ()
    
    override this.paint(graphics: Graphics) : unit =
        ()
    interface PlayerGameInputCompositeInterface with
        member this.getPlayerGameInput() : PlayerGameInput = this.getPlayerGameInput()
    interface GameInputInterface with
        member this.processInput(jp0: AllBinaryLayerManager) : unit = this.processInput(jp0)
        member this.initInputProcessors() : unit = this.initInputProcessors()
    interface NamedInterface with
        member this.getName() : string = this.getName()


