namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type SpecialGameInput =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpecialGameInput.jclinitDone then
            SpecialGameInput.jclinitDone <- true
            SpecialGameInput.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract up : unit -> unit
    default this.up() : unit =
        ()
    
    abstract down : unit -> unit
    default this.down() : unit =
        ()
    
    abstract right : unit -> unit
    default this.right() : unit =
        ()
    
    abstract left : unit -> unit
    default this.left() : unit =
        ()
    
    abstract strafeLeft : unit -> unit
    default this.strafeLeft() : unit =
        ()
    
    abstract strafeRight : unit -> unit
    default this.strafeRight() : unit =
        ()
    
    abstract fire : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.fire(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special1 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special1(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special2 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special2(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special3 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special3(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special4 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special4(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract special5 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    default this.special5(layerManager: AllBinaryLayerManager, gameKeyEvent: GameKeyEvent) : unit =
        ()
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        ()
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    interface SpecialGameInputInterface with
        member this.up() : unit = this.up()
        member this.down() : unit = this.down()
        member this.right() : unit = this.right()
        member this.left() : unit = this.left()
        member this.strafeLeft() : unit = this.strafeLeft()
        member this.strafeRight() : unit = this.strafeRight()
        member this.fire(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.fire(jp0, jp1)
        member this.special1(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special1(jp0, jp1)
        member this.special2(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special2(jp0, jp1)
        member this.special3(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special3(jp0, jp1)
        member this.special4(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special4(jp0, jp1)
        member this.special5(jp0: AllBinaryLayerManager, jp1: GameKeyEvent) : unit = this.special5(jp0, jp1)
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)


