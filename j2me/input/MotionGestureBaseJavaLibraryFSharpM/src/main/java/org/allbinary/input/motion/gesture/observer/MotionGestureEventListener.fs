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
type MotionGestureEventListener =
    inherit BaseMotionGestureEventListener
    abstract onPressedMotionGestureEvent : ev: MotionGestureEvent -> unit
    abstract onUpMotionGestureEvent : ev: MotionGestureEvent -> unit
    abstract onDownMotionGestureEvent : ev: MotionGestureEvent -> unit
    abstract onLeftMotionGestureEvent : ev: MotionGestureEvent -> unit
    abstract onRightMotionGestureEvent : ev: MotionGestureEvent -> unit
    abstract onDiagonalDownRightMotionGestureEvent : ev: MotionGestureEvent -> unit
    abstract onDiagonalDownLeftMotionGestureEvent : ev: MotionGestureEvent -> unit
    abstract onDiagonalUpRightMotionGestureEvent : ev: MotionGestureEvent -> unit
    abstract onDiagonalUpLeftMotionGestureEvent : ev: MotionGestureEvent -> unit
    abstract released : ev: MotionGestureEvent -> unit


