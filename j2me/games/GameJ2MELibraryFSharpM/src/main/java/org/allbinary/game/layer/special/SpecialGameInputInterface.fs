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
type SpecialGameInputInterface =
    inherit PaintableInterface
    abstract up : unit -> unit
    abstract down : unit -> unit
    abstract right : unit -> unit
    abstract left : unit -> unit
    abstract strafeLeft : unit -> unit
    abstract strafeRight : unit -> unit
    abstract fire : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    abstract special1 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    abstract special2 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    abstract special3 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    abstract special4 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit
    abstract special5 : layerManager: AllBinaryLayerManager * gameKeyEvent: GameKeyEvent -> unit


