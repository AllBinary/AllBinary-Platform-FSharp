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
type OrientationMotionGestureFactory =
    [<DefaultValue(false)>] val mutable LEFT : MotionGestureInput
    [<DefaultValue(false)>] val mutable RIGHT : MotionGestureInput
    [<DefaultValue(false)>] val mutable UP : MotionGestureInput
    [<DefaultValue(false)>] val mutable DOWN : MotionGestureInput
    [<DefaultValue(false)>] val mutable ROLL_LEFT : MotionGestureInput
    [<DefaultValue(false)>] val mutable ROLL_RIGHT : MotionGestureInput
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (OrientationMotionGestureFactory.jclinit(); OrientationMotionGestureFactory.jcell_instance) and set (jvalue: obj) = (OrientationMotionGestureFactory.jclinit(); OrientationMotionGestureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OrientationMotionGestureFactory.jclinitDone then
            OrientationMotionGestureFactory.jclinitDone <- true
            OrientationMotionGestureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        OrientationMotionGestureFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : OrientationMotionGestureFactory =
        if (JR.same(OrientationMotionGestureFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            OrientationMotionGestureFactory.instance <- (new OrientationMotionGestureFactory())
        (box (OrientationMotionGestureFactory.instance) :?> OrientationMotionGestureFactory)
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable MAX : int = InputFactory.getInstance().MAX
        this.LEFT <- (new MotionGestureInput((MAX - 20), "Left Orient"))
        this.RIGHT <- (new MotionGestureInput((MAX - 21), "Right Orient"))
        this.UP <- (new MotionGestureInput((MAX - 22), "Up Orient"))
        this.DOWN <- (new MotionGestureInput((MAX - 23), "Down Orient"))
        this.ROLL_LEFT <- (new MotionGestureInput((MAX - 24), "Roll Left"))
        this.ROLL_RIGHT <- (new MotionGestureInput((MAX - 25), "Roll Right"))
        ()


