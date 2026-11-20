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
type LayerInterface =
    inherit NamedInterface
    inherit PaintableInterface
    inherit GroupInterfaceCompositeInterface
    inherit PositionInterface
    abstract getHeight : unit -> int
    abstract getWidth : unit -> int
    abstract getHalfHeight : unit -> int
    abstract getHalfWidth : unit -> int
    abstract getXP : unit -> int
    abstract getYP : unit -> int
    abstract getZP : unit -> int
    abstract getX2 : unit -> int
    abstract getY2 : unit -> int
    abstract getZ2 : unit -> int
    abstract isVisible : unit -> bool
    abstract moveDXYZ : dx: int * dy: int * dz: int -> unit
    abstract setVisible : visible: bool -> unit
    abstract implmentsTickableInterface : unit -> bool
    abstract implmentsCollidableInterface : unit -> bool
    abstract implmentsGameInputInterface : unit -> bool
    abstract implmentsArtificialIntelligenceCompositeInterface : unit -> bool
    abstract getType : unit -> int


