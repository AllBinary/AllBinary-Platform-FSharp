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
type TrackballMotionGestureFactory =
    [<DefaultValue(false)>] val mutable LEFT : MotionGestureInput
    [<DefaultValue(false)>] val mutable RIGHT : MotionGestureInput
    [<DefaultValue(false)>] val mutable UP : MotionGestureInput
    [<DefaultValue(false)>] val mutable DOWN : MotionGestureInput
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (TrackballMotionGestureFactory.jclinit(); TrackballMotionGestureFactory.jcell_instance) and set (jvalue: obj) = (TrackballMotionGestureFactory.jclinit(); TrackballMotionGestureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TrackballMotionGestureFactory.jclinitDone then
            TrackballMotionGestureFactory.jclinitDone <- true
            TrackballMotionGestureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        TrackballMotionGestureFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : TrackballMotionGestureFactory =
        if (JR.same(TrackballMotionGestureFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            TrackballMotionGestureFactory.instance <- (new TrackballMotionGestureFactory())
        (box (TrackballMotionGestureFactory.instance) :?> TrackballMotionGestureFactory)
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable MAX : int = InputFactory.getInstance().MAX
        this.LEFT <- (new MotionGestureInput((MAX - 26), "L Trackball"))
        this.RIGHT <- (new MotionGestureInput((MAX - 27), "R Trackball"))
        this.UP <- (new MotionGestureInput((MAX - 28), "Up Trackball"))
        this.DOWN <- (new MotionGestureInput((MAX - 29), "D Trackball"))
        ()


